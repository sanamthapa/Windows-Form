using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormApp2
{
    public partial class Registration_Form : Form
    {
        //String Connection
        string path = @"Data Source=(LocaldB)\MSSQLLocaldB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        
        public Registration_Form()
        {
            InitializeComponent();
            conn = new SqlConnection(path);
            display();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtField.Text == "" || txtPhone.Text == "" || txtEmail.Text =="" || txtId.Text == "")
            {
                MessageBox.Show("Please Fill in the Blanks");
            }

            else
            {
                try
                {
                    string Gender;
                    if (rbtMale.Checked)
                    {
                        Gender = "Male";
                    }
                    else
                    {
                        Gender = "Female";
                    }
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM Table_1 WHERE Name = '" + txtName.Text + "' Field = '" + txtField.Text + "' Phone = '" + txtPhone.Text + "' Email = '" + txtEmail.Text + "' Id = '" + txtId + "' ");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Your Data has Been Saved in the Database");
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           


        

        }
        public void clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtField.Text = "";
            txtEmail.Text = "";
            txtId.Text = "";
          
        }
        public void display()
        {
            try
            {

                dt = new DataTable();
                conn.Open();
                adpt = new SqlDataAdapter("Select * from Table", conn);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
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
    }
}
