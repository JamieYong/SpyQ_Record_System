namespace SpyQ_Record_System
{
    partial class SearchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TeamCBbox = new System.Windows.Forms.ComboBox();
            this.PlayerCBbox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.RecordTable = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(291, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "~";
            // 
            // TeamCBbox
            // 
            this.TeamCBbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeamCBbox.FormattingEnabled = true;
            this.TeamCBbox.Location = new System.Drawing.Point(135, 353);
            this.TeamCBbox.Name = "TeamCBbox";
            this.TeamCBbox.Size = new System.Drawing.Size(121, 23);
            this.TeamCBbox.TabIndex = 8;
            this.TeamCBbox.SelectedValueChanged += new System.EventHandler(this.TeamCBbox_SelectedValueChanged);
            this.TeamCBbox.Click += new System.EventHandler(this.TeamCBbox_Click);
            // 
            // PlayerCBbox
            // 
            this.PlayerCBbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerCBbox.FormattingEnabled = true;
            this.PlayerCBbox.Location = new System.Drawing.Point(362, 353);
            this.PlayerCBbox.Name = "PlayerCBbox";
            this.PlayerCBbox.Size = new System.Drawing.Size(121, 23);
            this.PlayerCBbox.TabIndex = 9;
            this.PlayerCBbox.Click += new System.EventHandler(this.PlayerCBbox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(138, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "TEAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(356, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "PLAYER";
            // 
            // select_btn
            // 
            this.select_btn.Location = new System.Drawing.Point(252, 417);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(115, 45);
            this.select_btn.TabIndex = 13;
            this.select_btn.Text = "조회";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // RecordTable
            // 
            this.RecordTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordTable.Location = new System.Drawing.Point(578, 50);
            this.RecordTable.Name = "RecordTable";
            this.RecordTable.RowHeadersWidth = 51;
            this.RecordTable.RowTemplate.Height = 27;
            this.RecordTable.Size = new System.Drawing.Size(633, 467);
            this.RecordTable.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(246, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "PERIOD";
            // 
            // startdate
            // 
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(127, 228);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(129, 25);
            this.startdate.TabIndex = 16;
            // 
            // enddate
            // 
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.Location = new System.Drawing.Point(362, 228);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(133, 25);
            this.enddate.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(114, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 80);
            this.label5.TabIndex = 18;
            this.label5.Text = "기록 조회";
            // 
            // ColumnSelect
            // 
            this.ColumnSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnSelect.FormattingEnabled = true;
            this.ColumnSelect.Items.AddRange(new object[] {
            "전체",
            "공격",
            "수비"});
            this.ColumnSelect.Location = new System.Drawing.Point(835, 12);
            this.ColumnSelect.Name = "ColumnSelect";
            this.ColumnSelect.Size = new System.Drawing.Size(121, 23);
            this.ColumnSelect.TabIndex = 19;
            this.ColumnSelect.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 541);
            this.Controls.Add(this.ColumnSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RecordTable);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlayerCBbox);
            this.Controls.Add(this.TeamCBbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RecordTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamCBbox;
        private System.Windows.Forms.ComboBox PlayerCBbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.DataGridView RecordTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ColumnSelect;
    }
}

