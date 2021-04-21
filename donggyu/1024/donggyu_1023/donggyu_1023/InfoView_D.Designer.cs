
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
            this.arrplandtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.arrPlace = new System.Windows.Forms.Label();
            this.adultchargeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplacenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrplandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nodenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traingradenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adultchargeDataGridViewTextBoxColumn,
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
            // arrplandtime
            // 
            this.arrplandtime.DataPropertyName = "arrplandtime";
            this.arrplandtime.HeaderText = "도착시간";
            this.arrplandtime.Name = "arrplandtime";
            // 
            // trainCombo
            // 
            this.trainCombo.FormattingEnabled = true;
            this.trainCombo.Location = new System.Drawing.Point(115, 29);
            this.trainCombo.Name = "trainCombo";
            this.trainCombo.Size = new System.Drawing.Size(121, 20);
            this.trainCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "기차역";
            // 
            // arrPlace
            // 
            this.arrPlace.AutoSize = true;
            this.arrPlace.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.arrPlace.Location = new System.Drawing.Point(763, 28);
            this.arrPlace.Name = "arrPlace";
            this.arrPlace.Size = new System.Drawing.Size(94, 21);
            this.arrPlace.TabIndex = 4;
            this.arrPlace.Text = "도착정보";
            // 
            // adultchargeDataGridViewTextBoxColumn
            // 
            this.adultchargeDataGridViewTextBoxColumn.DataPropertyName = "adultcharge";
            this.adultchargeDataGridViewTextBoxColumn.HeaderText = "운임";
            this.adultchargeDataGridViewTextBoxColumn.Name = "adultchargeDataGridViewTextBoxColumn";
            // 
            // arrplacenameDataGridViewTextBoxColumn
            // 
            this.arrplacenameDataGridViewTextBoxColumn.DataPropertyName = "arrplacename";
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
            this.arrplandtimeDataGridViewTextBoxColumn.DataPropertyName = "arrplandtime";
            this.arrplandtimeDataGridViewTextBoxColumn.HeaderText = "도착지";
            this.arrplandtimeDataGridViewTextBoxColumn.Name = "arrplandtimeDataGridViewTextBoxColumn";
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
            // trainDBindingSource
            // 
            this.trainDBindingSource.DataSource = typeof(donggyu_1023.Data.Train_D);
            // 
            // InfoView_D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 452);
            this.Controls.Add(this.arrPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainCombo);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn adultchargeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplacenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrplandtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn nodenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traingradenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox trainCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label arrPlace;
    }
}