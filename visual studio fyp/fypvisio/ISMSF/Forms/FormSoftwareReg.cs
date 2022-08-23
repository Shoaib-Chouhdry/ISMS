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
    public partial class FormSoftwareReg : Form
    {
        public FormSoftwareReg()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelsr.Controls.Clear();
            f.TopLevel = false;
            this.panelsr.Controls.Add(f);
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
            SqlCommand cmd = new SqlCommand("insert into softr(id,name,py,version,quantity,location) values('" + ids.Text + "','" + names.Text + "','" + pys.Text + "','" + versions.Text + "','" + quantitys.Text + "','" + locations.Text + "')", con);
            if (ids.Text == ""|| names.Text == "" || pys.Text == "" || versions.Text == "" || quantitys.Text == "" || locations.Text == "")
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            ids.Text = "";
            names.Text = ""; pys.Text = ""; versions.Text = ""; quantitys.Text = ""; locations.Text = "";



            con.Close();

        }

        private void panelsr_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(id as int)),0)+1 from softr", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ids.Text = dt.Rows[0][0].ToString();
        }
       
    }
    }
    
