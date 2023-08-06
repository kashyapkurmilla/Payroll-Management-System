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
    public partial class Form13 : Form
    {
        OracleConnection conn;
        public Form13()
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
            if (!int.TryParse(textBox1.Text, out employee_id))
            {
                MessageBox.Show("Please enter a valid employee ID");
                return;
            }
            try
            {
                setConnection();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM employee WHERE emp_id = :employee_id";
                cmd.Parameters.Add(":employee_id", employee_id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record deleted successfully");
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
    }
}
