
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trainComboEnd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrPlace = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trainComboStart = new System.Windows.Forms.ComboBox();
            this.infoClick = new System.Windows.Forms.Button();
            this.trainDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplacenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traingradenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time,
            this.arrplacenameDataGridViewTextBoxColumn,
            this.depplandtimeDataGridViewTextBoxColumn,
            this.arrplandtimeDataGridViewTextBoxColumn,
            this.arrplandtime,
            this.nodenameDataGridViewTextBoxColumn,
            this.trainnoDataGridViewTextBoxColumn,
            this.traingradenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trainDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(845, 369);
            this.dataGridView1.TabIndex = 1;
            // 
            // trainComboEnd
            // 
            this.trainComboEnd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.trainComboEnd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.trainComboEnd.FormattingEnabled = true;
            this.trainComboEnd.Location = new System.Drawing.Point(343, 25);
            this.trainComboEnd.Name = "trainComboEnd";
            this.trainComboEnd.Size = new System.Drawing.Size(121, 20);
            this.trainComboEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "기차역(도착)";
            // 
            // arrPlace
            // 
            this.arrPlace.AutoSize = true;
            this.arrPlace.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrPlace.Location = new System.Drawing.Point(750, 25);
            this.arrPlace.Name = "arrPlace";
            this.arrPlace.Size = new System.Drawing.Size(94, 21);
            this.arrPlace.TabIndex = 4;
            this.arrPlace.Text = "도착정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "기차역(출발)";
            // 
            // trainComboStart
            // 
            this.trainComboStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.trainComboStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.trainComboStart.FormattingEnabled = true;
            this.trainComboStart.Location = new System.Drawing.Point(117, 25);
            this.trainComboStart.Name = "trainComboStart";
            this.trainComboStart.Size = new System.Drawing.Size(121, 20);
            this.trainComboStart.TabIndex = 6;
            // 
            // infoClick
            // 
            this.infoClick.Location = new System.Drawing.Point(496, 22);
            this.infoClick.Name = "infoClick";
            this.infoClick.Size = new System.Drawing.Size(75, 23);
            this.infoClick.TabIndex = 7;
            this.infoClick.Text = "검색";
            this.infoClick.UseVisualStyleBackColor = true;
            this.infoClick.Click += new System.EventHandler(this.infoClick_Click);
            // 
            // trainDBindingSource
            // 
            this.trainDBindingSource.DataSource = typeof(donggyu_1023.Data.Train_D);
            // 
            // time
            // 
            this.time.HeaderText = "도착 남은 시간";
            this.time.Name = "time";
            this.time.Width = 120;
            // 
            // arrplacenameDataGridViewTextBoxColumn
            // 
            this.arrplacenameDataGridViewTextBoxColumn.DataPropertyName = "depplacename";
            this.arrplacenameDataGridViewTextBoxColumn.HeaderText = "출발지";
            this.arrplacenameDataGridViewTextBoxColumn.Name = "arrplacenameDataGridViewTextBoxColumn";
            // 
            // depplandtimeDataGridViewTextBoxColumn
            // 
            this.depplandtimeDataGridViewTextBoxColumn.DataPropertyName = "depplandtime";
            this.depplandtimeDataGridViewTextBoxColumn.HeaderText = "출발시간";
            this.depplandtimeDataGridViewTextBoxColumn.Name = "depplandtimeDataGridViewTextBoxColumn";
            // 
            // arrplandtimeDataGridViewTextBoxColumn
            // 
            this.arrplandtimeDataGridViewTextBoxColumn.DataPropertyName = "arrplacename";
            this.arrplandtimeDataGridViewTextBoxColumn.HeaderText = "도착지";
            this.arrplandtimeDataGridViewTextBoxColumn.Name = "arrplandtimeDataGridViewTextBoxColumn";
            // 
            // arrplandtime
            // 
            this.arrplandtime.DataPropertyName = "arrplandtime";
            this.arrplandtime.HeaderText = "도착시간";
            this.arrplandtime.Name = "arrplandtime";
            // 
            // nodenameDataGridViewTextBoxColumn
            // 
            this.nodenameDataGridViewTextBoxColumn.DataPropertyName = "nodename";
            this.nodenameDataGridViewTextBoxColumn.HeaderText = "기차역명";
            this.nodenameDataGridViewTextBoxColumn.Name = "nodenameDataGridViewTextBoxColumn";
            // 
            // trainnoDataGridViewTextBoxColumn
            // 
            this.trainnoDataGridViewTextBoxColumn.DataPropertyName = "trainno";
            this.trainnoDataGridViewTextBoxColumn.HeaderText = "열차번호";
            this.trainnoDataGridViewTextBoxColumn.Name = "trainnoDataGridViewTextBoxColumn";
            // 
            // traingradenameDataGridViewTextBoxColumn
            // 
            this.traingradenameDataGridViewTextBoxColumn.DataPropertyName = "traingradename";
            this.traingradenameDataGridViewTextBoxColumn.HeaderText = "차량종류";
            this.traingradenameDataGridViewTextBoxColumn.Name = "traingradenameDataGridViewTextBoxColumn";
            // 
            // InfoView_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 452);
            this.Controls.Add(this.infoClick);
            this.Controls.Add(this.trainComboStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.arrPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainComboEnd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfoView_D";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InfoView_D";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trainDBindingSource;
        private System.Windows.Forms.ComboBox trainComboEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arrPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trainComboStart;
        private System.Windows.Forms.Button infoClick;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traingradenameDataGridViewTextBoxColumn;
    }
}