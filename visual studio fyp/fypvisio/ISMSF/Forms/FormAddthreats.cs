using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ISMSF.Forms
{
    public partial class FormAddthreats : Form
    {
        public FormAddthreats()
        {
            InitializeComponent();
            
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.paneltr.Controls.Clear();
            f.TopLevel = false;
            this.paneltr.Controls.Add(f);
            f.Show();
        }
      
       

        

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into treg(ID,Name,Impact) values('" + id.Text + "','" + name.Text + "','" + impact.Text + "')", con);
            if (id.Text == ""|| name.Text == ""|| impact.Text=="")
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            id.Text = ""; name.Text = ""; impact.Text = "";



            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("View Threat")) threat();
        }
        void threat()
        {
            loadform(new FormViewThreat());
        }

        private void paneltr_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)),0)+1 from treg", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
        }
     
    }
        }
    

