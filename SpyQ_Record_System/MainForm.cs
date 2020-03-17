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
        int[] attackValue = { 0, 0, 0, 0, 0, 0 };
        int[] defenseValue = { 0, 0, 0, 0, 0, 0, 0 };
        Dictionary<int, string> logList = new Dictionary<int, string>();  //이걸 딕셔너리로 하면 중복 생긴단 말이지..... 흠 진짜 어떡하지
        Dictionary<string, string> keyList = new Dictionary<string, string>()
            {
                {"at","공격 시도"},
                {"as","공격 성공" },
                {"af","공격 범실" },
                {"st","서브 시도" },
                {"ss","서브에이스" },
            { "sf","서브 범실"},
                {"ft","수비 시도" },
                {"fs","수비 성공" },
                {"ff","수비 범실" },
                {"dt","디그 시도" },
                {"ds","디그 성공" },
                {"bt","블로킹 시도" },
                {"bs","블로킹 성공" }
            };

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
                Random r = new Random();
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

                //gamecode
                int setScore = team1Set + team2Set;
                string date = string.Format("{0:d}", DateTime.Now);
                string gamecode;
                foreach (var i in date)
                {
                    if (i is int
                        )
                    {
                        //gamecode 어떻게 만드는 걸까.......
                    }
                }
                gamecode = DateTime.Now.ToString("yyyymmdd") + r.Next(100, 999).ToString() + setScore.ToString();
                MessageBox.Show(gamecode);

                if (check)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");
                    SqlCommand sqlComm = new SqlCommand();
                    sqlComm.Connection = con;
                    sqlComm.CommandText = "insert into game_data (GameCode,TeamA,TeamB,ScoreA,ScoreB,SetNum,GameDate) values(@GameCode,@TeamA,@TeamB,@ScoreA,@ScoreB,@SetNum,@GameDate)";
                    sqlComm.Parameters.AddWithValue("@Gamecode", gamecode);
                    sqlComm.Parameters.AddWithValue("@TeamA", Team1Name.Text);
                    sqlComm.Parameters.AddWithValue("@TeamB", Team2Name.Text);
                    sqlComm.Parameters.AddWithValue("@ScoreA", this.team1Sco);
                    sqlComm.Parameters.AddWithValue("@ScoreB", this.team2Sco);
                    sqlComm.Parameters.AddWithValue("@SetNum", setScore);
                    sqlComm.Parameters.AddWithValue("@GameDate", DateTime.Now);
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

            bool check = true;

            if (e.KeyCode == Keys.Enter)
            {

                if (inputBox != null && !string.IsNullOrWhiteSpace(inputBox.Text))
                {
                    string[] input = inputBox.Text.Split(' ');
                    if (input.Length != 2)
                    {
                        MessageBox.Show("키를 다시 입력하여 주십시오1");
                        foreach (var i in input)
                        {
                            MessageBox.Show(i);
                        }
                    }
                    else
                    {
                        try
                        {
                            int playerNum = Convert.ToInt32(input[1]);
                            if (input[0] == "at")
                                attackValue[0]++;    //공격 시도
                            else if (input[0] == "as")      //공격 성공
                            {
                                attackValue[1]++;
                                this.team1Sco++;
                                Team1Score.Text = team1Sco.ToString();
                            }
                            else if (input[0] == "af")   //공격 실패
                            {
                                attackValue[2]++;
                                this.team2Sco++;
                                Team2Score.Text = team2Sco.ToString();
                            }
                            else if (input[0] == "st")
                                attackValue[3]++;    // 서브 시도
                            else if (input[0] == "ss")   // 서브 성공
                            {
                                attackValue[4]++;
                                this.team1Sco++;
                                Team1Score.Text = team1Sco.ToString();
                            }
                            else if (input[0] == "sf") //서브 실패
                            {
                                attackValue[5]++;
                                this.team2Sco++;
                                Team2Score.Text = team2Sco.ToString();
                            }
                            else if (input[0] == "ft")
                                defenseValue[0]++;  // 수비 시도
                            else if (input[0] == "fs")
                                defenseValue[1]++; // 수비 성공
                            else if (input[0] == "ff")    // 수비 실패
                            {
                                defenseValue[2]++;
                                this.team2Sco++;
                                Team2Score.Text = team2Sco.ToString();
                            }
                            else if (input[0] == "dt") defenseValue[3]++;  //디그 시도
                            else if (input[0] == "ds") defenseValue[4]++; //디그 성공
                            else if (input[0] == "bt") defenseValue[5]++;  // 블로킹 시도
                            else if (input[0] == "bs")  //블로킹 성공
                            {
                                defenseValue[6]++;
                                this.team1Sco++;
                                Team1Score.Text = team1Sco.ToString();
                            }
                            else
                            {
                                check = false;
                                MessageBox.Show("단축키를 잘못 입력했습니다.");
                            }
                            if (check == true)
                            {
                                logList.Add(playerNum, input[0]); //딕셔너리로 사용하면 중복이 생겨버리는데... 어떡하지
                                LogBox.Items.Add(playerNum.ToString() + "번 " + keyList[input[0]]);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
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
