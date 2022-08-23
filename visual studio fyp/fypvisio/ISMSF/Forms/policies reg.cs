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

namespace ISMSF
{
    public partial class policies_reg : Form
    {
        public policies_reg()
        {
            InitializeComponent();
        }
       




        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into policies(Pid,Num,Title,Obj,Policy) values('" + pid.Text + "','" + textclause.Text + "','" + textdo.Text + "','" + textobj.Text + "','" + policytxt.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {

                MessageBox.Show("Successfully Data Added");
                this.Hide();


            }
            else
            {
                MessageBox.Show("error");

            }
            con.Close();

        }

        private void panelp_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Pid as int)),0)+1 from policies", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            pid.Text = dt.Rows[0][0].ToString();
        }
    }
}
