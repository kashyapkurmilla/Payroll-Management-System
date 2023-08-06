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
    
    public partial class Form5 : Form
    {
        OracleConnection conn;
        public string StdName { get; set; }
        public Form5()
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
     
            textBox1.Text = StdName;
            textBox1.Enabled = false;
            setConnection();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select emp_name from employee where emp_id=:emp_id";

            cmd.Parameters.Add(":emp_id",int.Parse(textBox1.Text));
            OracleDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            textBox2.Text=dataReader.GetString(0);
            textBox2.Enabled = false;
            cmd.Dispose();
            conn.Close();


            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "select address from employee where emp_id=:emp_id";

            //cmd2.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            //OracleDataReader dataReader2 = cmd2.ExecuteReader();
            //dataReader2.Read();
            //textBox3.Text = dataReader2.GetString(0);
            //cmd2.Dispose();
            //conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd3 = conn.CreateCommand();
            cmd3.CommandText = "select address from employee where emp_id=:emp_id";
            cmd3.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader3 = cmd3.ExecuteReader();
            dataReader3.Read();
            textBox3.Text = dataReader3.GetString(0);
            textBox3.Enabled = false;
            cmd3.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "select email from employee where emp_id=:emp_id";
            cmd4.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader4 = cmd4.ExecuteReader();
            dataReader4.Read();
            textBox4.Text = dataReader4.GetString(0);
            textBox4.Enabled = false;
            cmd4.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd5 = conn.CreateCommand();
            cmd5.CommandText = "select phone_number from employee where emp_id=:emp_id";
            cmd5.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader5 = cmd5.ExecuteReader();
            dataReader5.Read();
            textBox5.Text = dataReader5.GetString(0);
            textBox5.Enabled = false;
            cmd5.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd6 = conn.CreateCommand();
            cmd6.CommandText = "select position from employee where emp_id=:emp_id";
            cmd6.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader6 = cmd6.ExecuteReader();
            dataReader6.Read();
            textBox6.Text = dataReader6.GetString(0);
            textBox6.Enabled = false;
            cmd6.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd7 = conn.CreateCommand();
            cmd7.CommandText = "select hire_date from employee where emp_id=:emp_id ";
            cmd7.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader7 = cmd7.ExecuteReader();
            dataReader7.Read();
            textBox7.Text = dataReader7.GetString(0);
            textBox7.Enabled = false;
            cmd7.Dispose();
            conn.Close();

            //active hours
            //textBox1.Text = StdName;
            //setConnection();
            //OracleCommand cmd8 = conn.CreateCommand();
            //cmd8.CommandText = "SELECT CASE WHEN active_notactive = 'active' THEN (SYSDATE - hire_date) ELSE 0 END AS days_since_hire FROM employee WHERE emp_id = :emp_id";
            //cmd8.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            //OracleDataReader dataReader8 = cmd8.ExecuteReader();
            //dataReader8.Read();
            //textBox8.Text = dataReader8.GetInt32(0).ToString();
            //textBox8.Enabled = false;
            //cmd8.Dispose();
            //conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd9 = conn.CreateCommand();
            cmd9.CommandText = "select salary from employee natural join payroll_payslip where emp_id=:emp_id";
            cmd9.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader9 = cmd9.ExecuteReader();
            dataReader9.Read();
            textBox9.Text = dataReader9.GetString(0);
            textBox9.Enabled = false;
            cmd9.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd10 = conn.CreateCommand();
            cmd10.CommandText = "select active_notactive from employee where emp_id=:emp_id";
            cmd10.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader10 = cmd10.ExecuteReader();
            dataReader10.Read();
            textBox10.Text = dataReader10.GetString(0);
            textBox10.Enabled = false;
            cmd10.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd11 = conn.CreateCommand();
            cmd11.CommandText = "select fed_tax from salary natural join employee where emp_id=:emp_id";
            cmd11.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader11 = cmd11.ExecuteReader();
            dataReader11.Read();
            textBox14.Text = dataReader11.GetString(0);
            textBox14.Enabled = false;
            cmd11.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd12 = conn.CreateCommand();
            cmd12.CommandText = "select state_tax from salary natural join employee where emp_id=:emp_id";
            cmd12.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader12 = cmd12.ExecuteReader();
            dataReader12.Read();
            textBox13.Text = dataReader12.GetString(0);
            textBox13.Enabled = false;
            cmd12.Dispose();
            conn.Close();

            textBox1.Text = StdName;
            setConnection();
            OracleCommand cmd13 = conn.CreateCommand();
            cmd13.CommandText = "select no_of_leaves from payroll_payslip natural join employee where emp_id=:emp_id";
            cmd13.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader13 = cmd13.ExecuteReader();
            dataReader13.Read();
            textBox11.Text = dataReader13.GetString(0);
            textBox11.Enabled = false;
            cmd13.Dispose();
            conn.Close();

            //textBox1.Text = StdName;
            //setConnection();
            //OracleCommand cmd14 = conn.CreateCommand();
            //cmd14.CommandText = "select no_of_leaves from payroll_payslip natural join employee where emp_id=:emp_id";
            //cmd14.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            //OracleDataReader dataReader14 = cmd14.ExecuteReader();
            //dataReader14.Read();
            //textBox9.Text = dataReader14.GetString(0);
            //textBox9.Enabled = false;
            //cmd14.Dispose();
            //conn.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 frm = new Form9();
            frm.StdName6 = StdName;
            frm.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Logged Out Successfully");
        }
    }
}
