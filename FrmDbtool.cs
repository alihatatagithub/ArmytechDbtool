using AdoNetCore.AseClient;
using ArmytechDbtool.Repository;
using ArmytechDbtool.ViewModels;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ArmytechDbtool
{
    public partial class FrmDbtool : Form
    {
        private string SqlConnectionString = "data source=ST-APP01;initial catalog=ERPDB;persist security info=True;user id=sa;password=sa@12345;MultipleActiveResultSets=True;";
        TestConnectionVM createdTestConnectionVM = new TestConnectionVM();
        TestConnectionVM testConnectionVM = new TestConnectionVM();
        string csyBaseConnectionString = "";
        string? ReadTextFile = @"";
        string? CreateDatabaseQuery;
        private SqlDataReader reader = null;
       private SqlConnection sqlConnection = null;
        IDbConnection ISqlConnection;


        private void ExecuteSQLStmt(string sqlConnectionString, string CreateDatabaseQuery)
        {
            
            SqlCommand cmd = null;
            if (sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();
            sqlConnectionString = "data source=ST-APP01;initial catalog=ERPDB;persist security info=True;user id=sa;password=sa@12345;MultipleActiveResultSets=True;";

            sqlConnection.ConnectionString = sqlConnectionString;
            sqlConnection.Open();
            cmd = new SqlCommand(CreateDatabaseQuery, sqlConnection);
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
                sqlConnection.Close();
            }
        }
        public FrmDbtool()
        {
            InitializeComponent();
        }

        private void CreateDatabase(String sqlConnectionString)
        {
            CreateDatabaseQuery = "CREATE DATABASE " + createdTestConnectionVM.DataBaseName + " ON PRIMARY"
               + $"(Name=test_data, filename = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL13.MSSQLSERVER\\MSSQL\\DATA\\{createdTestConnectionVM.DataBaseName}.mdf', size=3,"
               + "maxsize=5, filegrowth=10%)log on"
               + $"(name=mydbb_log, filename='C:\\Program Files\\Microsoft SQL Server\\MSSQL13.MSSQLSERVER\\MSSQL\\DATA\\{createdTestConnectionVM.DataBaseName}.ldf',size=3,"
               + "maxsize=20,filegrowth=1)";
            try
            {
                ExecuteSQLStmt(sqlConnectionString, CreateDatabaseQuery);

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



            SqlConnectionString = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=ERPDB; persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
            sqlConnection = new SqlConnection(SqlConnectionString);
            // Open the connection  
            try
            {

                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();

                    StrOutConnectionString = SqlConnectionString;
                }
            }
            catch (Exception)
            {
                StrOutConnectionString = String.Empty;
                throw;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                    sqlConnection.Close();
            }

            return StrOutConnectionString;
        }
        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (TabCntrlDBTool.SelectedTab == TbPgConnections)
            {

                ConnectSqlserver();
                SqlConnectionString = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=" + createdTestConnectionVM.DataBaseName + "; persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
                sqlConnection.ConnectionString = SqlConnectionString;
                TabCntrlDBTool.SelectedTab = TbPgCreateSQlDB;

            }
            else if (TabCntrlDBTool.SelectedTab == TbPgCreateSQlDB)
            {
                StreamReader sr = new StreamReader(DLgSelectScriptPath.FileName);

                ReadTextFile = sr.ReadToEnd();
                sr.Close();


                ISqlConnection = sqlConnection;



                ISqlConnection.Open();

                var command = ISqlConnection.CreateCommand();
                command.CommandText = ReadTextFile;
                command.CommandTimeout = 0;


                command.ExecuteNonQuery();



                command.CommandText = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = '{createdTestConnectionVM.DataBaseName}'";
                command.CommandTimeout = 0;

                using (var dataReader = command.ExecuteReader(CommandBehavior.Default))
                {
                    while (dataReader.Read())
                    {

                        try
                        {
                            TablesCheckToTransferCKBox.Items.Add(dataReader[0].ToString());
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }

                    }



                }
                ISqlConnection.Close();

            }

            else
            {
                DataTable _dataTable = new DataTable();

                string ConnectionStringType = "";
                if (testConnectionVM.ServerType.Trim().ToLower() == "sqlserver")
                {
                    ISqlConnection = new SqlConnection(SqlConnectionString);
                }
                else
                {
                    ConnectionStringType = csyBaseConnectionString;
                    ISqlConnection = new AseConnection(ConnectionStringType);
                }


                ISqlConnection.Open();



                List<string> SelectedTable = new List<string>();
                foreach (var i in TablesCheckToTransferCKBox.CheckedItems)
                {
                    SelectedTable.Add(i.ToString());

                }
                foreach (var item in SelectedTable)
                {
                    var command = ISqlConnection.CreateCommand();

                    command.CommandText = $"SELECT * from {item}";
                    command.CommandTimeout = 0;

                    using (var dataReadFromSource = command.ExecuteReader(CommandBehavior.Default))
                    {
                       
                        string DestConnection = "data source=" + createdTestConnectionVM.ServerName + ";initial catalog=" + createdTestConnectionVM.DataBaseName + ";persist security info=True;user id=" + createdTestConnectionVM.UserName + ";password=" + createdTestConnectionVM.Password + ";MultipleActiveResultSets=True;";
                        try
                        {

                            using (SqlConnection DConnection = new SqlConnection(DestConnection))
                            {
                                if (DConnection.State != ConnectionState.Open)
                                    DConnection.Open();

                                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(DConnection))
                                {
                                    bulkCopy.DestinationTableName = item;
                                    bulkCopy.WriteToServer(dataReadFromSource);
                                    //bc.DestinationTableName = item;

                                    //bc.WriteToServer(_dataTable.CreateDataReader());
                                    TableSuccedTranferdLBox.Items.Add(item);
                                }



                            }

                        }

                        catch (Exception ex)
                        {

                            TableHasProblemInTransferedData.Items.Add(item);
                        }
                    }
                }
            }

            if (TxtScriptPath.Text.Trim().Length > 0)
            {
                TabCntrlDBTool.SelectedTab = TbPgTransfareData;
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
            testConnectionVM.Port = PortTxt.Text;

            if (testConnectionVM.ServerType.Trim().ToLower() == "sqlserver")
            {
                csyBaseConnectionString = "data source=" + testConnectionVM.ServerName + ";initial catalog=" + testConnectionVM.DataBaseName + ";persist security info=True;user id=" + testConnectionVM.UserName + ";password=" + testConnectionVM.Password + ";MultipleActiveResultSets=True;";
                if (test.TestMsSQl(csyBaseConnectionString))
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
                csyBaseConnectionString = "Data Source=" + testConnectionVM.ServerName + ";Port=" + testConnectionVM.Port + ";Database=" + testConnectionVM.DataBaseName + ";uid=" + testConnectionVM.UserName + ";pwd=" + testConnectionVM.Password + ";Connection Lifetime=1000;Charset=iso_1;";
                if (test.TestSybase(csyBaseConnectionString))
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

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAllCkBox.Checked == true)
            {

                for (int i = 0; i < TablesCheckToTransferCKBox.Items.Count; i++)
                {
                    TablesCheckToTransferCKBox.SetItemChecked(i, true);

                }

            }
            else
            {
                for (int i = 0; i < TablesCheckToTransferCKBox.Items.Count; i++)
                {
                    TablesCheckToTransferCKBox.SetItemChecked(i, false);

                }
            }
        }

        private void AuthenticationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreatedUserNameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}