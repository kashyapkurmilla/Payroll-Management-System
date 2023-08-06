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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payrollmanagementsystem
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=KASHYAP;PASSWORD=kurmilla2004");
            OracleCommand cmd = new OracleCommand(string.Format("SELECT emp_id FROM employee_cred WHERE emp_id='" + textBox1.Text + "' AND emp_password='" + textBox2.Text + "'", con));
            OracleDataAdapter sqlDa2 = new OracleDataAdapter(cmd.CommandText, con);
            DataTable dt = new DataTable();
            sqlDa2.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Form5 frm = new Form5();
                frm.StdName = textBox1.Text;
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                frm.ShowDialog();
                //this.Close();

            }
            else
            {
                textBox1.Clear() ;
                textBox2.Clear() ;
                MessageBox.Show("Incorrect Username and Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;  
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
