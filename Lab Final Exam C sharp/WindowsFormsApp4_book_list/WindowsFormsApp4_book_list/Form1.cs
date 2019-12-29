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

namespace WindowsFormsApp4_book_list
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
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from Book22", con);

            //Opening the connection:
            con.Open();

            ////Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView1.DataSource = source;

            //Disconnect
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            //  string sql = "INSERT INTO Mustafiz_Borrower(BorrowerId,Name,MobileNo,Address,BorrowerType,Status) VALUES(@param1,@param2)";
            string sql = "INSERT INTO Transaction VALUES(@BookId,@BorrowerId,@DateBorrowed,@ExpectedReturn)";


            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@BookId", textBox2.Text);
                cmd.Parameters.AddWithValue("@BorrowerId", textBox3.Text);
                cmd.Parameters.AddWithValue("@DateBorrowed", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@ExpectedReturn", dateTimePicker2.Value);






                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted welll");
                textBox2.Text = "";
                textBox3.Text = "";



                //Disconnect
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from Transaction", con);

            //Opening the connection:
            con.Open();

            ////Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView2.DataSource = source;

            //Disconnect
            con.Close();
        }
    }
}
