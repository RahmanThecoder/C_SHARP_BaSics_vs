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

namespace FinalExam
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
            //  string sql = "INSERT INTO Mustafiz_Borrower(BorrowerId,Name,MobileNo,Address,BorrowerType,Status) VALUES(@param1,@param2)";
            string sql = "INSERT INTO Mustafiz_Borrower VALUES(@BorrowerId,@Name,@MobileNo,@Address,@BorrowerType,@Status)";


            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.Parameters.Add("@param1", SqlDbType.Int).Value = int.Parse(textBox1.Text);
                //cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;

                cmd.Parameters.AddWithValue("@BorrowerId", textBox2.Text);
                cmd.Parameters.AddWithValue("@Name", textBox3.Text);
                cmd.Parameters.AddWithValue("@MobileNo", textBox4.Text);
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@BorrowerType", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Status", comboBox2.Text);





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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            string sql = "UPDATE Mustafiz_Borrower SET Name = " + " ' " + textBox3.Text + " '"  + "MobileNo=" + " ' " + textBox4.Text + " '" + "Address="+ " ' " + textBox5.Text + " '"+ "BorrowerType="+ " ' " + comboBox1.Text + " '"+ "Status="+ " ' " + comboBox2.Text + " '" + "where BorrowerID=" + textBox2.Text;
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

        private void button4_Click(object sender, EventArgs e)
        {
           

            //SQL Connection for DB connection
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";


            try
            {
                //Write Query Product from DAtabase
                String sql = "DELETE FROM Mustafiz_Borrower WHERE @BorrowerID='"+textBox2.Text+"'";

                //Sql Command to Pass the Value
                SqlCommand cmd = new SqlCommand(sql, con);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@BorrowerId",textBox2.Text );
               // cmd.ExecuteNonQuery();

                //Open Database Connection
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted succefully");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
              //  MessageBox.Show("delete not successful");
            }

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            //ConnectionString:
            con.ConnectionString = @"Data Source=DESKTOP-M8JKVTL\SQLEXPRESS;Initial Catalog=mustafizCSHARP;Integrated Security=True";

            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from Mustafiz_Borrower", con);

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
    }
}
