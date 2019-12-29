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
using System.Configuration;

namespace WindowsFormsApp1_database1
{
    public partial class Form1 : Form
    {
        // private string connetionString;

        // public object ConfigurationManager { get; private set; }
       // static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        //private string connetionString;
       // public string ConnetionStrings;
        //public string myconnstrng;

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
           // static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
           //static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

            string connetionString;
            SqlConnection cnn;
            // connetionString = "Data Source=MUSTAFIZ/SQLEXPRESS;database=mustafiz;User ID=MUSTAFIZ/Asus sayem; password=";
            // connetionString = "Data Source=MUSTAFIZ\SQLEXPRESS;Initial Catalog=AnyStore;Integrated Security=True";
            //connetionString = "Data Source=MUSTAFIZ/SQLEXPRESS;database=mustafiz";
            connetionString = @"server=MUSTAFIZ\SQLEXPRESS;database=mustafiz;Integrated Security=True";
            // cnn = new SqlConnection(myconnstrng);
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
