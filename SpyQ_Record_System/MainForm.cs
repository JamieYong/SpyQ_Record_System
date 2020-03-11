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

namespace SpyQRecordSystem
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
                

        private void inputBox_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(inputBox.Text == null)
                {
                    MessageBox.Show("아무것도 입력되지 않았습니다.");
                    return;
                }
                else
                {
                    bool can_in;
                    string text = inputBox.Text;
                    if(text.Length == 4)
                    {
                        if ((text[0] >= 80 && text[0] <= 89) && (text[1] >= 80 && text[1] <= 89))
                        {
                            if (text[2] == 'd' || text[2] == 'a' || text[2] == 's' || text[2] == 'm' || text[2] == 'r' || text[2] == 'b')
                            {

                            }
                        }
                    }
                    else
                    {
                        can_in = false;
                    }
                }
            }
        }
        int set = 1;
        private void SetchangeBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=recordproject;Integrated Security=True");

            con.Open();
            Console.WriteLine("DB연결");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO game_data"); // 쿼리문 작성
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
    
}



// + 세트 바꾸기-combobox-누르면 확인창 후 db로 전송,설정창으로 이동하는거, 휴지통 등
