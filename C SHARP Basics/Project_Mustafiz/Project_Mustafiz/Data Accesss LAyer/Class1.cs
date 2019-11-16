using Project_Mustafiz.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mustafiz.Data_Accesss_LAyer
{
    class Class1_dal
    {
        
            //Static String to Connect Database
            static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            public bool loginCheck(Class1_bll l)
            {
                //Create a boolean variable and set its value to false and return it
                bool isSuccess = false;

                //Connecting To DAtabase
                SqlConnection conn = new SqlConnection(myconnstrng);

                try
                {
                    //SQL Query to check login
                    string sql = "SELECT * FROM tbl_users WHERE username=@username AND password=@password AND user_type=@user_type";

                    //Creating SQL Command to pass value
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@username", l.username);
                    cmd.Parameters.AddWithValue("@password", l.password);
                    cmd.Parameters.AddWithValue("@user_type", l.user_type);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    //Checking The rows in DataTable 
                    if (dt.Rows.Count > 0)
                    {
                        //Login Sucessful
                        isSuccess = true;
                    }
                    else
                    {
                        //Login Failed
                        isSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                return isSuccess;
            }
        }
}
