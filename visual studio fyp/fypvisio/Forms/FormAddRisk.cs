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
    public partial class FormAddRisk : Form
    {
        public FormAddRisk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BI3HV03;Initial Catalog=FypDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into addr(id,name,impact) values('" + idr.Text + "','" + namer.Text + "','" + impactr.Text + "')", con);
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

    }
}

