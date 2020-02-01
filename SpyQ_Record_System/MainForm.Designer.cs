namespace SpyQ_Record_System
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListBox LogListBox;
            this.goToSetting = new System.Windows.Forms.Button();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.RecordHolderName = new System.Windows.Forms.Label();
            this.recordHolderLabel = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.Team1Name = new System.Windows.Forms.Label();
            this.Team2Home = new System.Windows.Forms.Label();
            this.Team1Home = new System.Windows.Forms.Label();
            this.Team2Score = new System.Windows.Forms.Label();
            this.Team1Score = new System.Windows.Forms.Label();
            this.UnderPanel = new System.Windows.Forms.Panel();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogPanelScroll = new System.Windows.Forms.VScrollBar();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SetCombo = new System.Windows.Forms.ComboBox();
            this.logInput = new System.Windows.Forms.Label();
            LogListBox = new System.Windows.Forms.ListBox();
            this.ScorePanel.SuspendLayout();
            this.UnderPanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogListBox
            // 
            LogListBox.FormattingEnabled = true;
            LogListBox.ItemHeight = 12;
            LogListBox.Location = new System.Drawing.Point(16, 9);
            LogListBox.Name = "LogListBox";
            LogListBox.Size = new System.Drawing.Size(143, 424);
            LogListBox.TabIndex = 2;
            // 
            // goToSetting
            // 
            this.goToSetting.BackgroundImage = global::SpyQ_Record_System.Properties.Resources.wheel;
            this.goToSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goToSetting.Location = new System.Drawing.Point(12, 12);
            this.goToSetting.Name = "goToSetting";
            this.goToSetting.Size = new System.Drawing.Size(37, 37);
            this.goToSetting.TabIndex = 10;
            this.goToSetting.UseVisualStyleBackColor = true;
            // 
            // scoreTitle
            // 
            this.scoreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreTitle.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(52, 67);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(67, 23);
            this.scoreTitle.TabIndex = 11;
            this.scoreTitle.Text = "Score";
            // 
            // ScorePanel
            // 
            this.ScorePanel.Controls.Add(this.RecordHolderName);
            this.ScorePanel.Controls.Add(this.recordHolderLabel);
            this.ScorePanel.Controls.Add(this.Team2Name);
            this.ScorePanel.Controls.Add(this.Team1Name);
            this.ScorePanel.Controls.Add(this.Team2Home);
            this.ScorePanel.Controls.Add(this.Team1Home);
            this.ScorePanel.Controls.Add(this.Team2Score);
            this.ScorePanel.Controls.Add(this.Team1Score);
            this.ScorePanel.Location = new System.Drawing.Point(45, 93);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(537, 163);
            this.ScorePanel.TabIndex = 12;
            // 
            // RecordHolderName
            // 
            this.RecordHolderName.AutoSize = true;
            this.RecordHolderName.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RecordHolderName.Location = new System.Drawing.Point(8, 32);
            this.RecordHolderName.Name = "RecordHolderName";
            this.RecordHolderName.Size = new System.Drawing.Size(66, 19);
            this.RecordHolderName.TabIndex = 9;
            this.RecordHolderName.Text = "박호열";
            // 
            // recordHolderLabel
            // 
            this.recordHolderLabel.AutoSize = true;
            this.recordHolderLabel.Location = new System.Drawing.Point(22, 14);
            this.recordHolderLabel.Name = "recordHolderLabel";
            this.recordHolderLabel.Size = new System.Drawing.Size(41, 12);
            this.recordHolderLabel.TabIndex = 8;
            this.recordHolderLabel.Text = "기록관";
            this.recordHolderLabel.Click += new System.EventHandler(this.recordHolderLabel_Click);
            // 
            // Team2Name
            // 
            this.Team2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Name.Font = new System.Drawing.Font("굴림", 11F);
            this.Team2Name.Location = new System.Drawing.Point(314, 122);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(85, 18);
            this.Team2Name.TabIndex = 7;
            this.Team2Name.Text = "광주제일고";
            // 
            // Team1Name
            // 
            this.Team1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Name.Font = new System.Drawing.Font("굴림", 11F);
            this.Team1Name.Location = new System.Drawing.Point(147, 122);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(40, 18);
            this.Team1Name.TabIndex = 6;
            this.Team1Name.Text = "GSM";
            // 
            // Team2Home
            // 
            this.Team2Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Home.Font = new System.Drawing.Font("굴림", 11F);
            this.Team2Home.Location = new System.Drawing.Point(334, 23);
            this.Team2Home.Name = "Team2Home";
            this.Team2Home.Size = new System.Drawing.Size(52, 18);
            this.Team2Home.TabIndex = 5;
            this.Team2Home.Text = "Away";
            // 
            // Team1Home
            // 
            this.Team1Home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Home.Font = new System.Drawing.Font("굴림", 11F);
            this.Team1Home.Location = new System.Drawing.Point(147, 23);
            this.Team1Home.Name = "Team1Home";
            this.Team1Home.Size = new System.Drawing.Size(52, 18);
            this.Team1Home.TabIndex = 4;
            this.Team1Home.Text = "Home";
            // 
            // Team2Score
            // 
            this.Team2Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Score.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Score.Location = new System.Drawing.Point(322, 32);
            this.Team2Score.Name = "Team2Score";
            this.Team2Score.Size = new System.Drawing.Size(66, 90);
            this.Team2Score.TabIndex = 3;
            this.Team2Score.Text = "0";
            // 
            // Team1Score
            // 
            this.Team1Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Score.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Score.Location = new System.Drawing.Point(135, 32);
            this.Team1Score.Name = "Team1Score";
            this.Team1Score.Size = new System.Drawing.Size(66, 90);
            this.Team1Score.TabIndex = 2;
            this.Team1Score.Text = "0";
            // 
            // UnderPanel
            // 
            this.UnderPanel.Controls.Add(this.InputBox);
            this.UnderPanel.Location = new System.Drawing.Point(9, 316);
            this.UnderPanel.Name = "UnderPanel";
            this.UnderPanel.Size = new System.Drawing.Size(615, 122);
            this.UnderPanel.TabIndex = 13;
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InputBox.Location = new System.Drawing.Point(12, 13);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(361, 35);
            this.InputBox.TabIndex = 0;
            this.InputBox.Enter += new System.EventHandler(this.InputBox_Enter);
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(LogListBox);
            this.LogPanel.Controls.Add(this.LogPanelScroll);
            this.LogPanel.Location = new System.Drawing.Point(630, 7);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(168, 444);
            this.LogPanel.TabIndex = 14;
            // 
            // LogPanelScroll
            // 
            this.LogPanelScroll.Location = new System.Drawing.Point(241, 12);
            this.LogPanelScroll.Name = "LogPanelScroll";
            this.LogPanelScroll.Size = new System.Drawing.Size(11, 432);
            this.LogPanelScroll.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Date.Location = new System.Drawing.Point(209, 28);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(186, 21);
            this.Date.TabIndex = 15;
            // 
            // SetCombo
            // 
            this.SetCombo.FormattingEnabled = true;
            this.SetCombo.Items.AddRange(new object[] {
            "1세트",
            "2세트",
            "3세트",
            "4세트",
            "5세트"});
            this.SetCombo.Location = new System.Drawing.Point(407, 29);
            this.SetCombo.Name = "SetCombo";
            this.SetCombo.Size = new System.Drawing.Size(116, 20);
            this.SetCombo.TabIndex = 16;
            this.SetCombo.Tag = "";
            // 
            // logInput
            // 
            this.logInput.AutoSize = true;
            this.logInput.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logInput.Location = new System.Drawing.Point(41, 292);
            this.logInput.Name = "logInput";
            this.logInput.Size = new System.Drawing.Size(52, 21);
            this.logInput.TabIndex = 18;
            this.logInput.Text = "입력";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logInput);
            this.Controls.Add(this.SetCombo);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.UnderPanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.scoreTitle);
            this.Controls.Add(this.goToSetting);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.UnderPanel.ResumeLayout(false);
            this.UnderPanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToSetting;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label RecordHolderName;
        private System.Windows.Forms.Label recordHolderLabel;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label Team1Name;
        private System.Windows.Forms.Label Team2Home;
        private System.Windows.Forms.Label Team1Home;
        private System.Windows.Forms.Label Team2Score;
        private System.Windows.Forms.Label Team1Score;
        private System.Windows.Forms.Panel UnderPanel;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.VScrollBar LogPanelScroll;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox SetCombo;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label logInput;
    }
}

