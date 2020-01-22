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
            
            /*string startdate = StartYear.Text + "-" + StartMonth.Text + "-" + StartDay.Text;
            string enddate = EndYear.Text + "-" + EndMonth.Text + "-" + EndDay.Text;
            
            con.Open();
            string query = "exec Pteamname " + startdate + "," + enddate + ";";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            da.Fill(data);

            TeamCBbox.DataSource = data;
*/
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            con.Open();


            string startdate = StartYear.Text + "-" + StartMonth.Text + "-" + StartDay.Text;
            string enddate = EndYear.Text + "-" + EndMonth.Text + "-" + EndDay.Text;

            string query = " exec Pselect @PdateA = '" + startdate + "' , @PdateB = '" + enddate + "' , @Pteam = ' " + TeamCBbox.Text + "', @Pplayer = '" + PlayerCBbox.Text + "';";

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
 