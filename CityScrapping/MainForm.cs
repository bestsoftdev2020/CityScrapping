using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DarkUI.Controls;
using HtmlAgilityPack;
using System.IO;
using System.Net;
using System.Web;
using System.Windows;

struct BussInfo {
    public string business_name;
    public string address;
    public string rating;
    public string reviews;
    public string phone_number;
    public BussInfo(string business_name, string adress, string rating, string reviews, string phone_number)
    {
        this.business_name = business_name;
        this.address = adress;
        this.rating = rating;
        this.reviews = reviews;
        this.phone_number = phone_number;
    }
}

namespace CityScrapping
{
    public partial class MainForm : Form
    {
        int state_count = 0 ;
        string [] state_array = new string[100];
        bool more_click = false;
        bool is_ready = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            
            string MyConnectionString = "Server=localhost;Database=city_scrapping;Uid=root;Pwd=";
            MySqlConnection mysql_cons = new MySqlConnection(MyConnectionString);
            mysql_cons.Open();
            try
            {
                MySqlCommand cmd = mysql_cons.CreateCommand();
                cmd.CommandText = "SELECT DISTINCT(t.state_name) FROM (SELECT id,city,state_id,state_name FROM cityinfo ORDER BY population DESC LIMIT 1000) AS t ORDER BY t.state_name";
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    state_array[state_count] = dataReader[0].ToString();
                    state_count++;
                }
                dataReader.Close();

                for (var i = 0; i < state_count; i++) {
                    cityTree.Nodes.Add(state_array[i]);
                    MySqlCommand subcmd = mysql_cons.CreateCommand();
                    subcmd.CommandText = "SELECT t.city FROM (SELECT id,city,state_id,state_name,population FROM cityinfo ORDER BY population DESC LIMIT 1000) AS t WHERE t.state_name=\"" + state_array[i] + "\" ORDER BY population DESC";
                    MySqlDataReader dataReader1 = subcmd.ExecuteReader();
                    while (dataReader1.Read())
                    {
                        string cityNode = dataReader1[0].ToString();
                        cityTree.Nodes[i].Nodes.Add(cityNode);
                    }
                    dataReader1.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (mysql_cons.State == ConnectionState.Open)
                {
                    mysql_cons.Close();
                }
            }   
        }

        public void OnScrapping(string url)
        {
            System.Threading.Thread.Sleep(150);
            is_ready = false;
            myBrowser.Navigate(url);
            do
            {
                System.Threading.Thread.Sleep(10);
                Application.DoEvents();
            } while (!is_ready);


            HtmlElementCollection links = myBrowser.Document.GetElementsByTagName("a");

            foreach (HtmlElement link in links)
            {
                HtmlElementCollection templinks = link.GetElementsByTagName("span");
                foreach (HtmlElement templink in templinks)
                {
                    if (templink.InnerText != null && templink.InnerText.Contains("More places"))
                    {
                        System.Threading.Thread.Sleep(150);
                        is_ready = false;
                        templink.InvokeMember("click");
                        is_ready = false;
                        do
                        {
                            System.Threading.Thread.Sleep(10);
                            Application.DoEvents();
                        } while (!is_ready);
                    }
                }
            }

            links = myBrowser.Document.GetElementsByTagName("a");

            foreach (HtmlElement link in links)
            {
                if(link.GetAttribute("role") == "link")
                {
                    string business_name = link.FirstChild.FirstChild.FirstChild.InnerText;
                    string rating = "";
                    string reviews = "";
                    string phone_number = "";
                    string address = "";
                    string is_fb = "";
                    string keywords = "";

                    HtmlElementCollection link_list = link.GetElementsByTagName("span");
                    foreach (HtmlElement sublink in link_list)
                    {
                        if (sublink.GetAttribute("className").Contains("rllt__details"))
                        {
                            rating = sublink.FirstChild.FirstChild.InnerText;
                            if(rating != "")
                                reviews = sublink.FirstChild.InnerText.Replace(rating,"");

                            List<HtmlElement> sublink_list = null;
                            sublink_list = new List<HtmlElement>(sublink.GetElementsByTagName("div").Cast<HtmlElement>());
                            phone_number = sublink_list[2].FirstChild.InnerText;
                            address = sublink_list[1].FirstChild.InnerText;
                        }
                    }
                    searchGrid.Rows.Add(business_name, is_fb, rating, reviews, keywords, phone_number, address);
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            searchGrid.Rows.Clear();
            searchGrid.Hide();
            loadingPic.Show();
            searchBtn.Enabled = false;
            foreach (TreeNode tNode in cityTree.Nodes)
            {
                chknode(tNode);
            }
            searchBtn.Enabled = true;
            loadingPic.Hide();
            searchGrid.Show();
            searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void chknode(TreeNode tn)
        {
            foreach (TreeNode tnn in tn.Nodes)
            {
                if (tnn.Checked)
                {
                    string [] temp = tnn.FullPath.Split((char)92) ;
                    string search_key = searchBox.Text.Trim();
                    if(search_key != "")
                    {
                        string url = "https://www.google.com/search?hl=en&q="+search_key+" in "+ temp[1] + " " + temp[0];
                        url = url.Replace(' ', '+');
                        myBrowser.Stop();
                        OnScrapping(url);
                    } 
                }
                chknode(tnn);
            }
        }

        private void BrowserLoaded(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                return;
            is_ready = true;
        }
    }
}
