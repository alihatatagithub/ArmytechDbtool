using AdoNetCore.AseClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmytechDbtool.Repository
{
    public class TestConnection
    {



        public bool TestMsSQl(string _strSQlConnection)
        {
            bool IsSucess = false;
            using (var conn = new SqlConnection(_strSQlConnection))
            {
                try
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                        IsSucess = true;
                }
                catch
                {
                    IsSucess = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return IsSucess;
        }
        public bool TestSybase(string _strSQlConnection)
        {
            bool IsSucess = false;
            using (var conn = new AseConnection(_strSQlConnection))
            {
                try
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                        IsSucess = true;
                }
                catch
                {
                    IsSucess = false;
                }
                finally
                {
                    conn.Close();
                }
            }
            return IsSucess;
        }
    }
}
