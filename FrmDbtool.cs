using ArmytechDbtool.Repository;
using ArmytechDbtool.ViewModels;
using System.Data;
using System.Data.SqlClient;

namespace ArmytechDbtool
{
    public partial class FrmDbtool : Form
    {
        private string CreatedConnectionString = "data source=ST-APP01;initial catalog=ERPDB;persist security info=True;user id=sa;password=sa@12345;MultipleActiveResultSets=True;";
        TestConnectionVM createdTestConnectionVM = new TestConnectionVM();
        TestConnectionVM testConnectionVM = new TestConnectionVM();
        List<string> AllTablesNames = new List<string>();
        List<string> ColumnsName = new List<string>();
        string connectionString = "";
        string? line = @"" ;
        string? sqlQuery ;
        private SqlDataReader reader = null;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

        private void ExecuteSQLStmt(string connectionString, string sql)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            CreatedConnectionString = "data source=ST-APP01;initial catalog=ERPDB;persist security info=True;user id=sa;password=sa@12345;MultipleActiveResultSets=True;";

            conn.ConnectionString = connectionString;
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }
        public FrmDbtool()
        {
            InitializeComponent();
        }

        private void CreateDatabase(String connectionString)
        {
            sqlQuery = "CREATE DATABASE " + createdTestConnectionVM.DataBaseName + " ON PRIMARY"
               + $"(Name=test_data, filename = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL13.MSSQLSERVER\\MSSQL\\DATA\\{createdTestConnectionVM.DataBaseName}.mdf', size=3,"
               + "maxsize=5, filegrowth=10%)log on"
               + $"(name=mydbb_log, filename='C:\\Program Files\\Microsoft SQL Server\\MSSQL13.MSSQLSERVER\\MSSQL\\DATA\\{createdTestConnectionVM.DataBaseName}.ldf',size=3,"
               + "maxsize=20,filegrowth=1)";
            try
            {
                ExecuteSQLStmt(connectionString, sqlQuery);
                MessageBox.Show("Success");
            }
            catch (Exception)
            {

                MessageBox.Show("Fail");
            }

        }
        private String ConnectSqlserver()
        {
            String StrOutConnectionString = String.Empty;
            createdTestConnectionVM.ServerType = CreatedServerTypecombo.Text;
            createdTestConnectionVM.ServerName = CreatedServerNameTxt.Text;
            createdTestConnectionVM.UserName = CreatedUserNameTxt.Text;
            createdTestConnectionVM.Password = CreatedPasswordTxt.Text;
            createdTestConnectionVM.DataBaseName = CreatedDataBaseNameTxt.Text;
            createdTestConnectionVM.AuthenticationType = CreatedAuthenticationLblcombo.Text;



            string connectionString = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=ERPDB;persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
            conn = new SqlConnection(CreatedConnectionString);
            // Open the connection  
            try
            {

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();

                    StrOutConnectionString= connectionString;
                }
            }
            catch (Exception)
            {
                StrOutConnectionString = String.Empty;
                throw;
            }
            finally
            {
                if (conn.State != ConnectionState.Closed)
                    conn.Close();   
            }
            
