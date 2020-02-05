namespace CityScrapping
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new DarkUI.Controls.DarkButton();
            this.darkCheckBox1 = new DarkUI.Controls.DarkCheckBox();
            this.searchBox = new DarkUI.Controls.DarkTextBox();
            this.settingBtn = new DarkUI.Controls.DarkButton();
            this.searchGrid = new System.Windows.Forms.DataGridView();
            this.buss_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_fb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.review_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingPic = new System.Windows.Forms.PictureBox();
            this.cityTree = new System.Windows.Forms.TreeView();
            this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
            this.darkSectionPanel4 = new DarkUI.Controls.DarkSectionPanel();
            this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
            this.darkSectionPanel3 = new DarkUI.Controls.DarkSectionPanel();
            this.darkButton4 = new DarkUI.Controls.DarkButton();
            this.darkButton3 = new DarkUI.Controls.DarkButton();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.darkTitle2 = new DarkUI.Controls.DarkTitle();
            this.darkTitle1 = new DarkUI.Controls.DarkTitle();
            this.darkTextBox2 = new DarkUI.Controls.DarkTextBox();
            this.darkTextBox1 = new DarkUI.Controls.DarkTextBox();
            this.darkRadioButton2 = new DarkUI.Controls.DarkRadioButton();
            this.darkRadioButton1 = new DarkUI.Controls.DarkRadioButton();
            this.darkSeparator1 = new DarkUI.Controls.DarkSeparator();
            this.myBrowser = new System.Windows.Forms.WebBrowser();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).BeginInit();
            this.darkSectionPanel3.SuspendLayout();
            this.darkSectionPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.darkCheckBox1);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Controls.Add(this.settingBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 69);
            this.panel1.TabIndex = 8;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(1077, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.searchBtn.Size = new System.Drawing.Size(117, 27);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // darkCheckBox1
            // 
            this.darkCheckBox1.AutoSize = true;
            this.darkCheckBox1.Location = new System.Drawing.Point(857, 26);
            this.darkCheckBox1.Name = "darkCheckBox1";
            this.darkCheckBox1.Size = new System.Drawing.Size(145, 23);
            this.darkCheckBox1.TabIndex = 3;
            this.darkCheckBox1.Text = "Check For FB Pixel?";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.searchBox.Location = new System.Drawing.Point(400, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchBox.Size = new System.Drawing.Size(437, 29);
            this.searchBox.TabIndex = 2;
            // 
            // settingBtn
            // 
            this.settingBtn.Location = new System.Drawing.Point(98, 22);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.settingBtn.Size = new System.Drawing.Size(117, 27);
            this.settingBtn.TabIndex = 1;
            this.settingBtn.Text = "SETTINGS";
            // 
            // searchGrid
            // 
            this.searchGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.searchGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.searchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.searchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buss_name,
            this.is_fb,
            this.rating,
            this.review_num,
            this.keyword,
            this.phone,
            this.address});
            this.searchGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchGrid.Location = new System.Drawing.Point(340, 208);
            this.searchGrid.Name = "searchGrid";
            this.searchGrid.Size = new System.Drawing.Size(912, 526);
            this.searchGrid.TabIndex = 11;
            this.searchGrid.Visible = false;
            // 
            // buss_name
            // 
            this.buss_name.HeaderText = "Business name";
            this.buss_name.Name = "buss_name";
            this.buss_name.ReadOnly = true;
            this.buss_name.Width = 124;
            // 
            // is_fb
            // 
            this.is_fb.HeaderText = "FB Pixel? Y/N";
            this.is_fb.Name = "is_fb";
            this.is_fb.ReadOnly = true;
            this.is_fb.Width = 113;
            // 
            // rating
            // 
            this.rating.HeaderText = "Rating";
            this.rating.Name = "rating";
            this.rating.ReadOnly = true;
            this.rating.Width = 73;
            // 
            // review_num
            // 
            this.review_num.HeaderText = "Reviews";
            this.review_num.Name = "review_num";
            this.review_num.ReadOnly = true;
            this.review_num.Width = 82;
            // 
            // keyword
            // 
            this.keyword.HeaderText = "Keyword";
            this.keyword.Name = "keyword";
            this.keyword.ReadOnly = true;
            this.keyword.Width = 87;
            // 
            // phone
            // 
            this.phone.HeaderText = "Phone";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 73;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 83;
            // 
            // loadingPic
            // 
            this.loadingPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.loadingPic.Image = global::CityScrapping.Properties.Resources.VAyR;
            this.loadingPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("loadingPic.InitialImage")));
            this.loadingPic.Location = new System.Drawing.Point(738, 396);
            this.loadingPic.Name = "loadingPic";
            this.loadingPic.Size = new System.Drawing.Size(100, 100);
            this.loadingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingPic.TabIndex = 13;
            this.loadingPic.TabStop = false;
            this.loadingPic.Visible = false;
            // 
            // cityTree
            // 
            this.cityTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.cityTree.CheckBoxes = true;
            this.cityTree.ForeColor = System.Drawing.Color.White;
            this.cityTree.Location = new System.Drawing.Point(22, 105);
            this.cityTree.Name = "cityTree";
            this.cityTree.Size = new System.Drawing.Size(279, 629);
            this.cityTree.TabIndex = 15;
            // 
            // darkSectionPanel1
            // 
            this.darkSectionPanel1.Location = new System.Drawing.Point(22, 83);
            this.darkSectionPanel1.Name = "darkSectionPanel1";
            this.darkSectionPanel1.SectionHeader = "City Explorer";
            this.darkSectionPanel1.Size = new System.Drawing.Size(279, 23);
            this.darkSectionPanel1.TabIndex = 6;
            // 
            // darkSectionPanel4
            // 
            this.darkSectionPanel4.Location = new System.Drawing.Point(340, 188);
            this.darkSectionPanel4.Name = "darkSectionPanel4";
            this.darkSectionPanel4.SectionHeader = "Search Result";
            this.darkSectionPanel4.Size = new System.Drawing.Size(912, 23);
            this.darkSectionPanel4.TabIndex = 7;
            // 
            // darkStatusStrip1
            // 
            this.darkStatusStrip1.AutoSize = false;
            this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkStatusStrip1.Location = new System.Drawing.Point(0, 737);
            this.darkStatusStrip1.Name = "darkStatusStrip1";
            this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.darkStatusStrip1.Size = new System.Drawing.Size(1264, 24);
            this.darkStatusStrip1.SizingGrip = false;
            this.darkStatusStrip1.TabIndex = 12;
            this.darkStatusStrip1.Text = "darkStatusStrip1";
            // 
            // darkSectionPanel3
            // 
            this.darkSectionPanel3.Controls.Add(this.darkButton4);
            this.darkSectionPanel3.Controls.Add(this.darkButton3);
            this.darkSectionPanel3.Controls.Add(this.darkButton2);
            this.darkSectionPanel3.Location = new System.Drawing.Point(1037, 83);
            this.darkSectionPanel3.Name = "darkSectionPanel3";
            this.darkSectionPanel3.SectionHeader = "Control Panel";
            this.darkSectionPanel3.Size = new System.Drawing.Size(215, 88);
            this.darkSectionPanel3.TabIndex = 10;
            // 
            // darkButton4
            // 
            this.darkButton4.Location = new System.Drawing.Point(145, 35);
            this.darkButton4.Name = "darkButton4";
            this.darkButton4.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton4.Size = new System.Drawing.Size(62, 39);
            this.darkButton4.TabIndex = 14;
            this.darkButton4.Text = "To Excel";
            // 
            // darkButton3
            // 
            this.darkButton3.Location = new System.Drawing.Point(76, 35);
            this.darkButton3.Name = "darkButton3";
            this.darkButton3.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton3.Size = new System.Drawing.Size(62, 39);
            this.darkButton3.TabIndex = 13;
            this.darkButton3.Text = "Results";
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(7, 35);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(62, 39);
            this.darkButton2.TabIndex = 12;
            this.darkButton2.Text = "Export";
            // 
            // darkSectionPanel2
            // 
            this.darkSectionPanel2.Controls.Add(this.darkButton1);
            this.darkSectionPanel2.Controls.Add(this.darkTitle2);
            this.darkSectionPanel2.Controls.Add(this.darkTitle1);
            this.darkSectionPanel2.Controls.Add(this.darkTextBox2);
            this.darkSectionPanel2.Controls.Add(this.darkTextBox1);
            this.darkSectionPanel2.Controls.Add(this.darkRadioButton2);
            this.darkSectionPanel2.Controls.Add(this.darkRadioButton1);
            this.darkSectionPanel2.Location = new System.Drawing.Point(340, 83);
            this.darkSectionPanel2.Name = "darkSectionPanel2";
            this.darkSectionPanel2.SectionHeader = "Filter Results";
            this.darkSectionPanel2.Size = new System.Drawing.Size(658, 88);
            this.darkSectionPanel2.TabIndex = 9;
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(583, 32);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(58, 46);
            this.darkButton1.TabIndex = 11;
            this.darkButton1.Text = "Filter";
            // 
            // darkTitle2
            // 
            this.darkTitle2.AutoSize = true;
            this.darkTitle2.Location = new System.Drawing.Point(356, 58);
            this.darkTitle2.Name = "darkTitle2";
            this.darkTitle2.Size = new System.Drawing.Size(123, 19);
            this.darkTitle2.TabIndex = 5;
            this.darkTitle2.Text = "Keywords in listing";
            // 
            // darkTitle1
            // 
            this.darkTitle1.AutoSize = true;
            this.darkTitle1.Location = new System.Drawing.Point(356, 31);
            this.darkTitle1.Name = "darkTitle1";
            this.darkTitle1.Size = new System.Drawing.Size(172, 19);
            this.darkTitle1.TabIndex = 4;
            this.darkTitle1.Text = "Show only these area code";
            // 
            // darkTextBox2
            // 
            this.darkTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.darkTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox2.Location = new System.Drawing.Point(189, 57);
            this.darkTextBox2.Name = "darkTextBox2";
            this.darkTextBox2.Size = new System.Drawing.Size(161, 22);
            this.darkTextBox2.TabIndex = 3;
            // 
            // darkTextBox1
            // 
            this.darkTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.darkTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.darkTextBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.darkTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkTextBox1.Location = new System.Drawing.Point(189, 29);
            this.darkTextBox1.Name = "darkTextBox1";
            this.darkTextBox1.Size = new System.Drawing.Size(161, 22);
            this.darkTextBox1.TabIndex = 2;
            // 
            // darkRadioButton2
            // 
            this.darkRadioButton2.AutoSize = true;
            this.darkRadioButton2.Location = new System.Drawing.Point(13, 57);
            this.darkRadioButton2.Name = "darkRadioButton2";
            this.darkRadioButton2.Size = new System.Drawing.Size(143, 23);
            this.darkRadioButton2.TabIndex = 1;
            this.darkRadioButton2.TabStop = true;
            this.darkRadioButton2.Text = "FB Pixel Not Found";
            // 
            // darkRadioButton1
            // 
            this.darkRadioButton1.AutoSize = true;
            this.darkRadioButton1.Location = new System.Drawing.Point(13, 31);
            this.darkRadioButton1.Name = "darkRadioButton1";
            this.darkRadioButton1.Size = new System.Drawing.Size(116, 23);
            this.darkRadioButton1.TabIndex = 0;
            this.darkRadioButton1.TabStop = true;
            this.darkRadioButton1.Text = "FB Pixel Found";
            // 
            // darkSeparator1
            // 
            this.darkSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.darkSeparator1.Location = new System.Drawing.Point(0, 0);
            this.darkSeparator1.Name = "darkSeparator1";
            this.darkSeparator1.Size = new System.Drawing.Size(1264, 2);
            this.darkSeparator1.TabIndex = 5;
            this.darkSeparator1.Text = "darkSeparator1";
            // 
            // myBrowser
            // 
            this.myBrowser.Location = new System.Drawing.Point(432, 341);
            this.myBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myBrowser.Name = "myBrowser";
            this.myBrowser.Size = new System.Drawing.Size(653, 277);
            this.myBrowser.TabIndex = 16;
            this.myBrowser.Visible = false;
            this.myBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.BrowserLoaded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.loadingPic);
            this.Controls.Add(this.myBrowser);
            this.Controls.Add(this.darkSectionPanel1);
            this.Controls.Add(this.cityTree);
            this.Controls.Add(this.darkSectionPanel4);
            this.Controls.Add(this.darkStatusStrip1);
            this.Controls.Add(this.searchGrid);
            this.Controls.Add(this.darkSectionPanel3);
            this.Controls.Add(this.darkSectionPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.darkSeparator1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CityScrapping";
            this.Load += new System.EventHandler(this.OnLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPic)).EndInit();
            this.darkSectionPanel3.ResumeLayout(false);
            this.darkSectionPanel2.ResumeLayout(false);
            this.darkSectionPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkUI.Controls.DarkButton settingBtn;
        private DarkUI.Controls.DarkTextBox searchBox;
        private DarkUI.Controls.DarkCheckBox darkCheckBox1;
        private DarkUI.Controls.DarkSeparator darkSeparator1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
        private System.Windows.Forms.Panel panel1;
        private DarkUI.Controls.DarkButton searchBtn;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel3;
        private DarkUI.Controls.DarkRadioButton darkRadioButton2;
        private DarkUI.Controls.DarkRadioButton darkRadioButton1;
        private DarkUI.Controls.DarkButton darkButton1;
        private DarkUI.Controls.DarkTitle darkTitle2;
        private DarkUI.Controls.DarkTitle darkTitle1;
        private DarkUI.Controls.DarkTextBox darkTextBox2;
        private DarkUI.Controls.DarkTextBox darkTextBox1;
        private DarkUI.Controls.DarkButton darkButton2;
        private DarkUI.Controls.DarkButton darkButton4;
        private DarkUI.Controls.DarkButton darkButton3;
        private System.Windows.Forms.DataGridView searchGrid;
        private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
        private DarkUI.Controls.DarkSectionPanel darkSectionPanel4;
        private System.Windows.Forms.PictureBox loadingPic;
        private System.Windows.Forms.TreeView cityTree;
        private System.Windows.Forms.WebBrowser myBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn buss_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_fb;
        private System.Windows.Forms.DataGridViewTextBoxColumn rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn review_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
    }
}

