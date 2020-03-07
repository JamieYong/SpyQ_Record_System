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
using System.Collections;

namespace SpyQ_Record_System
{
    public partial class SearchForm : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");
        public SearchForm()
        {
            InitializeComponent();
        }

        
        
        void refresh_RecordTable()
        {

            if (ColumnSelect.Text == "공격")
            {

                for (int i = 3; i < 15; i++)
                {

                    if (i >= 8)
                    {
                        RecordTable.Columns[i].Visible = false;
                    }
                    else
                    {
                        RecordTable.Columns[i].Visible = true;
                    }

                }


            }
            else if (ColumnSelect.Text == "수비")
            {
                for (int i = 3; i < 15; i++)
                {

                    if (i < 8)
                    {
                        RecordTable.Columns[i].Visible = false;
                    }
                    else
                    {
                        RecordTable.Columns[i].Visible = true;
                    }
                }

            }
            else
            {
                for (int i = 0; i <= 15; i++)
                {
                    RecordTable.Columns[i].Visible = true;
                }
            }


        }


        private void TeamCBbox_Click(object sender, EventArgs e)
        {
            
                ArrayList arr = new ArrayList();
                arr.Add("");
                con.Open();
                string query = String.Format("exec Pteamname '{0}', '{1}'", startdate.Text, enddate.Text);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                
                con.Close();
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    arr.Add(row["TeamName"].ToString());
                }




                TeamCBbox.DataSource = arr;
            

        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = String.Format("exec Pselect @PdateA = '{0}' , @PdateB = '{1}' , @Pteam='{2}', @Pplayer ='{3}' ", startdate.Text, enddate.Text, TeamCBbox.Text, PlayerCBbox.Text);



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
           
            da.Fill(ds, "record");

            RecordTable.DataSource = ds;
            RecordTable.DataMember = "record";


            refresh_RecordTable();


            con.Close();

        }

        private void PlayerCBbox_Click(object sender, EventArgs e)
        {

            ArrayList arr = new ArrayList();
            arr.Add("");
            con.Open();

            string query = String.Format("exec Pplayername '{0}'",TeamCBbox.Text);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            con.Close();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                arr.Add(row["PlayerName"].ToString());
            }

            PlayerCBbox.DataSource = arr;




        }

        private void TeamCBbox_SelectedValueChanged(object sender, EventArgs e)
        {

            if(TeamCBbox.Text == "")
            {
                PlayerCBbox.Text = "";
            }

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {


            refresh_RecordTable();



        }
    }
}
 