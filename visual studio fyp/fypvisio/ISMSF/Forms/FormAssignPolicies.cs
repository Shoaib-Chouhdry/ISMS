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
    public partial class FormAssignPolicies : Form
    {
        public FormAssignPolicies()
        {
            InitializeComponent();
          
            policycombobox();
            rcombobox();
        }

        public void loadform(object Form)
        {
            Form f = Form as Form;
            this.panelpa.Controls.Clear();
            f.TopLevel = false;
            this.panelpa.Controls.Add(f);
            f.Show();
        }

       



        void policycombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            string query = "select * from policies";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                cn.Items.Add(dr.GetString("Num"));

            }
            con.Close();


        }

        private void combop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cn.SelectedItem.ToString() != null)
            {
                string Num = cn.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                string query = "select * from policies where Num=@Num";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Num", Num);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    cn.Text = data.Rows[0]["Num"].ToString();
                    title.Text = data.Rows[0]["Title"].ToString();
                    obj.Text = data.Rows[0]["Obj"].ToString();
                    poli.Text = data.Rows[0]["Policy"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into policyassign(Pid,AssetId,Name,Vulnerability,Threat,C,I,A,Max,Impact,Probability,RiskValue,Category,ClauseNO,Title,Objective,Policy)values('" + id.Text + "','" + aid.Text + "','" + aname.Text + "','" + vv.Text + "','" + tr.Text + "','" + c.Text + "','" + i.Text + "','" + a.Text + "','" + max.Text + "','" + imp.Text + "','" + pro.Text + "','" + risk.Text + "','" + cat.Text + "','" + cn.Text + "','" + title.Text + "','" + obj.Text + "','" + poli.Text + "')", con);
            
            if (id.Text == ""||  aid.Text == "" || aname.Text == "" || vv.Text == "" || tr.Text == "" || c.Text == "" || i.Text == "" || a.Text == "" || max.Text == "" || imp.Text == "" || pro.Text == "" || risk.Text == "" || cat.Text == "" || cn.Text == "" || title.Text == "" || obj.Text == "" || poli.Text == "")
            {
                MessageBox.Show("Fill all the textboxes");
                return;
            }
            else
            {
                MessageBox.Show("Data added successfully");
            }
            cmd.ExecuteNonQuery();
            id.Text = ""; aid.Text = ""; aname.Text = ""; vv.Text = ""; tr.Text = ""; c.Text = ""; i.Text = ""; a.Text = ""; max.Text = ""; imp.Text = ""; pro.Text = ""; risk.Text = ""; cat.Text = ""; cn.Text = ""; title.Text = "";  obj.Text = ""; poli.Text = "";


            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadform(new FormViewPolicies());
        }
        void rcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            string query = "select * from Ra";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                combor.Items.Add(dr.GetString("ID"));

            }
            con.Close();


        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combor.SelectedItem.ToString() != null)
            {
                string id = combor.SelectedItem.ToString();
                SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
                string query = "select * from Ra where ID=@id";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@id", id);
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    aid.Text = data.Rows[0]["AssetId"].ToString();
                    aname.Text = data.Rows[0]["AssetName"].ToString();
                    vv.Text = data.Rows[0]["Vulnerabilities"].ToString();
                    tr.Text = data.Rows[0]["Threat"].ToString();
                    c.Text = data.Rows[0]["C"].ToString();
                    i.Text = data.Rows[0]["I"].ToString();
                    a.Text = data.Rows[0]["A"].ToString();
                    max.Text = data.Rows[0]["Max"].ToString();
                    imp.Text = data.Rows[0]["Impact"].ToString();
                    pro.Text = data.Rows[0]["Probability"].ToString();
                    risk.Text = data.Rows[0]["RiskValue"].ToString();
                    cat.Text = data.Rows[0]["Category"].ToString();

                }
            }
        }

        private void panelpa_Paint(object sender, PaintEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ZOHAIB\\SQLEXPRESS;Initial Catalog=fyplast;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(Pid as int)),0)+1 from policyassign", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id.Text = dt.Rows[0][0].ToString();
        }
       
    }
   
       
    }
  
