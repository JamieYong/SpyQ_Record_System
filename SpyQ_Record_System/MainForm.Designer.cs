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
            this.LogListbox = new System.Windows.Forms.ListBox();
            this.GoSettingButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogListbox
            // 
            this.LogListbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogListbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.LogListbox.FormattingEnabled = true;
            this.LogListbox.ItemHeight = 12;
            this.LogListbox.Location = new System.Drawing.Point(996, 0);
            this.LogListbox.Name = "LogListbox";
            this.LogListbox.Size = new System.Drawing.Size(165, 587);
            this.LogListbox.TabIndex = 0;
            // 
            // GoSettingButton
            // 
            this.GoSettingButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoSettingButton.Location = new System.Drawing.Point(0, 530);
            this.GoSettingButton.Name = "GoSettingButton";
            this.GoSettingButton.Size = new System.Drawing.Size(116, 57);
            this.GoSettingButton.TabIndex = 1;
            this.GoSettingButton.Text = "설정";
            this.GoSettingButton.UseVisualStyleBackColor = false;
            this.GoSettingButton.Click += new System.EventHandler(this.GoSettingButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitButton.Location = new System.Drawing.Point(880, 528);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(116, 57);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "종료";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 587);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GoSettingButton);
            this.Controls.Add(this.LogListbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LogListbox;
        private System.Windows.Forms.Button GoSettingButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

