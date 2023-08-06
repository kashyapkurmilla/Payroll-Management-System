using Oracle.ManagedDataAccess.Client;
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

namespace payrollmanagementsystem
{
   
    public partial class Form11 : Form

    {
        OracleConnection conn;
        public Form11()
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

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.EMPLOYEE' table. You can move, or remove it, as needed.
            this.eMPLOYEETableAdapter.Fill(this.dataSet2.EMPLOYEE);

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
            int sal_id = int.Parse(textBox6.Text);
            int managerid= int.Parse(textBox7.Text);

            string q = "INSERT INTO employee (emp_id, emp_name, address, email, hire_date, sal_id, position, active_notactive, phone_number, man_id) VALUES (:n, :name, :address, :email, :selectedDate, :sal_id, 'Employee', 'active', :phone, :managerid)";
            OracleCommand cmd = new OracleCommand(q, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", OracleDbType.Int32).Value = n;
            cmd.Parameters.Add("name", OracleDbType.Varchar2).Value = name;
            cmd.Parameters.Add("address", OracleDbType.Varchar2).Value = address;
            cmd.Parameters.Add("email", OracleDbType.Varchar2).Value = email;
            cmd.Parameters.Add("selectedDate", OracleDbType.Date).Value = selectedDate;
            cmd.Parameters.Add("sal_id", OracleDbType.Int32).Value = sal_id;
            cmd.Parameters.Add("phone", OracleDbType.Varchar2).Value = phone;
            cmd.Parameters.Add("managerid", OracleDbType.Int32).Value = managerid; // Assuming this field can be null

            if (phone.Length != 10)
            {
                MessageBox.Show("Incorrect Phone Number");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                this.eMPLOYEETableAdapter.Fill(this.dataSet2.EMPLOYEE);
            }
            cmd.Dispose();

            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 frm = new Form13();
            frm.ShowDialog();

            //int employee_id;
            //if (!int.TryParse(textBox1.Text, out employee_id))
            //{
            //    MessageBox.Show("Please enter a valid employee ID");
            //    return;
            //}
            //try
            //{
            //    setConnection();
            //    OracleCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = "DELETE FROM employee WHERE emp_id = :employee_id";
            //    cmd.Parameters.Add(":employee_id", employee_id);
            //    int rowsAffected = cmd.ExecuteNonQuery();
            //    if (rowsAffected > 0)
            //    {
            //        MessageBox.Show("Record deleted successfully");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No record found with the specified ID");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.ShowDialog();
            //int employee_id;
            //int manager_id;
            //if (!int.TryParse(textBox1.Text, out employee_id))
            //{
            //    MessageBox.Show("Please enter a valid employee ID");
            //    return;
            //}
            //try
            //{
            //    setConnection();
            //    OracleCommand cmd = conn.CreateCommand();
            //    cmd.CommandText = "UPDATE employee set man_id = :manager_id WHERE emp_id = :employee_id";
            //    cmd.Parameters.Add(":employee_id", employee_id);
            //    cmd.Parameters.Add(":manager_id", manager_id);
            //    int rowsAffected = cmd.ExecuteNonQuery();
            //    if (rowsAffected > 0)
            //    {
            //        MessageBox.Show("Record deleted successfully");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No record found with the specified ID");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.eMPLOYEETableAdapter.Fill(this.dataSet2.EMPLOYEE);
        }
    }
}
