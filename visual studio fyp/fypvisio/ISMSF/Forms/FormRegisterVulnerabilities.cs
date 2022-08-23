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

namespace ISMSF.Forms
{
    public partial class FormRegisterVulnerabilities : Form
    {
        public FormRegisterVulnerabilities()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelvr.Controls.Clear();
            f.TopLevel = false;
            this.panelvr.Controls.Add(f);
            f.Show();
        }

  

       

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into regv(ID,AssetId,AssetName,Vulnerabilities) values('" + idr.Text + "','" + aid.Text + "','" + namer.Text + "','" + vulnerabilitiesr.Text + "')", con);
            if (idr.Text == ""|| aid.Text == "" || namer.Text == "" || vulnerabilitiesr.Text == "" )
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            idr.Text = ""; aid.Text = ""; namer.Text = ""; vulnerabilitiesr.Text = "";



            con.Close();
        }

        private void panelvr_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)),0)+1 from regv", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            idr.Text = dt.Rows[0][0].ToString();
        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("View Vulnerabilities")) vulner();
        }
        void vulner()
        {
            loadform(new FormViewVulnerabilities());
        }
    }
}

