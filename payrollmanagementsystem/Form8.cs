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

namespace payrollmanagementsystem
{
    public partial class Form8 : Form
    {
        OracleConnection conn;
        public string StdName21 { get; set; }
        public Form8()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = StdName21;
            textBox1.Enabled = false;
            
            setConnection();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select man_name from manager where man_id=:man_id";

            cmd.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader = cmd.ExecuteReader();
            dataReader.Read();
            textBox2.Text = dataReader.GetString(0);
            textBox2.Enabled = false;
            cmd.Dispose();
            conn.Close();


            //textBox1.Text = StdName21;
            //setConnection();
            //OracleCommand cmd2 = conn.CreateCommand();
            //cmd2.CommandText = "select address from manager where man_id=:man_id";
            //cmd2.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            //OracleDataReader dataReader2 = cmd2.ExecuteReader();
            //dataReader2.Read();
            //textBox3.Text = dataReader2.GetString(0);
            //cmd2.Dispose();
            //conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd3 = conn.CreateCommand();
            cmd3.CommandText = "select address from manager where man_id=:man_id";
            cmd3.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader3 = cmd3.ExecuteReader();
            dataReader3.Read();
            textBox3.Text = dataReader3.GetString(0);
            textBox3.Enabled = false;
            cmd3.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd4 = conn.CreateCommand();
            cmd4.CommandText = "select email from manager where man_id=:man_id";
            cmd4.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader4 = cmd4.ExecuteReader();
            dataReader4.Read();
            textBox4.Text = dataReader4.GetString(0);
            textBox4.Enabled = false;
            cmd4.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd5 = conn.CreateCommand();
            cmd5.CommandText = "select phone_number_m from manager where man_id =:man_id";
            cmd5.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader5 = cmd5.ExecuteReader();
            dataReader5.Read();
            textBox5.Text = dataReader5.GetString(0);
            textBox5.Enabled = false;
            cmd5.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd6 = conn.CreateCommand();
            cmd6.CommandText = "select position from manager where man_id=:man_id";
            cmd6.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader6 = cmd6.ExecuteReader();
            dataReader6.Read();
            textBox6.Text = dataReader6.GetString(0);
            textBox6.Enabled = false;
            cmd6.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd7 = conn.CreateCommand();
            cmd7.CommandText = "select hire_date from manager where man_id=:man_id ";
            cmd7.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader7 = cmd7.ExecuteReader();
            dataReader7.Read();
            textBox7.Text = dataReader7.GetString(0);
            textBox7.Enabled = false;
            cmd7.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd12 = conn.CreateCommand();
            cmd12.CommandText = "select state_tax from salary natural join manager where man_id=:man_id";
            cmd12.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader12 = cmd12.ExecuteReader();
            dataReader12.Read();
            textBox13.Text = dataReader12.GetString(0);
            textBox13.Enabled = false;
            cmd12.Dispose();
            conn.Close();

            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd13 = conn.CreateCommand();
            cmd13.CommandText = "select fed_tax from salary natural join manager where man_id=:man_id";
            cmd13.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader13 = cmd13.ExecuteReader();
            dataReader13.Read();
            textBox14.Text = dataReader13.GetString(0);
            textBox14.Enabled = false;
            cmd13.Dispose();
            conn.Close();


            textBox1.Text = StdName21;
            setConnection();
            OracleCommand cmd14 = conn.CreateCommand();
            cmd14.CommandText = "select gross_salary from salary natural join manager where man_id=:man_id";
            cmd14.Parameters.Add(":man_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader14 = cmd14.ExecuteReader();
            dataReader14.Read();
            textBox9.Text = dataReader14.GetString(0);
            textBox9.Enabled = false;
            cmd13.Dispose();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
