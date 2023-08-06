using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payrollmanagementsystem
{
    public partial class Form12 : Form
    {
        OracleConnection conn;
        public Form12()
        {
            InitializeComponent();
        }
        public void setConnection()
        {
            conn = new OracleConnection("DATA SOURCE=localhost:1521/orcl;PERSIST SECURITY INFO=True;USER ID=KASHYAP;PASSWORD=kurmilla2004");
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("not Connected");
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet3.MANAGER' table. You can move, or remove it, as needed.
            this.mANAGERTableAdapter.Fill(this.dataSet3.MANAGER);



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setConnection();

            int n = int.Parse(textBox1.Text);
            string name = textBox2.Text;
            string address = textBox3.Text;
            string email = textBox4.Text;
            DateTime selectedDate = dateTimePicker1.Value;
            string phone = textBox5.Text;
            int sal_id = int.Parse(textBox7.Text);

            string q = "INSERT INTO manager (man_id, man_name, address, email, hire_date, sal_id, position,phone_number_m) VALUES (:n, :name, :address, :email, :selectedDate, :sal_id, 'Manager',:phone)";
            OracleCommand cmd = new OracleCommand(q, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", OracleDbType.Int32).Value = n;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
            cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("selectedDate", OracleDbType.Date).Value = selectedDate;
            cmd.Parameters.Add("sal_id", OracleDbType.Int32).Value = sal_id;
            cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = phone;
            if (phone.Length != 10)
            {
                MessageBox.Show("Incorrect Phone Number");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            cmd.Dispose();

            conn.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form15 frm = new Form15();
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.mANAGERTableAdapter.Fill(this.dataSet3.MANAGER);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
