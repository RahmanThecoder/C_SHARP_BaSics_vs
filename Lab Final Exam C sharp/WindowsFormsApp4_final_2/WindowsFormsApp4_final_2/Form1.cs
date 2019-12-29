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

namespace WindowsFormsApp4_final_2
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

            string sql = "INSERT INTO Book22 VALUES(@BookTitle,@Author,@Edition,@PublishedYear,@Status)";


            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                cmd.Parameters.AddWithValue("@BookTitle", textBox2.Text);
                cmd.Parameters.AddWithValue("@Author", textBox3.Text);
                cmd.Parameters.AddWithValue("@Edition", textBox4.Text);
                cmd.Parameters.AddWithValue("@PublishedYear", textBox5.Text);
                cmd.Parameters.AddWithValue("@Status", comboBox1.Text);





                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted welll");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


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
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            string sql = "UPDATE Book22 SET Author = " + " ' " + textBox3.Text + " '" + "where BookTitle=" + textBox2.Text;
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(textBox1.Text);
                //cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated welll");
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";


                //Disconnect
                con.Close();
            }
        }
    }
}
