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
    public partial class FormViewAssignPolicy : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

        
        SqlDataAdapter adpt;
        
        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM policyassign", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            gridap.DataSource = dt;
        }
        public FormViewAssignPolicy()
        {
            InitializeComponent();
            showdata();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FormViewPolicies()); 
        }
    }
}
