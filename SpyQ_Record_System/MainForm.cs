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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Console.WriteLine("변웅섭 멍청이");
            InitializeComponent();
        }

        private void GoSettingButton_Click(object sender, EventArgs e)
        {
            SettingForm SF = new SettingForm();
            SF.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
