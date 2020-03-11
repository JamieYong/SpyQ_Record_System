namespace SpyQRecordSystem
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListBox LogListBox;
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.scoreTitle = new System.Windows.Forms.Label();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogPanelScroll = new System.Windows.Forms.VScrollBar();
            this.UnderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.ScorePanel = new System.Windows.Forms.Panel();
            this.RecordHolderName = new System.Windows.Forms.Label();
            this.recordHolderLabel = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.Team1Name = new System.Windows.Forms.Label();
            this.Team2Home = new System.Windows.Forms.Label();
            this.Team1Home = new System.Windows.Forms.Label();
            this.Team2Score = new System.Windows.Forms.Label();
            this.Team1Score = new System.Windows.Forms.Label();
            this.goToSetting = new System.Windows.Forms.Button();
            this.SetchangeBtn = new System.Windows.Forms.Button();
            LogListBox = new System.Windows.Forms.ListBox();
            this.LogPanel.SuspendLayout();
            this.UnderPanel.SuspendLayout();
            this.ScorePanel.SuspendLayout();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Date.Location = new System.Drawing.Point(236, 27);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(184, 21);
            this.Date.TabIndex = 1;
            // 
            // scoreTitle
            // 
            this.scoreTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scoreTitle.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitle.Location = new System.Drawing.Point(82, 60);
            this.scoreTitle.Name = "scoreTitle";
            this.scoreTitle.Size = new System.Drawing.Size(67, 23);
            this.scoreTitle.TabIndex = 0;
            this.scoreTitle.Text = "Score";
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(LogListBox);
            this.LogPanel.Controls.Add(this.LogPanelScroll);
            this.LogPanel.Location = new System.Drawing.Point(629, 3);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(168, 444);
            this.LogPanel.TabIndex = 6;
            // 
            // LogPanelScroll
            // 
            this.LogPanelScroll.Location = new System.Drawing.Point(241, 12);
            this.LogPanelScroll.Name = "LogPanelScroll";
            this.LogPanelScroll.Size = new System.Drawing.Size(11, 432);
            this.LogPanelScroll.TabIndex = 1;
            // 
            // UnderPanel
            // 
            this.UnderPanel.Controls.Add(this.label1);
            this.UnderPanel.Controls.Add(this.SetchangeBtn);
            this.UnderPanel.Controls.Add(this.inputBox);
            this.UnderPanel.Location = new System.Drawing.Point(8, 316);
            this.UnderPanel.Name = "UnderPanel";
            this.UnderPanel.Size = new System.Drawing.Size(615, 122);
            this.UnderPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력 :";
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputBox.Location = new System.Drawing.Point(91, 26);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(198, 33);
            this.inputBox.TabIndex = 0;
            this.inputBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.inputBox_KeyDown);
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
            this.ScorePanel.Location = new System.Drawing.Point(75, 86);
            this.ScorePanel.Name = "ScorePanel";
            this.ScorePanel.Size = new System.Drawing.Size(537, 163);
            this.ScorePanel.TabIndex = 8;
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
            // 
            // Team2Name
            // 
            this.Team2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Name.Font = new System.Drawing.Font("굴림", 11F);
            this.Team2Name.Location = new System.Drawing.Point(293, 122);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(127, 18);
            this.Team2Name.TabIndex = 7;
            this.Team2Name.Text = "광주제일고";
            this.Team2Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Team1Name
            // 
            this.Team1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Name.Font = new System.Drawing.Font("굴림", 11F);
            this.Team1Name.Location = new System.Drawing.Point(125, 122);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(87, 18);
            this.Team1Name.TabIndex = 6;
            this.Team1Name.Text = "GSM";
            this.Team1Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // goToSetting
            // 
            this.goToSetting.BackgroundImage = global::SpyQRecordSystem.Properties.Resources.wheel;
            this.goToSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goToSetting.Location = new System.Drawing.Point(8, 3);
            this.goToSetting.Name = "goToSetting";
            this.goToSetting.Size = new System.Drawing.Size(46, 44);
            this.goToSetting.TabIndex = 9;
            this.goToSetting.UseVisualStyleBackColor = true;
            this.goToSetting.Click += new System.EventHandler(this.goToSetting_Click);
            // 
            // SetchangeBtn
            // 
            this.SetchangeBtn.Location = new System.Drawing.Point(499, 17);
            this.SetchangeBtn.Name = "SetchangeBtn";
            this.SetchangeBtn.Size = new System.Drawing.Size(91, 50);
            this.SetchangeBtn.TabIndex = 10;
            this.SetchangeBtn.Text = "세트 바꾸기";
            this.SetchangeBtn.UseVisualStyleBackColor = true;
            this.SetchangeBtn.Click += new System.EventHandler(this.SetchangeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.goToSetting);
            this.Controls.Add(this.UnderPanel);
            this.Controls.Add(this.ScorePanel);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.scoreTitle);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LogPanel.ResumeLayout(false);
            this.UnderPanel.ResumeLayout(false);
            this.UnderPanel.PerformLayout();
            this.ScorePanel.ResumeLayout(false);
            this.ScorePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label scoreTitle;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.VScrollBar LogPanelScroll;
        private System.Windows.Forms.Panel UnderPanel;
        private System.Windows.Forms.Panel ScorePanel;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label Team1Name;
        private System.Windows.Forms.Label Team2Home;
        private System.Windows.Forms.Label Team1Home;
        private System.Windows.Forms.Label Team2Score;
        private System.Windows.Forms.Label Team1Score;
        private System.Windows.Forms.Button goToSetting;
        private System.Windows.Forms.Label recordHolderLabel;
        private System.Windows.Forms.Label RecordHolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button SetchangeBtn;
    }
}

