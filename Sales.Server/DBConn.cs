using Microsoft.Data.SqlClient;
using System.Data;

namespace Sales.Server
{
    public class DBConn
    {
            private readonly string connectionString; //create a variable for connection
            public DBConn()
            {
            connectionString = @"Data Source=DESKTOP-8BL3MIG\SQLEXPRESS;Initial Catalog=SalesSpark; Integrated Security=True; TrustServerCertificate = True" ;
            }
            public void ExecuteCommand(string query)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                //creating connection first sql comand need two argument 
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {

                        cmd.ExecuteNonQuery();
                        //offline data retrive and give from there

                    }

                    //adapter cmd pass will fetch the the consequecces of cmd 
                    //the place data in dataset which is temporary storage for data
                }
            }
            public DataTable FetchData(string query)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds.Tables[0];

                    }
                }

            }
         }
    }
