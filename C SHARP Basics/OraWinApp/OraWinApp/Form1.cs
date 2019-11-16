using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; // ODP.NET Oracle managed provider
using Oracle.ManagedDataAccess.Types;

namespace OraWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // string oradb = "Data Source=ORCL;User Id=SYSTEM;Password=tiger;";
            string oradb = "Data Source=localhost:ORCL;User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "select department_name from departments where department_id = 10";
            cmd.CommandText = "select empno from emp where deptno= 10";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            label1.Text = dr.GetString(0);
            conn.Dispose();
        }
    }
}
