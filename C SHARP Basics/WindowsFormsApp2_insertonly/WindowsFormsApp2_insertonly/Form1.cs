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

namespace WindowsFormsApp2_insertonly
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
            con.ConnectionString = @"data source=MUSTAFIZ\SQLEXPRESS;database = mustafiz;integrated security = SSPI";

            //Generating SQL Query
            string sql = "INSERT INTO mustafizT(Name,Password) VALUES(@param1,@param2)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.Add("@param1", SqlDbType.VarChar,50).Value= textBox1.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                //this.Hide();
                con.Close();

            }

        }
    }
}
