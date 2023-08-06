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
    public partial class Form14 : Form
    {
        OracleConnection conn;
        public Form14()
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
        private void button1_Click(object sender, EventArgs e)
        {
            int employee_id = int.Parse(textBox1.Text); 
            int manager_id=int.Parse(textBox2.Text);
            try
            {
                setConnection();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE employee SET man_id = '" +manager_id+ "' WHERE emp_id ='" +employee_id+ "'";
                //cmd.Parameters.Add(":employee_id", employee_id);
               // cmd.Parameters.Add(":manager_id", manager_id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record updated successfully");
                }
                else
                {
                    MessageBox.Show("No record found with the specified ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
