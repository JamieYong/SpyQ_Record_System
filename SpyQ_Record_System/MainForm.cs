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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static string recordHolder;
        public static string oppTeam;
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RecordHolderName.Text = recordHolder;
            this.Team2Name.Text = oppTeam;
        }

        private void goToSetting_Click(object sender, EventArgs e)
        {
           MessageBox.Show("hello C#");
        }
                

        private void SetchangeBtn_Click(object sender, EventArgs e)
        {
            // insert 변수 선언
            string teamA = Team1Name.Text;
            string teamB = Team2Name.Text;
            int scoreA = int.Parse(Team1Score.Text);
            int scoreB = int.Parse(Team2Score.Text);
            int setNum = int.Parse(ASetScore.Text)+ int.Parse(BSetScore.Text);
            
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = con;
            sqlComm.CommandText = "insert into game_data (GameCode,TeamA,TeamB,ScoreA,ScoreB,SetNum,GameDate) values(@GameCode,@TeamA,@TeamB,@ScoreA,@ScoreB,@SetNum,@GameDate)";
            sqlComm.Parameters.AddWithValue("@Gamecode", "00000000000");
            sqlComm.Parameters.AddWithValue("@TeamA", teamA);
            sqlComm.Parameters.AddWithValue("@TeamB", teamB);
            sqlComm.Parameters.AddWithValue("@ScoreA", scoreA);
            sqlComm.Parameters.AddWithValue("@ScoreB", scoreB);
            sqlComm.Parameters.AddWithValue("@SetNum", setNum);
            sqlComm.Parameters.AddWithValue("@GameDate", DateTime.Now);
            con.Open();
            sqlComm.ExecuteNonQuery();
            con.Close();
        }
        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {

            string[] keySet = { "dt", "dt", "at", "as","am","ms","st","ss","rt","rs","bt","bs" };
            bool check;
            if (e.KeyCode == Keys.Enter)
            {
                
                if (inputBox != null && !string.IsNullOrWhiteSpace(inputBox.Text))
                {
                    string[] input = inputBox.Text.Split(' ');
                    if (input.Length > 2)
                    {
                        MessageBox.Show("키를 다시 입력하여 주십시오");
                    }
                    else
                    {
                        if (input[0] is string)
                        {
                            foreach (var k in keySet)
                            {
                                if (input[0] == k)
                                {
                                    check = true;
                                }
                                else
                                {
                                    check = false;
                                }
                            }
                        }
                        else
                        {
                           MessageBox.Show("키를 다시 입력하여 주십시오");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("아무것도 입력되지 않았습니다. 다시 입력하여 주십시오.");
                }
            }
        }
      
    }
    
}



// + 세트 바꾸기-combobox-누르면 확인창 후 db로 전송,설정창으로 이동하는거, 휴지통 등


