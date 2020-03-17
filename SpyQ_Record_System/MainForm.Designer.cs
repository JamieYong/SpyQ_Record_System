﻿namespace SpyQ_Record_System
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
            System.Windows.Forms.GroupBox underBox;
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetchangeBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goToSetting = new System.Windows.Forms.Button();
            this.Scorepanel = new System.Windows.Forms.GroupBox();
            this.RecordHolderName = new System.Windows.Forms.Label();
            this.BSetScore = new System.Windows.Forms.Label();
            this.Team1Score = new System.Windows.Forms.Label();
            this.Team2Score = new System.Windows.Forms.Label();
            this.ASetScore = new System.Windows.Forms.Label();
            this.Team2Name = new System.Windows.Forms.Label();
            this.Team1Name = new System.Windows.Forms.Label();
            this.recordHolderLabel = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LogPanelScroll = new System.Windows.Forms.VScrollBar();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogBox = new System.Windows.Forms.CheckedListBox();
            this.LogDeleteButton = new System.Windows.Forms.Button();
            underBox = new System.Windows.Forms.GroupBox();
            underBox.SuspendLayout();
            this.Scorepanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // underBox
            // 
            underBox.Controls.Add(this.inputBox);
            underBox.Controls.Add(this.label1);
            underBox.Controls.Add(this.SetchangeBtn);
            underBox.Location = new System.Drawing.Point(12, 333);
            underBox.Name = "underBox";
            underBox.Size = new System.Drawing.Size(601, 100);
            underBox.TabIndex = 14;
            underBox.TabStop = false;
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inputBox.Location = new System.Drawing.Point(80, 28);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(198, 33);
            this.inputBox.TabIndex = 0;
            this.inputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "입력";
            // 
            // SetchangeBtn
            // 
            this.SetchangeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetchangeBtn.Location = new System.Drawing.Point(524, 34);
            this.SetchangeBtn.Name = "SetchangeBtn";
            this.SetchangeBtn.Size = new System.Drawing.Size(51, 50);
            this.SetchangeBtn.TabIndex = 10;
            this.SetchangeBtn.Text = "세트 바꾸기";
            this.SetchangeBtn.UseVisualStyleBackColor = true;
            this.SetchangeBtn.Click += new System.EventHandler(this.SetchangeBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // goToSetting
            // 
            this.goToSetting.BackgroundImage = global::SpyQ_Record_System.Properties.Resources.wheel;
            this.goToSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goToSetting.Location = new System.Drawing.Point(8, 3);
            this.goToSetting.Name = "goToSetting";
            this.goToSetting.Size = new System.Drawing.Size(46, 44);
            this.goToSetting.TabIndex = 9;
            this.goToSetting.UseVisualStyleBackColor = true;
            this.goToSetting.Click += new System.EventHandler(this.goToSetting_Click);
            // 
            // Scorepanel
            // 
            this.Scorepanel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Scorepanel.Controls.Add(this.RecordHolderName);
            this.Scorepanel.Controls.Add(this.BSetScore);
            this.Scorepanel.Controls.Add(this.Team1Score);
            this.Scorepanel.Controls.Add(this.Team2Score);
            this.Scorepanel.Controls.Add(this.ASetScore);
            this.Scorepanel.Controls.Add(this.Team2Name);
            this.Scorepanel.Controls.Add(this.Team1Name);
            this.Scorepanel.Controls.Add(this.recordHolderLabel);
            this.Scorepanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorepanel.Location = new System.Drawing.Point(102, 66);
            this.Scorepanel.Name = "Scorepanel";
            this.Scorepanel.Size = new System.Drawing.Size(476, 179);
            this.Scorepanel.TabIndex = 10;
            this.Scorepanel.TabStop = false;
            this.Scorepanel.Text = "Score";
            // 
            // RecordHolderName
            // 
            this.RecordHolderName.AutoSize = true;
            this.RecordHolderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordHolderName.Location = new System.Drawing.Point(16, 50);
            this.RecordHolderName.Name = "RecordHolderName";
            this.RecordHolderName.Size = new System.Drawing.Size(55, 24);
            this.RecordHolderName.TabIndex = 9;
            this.RecordHolderName.Text = "박호열";
            // 
            // BSetScore
            // 
            this.BSetScore.AutoSize = true;
            this.BSetScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BSetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSetScore.Location = new System.Drawing.Point(258, 76);
            this.BSetScore.Name = "BSetScore";
            this.BSetScore.Size = new System.Drawing.Size(25, 25);
            this.BSetScore.TabIndex = 13;
            this.BSetScore.Text = "0";
            // 
            // Team1Score
            // 
            this.Team1Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Score.Location = new System.Drawing.Point(113, 68);
            this.Team1Score.Name = "Team1Score";
            this.Team1Score.Size = new System.Drawing.Size(64, 72);
            this.Team1Score.TabIndex = 2;
            this.Team1Score.Text = "0";
            // 
            // Team2Score
            // 
            this.Team2Score.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Score.Location = new System.Drawing.Point(299, 68);
            this.Team2Score.Name = "Team2Score";
            this.Team2Score.Size = new System.Drawing.Size(59, 73);
            this.Team2Score.TabIndex = 3;
            this.Team2Score.Text = "0";
            // 
            // ASetScore
            // 
            this.ASetScore.AutoSize = true;
            this.ASetScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ASetScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ASetScore.Location = new System.Drawing.Point(183, 76);
            this.ASetScore.Name = "ASetScore";
            this.ASetScore.Size = new System.Drawing.Size(25, 25);
            this.ASetScore.TabIndex = 11;
            this.ASetScore.Text = "0";
            // 
            // Team2Name
            // 
            this.Team2Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team2Name.Location = new System.Drawing.Point(270, 50);
            this.Team2Name.Name = "Team2Name";
            this.Team2Name.Size = new System.Drawing.Size(127, 18);
            this.Team2Name.TabIndex = 7;
            this.Team2Name.Text = "광주제일고";
            this.Team2Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Team1Name
            // 
            this.Team1Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Team1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team1Name.Location = new System.Drawing.Point(101, 50);
            this.Team1Name.Name = "Team1Name";
            this.Team1Name.Size = new System.Drawing.Size(87, 18);
            this.Team1Name.TabIndex = 6;
            this.Team1Name.Text = "GSM";
            this.Team1Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // recordHolderLabel
            // 
            this.recordHolderLabel.AutoSize = true;
            this.recordHolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordHolderLabel.Location = new System.Drawing.Point(17, 33);
            this.recordHolderLabel.Name = "recordHolderLabel";
            this.recordHolderLabel.Size = new System.Drawing.Size(43, 15);
            this.recordHolderLabel.TabIndex = 8;
            this.recordHolderLabel.Text = "기록관";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(520, 335);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 25);
            this.Time.TabIndex = 12;
            this.Time.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(249, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // LogPanelScroll
            // 
            this.LogPanelScroll.Location = new System.Drawing.Point(241, 12);
            this.LogPanelScroll.Name = "LogPanelScroll";
            this.LogPanelScroll.Size = new System.Drawing.Size(11, 432);
            this.LogPanelScroll.TabIndex = 1;
            // 
            // LogPanel
            // 
            this.LogPanel.Controls.Add(this.LogDeleteButton);
            this.LogPanel.Controls.Add(this.LogBox);
            this.LogPanel.Controls.Add(this.LogPanelScroll);
            this.LogPanel.Location = new System.Drawing.Point(632, 0);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Size = new System.Drawing.Size(168, 444);
            this.LogPanel.TabIndex = 6;
            // 
            // LogBox
            // 
            this.LogBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(9, 12);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(150, 356);
            this.LogBox.TabIndex = 2;
            // 
            // LogDeleteButton
            // 
            this.LogDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogDeleteButton.Location = new System.Drawing.Point(9, 374);
            this.LogDeleteButton.Name = "LogDeleteButton";
            this.LogDeleteButton.Size = new System.Drawing.Size(150, 43);
            this.LogDeleteButton.TabIndex = 3;
            this.LogDeleteButton.Text = "삭제";
            this.LogDeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.goToSetting);
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.Scorepanel);
            this.Controls.Add(underBox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            underBox.ResumeLayout(false);
            underBox.PerformLayout();
            this.Scorepanel.ResumeLayout(false);
            this.Scorepanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button goToSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button SetchangeBtn;
        private System.Windows.Forms.GroupBox Scorepanel;
        private System.Windows.Forms.Label Team1Score;
        private System.Windows.Forms.Label Team2Score;
        private System.Windows.Forms.Label Team1Name;
        private System.Windows.Forms.Label Team2Name;
        private System.Windows.Forms.Label recordHolderLabel;
        private System.Windows.Forms.Label RecordHolderName;
        private System.Windows.Forms.Label ASetScore;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label BSetScore;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.VScrollBar LogPanelScroll;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Button LogDeleteButton;
        private System.Windows.Forms.CheckedListBox LogBox;
    }
}

