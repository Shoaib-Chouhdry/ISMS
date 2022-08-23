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
    public partial class FormViewVulnerabilities : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        
        SqlDataAdapter adpt;
       
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM regv", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            Vulnergridview.DataSource = dt;
        }
        public FormViewVulnerabilities()
        {
            InitializeComponent();
            showdata();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelvv.Controls.Clear();
            f.TopLevel = false;
            this.panelvv.Controls.Add(f);
            f.Show();
        }

     

   

        private void button3_Click(object sender, EventArgs e)
        {
            loadform(new FormRegisterVulnerabilities());
        }

       
    }
}
