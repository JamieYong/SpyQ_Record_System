namespace SpyQRecordSystem
{
    partial class GameSetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartImg = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.oppositeLabel = new System.Windows.Forms.Label();
            this.WriterLabel = new System.Windows.Forms.Label();
            this.oppTeamBox = new System.Windows.Forms.TextBox();
            this.WriterBox = new System.Windows.Forms.TextBox();
            this.StartBotton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartImg)).BeginInit();
            this.SuspendLayout();
            // 
            // StartImg
            // 
            this.StartImg.BackgroundImage = global::SpyQRecordSystem.Properties.Resources.StartImg1;
            this.StartImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartImg.Location = new System.Drawing.Point(201, 68);
            this.StartImg.Name = "StartImg";
            this.StartImg.Size = new System.Drawing.Size(401, 191);
            this.StartImg.TabIndex = 0;
            this.StartImg.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.Location = new System.Drawing.Point(260, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(305, 40);
            this.Title.TabIndex = 1;
            this.Title.Text = "SpyQ Record System";
            // 
            // oppositeLabel
            // 
            this.oppositeLabel.AutoSize = true;
            this.oppositeLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oppositeLabel.Location = new System.Drawing.Point(109, 311);
            this.oppositeLabel.Name = "oppositeLabel";
            this.oppositeLabel.Size = new System.Drawing.Size(109, 30);
            this.oppositeLabel.TabIndex = 2;
            this.oppositeLabel.Text = "상대팀   : ";
            // 
            // WriterLabel
            // 
            this.WriterLabel.AutoSize = true;
            this.WriterLabel.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WriterLabel.Location = new System.Drawing.Point(109, 360);
            this.WriterLabel.Name = "WriterLabel";
            this.WriterLabel.Size = new System.Drawing.Size(109, 30);
            this.WriterLabel.TabIndex = 3;
            this.WriterLabel.Text = "기록관   : ";
            // 
            // oppTeamBox
            // 
            this.oppTeamBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.oppTeamBox.Location = new System.Drawing.Point(224, 311);
            this.oppTeamBox.Name = "oppTeamBox";
            this.oppTeamBox.Size = new System.Drawing.Size(135, 35);
            this.oppTeamBox.TabIndex = 4;
            // 
            // WriterBox
            // 
            this.WriterBox.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WriterBox.Location = new System.Drawing.Point(224, 360);
            this.WriterBox.Name = "WriterBox";
            this.WriterBox.Size = new System.Drawing.Size(135, 35);
            this.WriterBox.TabIndex = 5;
            // 
            // StartBotton
            // 
            this.StartBotton.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartBotton.Location = new System.Drawing.Point(686, 344);
            this.StartBotton.Name = "StartBotton";
            this.StartBotton.Size = new System.Drawing.Size(75, 69);
            this.StartBotton.TabIndex = 6;
            this.StartBotton.Text = "경기시작";
            this.StartBotton.UseVisualStyleBackColor = true;
            this.StartBotton.Click += new System.EventHandler(this.StartBotton_Click);
            // 
            // GameSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartBotton);
            this.Controls.Add(this.WriterBox);
            this.Controls.Add(this.oppTeamBox);
            this.Controls.Add(this.WriterLabel);
            this.Controls.Add(this.oppositeLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.StartImg);
            this.Name = "GameSetForm";
            this.Text = "GameSetForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartImg;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label oppositeLabel;
        private System.Windows.Forms.Label WriterLabel;
        private System.Windows.Forms.TextBox oppTeamBox;
        private System.Windows.Forms.TextBox WriterBox;
        private System.Windows.Forms.Button StartBotton;
    }
}