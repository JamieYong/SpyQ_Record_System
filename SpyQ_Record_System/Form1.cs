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

            /*
            String[] str = {"모두" };

            con.Open();
            SqlCommand com = new SqlCommand();
            string startdate = StartYear.Text + "-" + StartMonth.Text + "-" + StartDay.Text;
            string enddate = EndYear.Text + "-" + EndMonth.Text + "-" + EndDay.Text;
            string Tselect = "Select distinct TeamA,TeamB from dbo.game_data where GameDate between ' " + startdate + "' AND '" + enddate + "'";
            com.CommandText = Tselect;
            SqlDataReader sr = com.ExecuteReader();

            while (sr.Read())
            {
                
                string s = sr["TeamA"] as string;
                str.Append(s);
                s = sr["TeamB"] as string;
                str.Append(s);

            }

            TeamCBbox.Items.AddRange(str);
            TeamCBbox.SelectedIndex = 0;

            sr.Close();
            con.Close();
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
 