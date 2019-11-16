using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1_database1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string connetionString;
            //SqlConnection cnn;
            //connetionString = @"Data Source=Mustafiz;
            // Initial Catalog=C_sharp;User ID=root;Password=";
            //cnn = new SqlConnection(connetionString);
            //cnn.Open();
            //MessageBox.Show("Connection Open  !");
            //cnn.Close();
            Dbconnection();
        }

        public void Dbconnection()
        {
            string connetionString;
            SqlConnection cnn;
            // connetionString = "Data Source=MUSTAFIZ/SQLEXPRESS;database=mustafiz;User ID=MUSTAFIZ/Asus sayem; password=";
            // connetionString = "Data Source=MUSTAFIZ\SQLEXPRESS;Initial Catalog=AnyStore;Integrated Security=True";
            connetionString = "Data Source=MUSTAFIZ/SQLEXPRESS;database=mustafiz";

            cnn = new SqlConnection(connetionString);
            //cnn.Open();
            //MessageBox.Show("Connection Open  !");
            //cnn.Close();
            try
            {
                cnn.Open();
                MessageBox.Show("Server Connection Open  !");
            }
            catch(Exception e){
                MessageBox.Show(e.Message);
            }
        }

    }
}
