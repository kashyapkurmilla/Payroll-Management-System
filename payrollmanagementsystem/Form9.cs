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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payrollmanagementsystem
{
    public partial class Form9 : Form
    {
        OracleConnection conn;
        public string StdName6 { get; set; }
        public Form9()
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = StdName6;
            textBox1.Enabled = false;

            //int n = int.Parse(textBox2.Text);
            //int m = int.Parse(textBox3.Text);

            //try
            //{
            //    setConnection();

            //    OracleCommand cmd = new OracleCommand();
            //    cmd.Connection = conn;
            //    cmd.CommandText = "calculate_salary";
            //    cmd.CommandType = CommandType.StoredProcedure;
            //    cmd.Parameters.Add("p_emp_id", OracleDbType.Int32).Value = StdName6;
            //    cmd.Parameters.Add("p_month", OracleDbType.Int32).Value = n;
            //    cmd.Parameters.Add("p_year", OracleDbType.Int32).Value = m ;

            //    int rowsAffected = cmd.ExecuteNonQuery();

            //    string outputValue = cmd.Parameters["v_net_salary"].Value.ToString();

            //    textBox4.Text = outputValue;
            //    textBox4.Enabled = false;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}

            textBox1.Text = StdName6;
            setConnection();
            OracleCommand cmd13 = conn.CreateCommand();
            cmd13.CommandText = "select salary_per_day from payroll_payslip natural join employee where emp_id=:emp_id";
            cmd13.Parameters.Add(":emp_id", int.Parse(textBox1.Text));
            OracleDataReader dataReader13 = cmd13.ExecuteReader();
            dataReader13.Read();
            textBox4.Text = dataReader13.GetString(0);
            textBox4.Enabled = false;
            cmd13.Dispose();
            conn.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

              
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
