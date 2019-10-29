namespace JSON
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonReadJson = new System.Windows.Forms.Button();
            this.buttonWriteJson = new System.Windows.Forms.Button();
            this.cBserverList = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.tBformatLink = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.lblFormatVariables = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFinalLink = new System.Windows.Forms.Label();
            this.btnTestTileLoad = new System.Windows.Forms.Button();
            this.tBServerLoad = new System.Windows.Forms.TextBox();
            this.tBAppID = new System.Windows.Forms.TextBox();
            this.tBAppCode = new System.Windows.Forms.TextBox();
            this.tBHitsStartDate = new System.Windows.Forms.TextBox();
            this.tBDateToResetHits = new System.Windows.Forms.TextBox();
            this.tBHits = new System.Windows.Forms.TextBox();
            this.btnWriteNewFromThis = new System.Windows.Forms.Button();
            this.btnWriteNewFromBlank = new System.Windows.Forms.Button();
            this.btnDeleteServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReadJson
            // 
            this.buttonReadJson.Location = new System.Drawing.Point(125, 21);
            this.buttonReadJson.Name = "buttonReadJson";
            this.buttonReadJson.Size = new System.Drawing.Size(110, 23);
            this.buttonReadJson.TabIndex = 0;
            this.buttonReadJson.Text = "Read Server Lists";
            this.buttonReadJson.UseVisualStyleBackColor = true;
            this.buttonReadJson.Click += new System.EventHandler(this.buttonReadJson_Click);
            // 
            // buttonWriteJson
            // 
            this.buttonWriteJson.Location = new System.Drawing.Point(241, 21);
            this.buttonWriteJson.Name = "buttonWriteJson";
            this.buttonWriteJson.Size = new System.Drawing.Size(107, 23);
            this.buttonWriteJson.TabIndex = 2;
            this.buttonWriteJson.Text = "Write Server Lists";
            this.buttonWriteJson.UseVisualStyleBackColor = true;
            this.buttonWriteJson.Click += new System.EventHandler(this.buttonWriteJson_Click);
            // 
            // cBserverList
            // 
            this.cBserverList.FormattingEnabled = true;
            this.cBserverList.Location = new System.Drawing.Point(19, 23);
            this.cBserverList.Name = "cBserverList";
            this.cBserverList.Size = new System.Drawing.Size(100, 21);
            this.cBserverList.TabIndex = 3;
            this.cBserverList.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(122, 62);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(13, 13);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "0";
            // 
            // tBformatLink
            // 
            this.tBformatLink.Location = new System.Drawing.Point(16, 85);
            this.tBformatLink.Name = "tBformatLink";
            this.tBformatLink.Size = new System.Drawing.Size(772, 20);
            this.tBformatLink.TabIndex = 5;
            this.tBformatLink.Text = "https://";
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(16, 59);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(100, 20);
            this.tBName.TabIndex = 6;
            // 
            // lblFormatVariables
            // 
            this.lblFormatVariables.AutoSize = true;
            this.lblFormatVariables.Location = new System.Drawing.Point(16, 113);
            this.lblFormatVariables.Name = "lblFormatVariables";
            this.lblFormatVariables.Size = new System.Drawing.Size(332, 13);
            this.lblFormatVariables.TabIndex = 7;
            this.lblFormatVariables.Text = "{0} = z, {1} = x, {2} = y,  {3} = appID,  {4} = appCode , {5} = serverNo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(533, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 255);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblFinalLink
            // 
            this.lblFinalLink.AutoSize = true;
            this.lblFinalLink.Location = new System.Drawing.Point(16, 130);
            this.lblFinalLink.Name = "lblFinalLink";
            this.lblFinalLink.Size = new System.Drawing.Size(43, 13);
            this.lblFinalLink.TabIndex = 9;
            this.lblFinalLink.Text = "https://";
            // 
            // btnTestTileLoad
            // 
            this.btnTestTileLoad.Location = new System.Drawing.Point(713, 155);
            this.btnTestTileLoad.Name = "btnTestTileLoad";
            this.btnTestTileLoad.Size = new System.Drawing.Size(75, 23);
            this.btnTestTileLoad.TabIndex = 10;
            this.btnTestTileLoad.Text = "test tile load";
            this.btnTestTileLoad.UseVisualStyleBackColor = true;
            this.btnTestTileLoad.Click += new System.EventHandler(this.BtnTestTileLoad_Click);
            // 
            // tBServerLoad
            // 
            this.tBServerLoad.Location = new System.Drawing.Point(227, 221);
            this.tBServerLoad.Name = "tBServerLoad";
            this.tBServerLoad.Size = new System.Drawing.Size(100, 20);
            this.tBServerLoad.TabIndex = 11;
            // 
            // tBAppID
            // 
            this.tBAppID.Location = new System.Drawing.Point(227, 247);
            this.tBAppID.Name = "tBAppID";
            this.tBAppID.Size = new System.Drawing.Size(283, 20);
            this.tBAppID.TabIndex = 12;
            // 
            // tBAppCode
            // 
            this.tBAppCode.Location = new System.Drawing.Point(227, 273);
            this.tBAppCode.Name = "tBAppCode";
            this.tBAppCode.Size = new System.Drawing.Size(283, 20);
            this.tBAppCode.TabIndex = 13;
            // 
            // tBHitsStartDate
            // 
            this.tBHitsStartDate.Location = new System.Drawing.Point(227, 299);
            this.tBHitsStartDate.Name = "tBHitsStartDate";
            this.tBHitsStartDate.Size = new System.Drawing.Size(173, 20);
            this.tBHitsStartDate.TabIndex = 14;
            // 
            // tBDateToResetHits
            // 
            this.tBDateToResetHits.Location = new System.Drawing.Point(227, 325);
            this.tBDateToResetHits.Name = "tBDateToResetHits";
            this.tBDateToResetHits.Size = new System.Drawing.Size(173, 20);
            this.tBDateToResetHits.TabIndex = 15;
            // 
            // tBHits
            // 
            this.tBHits.Location = new System.Drawing.Point(227, 351);
            this.tBHits.Name = "tBHits";
            this.tBHits.ReadOnly = true;
            this.tBHits.Size = new System.Drawing.Size(100, 20);
            this.tBHits.TabIndex = 16;
            // 
            // btnWriteNewFromThis
            // 
            this.btnWriteNewFromThis.Location = new System.Drawing.Point(354, 21);
            this.btnWriteNewFromThis.Name = "btnWriteNewFromThis";
            this.btnWriteNewFromThis.Size = new System.Drawing.Size(182, 23);
            this.btnWriteNewFromThis.TabIndex = 17;
            this.btnWriteNewFromThis.Text = "Write New Server From Existing";
            this.btnWriteNewFromThis.UseVisualStyleBackColor = true;
            this.btnWriteNewFromThis.Click += new System.EventHandler(this.BtnWriteNewFromThis_Click);
            // 
            // btnWriteNewFromBlank
            // 
            this.btnWriteNewFromBlank.Location = new System.Drawing.Point(542, 21);
            this.btnWriteNewFromBlank.Name = "btnWriteNewFromBlank";
            this.btnWriteNewFromBlank.Size = new System.Drawing.Size(158, 23);
            this.btnWriteNewFromBlank.TabIndex = 18;
            this.btnWriteNewFromBlank.Text = "Write New Server From Blank";
            this.btnWriteNewFromBlank.UseVisualStyleBackColor = true;
            this.btnWriteNewFromBlank.Click += new System.EventHandler(this.BtnWriteNewFromBlank_Click);
            // 
            // btnDeleteServer
            // 
            this.btnDeleteServer.Location = new System.Drawing.Point(706, 21);
            this.btnDeleteServer.Name = "btnDeleteServer";
            this.btnDeleteServer.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteServer.TabIndex = 19;
            this.btnDeleteServer.Text = "Delete Server";
            this.btnDeleteServer.UseVisualStyleBackColor = true;
            this.btnDeleteServer.Click += new System.EventHandler(this.BtnDeleteServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Server Load";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "App ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "App Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Hits start date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hits End Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hits";
            // 
            // tBType
            // 
            this.tBType.Location = new System.Drawing.Point(227, 377);
            this.tBType.Name = "tBType";
            this.tBType.Size = new System.Drawing.Size(100, 20);
            this.tBType.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Free hits per month";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteServer);
            this.Controls.Add(this.btnWriteNewFromBlank);
            this.Controls.Add(this.btnWriteNewFromThis);
            this.Controls.Add(this.tBHits);
            this.Controls.Add(this.tBDateToResetHits);
            this.Controls.Add(this.tBHitsStartDate);
            this.Controls.Add(this.tBAppCode);
            this.Controls.Add(this.tBAppID);
            this.Controls.Add(this.tBServerLoad);
            this.Controls.Add(this.btnTestTileLoad);
            this.Controls.Add(this.lblFinalLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblFormatVariables);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBformatLink);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cBserverList);
            this.Controls.Add(this.buttonWriteJson);
            this.Controls.Add(this.buttonReadJson);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tile Servers List";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReadJson;
        private System.Windows.Forms.Button buttonWriteJson;
        private System.Windows.Forms.ComboBox cBserverList;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox tBformatLink;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label lblFormatVariables;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinalLink;
        private System.Windows.Forms.Button btnTestTileLoad;
        private System.Windows.Forms.TextBox tBServerLoad;
        private System.Windows.Forms.TextBox tBAppID;
        private System.Windows.Forms.TextBox tBAppCode;
        private System.Windows.Forms.TextBox tBHitsStartDate;
        private System.Windows.Forms.TextBox tBDateToResetHits;
        private System.Windows.Forms.TextBox tBHits;
        private System.Windows.Forms.Button btnWriteNewFromThis;
        private System.Windows.Forms.Button btnWriteNewFromBlank;
        private System.Windows.Forms.Button btnDeleteServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBType;
        private System.Windows.Forms.Label label7;
    }
}

