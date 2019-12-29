using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();

            //ConnectionString:
            //con.ConnectionString = "data source = MUSTAFIZ/SQLEXPRESS;database = mustafiz;integrated security = True";
            // con.ConnectionString = "data source = localhost;database = mustafiz;integrated security = SSPI";
            con.ConnectionString = "Data Source=localhost;Initial Catalog=mustafiz;Integrated Security=True";
            // query direct from database


//INSERT INTO[dbo].[mustafizT]
//           ([Name]
//           ,[Nationality])
//     VALUES
//           (<Name, varchar(50),>
//           ,<Nationality, varchar(50),>)



            //Generating SQL Query


            string sql = "INSERT INTO mustafizT(Name,Nationality) VALUES(@Name,@Nationality)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@Name", SqlDbType.VarChar,50).Value = textBox1.Text;
                cmd.Parameters.Add("@Nationality", SqlDbType.VarChar, 50).Value = textBox2.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();
            }


        }
    }
}
