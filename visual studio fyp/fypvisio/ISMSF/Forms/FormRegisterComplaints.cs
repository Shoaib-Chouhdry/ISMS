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
    public partial class FormRegisterComplaints : Form
    {
        public FormRegisterComplaints()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelc.Controls.Clear();
            f.TopLevel = false;
            this.panelc.Controls.Add(f);
            f.Show();
        }

        private void FormRegisterComplaints_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into creg(ID,Assetid,AssetName,Location,OwnerName,Complaints,Status,TechnicianComments) values('" + id.Text + "','" + assetid.Text + "','" + name.Text + "','" + location.Text + "','" + oname.Text + "','" + comp.Text + "','" + status.Text + "','" + tech.Text + "')", con);
            if (id.Text ==""|| assetid.Text == "" || name.Text == "" || location.Text == "" || oname.Text == "" || comp.Text == "" || status.Text == "" || tech.Text == "" )
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            id.Text = "" ; assetid.Text = ""; name.Text = ""; location.Text = ""; oname.Text = ""; comp.Text = ""; status.Text = ""; tech.Text = "";



            con.Close();

        }


        private void panelc_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)),0)+1 from creg", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
        }


      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("View Complaints")) complaints();
            
        }
        void complaints()
        {
            loadform(new FormViewComplaints());
        }
    }
}
