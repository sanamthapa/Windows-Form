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
using System.Text.RegularExpressions;

namespace WinFormApp2
{
    public partial class Registration_Form : Form
    {
        //String Connection
        string path = @"Data Source=(LocaldB)\MSSQLLocaldB;Initial Catalog=dummy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        ErrorProvider errorProvider;
        static Regex validate_emailaddress = email_validation();

        public Registration_Form()
        {
            InitializeComponent();
            con = new SqlConnection(path);
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

            if (txtName.Text == "" || txtField.Text == "" || txtPhone.Text == "" || txtEmail.Text ==""|| txtGender.Text==""||txtAddress.Text=="" )
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
                    con.Open();
                    cmd = new SqlCommand("insert into Employee (Emplyoee_Name,Emplyoee_Phone,Employee_Field,Employee_Email,Gender,Addrss ) values('"+txtName.Text+ "','" + txtPhone.Text + "','" + txtField.Text + "','" + txtEmail.Text + "','" + Gender + "','" + txtAddress.Text + "')",con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Your Data has Been Saved in the Database");
                    clear();
                    display();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            if (validate_emailaddress.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Email Address is valid.");
            }





        }
        public void clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtField.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            
            txtId.Text = "";
          
        }
        public void display()
        {
            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("Select * from Employee", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only allow numeric value");
                errorProvider.SetError(txtPhone, "Allow only Numeric Values !");
                txtPhone.Text = "Allow Only Numeric Values";

            }
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
