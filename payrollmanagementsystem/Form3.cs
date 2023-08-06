using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace payrollmanagementsystem
{
    public partial class Form3 : Form
    {
        OracleConnection conn;
        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=KASHYAP;PASSWORD=kurmilla2004");
            OracleCommand cmd = new OracleCommand("SELECT man_id FROM manager_cred WHERE man_id='" + textBox1.Text + "' AND man_password='" + textBox2.Text + "'", con);
            OracleDataAdapter sqlDa3 = new OracleDataAdapter(cmd.CommandText, con);
            DataTable dt2 = new DataTable();
            sqlDa3.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                Form7 frm = new Form7();
                frm.StdName2 = textBox1.Text;
                this.Hide();
                textBox1.Clear();
                textBox2.Clear();
                frm.ShowDialog();
                //this.Close();

            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Incorrect Username and Password");
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
