using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_change_dept_arrive_Click(object sender, EventArgs e)
        {
            String temp_string="";
            temp_string = textBox_Dept.Text;
            textBox_Dept.Text = textBox_Arrive.Text;
            textBox_Arrive.Text = temp_string;

        }
    }
}
