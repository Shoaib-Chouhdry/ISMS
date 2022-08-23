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
    public partial class FormViewThreat : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        SqlDataAdapter adpt;
       
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM treg", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            Threatgridview.DataSource = dt;
        }

        public FormViewThreat()
        {
            InitializeComponent();
            showdata();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelvt.Controls.Clear();
            f.TopLevel = false;
            this.panelvt.Controls.Add(f);
            f.Show();
        }
     

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormAddthreats());
        }

        private void panelvt_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
