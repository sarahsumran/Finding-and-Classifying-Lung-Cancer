using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ReversibleDataHiding
{
    public partial class Login : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        string s;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Admin" && textBox2.Text=="Admin")
           
            {
                MessageBox.Show("Login Success");
                this.Hide();
                Main de = new Main();
                 
                de.Show();

            }
            else
            {
                MessageBox.Show("Invalid...");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //con = new SqlConnection(@"Data Source=ADMIN-PC;Initial Catalog=Reversible;Integrated Security=True");
            //con.Open();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register obj = new Register();
         
            obj.Show();
        }
    }
}
