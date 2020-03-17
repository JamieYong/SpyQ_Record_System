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
        private int team1Sco = 0;
        private int team2Sco = 0;
        private int team1Set = 0;
        private int team2Set = 0;
        int[] attackValue = { 0, 0, 0, 0, 0 };
        int[] defenseValue = { 0, 0, 0, 0, 0, 0, 0 };
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
            if (MessageBox.Show("정말로 세트를 넘기시겠습니까?", "경고", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            else
            {
                Random r = new Random(); //gamecode
                bool check = true;
                if (this.team1Sco > this.team2Sco)
                {
                    team1Set++;
                    ASetScore.Text = team1Set.ToString();
                }
                else if (this.team1Sco < this.team2Sco)
                {
                    team2Set++;
                    BSetScore.Text = team2Set.ToString();
                }
                else check = false;

                if (check)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.Connection = con;
                    sqlComm.CommandText = "insert into game_data (GameCode,TeamA,TeamB,ScoreA,ScoreB,SetNum,GameDate) values(@GameCode,@TeamA,@TeamB,@ScoreA,@ScoreB,@SetNum,@GameDate)";
                    sqlComm.Parameters.AddWithValue("@Gamecode", r.Next(1000, 100000));
                    sqlComm.Parameters.AddWithValue("@TeamA", Team1Name.Text);
                    sqlComm.Parameters.AddWithValue("@TeamB", Team2Name.Text);
                    sqlComm.Parameters.AddWithValue("@ScoreA", this.team1Sco);
                    sqlComm.Parameters.AddWithValue("@ScoreB", this.team2Sco);
                    sqlComm.Parameters.AddWithValue("@SetNum", team1Set + team2Set);
                    sqlComm.Parameters.AddWithValue("@GameDate", DateTime.Now);

                    /*
                    파라미터 사용 굳
                    */

                    con.Open();
                    sqlComm.ExecuteNonQuery();
                    con.Close();

                    this.team1Sco = 0;
                    this.team2Sco = 0;
                    Team1Score.Text = this.team1Sco.ToString();
                    Team2Score.Text = this.team2Sco.ToString();
                }
            }

        }
        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            string[] keySet = { "at", "as", "af", "st", "ss", "ft", "fs", "ff", "dt", "ds", "bt", "bs" };
            // └얘를 배열로 이렇게 선언하지말고 설정하는 공간에서 받아오는게 좋을텐데.... 처음하면 그 부분이 힘들수도 있겠구만

            if (e.KeyCode == Keys.Enter)
            {

                if (inputBox != null && !string.IsNullOrWhiteSpace(inputBox.Text))
                {
                    string[] input = inputBox.Text.Split(' ');
                    if (input.Length != 2)
                    {
                        MessageBox.Show("키를 다시 입력하여 주십시오1");
                    }
                    else
                    {
                        try
                        {
                            int playerNum = Convert.ToInt32(input[1]);
                            if (input[0] == "at") attackValue[0]++;
                            else if (input[0] == "as")
                            {
                                attackValue[1]++;
                                this.team1Sco++;
                                Team1Score.Text = team1Sco.ToString();
                            }
                            else if (input[0] == "af") attackValue[2]++;
                            else if (input[0] == "st") attackValue[3]++;
                            else if (input[0] == "ss") attackValue[4]++;
                            else if (input[0] == "ft") defenseValue[0]++;
                            else if (input[0] == "fs") defenseValue[1]++;
                            else if (input[0] == "ff")
                            {
                                defenseValue[2]++;
                                this.team2Sco++;
                                Team2Score.Text = team2Sco.ToString();
                            }
                            else if (input[0] == "dt") defenseValue[3]++;
                            else if (input[0] == "ds") defenseValue[4]++;
                            else if (input[0] == "bt") defenseValue[5]++;
                            else if (input[0] == "bs")
                            {
                                defenseValue[6]++;
                                this.team1Sco++;
                                Team1Score.Text = team1Sco.ToString();
                            }
                            else MessageBox.Show("단축키를 잘못 입력했습니다.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            MessageBox.Show("키를 다시 입력해주십시오.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("아무것도 입력되지 않았습니다. 다시 입력하여 주십시오.");
                }
                inputBox.Text = string.Empty;
            }
        }
        private void sqlAttackData(int[] attackData)
        {

        }
        private void sqlDefenseData(int[] defenseData)
        {

        }
    }
}






// + 세트 바꾸기-combobox-누르면 확인창 후 db로 전송,설정창으로 이동하는거, 휴지통 등
