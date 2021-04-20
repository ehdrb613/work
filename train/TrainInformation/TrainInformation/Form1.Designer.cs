
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Dept = new System.Windows.Forms.TextBox();
            this.textBox_Arrive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_change_dept_arrive = new System.Windows.Forms.Button();
            this.btn_search_train = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발역";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착역";
            // 
            // textBox_Dept
            // 
            this.textBox_Dept.Location = new System.Drawing.Point(104, 24);
            this.textBox_Dept.Name = "textBox_Dept";
            this.textBox_Dept.Size = new System.Drawing.Size(100, 21);
            this.textBox_Dept.TabIndex = 2;
            // 
            // textBox_Arrive
            // 
            this.textBox_Arrive.Location = new System.Drawing.Point(104, 79);
            this.textBox_Arrive.Name = "textBox_Arrive";
            this.textBox_Arrive.Size = new System.Drawing.Size(100, 21);
            this.textBox_Arrive.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(764, 302);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_change_dept_arrive
            // 
            this.btn_change_dept_arrive.Location = new System.Drawing.Point(133, 50);
            this.btn_change_dept_arrive.Name = "btn_change_dept_arrive";
            this.btn_change_dept_arrive.Size = new System.Drawing.Size(46, 23);
            this.btn_change_dept_arrive.TabIndex = 5;
            this.btn_change_dept_arrive.Text = "↕";
            this.btn_change_dept_arrive.UseVisualStyleBackColor = true;
            this.btn_change_dept_arrive.Click += new System.EventHandler(this.btn_change_dept_arrive_Click);
            // 
            // btn_search_train
            // 
            this.btn_search_train.Location = new System.Drawing.Point(229, 24);
            this.btn_search_train.Name = "btn_search_train";
            this.btn_search_train.Size = new System.Drawing.Size(75, 76);
            this.btn_search_train.TabIndex = 6;
            this.btn_search_train.Text = "조회";
            this.btn_search_train.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

