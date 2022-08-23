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
    public partial class FormRAssesment : Form
    {
        public FormRAssesment()
        {
            InitializeComponent();
            vcombobox();
            tcombobox();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ID as int)),0)+1 from Ra", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Ra(ID,AssetId,AssetName,Vulnerabilities,Threat,C,I,A,Max,Impact,Probability,RiskValue,Category) values('" + id.Text + "','" + aid.Text + "','" + aname.Text + "','" + vr.Text + "','" + tr.Text + "','" + conf.Text + "','" + intg.Text + "','" + avai.Text + "','" + maxi.Text + "','" + imp.Text + "','" + pro.Text + "','" + risk.Text + "','" + catg.Text + "')", con);
           
              if ( id.Text ==""||  aid.Text == "" || aname.Text == "" || vr.Text == "" || tr.Text == "" || conf.Text == "" || intg.Text == "" || avai.Text == "" || maxi.Text == "" || imp.Text == "" || pro.Text == "" || risk.Text == "" || catg.Text == "" )
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            id.Text = ""; aid.Text = ""; aname.Text = ""; vr.Text = ""; tr.Text = ""; conf.Text = ""; intg.Text = ""; avai.Text = ""; maxi.Text = ""; imp.Text = ""; pro.Text = ""; risk.Text = ""; catg.Text = "";



            con.Close();


        }

       
        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void conf_TextChanged(object sender, EventArgs e)
        {

        }

        private void vc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (aid.SelectedItem.ToString() != null)
            {
                string id = aid.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                string query = "select * from regv where ID=@ID";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ID", id);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    aid.Text = data.Rows[0]["AssetId"].ToString();
                    aname.Text = data.Rows[0]["AssetName"].ToString();
                    vr.Text = data.Rows[0]["Vulnerabilities"].ToString();
                    
                }
         
            }
        }
        void vcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            string query = "select * from regv";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                aid.Items.Add(dr.GetString("ID"));

            }
            con.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcombo.SelectedItem.ToString() != null)
            {
                string id = tcombo.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                string query = "select * from treg where ID=@id";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                   
                    tr.Text = data.Rows[0]["Name"].ToString();
                  

                }

            }

        }
        void tcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            string query = "select * from treg";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                tcombo.Items.Add(dr.GetString("ID"));

            }
            con.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("RA View")) RA();
        }
        void RA()
        {
            loadform(new FormViewRiskAssesment());
        }

       

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(maxi.Text);
            int b = Convert.ToInt32(imp.Text);
            int c = Convert.ToInt32(pro.Text);
            int d = a * b * c;
            risk.Text = "" + d;
            int f = Convert.ToInt32(risk.Text);
            if(f>27)
            {
                catg.Text = "High";
            }
            else if(f==27 || f>8)
                {
                catg.Text = "Medium";
            }
            else
             {
                catg.Text = "Low";
            }
        }
    }
}
