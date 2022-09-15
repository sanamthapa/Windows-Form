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
        //StringConnection
        string path = @"Data Source=(LocaldB)\MSSQLLocaldB;Initial Catalog=registration;Integrated Security=True";
        SqlConnection con;
        
        public Registration_Form()
        {
            InitializeComponent();
            con=new SqlConnection(path);
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
        

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
