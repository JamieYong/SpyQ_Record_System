using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpyQ_Record_System
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            //기록관 저장
            WriterTextBox.Text = Properties.Settings.Default.Writer;

            //공격 기록
            AttackAccTextBox.Text = Properties.Settings.Default.AttackAcc;
            AttackCntTextBox.Text = Properties.Settings.Default.AttackCnt;
            AttackMissTextBox.Text = Properties.Settings.Default.AttackMiss;

            //서브 기록
            ServeAccTextbox.Text = Properties.Settings.Default.ServeAcc;
            ServeCntTextBox.Text = Properties.Settings.Default.ServeCnt;
            ServeMissTextBox.Text = Properties.Settings.Default.ServeMiss;

            //디그 기록
            DigAccTextBox.Text = Properties.Settings.Default.Dig;
            DigCntTextBox.Text = Properties.Settings.Default.DigCnt;

            //블로킹 기록
            BlockAccTextBox.Text = Properties.Settings.Default.BlockAcc;
            BlockCntTextBox.Text = Properties.Settings.Default.BlockCnt;

            //수비 기록
            ReceiveAccTextBox.Text = Properties.Settings.Default.ReceiveAcc;
            ReceiveCntTextBox.Text = Properties.Settings.Default.ReceiveCnt;
            DefenseMissTextBox.Text = Properties.Settings.Default.DefenseMiss;


        }

        private void SettingExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //기록관 저장
            Properties.Settings.Default.Writer = WriterTextBox.Text;

            //공격 기록
            Properties.Settings.Default.AttackAcc = AttackAccTextBox.Text;
            Properties.Settings.Default.AttackCnt = AttackCntTextBox.Text;
            Properties.Settings.Default.AttackMiss = AttackMissTextBox.Text;

            //서브 기록
            Properties.Settings.Default.ServeAcc = ServeAccTextbox.Text;
            Properties.Settings.Default.ServeCnt = ServeCntTextBox.Text;
            Properties.Settings.Default.ServeMiss = ServeMissTextBox.Text;

            //디그 기록
            Properties.Settings.Default.Dig = DigAccTextBox.Text;
            Properties.Settings.Default.DigCnt = DigCntTextBox.Text;

            //블로킹 기록
            Properties.Settings.Default.BlockAcc = BlockAccTextBox.Text;
            Properties.Settings.Default.BlockCnt = BlockCntTextBox.Text;

            //수비 기록
            Properties.Settings.Default.ReceiveAcc = ReceiveAccTextBox.Text;
            Properties.Settings.Default.ReceiveCnt = ReceiveCntTextBox.Text;
            Properties.Settings.Default.DefenseMiss = DefenseMissTextBox.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("저장되었습니다.","저장 성공");
        }
    }
}
