using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainInformation
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        GetUrl get = new GetUrl();
        List<String> nodename = new List<string>();
        private void autoComplete(TextBox textBox)
        {
            var source = new AutoCompleteStringCollection();
            foreach (var item in get.getAllTrain())
            {
                nodename.Add(item.Value);
            }
            String[] nodeNameArr = nodename.ToArray();
            source.AddRange(nodeNameArr);
            textBox.AutoCompleteCustomSource = source;

            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public Form1()
        {
            InitializeComponent();
            autoComplete(textBox_Dept);
            autoComplete(textBox_Arrive);
            textBox_dept_date.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd");
        }


        private void btn_change_dept_arrive_Click(object sender, EventArgs e)
        {
            String temp_string = "";
            temp_string = textBox_Dept.Text;
            textBox_Dept.Text = textBox_Arrive.Text;
            textBox_Arrive.Text = temp_string;
            textBox_Dept_Leave(this,e);
            textBox_Arrive_Leave(this, e);
        }

        String deptNodeId = "";
        String arrNodeId = "";
        private void Btn_dept_station_Click(object sender, EventArgs e)
        {
            var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Dept.Text).Key;
            Console.WriteLine(node);
            deptNodeId = node;
        }

        private void Btn_arr_station_Click(object sender, EventArgs e)
        {
            var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Arrive.Text).Key;
            Console.WriteLine(node);
            arrNodeId = node;
        }

        private void btn_search_train_Click(object sender, EventArgs e)
        {
            String typeOfTrain1 = "";
            String typoOfTrain2 = "";
            if (R_AllTrain.Checked)
            {
                typeOfTrain1 = "all";
                typoOfTrain2 = "all";
            }
            else if (R_KTX_SRT.Checked)
            {
                typeOfTrain1 = "KTX";
                typoOfTrain2 = "SRT";
            }
            else if (R_Mugoonhwa_Nuriro.Checked)
            {
                typeOfTrain1 = "무궁화호";
                typoOfTrain2 = "누리로";
            }
            else if (R_ITX_Chungchoon.Checked)
            {
                typeOfTrain1 = "ITX-청춘";
                typoOfTrain2 = " ";

            }
            else if (R_SaeMaeul_ITX_SaeMaeul.Checked)
            {
                typeOfTrain1 = "새마을";
                typoOfTrain2 = "ITX-새마을";
            }
            else if (R_Tonggeun.Checked)
            {
                typeOfTrain1 = "통근열차";
                typoOfTrain2 = " ";

            }
            string date = textBox_dept_date.Text.Replace(".","");
            get.getStrtpntAlocFndTrainInfo(date, deptNodeId, arrNodeId, typeOfTrain1, typoOfTrain2);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetUrl.st;
            if (GetUrl.st.Count == 0) { MessageBox.Show("선택하신 경로의 기차는 없습니다.");}
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_dept_date.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy.MM.dd");
        }

        private void textBox_Dept_Leave(object sender, EventArgs e)
        {
            var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Dept.Text).Key;
            Console.WriteLine(node);
            deptNodeId = node;
        }

        private void textBox_Arrive_Leave(object sender, EventArgs e)
        {
            var node = get.getAllTrain().FirstOrDefault(x => x.Value == textBox_Arrive.Text).Key;
            Console.WriteLine(node);
            arrNodeId = node;
        }

        private void R_KTX_SRT_CheckedChanged(object sender, EventArgs e)
        {
            btn_search_train_Click(this, e);
        }

        private void R_ITX_Chungchoon_CheckedChanged(object sender, EventArgs e)
        {
            btn_search_train_Click(this, e);

        }

        private void R_SaeMaeul_ITX_SaeMaeul_CheckedChanged(object sender, EventArgs e)
        {
            btn_search_train_Click(this, e);

        }

        private void R_Mugoonhwa_Nuriro_CheckedChanged(object sender, EventArgs e)
        {
            btn_search_train_Click(this, e);

        }

        private void R_Tonggeun_CheckedChanged(object sender, EventArgs e)
        {
            btn_search_train_Click(this, e);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            whatTime.Text = "현재 시각 : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

        }
    }
}
