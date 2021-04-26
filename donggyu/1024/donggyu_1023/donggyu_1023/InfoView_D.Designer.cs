
namespace donggyu_1023
{
    partial class InfoView_D
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.outTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainComboEnd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrPlaceLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainComboStart = new System.Windows.Forms.ComboBox();
            this.infoClick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.traingradenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplacenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.outTime,
            this.traingradenameDataGridViewTextBoxColumn,
            this.arrplacenameDataGridViewTextBoxColumn,
            this.depplandtimeDataGridViewTextBoxColumn,
            this.arrplandtimeDataGridViewTextBoxColumn,
            this.arrplandtime,
            this.nodenameDataGridViewTextBoxColumn,
            this.trainnoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainDBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 438);
            this.dataGridView1.TabIndex = 1;
            // 
            // outTime
            // 
            this.outTime.DataPropertyName = "outTime";
            this.outTime.HeaderText = "도착남은시간";
            this.outTime.Name = "outTime";
            this.outTime.ReadOnly = true;
            // 
            // arrplandtime
            // 
            this.arrplandtime.DataPropertyName = "arrplandtime";
            this.arrplandtime.HeaderText = "도착시간";
            this.arrplandtime.Name = "arrplandtime";
            this.arrplandtime.ReadOnly = true;
            // 
            // trainComboEnd
            // 
            this.trainComboEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.trainComboEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.trainComboEnd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.trainComboEnd.FormattingEnabled = true;
            this.trainComboEnd.Location = new System.Drawing.Point(117, 65);
            this.trainComboEnd.Name = "trainComboEnd";
            this.trainComboEnd.Size = new System.Drawing.Size(122, 25);
            this.trainComboEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "기차역(도착)";
            // 
            // arrPlaceLabel
            // 
            this.arrPlaceLabel.AutoSize = true;
            this.arrPlaceLabel.Enabled = false;
            this.arrPlaceLabel.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold);
            this.arrPlaceLabel.Location = new System.Drawing.Point(680, 58);
            this.arrPlaceLabel.Name = "arrPlaceLabel";
            this.arrPlaceLabel.Size = new System.Drawing.Size(92, 28);
            this.arrPlaceLabel.TabIndex = 4;
            this.arrPlaceLabel.Text = "도착정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "기차역(출발)";
            // 
            // trainComboStart
            // 
            this.trainComboStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.trainComboStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.trainComboStart.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.trainComboStart.FormattingEnabled = true;
            this.trainComboStart.Location = new System.Drawing.Point(117, 21);
            this.trainComboStart.Name = "trainComboStart";
            this.trainComboStart.Size = new System.Drawing.Size(121, 25);
            this.trainComboStart.TabIndex = 1;
            // 
            // infoClick
            // 
            this.infoClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(116)))), ((int)(((byte)(212)))));
            this.infoClick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(160)))), ((int)(((byte)(230)))));
            this.infoClick.FlatAppearance.BorderSize = 0;
            this.infoClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoClick.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.infoClick.ForeColor = System.Drawing.Color.White;
            this.infoClick.Location = new System.Drawing.Point(256, 21);
            this.infoClick.Name = "infoClick";
            this.infoClick.Size = new System.Drawing.Size(74, 69);
            this.infoClick.TabIndex = 3;
            this.infoClick.Text = "조 회";
            this.infoClick.UseVisualStyleBackColor = false;
            this.infoClick.Click += new System.EventHandler(this.infoClick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio6);
            this.groupBox1.Controls.Add(this.radio3);
            this.groupBox1.Controls.Add(this.radio1);
            this.groupBox1.Controls.Add(this.radio5);
            this.groupBox1.Controls.Add(this.radio4);
            this.groupBox1.Controls.Add(this.radio2);
            this.groupBox1.Location = new System.Drawing.Point(349, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 96);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(154, 20);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(72, 16);
            this.radio2.TabIndex = 5;
            this.radio2.Text = "ITX-청춘";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(154, 45);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(126, 16);
            this.radio4.TabIndex = 7;
            this.radio4.Text = "새마을/ITX-새마을";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // radio5
            // 
            this.radio5.AutoSize = true;
            this.radio5.Location = new System.Drawing.Point(22, 70);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(101, 16);
            this.radio5.TabIndex = 8;
            this.radio5.Text = "무궁화/누리로";
            this.radio5.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(685, 9);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(184, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            // 
            // StripLabel
            // 
            this.StripLabel.Name = "StripLabel";
            this.StripLabel.Size = new System.Drawing.Size(138, 17);
            this.StripLabel.Text = "----년 --월 --일 --:--:--";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 6000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(22, 20);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(47, 16);
            this.radio1.TabIndex = 4;
            this.radio1.TabStop = true;
            this.radio1.Text = "전체";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(22, 45);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(77, 16);
            this.radio3.TabIndex = 6;
            this.radio3.Text = "KTX/SRT";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio6
            // 
            this.radio6.AutoSize = true;
            this.radio6.Location = new System.Drawing.Point(154, 70);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(71, 16);
            this.radio6.TabIndex = 9;
            this.radio6.Text = "통근열차";
            this.radio6.UseVisualStyleBackColor = true;
            // 
            // traingradenameDataGridViewTextBoxColumn
            // 
            this.traingradenameDataGridViewTextBoxColumn.DataPropertyName = "traingradename";
            this.traingradenameDataGridViewTextBoxColumn.HeaderText = "차량종류";
            this.traingradenameDataGridViewTextBoxColumn.Name = "traingradenameDataGridViewTextBoxColumn";
            this.traingradenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrplacenameDataGridViewTextBoxColumn
            // 
            this.arrplacenameDataGridViewTextBoxColumn.DataPropertyName = "depplacename";
            this.arrplacenameDataGridViewTextBoxColumn.HeaderText = "출발지";
            this.arrplacenameDataGridViewTextBoxColumn.Name = "arrplacenameDataGridViewTextBoxColumn";
            this.arrplacenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrplacenameDataGridViewTextBoxColumn.Width = 80;
            // 
            // depplandtimeDataGridViewTextBoxColumn
            // 
            this.depplandtimeDataGridViewTextBoxColumn.DataPropertyName = "depplandtime";
            this.depplandtimeDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.depplandtimeDataGridViewTextBoxColumn.Name = "depplandtimeDataGridViewTextBoxColumn";
            this.depplandtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrplandtimeDataGridViewTextBoxColumn
            // 
            this.arrplandtimeDataGridViewTextBoxColumn.DataPropertyName = "arrplacename";
            this.arrplandtimeDataGridViewTextBoxColumn.HeaderText = "도착지";
            this.arrplandtimeDataGridViewTextBoxColumn.Name = "arrplandtimeDataGridViewTextBoxColumn";
            this.arrplandtimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.arrplandtimeDataGridViewTextBoxColumn.Width = 80;
            // 
            // nodenameDataGridViewTextBoxColumn
            // 
            this.nodenameDataGridViewTextBoxColumn.DataPropertyName = "nodename";
            this.nodenameDataGridViewTextBoxColumn.HeaderText = "기차역명";
            this.nodenameDataGridViewTextBoxColumn.Name = "nodenameDataGridViewTextBoxColumn";
            this.nodenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainnoDataGridViewTextBoxColumn
            // 
            this.trainnoDataGridViewTextBoxColumn.DataPropertyName = "trainno";
            this.trainnoDataGridViewTextBoxColumn.HeaderText = "열차번호";
            this.trainnoDataGridViewTextBoxColumn.Name = "trainnoDataGridViewTextBoxColumn";
            this.trainnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trainDBindingSource
            // 
            this.trainDBindingSource.DataSource = typeof(donggyu_1023.Data.Train_D);
            // 
            // InfoView_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(880, 555);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infoClick);
            this.Controls.Add(this.trainComboStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrPlaceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainComboEnd);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "InfoView_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "도착정보";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox trainComboEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arrPlaceLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trainComboStart;
        private System.Windows.Forms.Button infoClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn outTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio5;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn traingradenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainDBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StripLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.RadioButton radio6;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio1;
    }
}