            return StrOutConnectionString;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {
            
            if (TabCntrlDBTool.SelectedTab == TbPgConnections)
            {

                ConnectSqlserver();
                TabCntrlDBTool.SelectedTab = TbPgCreateSQlDB;

            }
            else if (TabCntrlDBTool.SelectedTab == TbPgCreateSQlDB)
            {

                StreamReader sr = new StreamReader(DLgSelectScriptPath.FileName);

                line = sr.ReadToEnd();
                sr.Close();
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                string myConnectionString = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=" + createdTestConnectionVM.DataBaseName + "; persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";

                conn.ConnectionString = myConnectionString;
                conn.Open();

                cmd = new SqlCommand(line, conn);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ae)
                {
                    MessageBox.Show(ae.Message.ToString());
                }
                conn.Close();
                //string connectionString = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=" + createdTestConnectionVM.DataBaseName + "; persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
                using (SqlConnection con = new SqlConnection(myConnectionString))
                {
                    con.Open();

                    SqlCommand objSqlCommand = new SqlCommand($"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '{createdTestConnectionVM.DataBaseName}'", con);
                    SqlDataReader read = objSqlCommand.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            checkedListBox1.Items.Add(read[0].ToString());
                            AllTablesNames.Add(read[0].ToString());
                        }
                    }
                    read.Close();
                    //con.Close();

                }

                using (SqlConnection con2 = new SqlConnection(connectionString))
                {
                    SqlDataReader myreader = null;
                    if (con2.State != ConnectionState.Open)
                    {
                        con2.Open();


                    }
                    string fillData = "";
                    foreach (var item in AllTablesNames)
                    {
                        SqlCommand objSqlCommand = new SqlCommand($"SELECT * from {item}", con2);
                        SqlCommand ColumnNameCommand = new SqlCommand($"SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{item}'", con2);

                        SqlDataReader reader = objSqlCommand.ExecuteReader();
                         myreader = ColumnNameCommand.ExecuteReader();

                       
                        //if (reader.HasRows)
                        //{
                            while (reader.Read())
                            {

                                
                                //if (myreader.HasRows)
                                //{
                                    while (myreader.Read())
                                    {

                                        //This Is ColumnName myreader[0].ToString();
                                        ColumnsName.Add(myreader[0].ToString());
                                        
                                    }
                                    string x = "";
                                    string y = "";
                                    for (int i = 0; i < ColumnsName.Count; i++)
                                    {
                                      
                                        if (i != ColumnsName.Count -1)
                                        {
                                            x += (ColumnsName[i] + ",");
                                            y += ("'"+reader[ColumnsName[i]] + "',");
                                        }
                                        else
                                        {
                                            x += (ColumnsName[i]);
                                            y += ("'"+reader[ColumnsName[i]]+"'");
                                        }

                                       

                                    }
                                    fillData = $"SET IDENTITY_INSERT   {item} ON  INSERT INTO {item}({x})" + $"VALUES({y}) SET IDENTITY_INSERT  {item} OFF";
                                x = "";
                                y = "";
                                    string CO = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog="+ createdTestConnectionVM.DataBaseName+";persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
                                    SqlCommand cm = null;

                            try
                            {
 using (SqlConnection CC = new SqlConnection(CO))
                                    {
                                if (CC.State != ConnectionState.Open)
                                    CC.Open();
                                cm = new SqlCommand(fillData, CC);
                                        cm.ExecuteNonQuery();
                                

                                    }
                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(item + " :::: "+ex.Message);
                            }
                                   
                                //}

                                
                            }
                        ColumnsName.Clear();
                        //}


                    }
                    //myreader.Close();
                    //reader.Close();

                }


                if (TxtScriptPath.Text.Trim().Length>0)
                {
                    
                       


                    TabCntrlDBTool.SelectedTab = TbPgTransfareData;
                }
                
            }

            else
            {
               

            }




        }

        private void LblSyBaseServerName_Click(object sender, EventArgs e)
        {

        }

        private void ServerNameLbl_Click(object sender, EventArgs e)
        {

        }

        private void TblLaySybase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TstConnectionBtn_Click(object sender, EventArgs e)
        {
            TestConnection test = new TestConnection();

            testConnectionVM.ServerType = ServerTypecomboBox.Text;
            testConnectionVM.ServerName = ServerNameTxt.Text;
            testConnectionVM.UserName = UserNameTxt.Text;
            testConnectionVM.Password = PasswordTxt.Text;
            testConnectionVM.DataBaseName = DataBaseNameTxt.Text;
            testConnectionVM.AuthenticationType = AuthenticationcomboBox.SelectedText;


          
            bool result = int.TryParse(PortTxt.Text, out int portNumber);
            //string provider = "System.Data.SqlClient";

            

            if (testConnectionVM.ServerType.Trim().ToLower() == "sqlserver")
            {
                connectionString = "data source=" + testConnectionVM.ServerName + ";initial catalog=" + testConnectionVM.DataBaseName + ";persist security info=True;user id=" + testConnectionVM.UserName + ";password=" + testConnectionVM.Password + ";MultipleActiveResultSets=True;";
                if (test.TestMsSQl(connectionString))
                {
                    MessageBox.Show("Succeed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
                
            }

            else
            {
                if (test.TestSybase(connectionString))
                {
                    MessageBox.Show("Succeed");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FrmDbtool_Load(object sender, EventArgs e)
        {
            //if (TabCntrlDBTool.SelectedTab == TbPgTransfareData)
            //{
            //    BtnNext.Enabled = false;
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    checkedListBox1.Items.Add(i);
            //}
        }

        private void BtnSelectScriptPath_Click(object sender, EventArgs e)
        {
            if (DLgSelectScriptPath.ShowDialog() == DialogResult.OK)
            {
                TxtScriptPath.Text = DLgSelectScriptPath.FileName;
               


            }
        }

        private void BtnClearScriptPath_Click(object sender, EventArgs e)
        {
            TxtScriptPath.Clear();
        }

        private void BtnCreateSQlDB_Click(object sender, EventArgs e)
        {
            CreateDatabase(ConnectSqlserver());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
        }
    }
}