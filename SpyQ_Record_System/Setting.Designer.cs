namespace SpyQ_Record_System
{
    partial class Setting
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
            this.GoMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GoMain
            // 
            this.GoMain.Location = new System.Drawing.Point(347, 328);
            this.GoMain.Name = "GoMain";
            this.GoMain.Size = new System.Drawing.Size(75, 23);
            this.GoMain.TabIndex = 0;
            this.GoMain.Text = "Exit";
            this.GoMain.UseVisualStyleBackColor = true;
            this.GoMain.Click += new System.EventHandler(this.GoMain_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GoMain);
            this.Name = "Setting";
            this.Text = "Setting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoMain;
    }
}