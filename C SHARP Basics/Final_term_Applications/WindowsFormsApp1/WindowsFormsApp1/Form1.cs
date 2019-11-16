using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            string[] choosehere = new string[5];
            choosehere[0] = "Mustafiz";
            choosehere[1] = "C_sharp";
            choosehere[2] = "T_O_C";
            choosehere[3] = "DLD";
            choosehere[4] = "ADMS";
            comboBox1.DataSource = choosehere;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string herename = Convert.ToString(Console.ReadLine());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string textBox4 = Convert.ToString(textBox2.herename);
            //string textBox4 = 
            //  Convert.ToString(textBox2_TextChanged(string herename));

             textBox4.Text=textBox2.Text;
        }
    }
}
