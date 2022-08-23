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
    public partial class FormViewComplaints : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        SqlDataAdapter adpt;
        
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM creg", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            gridviewc.DataSource = dt;
        }
        public FormViewComplaints()
        {
            InitializeComponent();
            showdata();
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FormRegisterComplaints());
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelcv.Controls.Clear();
            f.TopLevel = false;
            this.panelcv.Controls.Add(f);
            f.Show();
        }

        private void gridviewc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id.Text = gridviewc.SelectedRows[0].Cells[0].Value.ToString();
            stat.Text = gridviewc.SelectedRows[0].Cells[6].Value.ToString();
            tech.Text = gridviewc.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          
                SqlConnection conn = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                string query = "update creg set  ID=@id,Status=@status,TechnicianComments=@Techniciancomments where ID=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@status", stat.Text);
                cmd.Parameters.AddWithValue("@Techniciancomments", tech.Text);
                conn.Open();
                int a = cmd.ExecuteNonQuery();
                if (a != 0)
                {

                    MessageBox.Show("Successfully Data updated");

                }
                else
                {
                    MessageBox.Show("error");

                }
                conn.Close();
            }
        
    }
}
