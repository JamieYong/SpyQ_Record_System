namespace SpyQ_Record_System
{
    partial class Form1
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
            this.StartYear = new System.Windows.Forms.ComboBox();
            this.StartMonth = new System.Windows.Forms.ComboBox();
            this.StartDay = new System.Windows.Forms.ComboBox();
            this.EndYear = new System.Windows.Forms.ComboBox();
            this.EndMonth = new System.Windows.Forms.ComboBox();
            this.EndDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TeamCBbox = new System.Windows.Forms.ComboBox();
            this.PlayerCBbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartYear
            // 
            this.StartYear.FormattingEnabled = true;
            this.StartYear.Location = new System.Drawing.Point(90, 114);
            this.StartYear.Name = "StartYear";
            this.StartYear.Size = new System.Drawing.Size(121, 23);
            this.StartYear.TabIndex = 1;
            // 
            // StartMonth
            // 
            this.StartMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartMonth.FormattingEnabled = true;
            this.StartMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.StartMonth.Location = new System.Drawing.Point(242, 114);
            this.StartMonth.Name = "StartMonth";
            this.StartMonth.Size = new System.Drawing.Size(121, 23);
            this.StartMonth.TabIndex = 2;
            // 
            // StartDay
            // 
            this.StartDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StartDay.FormattingEnabled = true;
            this.StartDay.ItemHeight = 15;
            this.StartDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.StartDay.Location = new System.Drawing.Point(393, 114);
            this.StartDay.Name = "StartDay";
            this.StartDay.Size = new System.Drawing.Size(121, 23);
            this.StartDay.TabIndex = 3;
            // 
            // EndYear
            // 
            this.EndYear.FormattingEnabled = true;
            this.EndYear.Location = new System.Drawing.Point(90, 202);
            this.EndYear.Name = "EndYear";
            this.EndYear.Size = new System.Drawing.Size(121, 23);
            this.EndYear.TabIndex = 4;
            // 
            // EndMonth
            // 
            this.EndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndMonth.FormattingEnabled = true;
            this.EndMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.EndMonth.Location = new System.Drawing.Point(242, 202);
            this.EndMonth.Name = "EndMonth";
            this.EndMonth.Size = new System.Drawing.Size(121, 23);
            this.EndMonth.TabIndex = 5;
            // 
            // EndDay
            // 
            this.EndDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndDay.FormattingEnabled = true;
            this.EndDay.ItemHeight = 15;
            this.EndDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.EndDay.Location = new System.Drawing.Point(393, 202);
            this.EndDay.Name = "EndDay";
            this.EndDay.Size = new System.Drawing.Size(121, 23);
            this.EndDay.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(282, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "~";
            // 
            // TeamCBbox
            // 
            this.TeamCBbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamCBbox.FormattingEnabled = true;
            this.TeamCBbox.Location = new System.Drawing.Point(131, 340);
            this.TeamCBbox.Name = "TeamCBbox";
            this.TeamCBbox.Size = new System.Drawing.Size(121, 23);
            this.TeamCBbox.TabIndex = 8;
            this.TeamCBbox.Click += new System.EventHandler(this.TeamCBbox_Click);
            // 
            // PlayerCBbox
            // 
            this.PlayerCBbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerCBbox.FormattingEnabled = true;
            this.PlayerCBbox.Location = new System.Drawing.Point(358, 340);
            this.PlayerCBbox.Name = "PlayerCBbox";
            this.PlayerCBbox.Size = new System.Drawing.Size(121, 23);
            this.PlayerCBbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(134, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "TEAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(352, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "PLAYER";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(248, 404);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(115, 45);
            this.select_btn.TabIndex = 13;
            this.select_btn.Text = "조회";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(578, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(633, 494);
            this.dataGridView1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(236, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "PERIOD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 541);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerCBbox);
            this.Controls.Add(this.TeamCBbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndDay);
            this.Controls.Add(this.EndMonth);
            this.Controls.Add(this.EndYear);
            this.Controls.Add(this.StartDay);
            this.Controls.Add(this.StartMonth);
            this.Controls.Add(this.StartYear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox StartYear;
        private System.Windows.Forms.ComboBox StartMonth;
        private System.Windows.Forms.ComboBox StartDay;
        private System.Windows.Forms.ComboBox EndYear;
        private System.Windows.Forms.ComboBox EndMonth;
        private System.Windows.Forms.ComboBox EndDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamCBbox;
        private System.Windows.Forms.ComboBox PlayerCBbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
    }
}

