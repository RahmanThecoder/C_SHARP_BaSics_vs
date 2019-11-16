using Project_Mustafiz.Business_Logic_Layer;
using Project_Mustafiz.Data_Accesss_LAyer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Mustafiz.User_Interface
{
    //public partial class Form1 : Form
    //{
    //    public Form1()
    //    {
    //        InitializeComponent();
    //    }

    //    private void btnLogin_Click(object sender, EventArgs e)
    //    {

    //    }
    //}

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1_bll l = new Class1_bll();
        Class1_dal dal = new Class1_dal();
        public static string loggedIn;

        private void pboxClose_Click(object sender, EventArgs e)
        {
            //Code to close this form
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //Checking the login credentials
            bool sucess = dal.loginCheck(l);
            if (sucess == true)
            {
                //Login Successfull
                MessageBox.Show("Login Successful.");
                loggedIn = l.username;
                //Need to open Respective Forms based on User Type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //Display Admin Dashboard // not created yet
                            Form2 admin = new Form2();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "User":
                        {
                            //Display User Dashboard
                            Form2 user = new Form2();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //Display an error message
                            MessageBox.Show("Invalid User Type.");
                        }
                        break;
                }
            }
            else
            {
                //login Failed
                MessageBox.Show("Login Failed. Try Again");
            }
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{

        //}
    }
}
