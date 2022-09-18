namespace ArmytechDbtool
{
    partial class FrmDbtool
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlContent = new System.Windows.Forms.Panel();
            this.TabCntrlDBTool = new System.Windows.Forms.TabControl();
            this.TbPgConnections = new System.Windows.Forms.TabPage();
            this.TblLayPnlConnections = new System.Windows.Forms.TableLayoutPanel();
            this.TblLaySybase = new System.Windows.Forms.TableLayoutPanel();
            this.DataBaseNameLbl = new System.Windows.Forms.Label();
            this.TstConnectionBtn = new System.Windows.Forms.Button();
            this.LblSyBaseServerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ServerTypecomboBox = new System.Windows.Forms.ComboBox();
            this.ServerNameTxt = new System.Windows.Forms.TextBox();
            this.PortTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AuthenticationcomboBox = new System.Windows.Forms.ComboBox();
            this.DataBaseNameTxt = new System.Windows.Forms.TextBox();
            this.TblLaySQl = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedAuthenticationLblcombo = new System.Windows.Forms.ComboBox();
            this.CreatedServerNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CreatedServerTypecombo = new System.Windows.Forms.ComboBox();
            this.CreatedServerNameLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CreatedPasswordTxt = new System.Windows.Forms.TextBox();
            this.CreatedUserNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CreatedAuthenticationLbl = new System.Windows.Forms.Label();
            this.CreatedDataBaseNameLbl = new System.Windows.Forms.Label();
            this.CreatedDataBaseNameTxt = new System.Windows.Forms.TextBox();
            this.BtnCreateSQlDB = new System.Windows.Forms.Button();
            this.LblSybaseTitle = new System.Windows.Forms.Label();
            this.LblSQlTitle = new System.Windows.Forms.Label();
            this.TbPgCreateSQlDB = new System.Windows.Forms.TabPage();
            this.BtnClearScriptPath = new System.Windows.Forms.Button();
            this.BtnSelectScriptPath = new System.Windows.Forms.Button();
            this.TxtScriptPath = new System.Windows.Forms.TextBox();
            this.LblScriptPath = new System.Windows.Forms.Label();
            this.TbPgTransfareData = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TableHasProblemInTransferedData = new System.Windows.Forms.ListBox();
            this.TableSuccedTranferdLBox = new System.Windows.Forms.ListBox();
            this.SelectAllCkBox = new System.Windows.Forms.CheckBox();
            this.TablesCheckToTransferCKBox = new System.Windows.Forms.CheckedListBox();
            this.DLgSelectScriptPath = new System.Windows.Forms.OpenFileDialog();
            this.PnlFooter.SuspendLayout();
            this.PnlContent.SuspendLayout();
            this.TabCntrlDBTool.SuspendLayout();
            this.TbPgConnections.SuspendLayout();
            this.TblLayPnlConnections.SuspendLayout();
            this.TblLaySybase.SuspendLayout();
            this.TblLaySQl.SuspendLayout();
            this.TbPgCreateSQlDB.SuspendLayout();
            this.TbPgTransfareData.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlFooter
            // 
            this.PnlFooter.Controls.Add(this.BtnNext);
            this.PnlFooter.Controls.Add(this.BtnExit);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 425);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(779, 44);
            this.PnlFooter.TabIndex = 1;
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Location = new System.Drawing.Point(603, 3);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(84, 37);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.Location = new System.Drawing.Point(688, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(84, 37);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Close";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHeader
            // 
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(779, 40);
            this.PnlHeader.TabIndex = 0;
            // 
            // PnlContent
            // 
            this.PnlContent.Controls.Add(this.TabCntrlDBTool);
            this.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContent.Location = new System.Drawing.Point(0, 40);
            this.PnlContent.Name = "PnlContent";
            this.PnlContent.Size = new System.Drawing.Size(779, 385);
            this.PnlContent.TabIndex = 3;
            // 
            // TabCntrlDBTool
            // 
            this.TabCntrlDBTool.Controls.Add(this.TbPgConnections);
            this.TabCntrlDBTool.Controls.Add(this.TbPgCreateSQlDB);
            this.TabCntrlDBTool.Controls.Add(this.TbPgTransfareData);
            this.TabCntrlDBTool.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabCntrlDBTool.Location = new System.Drawing.Point(0, 0);
            this.TabCntrlDBTool.Name = "TabCntrlDBTool";
            this.TabCntrlDBTool.SelectedIndex = 0;
            this.TabCntrlDBTool.Size = new System.Drawing.Size(779, 385);
            this.TabCntrlDBTool.TabIndex = 0;
            // 
            // TbPgConnections
            // 
            this.TbPgConnections.Controls.Add(this.TblLayPnlConnections);
            this.TbPgConnections.Location = new System.Drawing.Point(4, 24);
            this.TbPgConnections.Name = "TbPgConnections";
            this.TbPgConnections.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgConnections.Size = new System.Drawing.Size(771, 357);
            this.TbPgConnections.TabIndex = 0;
            this.TbPgConnections.Text = "Databases Connections";
            this.TbPgConnections.UseVisualStyleBackColor = true;
            // 
            // TblLayPnlConnections
            // 
            this.TblLayPnlConnections.ColumnCount = 2;
            this.TblLayPnlConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayPnlConnections.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLayPnlConnections.Controls.Add(this.TblLaySybase, 0, 1);
            this.TblLayPnlConnections.Controls.Add(this.TblLaySQl, 1, 1);
            this.TblLayPnlConnections.Controls.Add(this.LblSybaseTitle, 0, 0);
            this.TblLayPnlConnections.Controls.Add(this.LblSQlTitle, 1, 0);
            this.TblLayPnlConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLayPnlConnections.Location = new System.Drawing.Point(3, 3);
            this.TblLayPnlConnections.Name = "TblLayPnlConnections";
            this.TblLayPnlConnections.RowCount = 2;
            this.TblLayPnlConnections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.83333F));
            this.TblLayPnlConnections.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.16666F));
            this.TblLayPnlConnections.Size = new System.Drawing.Size(765, 351);
            this.TblLayPnlConnections.TabIndex = 0;
            // 
            // TblLaySybase
            // 
            this.TblLaySybase.ColumnCount = 2;
            this.TblLaySybase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TblLaySybase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.74227F));
            this.TblLaySybase.Controls.Add(this.DataBaseNameLbl, 0, 2);
            this.TblLaySybase.Controls.Add(this.TstConnectionBtn, 1, 9);
            this.TblLaySybase.Controls.Add(this.LblSyBaseServerName, 0, 0);
            this.TblLaySybase.Controls.Add(this.label1, 0, 1);
            this.TblLaySybase.Controls.Add(this.label2, 0, 3);
            this.TblLaySybase.Controls.Add(this.label3, 0, 4);
            this.TblLaySybase.Controls.Add(this.UserNameTxt, 1, 4);
            this.TblLaySybase.Controls.Add(this.label4, 0, 5);
            this.TblLaySybase.Controls.Add(this.PasswordTxt, 1, 5);
            this.TblLaySybase.Controls.Add(this.ServerTypecomboBox, 1, 0);
            this.TblLaySybase.Controls.Add(this.ServerNameTxt, 1, 1);
            this.TblLaySybase.Controls.Add(this.PortTxt, 1, 6);
            this.TblLaySybase.Controls.Add(this.label5, 0, 6);
            this.TblLaySybase.Controls.Add(this.comboBox2, 1, 7);
            this.TblLaySybase.Controls.Add(this.label6, 0, 7);
            this.TblLaySybase.Controls.Add(this.AuthenticationcomboBox, 1, 3);
            this.TblLaySybase.Controls.Add(this.DataBaseNameTxt, 1, 2);
            this.TblLaySybase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLaySybase.Location = new System.Drawing.Point(3, 41);
            this.TblLaySybase.Name = "TblLaySybase";
            this.TblLaySybase.RowCount = 10;
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TblLaySybase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TblLaySybase.Size = new System.Drawing.Size(376, 307);
            this.TblLaySybase.TabIndex = 0;
            this.TblLaySybase.Paint += new System.Windows.Forms.PaintEventHandler(this.TblLaySybase_Paint);
            // 
            // DataBaseNameLbl
            // 
            this.DataBaseNameLbl.Location = new System.Drawing.Point(3, 65);
            this.DataBaseNameLbl.Name = "DataBaseNameLbl";
            this.DataBaseNameLbl.Size = new System.Drawing.Size(188, 24);
            this.DataBaseNameLbl.TabIndex = 17;
            this.DataBaseNameLbl.Text = "Data base Name:";
            this.DataBaseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TstConnectionBtn
            // 
            this.TstConnectionBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TstConnectionBtn.Location = new System.Drawing.Point(220, 270);
            this.TstConnectionBtn.Name = "TstConnectionBtn";
            this.TstConnectionBtn.Size = new System.Drawing.Size(130, 34);
            this.TstConnectionBtn.TabIndex = 14;
            this.TstConnectionBtn.Text = "Test Connection";
            this.TstConnectionBtn.UseVisualStyleBackColor = true;
            this.TstConnectionBtn.Click += new System.EventHandler(this.TstConnectionBtn_Click);
            // 
            // LblSyBaseServerName
            // 
            this.LblSyBaseServerName.Location = new System.Drawing.Point(3, 0);
            this.LblSyBaseServerName.Name = "LblSyBaseServerName";
            this.LblSyBaseServerName.Size = new System.Drawing.Size(188, 30);
            this.LblSyBaseServerName.TabIndex = 0;
            this.LblSyBaseServerName.Text = "Server Type:";
            this.LblSyBaseServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblSyBaseServerName.Click += new System.EventHandler(this.LblSyBaseServerName_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Authentication:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "User name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameTxt.Location = new System.Drawing.Point(197, 129);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(176, 23);
            this.UserNameTxt.TabIndex = 7;
            this.UserNameTxt.Text = "sa";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTxt.Location = new System.Drawing.Point(197, 163);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(176, 23);
            this.PasswordTxt.TabIndex = 9;
            this.PasswordTxt.Text = "ha-P@$$-gh";
            // 
            // ServerTypecomboBox
            // 
            this.ServerTypecomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerTypecomboBox.FormattingEnabled = true;
            this.ServerTypecomboBox.Items.AddRange(new object[] {
            "Sybase",
            "SqlServer"});
            this.ServerTypecomboBox.Location = new System.Drawing.Point(197, 4);
            this.ServerTypecomboBox.Name = "ServerTypecomboBox";
            this.ServerTypecomboBox.Size = new System.Drawing.Size(176, 23);
            this.ServerTypecomboBox.TabIndex = 1;
            // 
            // ServerNameTxt
            // 
            this.ServerNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerNameTxt.Location = new System.Drawing.Point(197, 37);
            this.ServerNameTxt.Name = "ServerNameTxt";
            this.ServerNameTxt.Size = new System.Drawing.Size(176, 23);
            this.ServerNameTxt.TabIndex = 3;
            this.ServerNameTxt.Text = "192.168.1.210";
            // 
            // PortTxt
            // 
            this.PortTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PortTxt.Location = new System.Drawing.Point(197, 196);
            this.PortTxt.Name = "PortTxt";
            this.PortTxt.Size = new System.Drawing.Size(176, 23);
            this.PortTxt.TabIndex = 11;
            this.PortTxt.Text = "5000";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Port:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "default",
            "utf-8"});
            this.comboBox2.Location = new System.Drawing.Point(197, 234);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 23);
            this.comboBox2.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "CharSet:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthenticationcomboBox
            // 
            this.AuthenticationcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthenticationcomboBox.FormattingEnabled = true;
            this.AuthenticationcomboBox.Items.AddRange(new object[] {
            "UserName and Password",
            "Windows Auth"});
            this.AuthenticationcomboBox.Location = new System.Drawing.Point(197, 94);
            this.AuthenticationcomboBox.Name = "AuthenticationcomboBox";
            this.AuthenticationcomboBox.Size = new System.Drawing.Size(176, 23);
            this.AuthenticationcomboBox.TabIndex = 15;
            this.AuthenticationcomboBox.SelectedIndexChanged += new System.EventHandler(this.AuthenticationcomboBox_SelectedIndexChanged);
            // 
            // DataBaseNameTxt
            // 
            this.DataBaseNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBaseNameTxt.Location = new System.Drawing.Point(197, 68);
            this.DataBaseNameTxt.Name = "DataBaseNameTxt";
            this.DataBaseNameTxt.Size = new System.Drawing.Size(176, 23);
            this.DataBaseNameTxt.TabIndex = 16;
            this.DataBaseNameTxt.Text = "Stock200";
            // 
            // TblLaySQl
            // 
            this.TblLaySQl.ColumnCount = 2;
            this.TblLaySQl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLaySQl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TblLaySQl.Controls.Add(this.CreatedAuthenticationLblcombo, 1, 3);
            this.TblLaySQl.Controls.Add(this.CreatedServerNameTxt, 1, 1);
            this.TblLaySQl.Controls.Add(this.label7, 0, 0);
            this.TblLaySQl.Controls.Add(this.CreatedServerTypecombo, 1, 0);
            this.TblLaySQl.Controls.Add(this.CreatedServerNameLbl, 0, 1);
            this.TblLaySQl.Controls.Add(this.label11, 0, 5);
            this.TblLaySQl.Controls.Add(this.CreatedPasswordTxt, 1, 5);
            this.TblLaySQl.Controls.Add(this.CreatedUserNameTxt, 1, 4);
            this.TblLaySQl.Controls.Add(this.label10, 0, 4);
            this.TblLaySQl.Controls.Add(this.CreatedAuthenticationLbl, 0, 3);
            this.TblLaySQl.Controls.Add(this.CreatedDataBaseNameLbl, 0, 2);
            this.TblLaySQl.Controls.Add(this.CreatedDataBaseNameTxt, 1, 2);
            this.TblLaySQl.Controls.Add(this.BtnCreateSQlDB, 1, 8);
            this.TblLaySQl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblLaySQl.Location = new System.Drawing.Point(385, 41);
            this.TblLaySQl.Name = "TblLaySQl";
            this.TblLaySQl.RowCount = 9;
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.11765F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.88235F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TblLaySQl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TblLaySQl.Size = new System.Drawing.Size(377, 307);
            this.TblLaySQl.TabIndex = 1;
            // 
            // CreatedAuthenticationLblcombo
            // 
            this.CreatedAuthenticationLblcombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedAuthenticationLblcombo.AutoCompleteCustomSource.AddRange(new string[] {
            "Sql Server Authentication",
            "Windows Authentication"});
            this.CreatedAuthenticationLblcombo.FormattingEnabled = true;
            this.CreatedAuthenticationLblcombo.Items.AddRange(new object[] {
            "UserName and Password",
            "Windows Auth"});
            this.CreatedAuthenticationLblcombo.Location = new System.Drawing.Point(191, 99);
            this.CreatedAuthenticationLblcombo.Name = "CreatedAuthenticationLblcombo";
            this.CreatedAuthenticationLblcombo.Size = new System.Drawing.Size(183, 23);
            this.CreatedAuthenticationLblcombo.TabIndex = 18;
            // 
            // CreatedServerNameTxt
            // 
            this.CreatedServerNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedServerNameTxt.Location = new System.Drawing.Point(191, 38);
            this.CreatedServerNameTxt.Name = "CreatedServerNameTxt";
            this.CreatedServerNameTxt.Size = new System.Drawing.Size(183, 23);
            this.CreatedServerNameTxt.TabIndex = 14;
            this.CreatedServerNameTxt.Text = "192.168.1.210";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Server Type:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatedServerTypecombo
            // 
            this.CreatedServerTypecombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedServerTypecombo.FormattingEnabled = true;
            this.CreatedServerTypecombo.Items.AddRange(new object[] {
            "Sql Server"});
            this.CreatedServerTypecombo.Location = new System.Drawing.Point(191, 6);
            this.CreatedServerTypecombo.Name = "CreatedServerTypecombo";
            this.CreatedServerTypecombo.Size = new System.Drawing.Size(183, 23);
            this.CreatedServerTypecombo.TabIndex = 1;
            // 
            // CreatedServerNameLbl
            // 
            this.CreatedServerNameLbl.Location = new System.Drawing.Point(3, 35);
            this.CreatedServerNameLbl.Name = "CreatedServerNameLbl";
            this.CreatedServerNameLbl.Size = new System.Drawing.Size(182, 24);
            this.CreatedServerNameLbl.TabIndex = 3;
            this.CreatedServerNameLbl.Text = "Server Name:";
            this.CreatedServerNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Password:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatedPasswordTxt
            // 
            this.CreatedPasswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedPasswordTxt.Location = new System.Drawing.Point(191, 166);
            this.CreatedPasswordTxt.Name = "CreatedPasswordTxt";
            this.CreatedPasswordTxt.PasswordChar = '*';
            this.CreatedPasswordTxt.Size = new System.Drawing.Size(183, 23);
            this.CreatedPasswordTxt.TabIndex = 15;
            this.CreatedPasswordTxt.Text = "sa@12345";
            // 
            // CreatedUserNameTxt
            // 
            this.CreatedUserNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedUserNameTxt.Location = new System.Drawing.Point(191, 133);
            this.CreatedUserNameTxt.Name = "CreatedUserNameTxt";
            this.CreatedUserNameTxt.Size = new System.Drawing.Size(183, 23);
            this.CreatedUserNameTxt.TabIndex = 14;
            this.CreatedUserNameTxt.Text = "sa";
            this.CreatedUserNameTxt.TextChanged += new System.EventHandler(this.CreatedUserNameTxt_TextChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 129);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "User name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // CreatedAuthenticationLbl
            // 
            this.CreatedAuthenticationLbl.Location = new System.Drawing.Point(3, 93);
            this.CreatedAuthenticationLbl.Name = "CreatedAuthenticationLbl";
            this.CreatedAuthenticationLbl.Size = new System.Drawing.Size(182, 36);
            this.CreatedAuthenticationLbl.TabIndex = 14;
            this.CreatedAuthenticationLbl.Text = "Authentication:";
            this.CreatedAuthenticationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreatedAuthenticationLbl.Click += new System.EventHandler(this.label9_Click);
            // 
            // CreatedDataBaseNameLbl
            // 
            this.CreatedDataBaseNameLbl.Location = new System.Drawing.Point(3, 64);
            this.CreatedDataBaseNameLbl.Name = "CreatedDataBaseNameLbl";
            this.CreatedDataBaseNameLbl.Size = new System.Drawing.Size(182, 24);
            this.CreatedDataBaseNameLbl.TabIndex = 16;
            this.CreatedDataBaseNameLbl.Text = "Data base Name:";
            this.CreatedDataBaseNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreatedDataBaseNameTxt
            // 
            this.CreatedDataBaseNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedDataBaseNameTxt.Location = new System.Drawing.Point(191, 67);
            this.CreatedDataBaseNameTxt.Name = "CreatedDataBaseNameTxt";
            this.CreatedDataBaseNameTxt.Size = new System.Drawing.Size(183, 23);
            this.CreatedDataBaseNameTxt.TabIndex = 17;
            this.CreatedDataBaseNameTxt.Text = "Stock200Tst";
            // 
            // BtnCreateSQlDB
            // 
            this.BtnCreateSQlDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCreateSQlDB.Location = new System.Drawing.Point(217, 269);
            this.BtnCreateSQlDB.Name = "BtnCreateSQlDB";
            this.BtnCreateSQlDB.Size = new System.Drawing.Size(130, 35);
            this.BtnCreateSQlDB.TabIndex = 20;
            this.BtnCreateSQlDB.Text = "Create Database";
            this.BtnCreateSQlDB.UseVisualStyleBackColor = true;
            this.BtnCreateSQlDB.Click += new System.EventHandler(this.BtnCreateSQlDB_Click);
            // 
            // LblSybaseTitle
            // 
            this.LblSybaseTitle.AutoSize = true;
            this.LblSybaseTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSybaseTitle.Location = new System.Drawing.Point(3, 0);
            this.LblSybaseTitle.Name = "LblSybaseTitle";
            this.LblSybaseTitle.Size = new System.Drawing.Size(376, 38);
            this.LblSybaseTitle.TabIndex = 0;
            this.LblSybaseTitle.Text = "Sybase";
            this.LblSybaseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSQlTitle
            // 
            this.LblSQlTitle.AutoSize = true;
            this.LblSQlTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblSQlTitle.Location = new System.Drawing.Point(385, 0);
            this.LblSQlTitle.Name = "LblSQlTitle";
            this.LblSQlTitle.Size = new System.Drawing.Size(377, 38);
            this.LblSQlTitle.TabIndex = 1;
            this.LblSQlTitle.Text = "SQL";
            this.LblSQlTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbPgCreateSQlDB
            // 
            this.TbPgCreateSQlDB.Controls.Add(this.BtnClearScriptPath);
            this.TbPgCreateSQlDB.Controls.Add(this.BtnSelectScriptPath);
            this.TbPgCreateSQlDB.Controls.Add(this.TxtScriptPath);
            this.TbPgCreateSQlDB.Controls.Add(this.LblScriptPath);
            this.TbPgCreateSQlDB.Location = new System.Drawing.Point(4, 24);
            this.TbPgCreateSQlDB.Name = "TbPgCreateSQlDB";
            this.TbPgCreateSQlDB.Size = new System.Drawing.Size(771, 357);
            this.TbPgCreateSQlDB.TabIndex = 3;
            this.TbPgCreateSQlDB.Text = "Create Database";
            this.TbPgCreateSQlDB.UseVisualStyleBackColor = true;
            // 
            // BtnClearScriptPath
            // 
            this.BtnClearScriptPath.Location = new System.Drawing.Point(636, 11);
            this.BtnClearScriptPath.Name = "BtnClearScriptPath";
            this.BtnClearScriptPath.Size = new System.Drawing.Size(30, 23);
            this.BtnClearScriptPath.TabIndex = 3;
            this.BtnClearScriptPath.Text = "x";
            this.BtnClearScriptPath.UseVisualStyleBackColor = true;
            this.BtnClearScriptPath.Click += new System.EventHandler(this.BtnClearScriptPath_Click);
            // 
            // BtnSelectScriptPath
            // 
            this.BtnSelectScriptPath.Location = new System.Drawing.Point(606, 11);
            this.BtnSelectScriptPath.Name = "BtnSelectScriptPath";
            this.BtnSelectScriptPath.Size = new System.Drawing.Size(30, 23);
            this.BtnSelectScriptPath.TabIndex = 2;
            this.BtnSelectScriptPath.Text = "...";
            this.BtnSelectScriptPath.UseVisualStyleBackColor = true;
            this.BtnSelectScriptPath.Click += new System.EventHandler(this.BtnSelectScriptPath_Click);
            // 
            // TxtScriptPath
            // 
            this.TxtScriptPath.Location = new System.Drawing.Point(163, 11);
            this.TxtScriptPath.Name = "TxtScriptPath";
            this.TxtScriptPath.ReadOnly = true;
            this.TxtScriptPath.Size = new System.Drawing.Size(443, 23);
            this.TxtScriptPath.TabIndex = 1;
            // 
            // LblScriptPath
            // 
            this.LblScriptPath.Location = new System.Drawing.Point(8, 10);
            this.LblScriptPath.Name = "LblScriptPath";
            this.LblScriptPath.Size = new System.Drawing.Size(149, 23);
            this.LblScriptPath.TabIndex = 0;
            this.LblScriptPath.Text = "Create tables Script Path:";
            this.LblScriptPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TbPgTransfareData
            // 
            this.TbPgTransfareData.Controls.Add(this.label9);
            this.TbPgTransfareData.Controls.Add(this.label8);
            this.TbPgTransfareData.Controls.Add(this.TableHasProblemInTransferedData);
            this.TbPgTransfareData.Controls.Add(this.TableSuccedTranferdLBox);
            this.TbPgTransfareData.Controls.Add(this.SelectAllCkBox);
            this.TbPgTransfareData.Controls.Add(this.TablesCheckToTransferCKBox);
            this.TbPgTransfareData.Location = new System.Drawing.Point(4, 24);
            this.TbPgTransfareData.Name = "TbPgTransfareData";
            this.TbPgTransfareData.Size = new System.Drawing.Size(771, 357);
            this.TbPgTransfareData.TabIndex = 2;
            this.TbPgTransfareData.Text = "Transferrer Data";
            this.TbPgTransfareData.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tableshas problem Transfer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tables Transfer succeed";
            // 
            // TableHasProblemInTransferedData
            // 
            this.TableHasProblemInTransferedData.FormattingEnabled = true;
            this.TableHasProblemInTransferedData.ItemHeight = 15;
            this.TableHasProblemInTransferedData.Location = new System.Drawing.Point(404, 46);
            this.TableHasProblemInTransferedData.Name = "TableHasProblemInTransferedData";
            this.TableHasProblemInTransferedData.Size = new System.Drawing.Size(155, 289);
            this.TableHasProblemInTransferedData.TabIndex = 4;
            // 
            // TableSuccedTranferdLBox
            // 
            this.TableSuccedTranferdLBox.FormattingEnabled = true;
            this.TableSuccedTranferdLBox.ItemHeight = 15;
            this.TableSuccedTranferdLBox.Location = new System.Drawing.Point(608, 46);
            this.TableSuccedTranferdLBox.Name = "TableSuccedTranferdLBox";
            this.TableSuccedTranferdLBox.Size = new System.Drawing.Size(155, 289);
            this.TableSuccedTranferdLBox.TabIndex = 3;
            // 
            // SelectAllCkBox
            // 
            this.SelectAllCkBox.AutoSize = true;
            this.SelectAllCkBox.Location = new System.Drawing.Point(8, 21);
            this.SelectAllCkBox.Name = "SelectAllCkBox";
            this.SelectAllCkBox.Size = new System.Drawing.Size(71, 19);
            this.SelectAllCkBox.TabIndex = 2;
            this.SelectAllCkBox.Text = "SelectAll";
            this.SelectAllCkBox.UseVisualStyleBackColor = true;
            this.SelectAllCkBox.CheckedChanged += new System.EventHandler(this.SelectAll_CheckedChanged);
            // 
            // TablesCheckToTransferCKBox
            // 
            this.TablesCheckToTransferCKBox.FormattingEnabled = true;
            this.TablesCheckToTransferCKBox.Location = new System.Drawing.Point(8, 46);
            this.TablesCheckToTransferCKBox.Name = "TablesCheckToTransferCKBox";
            this.TablesCheckToTransferCKBox.Size = new System.Drawing.Size(298, 292);
            this.TablesCheckToTransferCKBox.TabIndex = 1;
            // 
            // DLgSelectScriptPath
            // 
            this.DLgSelectScriptPath.Filter = "SQL Files|*.sql";
            // 
            // FrmDbtool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 469);
            this.Controls.Add(this.PnlContent);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.PnlFooter);
            this.Name = "FrmDbtool";
            this.Text = "FrmDbtool";
            this.Load += new System.EventHandler(this.FrmDbtool_Load);
            this.PnlFooter.ResumeLayout(false);
            this.PnlContent.ResumeLayout(false);
            this.TabCntrlDBTool.ResumeLayout(false);
            this.TbPgConnections.ResumeLayout(false);
            this.TblLayPnlConnections.ResumeLayout(false);
            this.TblLayPnlConnections.PerformLayout();
            this.TblLaySybase.ResumeLayout(false);
            this.TblLaySybase.PerformLayout();
            this.TblLaySQl.ResumeLayout(false);
            this.TblLaySQl.PerformLayout();
            this.TbPgCreateSQlDB.ResumeLayout(false);
            this.TbPgCreateSQlDB.PerformLayout();
            this.TbPgTransfareData.ResumeLayout(false);
            this.TbPgTransfareData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel PnlFooter;
        private Button BtnNext;
        private Button BtnExit;
        private Panel PnlHeader;
        private Panel PnlContent;
        private TabControl TabCntrlDBTool;
        private TabPage TbPgConnections;
        private TabPage TbPgTransfareData;
        private TableLayoutPanel TblLayPnlConnections;
        private TableLayoutPanel TblLaySybase;
        private TableLayoutPanel TblLaySQl;
        private Label LblSybaseTitle;
        private Label LblSQlTitle;
        private Label LblSyBaseServerName;
        private ComboBox ServerTypecomboBox;
        private TextBox ServerNameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox UserNameTxt;
        private Label label4;
        private TextBox PasswordTxt;
        private TextBox PortTxt;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox CreatedPasswordTxt;
        private Label label11;
        private TextBox CreatedUserNameTxt;
        private Label label10;
        private Label CreatedAuthenticationLbl;
        private TextBox CreatedServerNameTxt;
        private Label label7;
        private ComboBox CreatedServerTypecombo;
        private Label CreatedServerNameLbl;
        private Button TstConnectionBtn;
        private ComboBox AuthenticationcomboBox;
        private Label DataBaseNameLbl;
        private TextBox DataBaseNameTxt;
        private Label CreatedDataBaseNameLbl;
        private TextBox CreatedDataBaseNameTxt;
        private ComboBox CreatedAuthenticationLblcombo;
        private TabPage TbPgCreateSQlDB;
        private Button TstConnectionBtn2;
        private Button BtnClearScriptPath;
        private Button BtnSelectScriptPath;
        private TextBox TxtScriptPath;
        private Label LblScriptPath;
        private CheckedListBox TablesCheckToTransferCKBox;
        private OpenFileDialog DLgSelectScriptPath;
        private Button BtnCreateSQlDB;
        private CheckBox SelectAllCkBox;
        private ListBox TableSuccedTranferdLBox;
        private Label label9;
        private Label label8;
        private ListBox TableHasProblemInTransferedData;
    }
}