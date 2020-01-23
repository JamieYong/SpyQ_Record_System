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
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");
        public Form1()
        {
            Console.WriteLine("Hello windowforms");
            InitializeComponent();
        }




        private void TeamCBbox_Click(object sender, EventArgs e)
        {
            
                ArrayList arr = new ArrayList();
                arr.Add("");
                con.Open();
                string query = "exec Pteamname '" + startdate.Text + "','" + enddate.Text + "';";
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


     
            string query = " exec Pselect @PdateA = '" + startdate.Text + "' , @PdateB = '" + enddate.Text + "' , @Pteam = ' " + TeamCBbox.Text + "', @Pplayer = '" + PlayerCBbox.Text + "';";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "record");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "record";

            con.Close();

        }



    }
}
 