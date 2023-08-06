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
using OracleInternal.SqlAndPlsqlParser.LocalParsing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace payrollmanagementsystem
{
    public partial class Form6 : Form
    {
        OracleConnection conn;
        public string StdName3 { get; set; }
        public Form6()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //textBox1.Text = StdName2;

            //manager name
            setConnection();
            textBox1.Text = StdName3;
            textBox1.Enabled = false;
            OracleCommand cmd2 = conn.CreateCommand();
            cmd2.CommandText = "select man_name from manager where man_id=:man_id";
            cmd2.Parameters.Add(":man_id", StdName3);
            OracleDataReader dataReader2 = cmd2.ExecuteReader();
            dataReader2.Read();
            textBox2.Text = dataReader2.GetString(0);
            cmd2.Dispose();
            conn.Close();

            //display tables
            setConnection();
            textBox1.Text = StdName3;
            textBox1.Enabled = false;
            string query = "select * from employee e,employee_manager_relation em where em.emp_id=e.emp_id and  em.man_id = '" + StdName3 + "' ";
            OracleCommand command = new OracleCommand(query, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);

            if (dataset.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No employees Under this manager");
                return;
            }
            textBox2.Enabled = false;
            dataGridView1.DataSource = dataset.Tables[0];
            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            setConnection();
            int currentNoOfLeaves;
            int t = int.Parse(textBox3.Text);
            string selectQuery = "SELECT no_of_leaves FROM payroll_payslip WHERE emp_id = :id";
            OracleCommand selectCmd = new OracleCommand(selectQuery, conn);
            selectCmd.Parameters.Add("id", OracleDbType.Int32).Value = t;
            //int currentNoOfLeaves = (int)selectCmd.ExecuteScalar();

            object result = selectCmd.ExecuteScalar();
            if (result != null)
            {
                currentNoOfLeaves = Convert.ToInt32(result);
                // do something with currentNoOfLeaves
            }
            else
            {
                currentNoOfLeaves = 0;
            }


            //string q = "UPDATE payroll_payslip SET no_of_leaves = :new_no_of_leaves WHERE man_id = '" + StdName3 + "' emp_id = :id";
            string q = "UPDATE payroll_payslip SET no_of_leaves = :new_no_of_leaves WHERE emp_id = :id";

            OracleCommand cmd = new OracleCommand(q, conn);
            cmd.Parameters.Add("new_no_of_leaves", OracleDbType.Int32).Value = currentNoOfLeaves + 1; // newNoOfLeaves is the new value for no_of_leaves
            cmd.Parameters.Add("id", OracleDbType.Int32).Value = t; // empId is the ID of the employee to update
            int rowsUpdated = cmd.ExecuteNonQuery();

            MessageBox.Show("updated");
            //if (rowsUpdated == 0)
            //{
            //    MessageBox.Show("Enter correct row");
            //}
            //else
            //{
            //    MessageBox.Show("updated");
            //}

            cmd.Dispose();

            conn.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
