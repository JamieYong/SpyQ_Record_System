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
    public partial class GameSetForm : Form
    {
        public GameSetForm()
        {
            InitializeComponent();
        }

        

        private void StartBotton_Click(object sender, EventArgs e)
        {

            if (oppTeamBox.Text.Length == 0 || WriterBox.Text.Length == 0)
            {
                MessageBox.Show("상대팀이름과 기록관을 입력해주세요.");
                return;
            }
            else
            {
                this.Hide();
                MainForm mainform = new MainForm();
                MainForm.oppTeam = oppTeamBox.Text;
                MainForm.recordHolder = WriterBox.Text;
                mainform.ShowDialog();
                this.Close();
            }
            
        }
    }
}
