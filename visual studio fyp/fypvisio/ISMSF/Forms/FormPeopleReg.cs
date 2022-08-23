using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
namespace ISMSF.Forms
{
    public partial class FormPeopleReg : Form
    {
        public FormPeopleReg()
        {
            InitializeComponent();
        }


        string pattern = "@gmail.com";

       
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelpr.Controls.Clear();
            f.TopLevel = false;
            this.panelpr.Controls.Add(f);
            f.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormHardwareReg());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into prt(id,Name,Email) values('" + idpr.Text + "','" + namepr.Text + "','" + emailpr.Text + "')", con);
            if (Regex.IsMatch(emailpr.Text, pattern) == false)
            {
                emailpr.Focus();
                errorProvider1.SetError(this.emailpr, "Invalid Email !!");
                MessageBox.Show("Error!! Invalid Email");
                return;
            }
            else if(Regex.IsMatch(emailpr.Text, pattern) == true)
            {
                errorProvider1.Clear();
            }

            else if (idpr.Text=="" || namepr.Text == ""|| emailpr.Text=="")
            {
                MessageBox.Show("Error!! Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            
             namepr.Text = "";
             emailpr.Text = "";

            con.Close();
        }

        private void panelpr_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(id as int)),0)+1 from prt", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            idpr.Text = dt.Rows[0][0].ToString();
        }
      
      
    }
}
