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
        public Form1()
        {
            InitializeComponent();
            
            foreach (var Value in get.getCtyCodeList().Values)
            {
                comboBox_deptCity.Items.Add(Value);
                comboBox_arrtCity.Items.Add(Value);
            }

            //get.getStrtpntAlocFndTrainInfo(textBox_dept_date.Text,textBox_Dept.Text,textBox_Arrive.Text);
        }


        private void btn_change_dept_arrive_Click(object sender, EventArgs e)
        {
            String temp_string = "";
            temp_string = textBox_Dept.Text;
            textBox_Dept.Text = textBox_Arrive.Text;
            textBox_Arrive.Text = temp_string;

        }
        public string deptCityCode = "";
        public string arrCityCode = "";

        private void comboBox_deptCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            deptCityCode = get.getCtyCodeList().FirstOrDefault(x => x.Value == comboBox_deptCity.SelectedItem.ToString()).Key;
            //Console.WriteLine(citycode);
        }
        private void comboBox_arrtCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrCityCode = get.getCtyCodeList().FirstOrDefault(x => x.Value == comboBox_arrtCity.SelectedItem.ToString()).Key;
        }

        public string deptNodeId = "";
        public string arrNodeId = "";

        private void Btn_dept_station_Click(object sender, EventArgs e)
        {
            var node = get.getCtyAcctoTrainSttnList(deptCityCode);
            if (!node.Values.Contains(textBox_Dept.Text))
            {
                MessageBox.Show("해당 지역에 해당 기차역이 없습니다.");
            }
            else
            {
                deptNodeId = get.getCtyAcctoTrainSttnList(deptCityCode).FirstOrDefault(x => x.Value == textBox_Dept.Text).Key;
                Console.WriteLine(deptNodeId);
            }
        }

        private void Btn_arr_station_Click(object sender, EventArgs e)
        {
            var node = get.getCtyAcctoTrainSttnList(arrCityCode);
            if (!node.Values.Contains(textBox_Arrive.Text))
            {
                MessageBox.Show("해당 지역에 해당 기차역이 없습니다.");
            }
            else
            {
                arrNodeId = get.getCtyAcctoTrainSttnList(arrCityCode).FirstOrDefault(x => x.Value == textBox_Arrive.Text).Key;
                Console.WriteLine(arrNodeId);
            }
        }

        private void btn_search_train_Click(object sender, EventArgs e)
        {
            get.getStrtpntAlocFndTrainInfo(textBox_dept_date.Text,deptNodeId,arrNodeId);
        }
    }
}
