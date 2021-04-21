
namespace TrainInformation
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dept = new System.Windows.Forms.TextBox();
            this.textBox_Arrive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_change_dept_arrive = new System.Windows.Forms.Button();
            this.btn_search_train = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_dept_date = new System.Windows.Forms.TextBox();
            this.Btn_dept_station = new System.Windows.Forms.Button();
            this.Btn_arr_station = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.R_Tonggeun = new System.Windows.Forms.RadioButton();
            this.R_Mugoonhwa_Nuriro = new System.Windows.Forms.RadioButton();
            this.R_ITX_Chungchoon = new System.Windows.Forms.RadioButton();
            this.R_SaeMaeul_ITX_SaeMaeul = new System.Windows.Forms.RadioButton();
            this.R_KTX_SRT = new System.Windows.Forms.RadioButton();
            this.R_AllTrain = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.whatTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.adultchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depplacenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplacenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traingradenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTrainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getUrlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUrlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역";
            // 
            // textBox_Dept
            // 
            this.textBox_Dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_Dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_Dept.Location = new System.Drawing.Point(322, 55);
            this.textBox_Dept.Name = "textBox_Dept";
            this.textBox_Dept.Size = new System.Drawing.Size(100, 21);
            this.textBox_Dept.TabIndex = 2;
            this.textBox_Dept.Leave += new System.EventHandler(this.textBox_Dept_Leave);
            // 
            // textBox_Arrive
            // 
            this.textBox_Arrive.Location = new System.Drawing.Point(322, 110);
            this.textBox_Arrive.Name = "textBox_Arrive";
            this.textBox_Arrive.Size = new System.Drawing.Size(100, 21);
            this.textBox_Arrive.TabIndex = 3;
            this.textBox_Arrive.Leave += new System.EventHandler(this.textBox_Arrive_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 332);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adultchargeDataGridViewTextBoxColumn,
            this.depplacenameDataGridViewTextBoxColumn,
            this.depplandtimeDataGridViewTextBoxColumn,
            this.arrplacenameDataGridViewTextBoxColumn,
            this.arrplandtimeDataGridViewTextBoxColumn,
            this.traingradenameDataGridViewTextBoxColumn,
            this.trainnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.searchTrainBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(790, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_change_dept_arrive
            // 
            this.btn_change_dept_arrive.Location = new System.Drawing.Point(351, 81);
            this.btn_change_dept_arrive.Name = "btn_change_dept_arrive";
            this.btn_change_dept_arrive.Size = new System.Drawing.Size(46, 23);
            this.btn_change_dept_arrive.TabIndex = 5;
            this.btn_change_dept_arrive.Text = "↕";
            this.btn_change_dept_arrive.UseVisualStyleBackColor = true;
            this.btn_change_dept_arrive.Click += new System.EventHandler(this.btn_change_dept_arrive_Click);
            // 
            // btn_search_train
            // 
            this.btn_search_train.Location = new System.Drawing.Point(481, 55);
            this.btn_search_train.Name = "btn_search_train";
            this.btn_search_train.Size = new System.Drawing.Size(75, 76);
            this.btn_search_train.TabIndex = 6;
            this.btn_search_train.Text = "조회";
            this.btn_search_train.UseVisualStyleBackColor = true;
            this.btn_search_train.Click += new System.EventHandler(this.btn_search_train_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "출발일";
            // 
            // textBox_dept_date
            // 
            this.textBox_dept_date.Location = new System.Drawing.Point(68, 25);
            this.textBox_dept_date.Name = "textBox_dept_date";
            this.textBox_dept_date.Size = new System.Drawing.Size(100, 21);
            this.textBox_dept_date.TabIndex = 8;
            // 
            // Btn_dept_station
            // 
            this.Btn_dept_station.Location = new System.Drawing.Point(429, 55);
            this.Btn_dept_station.Name = "Btn_dept_station";
            this.Btn_dept_station.Size = new System.Drawing.Size(46, 23);
            this.Btn_dept_station.TabIndex = 11;
            this.Btn_dept_station.Text = "선택";
            this.Btn_dept_station.UseVisualStyleBackColor = true;
            this.Btn_dept_station.Click += new System.EventHandler(this.Btn_dept_station_Click);
            // 
            // Btn_arr_station
            // 
            this.Btn_arr_station.Location = new System.Drawing.Point(429, 110);
            this.Btn_arr_station.Name = "Btn_arr_station";
            this.Btn_arr_station.Size = new System.Drawing.Size(46, 23);
            this.Btn_arr_station.TabIndex = 12;
            this.Btn_arr_station.Text = "선택";
            this.Btn_arr_station.UseVisualStyleBackColor = true;
            this.Btn_arr_station.Click += new System.EventHandler(this.Btn_arr_station_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 58);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 13;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.R_Tonggeun);
            this.groupBox2.Controls.Add(this.R_Mugoonhwa_Nuriro);
            this.groupBox2.Controls.Add(this.R_ITX_Chungchoon);
            this.groupBox2.Controls.Add(this.R_SaeMaeul_ITX_SaeMaeul);
            this.groupBox2.Controls.Add(this.R_KTX_SRT);
            this.groupBox2.Controls.Add(this.R_AllTrain);
            this.groupBox2.Location = new System.Drawing.Point(595, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 179);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // R_Tonggeun
            // 
            this.R_Tonggeun.AutoSize = true;
            this.R_Tonggeun.Location = new System.Drawing.Point(24, 155);
            this.R_Tonggeun.Name = "R_Tonggeun";
            this.R_Tonggeun.Size = new System.Drawing.Size(71, 16);
            this.R_Tonggeun.TabIndex = 5;
            this.R_Tonggeun.Text = "통근열차";
            this.R_Tonggeun.UseVisualStyleBackColor = true;
            this.R_Tonggeun.CheckedChanged += new System.EventHandler(this.R_Tonggeun_CheckedChanged);
            // 
            // R_Mugoonhwa_Nuriro
            // 
            this.R_Mugoonhwa_Nuriro.AutoSize = true;
            this.R_Mugoonhwa_Nuriro.Location = new System.Drawing.Point(24, 129);
            this.R_Mugoonhwa_Nuriro.Name = "R_Mugoonhwa_Nuriro";
            this.R_Mugoonhwa_Nuriro.Size = new System.Drawing.Size(121, 16);
            this.R_Mugoonhwa_Nuriro.TabIndex = 4;
            this.R_Mugoonhwa_Nuriro.Text = "무궁화호 / 누리로";
            this.R_Mugoonhwa_Nuriro.UseVisualStyleBackColor = true;
            this.R_Mugoonhwa_Nuriro.CheckedChanged += new System.EventHandler(this.R_Mugoonhwa_Nuriro_CheckedChanged);
            // 
            // R_ITX_Chungchoon
            // 
            this.R_ITX_Chungchoon.AutoSize = true;
            this.R_ITX_Chungchoon.Location = new System.Drawing.Point(24, 77);
            this.R_ITX_Chungchoon.Name = "R_ITX_Chungchoon";
            this.R_ITX_Chungchoon.Size = new System.Drawing.Size(80, 16);
            this.R_ITX_Chungchoon.TabIndex = 3;
            this.R_ITX_Chungchoon.Text = "ITX - 청춘";
            this.R_ITX_Chungchoon.UseVisualStyleBackColor = true;
            this.R_ITX_Chungchoon.CheckedChanged += new System.EventHandler(this.R_ITX_Chungchoon_CheckedChanged);
            // 
            // R_SaeMaeul_ITX_SaeMaeul
            // 
            this.R_SaeMaeul_ITX_SaeMaeul.AutoSize = true;
            this.R_SaeMaeul_ITX_SaeMaeul.Location = new System.Drawing.Point(24, 103);
            this.R_SaeMaeul_ITX_SaeMaeul.Name = "R_SaeMaeul_ITX_SaeMaeul";
            this.R_SaeMaeul_ITX_SaeMaeul.Size = new System.Drawing.Size(146, 16);
            this.R_SaeMaeul_ITX_SaeMaeul.TabIndex = 2;
            this.R_SaeMaeul_ITX_SaeMaeul.Text = "새마을호 / ITX-새마을";
            this.R_SaeMaeul_ITX_SaeMaeul.UseVisualStyleBackColor = true;
            this.R_SaeMaeul_ITX_SaeMaeul.CheckedChanged += new System.EventHandler(this.R_SaeMaeul_ITX_SaeMaeul_CheckedChanged);
            // 
            // R_KTX_SRT
            // 
            this.R_KTX_SRT.AutoSize = true;
            this.R_KTX_SRT.Location = new System.Drawing.Point(24, 51);
            this.R_KTX_SRT.Name = "R_KTX_SRT";
            this.R_KTX_SRT.Size = new System.Drawing.Size(85, 16);
            this.R_KTX_SRT.TabIndex = 1;
            this.R_KTX_SRT.Text = "KTX / SRT";
            this.R_KTX_SRT.UseVisualStyleBackColor = true;
            this.R_KTX_SRT.CheckedChanged += new System.EventHandler(this.R_KTX_SRT_CheckedChanged);
            // 
            // R_AllTrain
            // 
            this.R_AllTrain.AutoSize = true;
            this.R_AllTrain.Checked = true;
            this.R_AllTrain.Location = new System.Drawing.Point(24, 25);
            this.R_AllTrain.Name = "R_AllTrain";
            this.R_AllTrain.Size = new System.Drawing.Size(47, 16);
            this.R_AllTrain.TabIndex = 0;
            this.R_AllTrain.TabStop = true;
            this.R_AllTrain.Text = "전체";
            this.R_AllTrain.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whatTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(833, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // whatTime
            // 
            this.whatTime.Name = "whatTime";
            this.whatTime.Size = new System.Drawing.Size(12, 17);
            this.whatTime.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // adultchargeDataGridViewTextBoxColumn
            // 
            this.adultchargeDataGridViewTextBoxColumn.DataPropertyName = "adultcharge";
            this.adultchargeDataGridViewTextBoxColumn.HeaderText = "운임";
            this.adultchargeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adultchargeDataGridViewTextBoxColumn.Name = "adultchargeDataGridViewTextBoxColumn";
            this.adultchargeDataGridViewTextBoxColumn.ReadOnly = true;
            this.adultchargeDataGridViewTextBoxColumn.Width = 80;
            // 
            // depplacenameDataGridViewTextBoxColumn
            // 
            this.depplacenameDataGridViewTextBoxColumn.DataPropertyName = "depplacename";
            this.depplacenameDataGridViewTextBoxColumn.HeaderText = "출발 역";
            this.depplacenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depplacenameDataGridViewTextBoxColumn.Name = "depplacenameDataGridViewTextBoxColumn";
            this.depplacenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // depplandtimeDataGridViewTextBoxColumn
            // 
            this.depplandtimeDataGridViewTextBoxColumn.DataPropertyName = "depplandtime";
            this.depplandtimeDataGridViewTextBoxColumn.HeaderText = "출발 시간";
            this.depplandtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depplandtimeDataGridViewTextBoxColumn.Name = "depplandtimeDataGridViewTextBoxColumn";
            this.depplandtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrplacenameDataGridViewTextBoxColumn
            // 
            this.arrplacenameDataGridViewTextBoxColumn.DataPropertyName = "arrplacename";
            this.arrplacenameDataGridViewTextBoxColumn.HeaderText = "도착 역";
            this.arrplacenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrplacenameDataGridViewTextBoxColumn.Name = "arrplacenameDataGridViewTextBoxColumn";
            this.arrplacenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrplandtimeDataGridViewTextBoxColumn
            // 
            this.arrplandtimeDataGridViewTextBoxColumn.DataPropertyName = "arrplandtime";
            this.arrplandtimeDataGridViewTextBoxColumn.HeaderText = "도착 시간";
            this.arrplandtimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrplandtimeDataGridViewTextBoxColumn.Name = "arrplandtimeDataGridViewTextBoxColumn";
            this.arrplandtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // traingradenameDataGridViewTextBoxColumn
            // 
            this.traingradenameDataGridViewTextBoxColumn.DataPropertyName = "traingradename";
            this.traingradenameDataGridViewTextBoxColumn.HeaderText = "기차 종류";
            this.traingradenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.traingradenameDataGridViewTextBoxColumn.Name = "traingradenameDataGridViewTextBoxColumn";
            this.traingradenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainnoDataGridViewTextBoxColumn
            // 
            this.trainnoDataGridViewTextBoxColumn.DataPropertyName = "trainno";
            this.trainnoDataGridViewTextBoxColumn.HeaderText = "기차 번호";
            this.trainnoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trainnoDataGridViewTextBoxColumn.Name = "trainnoDataGridViewTextBoxColumn";
            this.trainnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // searchTrainBindingSource
            // 
            this.searchTrainBindingSource.DataSource = typeof(TrainInformation.SearchTrain);
            // 
            // getUrlBindingSource
            // 
            this.getUrlBindingSource.DataSource = typeof(TrainInformation.GetUrl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 587);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Btn_arr_station);
            this.Controls.Add(this.Btn_dept_station);
            this.Controls.Add(this.textBox_dept_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_search_train);
            this.Controls.Add(this.btn_change_dept_arrive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Arrive);
            this.Controls.Add(this.textBox_Dept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTrainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getUrlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Dept;
        private System.Windows.Forms.TextBox textBox_Arrive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_change_dept_arrive;
        private System.Windows.Forms.Button btn_search_train;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_dept_date;
        private System.Windows.Forms.Button Btn_dept_station;
        private System.Windows.Forms.Button Btn_arr_station;
        private System.Windows.Forms.BindingSource searchTrainBindingSource;
        private System.Windows.Forms.BindingSource getUrlBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traingradenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton R_Tonggeun;
        private System.Windows.Forms.RadioButton R_Mugoonhwa_Nuriro;
        private System.Windows.Forms.RadioButton R_ITX_Chungchoon;
        private System.Windows.Forms.RadioButton R_SaeMaeul_ITX_SaeMaeul;
        private System.Windows.Forms.RadioButton R_KTX_SRT;
        private System.Windows.Forms.RadioButton R_AllTrain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel whatTime;
        private System.Windows.Forms.Timer timer1;
    }
}

