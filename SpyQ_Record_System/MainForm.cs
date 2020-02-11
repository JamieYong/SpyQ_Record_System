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

        private void SetCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void goToSetting_Click(object sender, EventArgs e)
        {
            Setting setForm = new Setting();
            setForm.Show();
        }

        //int playerNum;
        //String firstKey;
        //String result;
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        //{
            
        //    if (firstKey == null)
        //    {
        //                if (keyData == (Keys.D))
        //                {
        //                    firstKey = "d";
        //                }
        //                else if (keyData == (Keys.A))
        //                {
        //                    firstKey = "a";
        //                }
        //                else if (keyData == (Keys.M))
        //                {
        //                    firstKey = "m";
        //                }
        //                else if (keyData == (Keys.S))
        //                {
        //                    firstKey = "s";
        //                }
        //                else if (keyData == (Keys.R))
        //                {
        //                    firstKey = "r";
        //                }
        //                else if (keyData == (Keys.B))
        //                {
        //                    firstKey = "b";
        //                }
        //                else
        //                {
        //                    MessageBox.Show("지정되지 않은 단축키입니다.");
        //                }
        //                return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //    else if (firstKey == "m")
        //    {
        //                if (keyData == Keys.S)
        //                {
        //                    result = "범실";
        //                    MessageBox.Show(firstKey + result);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("지정되지 않은 단축키입니다.");
        //                }
        //                firstKey = null;
        //                return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //    else
        //    {
        //                if (keyData == Keys.T)
        //                {
        //                    result = "시도";
        //                    MessageBox.Show(firstKey + result);
        //                }
        //                else if (keyData == Keys.S)
        //                {
        //                    result = "성공";
        //                    MessageBox.Show(firstKey + result);
        //                }
        //                else
        //                {
        //                    MessageBox.Show("지정되지 않은 단축키입니다.");
        //                }
                
        //                firstKey = null;
        //                return base.ProcessCmdKey(ref msg, keyData);
        //    }
        //}


        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
 
        private void InputBox_pressEnter() {
            string data = InputBox.Text;
            int num = Convert.ToInt32(data.Substring(0, 2));
            MessageBox.Show(Convert.ToString(num.GetType()));
        }

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                InputBox_pressEnter();
            }
        }

    }

}



// + 세트 바꾸기-combobox-누르면 확인창 후 db로 전송,설정창으로 이동하는거, 휴지통 등