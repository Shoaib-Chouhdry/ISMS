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
    public partial class FormViewPolicies : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=ZOHAIB\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");

     
        SqlDataAdapter adpt;

        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT* FROM policies", conn);
            DataTable dt = new DataTable();

            adpt.Fill(dt);
            gridpolicy.DataSource = dt;
        }
        public FormViewPolicies()
        {
            InitializeComponent();
            showdata();
        }

        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelpo.Controls.Clear();
            f.TopLevel = false;
            this.panelpo.Controls.Add(f);
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Add Policies")) policies();
            if (comboBox1.Text.Equals("Assign Policies")) Assign();
            if (comboBox1.Text.Equals("View Assign Policies")) View();
        }
        void policies()
        {
            loadform(new policies_reg());
        }
        void Assign()
        {
            loadform(new FormAssignPolicies());
        }
        void View()
        {
            loadform(new FormViewAssignPolicy());
        }

        private void panelpo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
