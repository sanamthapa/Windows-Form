using System.Data;

namespace WinForm_App
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();


        string name;
        string desigination;
        int salary;
        string gender;
        string review;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             name=txtName.Text;
             desigination=txtDesigination.Text;
             salary=int.Parse(txtSalary.Text);


            if (rbtMale.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            if(chkGood.Checked)
            {
                review = "Good";
            }
            else
            {
                review = "Very Good";
            }

            display();
            empty();
            //(To display the data in the button)
            lblDisplay.Text = name + " " + desigination + " " + salary + " " + gender+" " +review;
            //MessageBox.Show("Your Name is :" + name + "Your Desigination is: " + desigination + "Your Salary is :" + salary);
        }
        public void display()
        {
            dt.Columns.Add("Name");
            dt.Columns.Add("Desigination");
            dt.Columns.Add("Salary");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Review");

            DataRow dr = dt.NewRow();
            dr[0] = name;
            dr[1] = desigination;
            dr[2] = salary;
            dr[3] = gender;
            dr[4] = review;

            dt.Rows.Add(dr);
            dtDataGridView.DataSource = dt; 


        }

        public void empty()
        {
            txtDesigination.Text = "";
            txtName.Text = "";
            txtSalary.Text = "";


        }

        private void txtDesigination_TextChanged(object sender, EventArgs e)
        {

        }
    }
}