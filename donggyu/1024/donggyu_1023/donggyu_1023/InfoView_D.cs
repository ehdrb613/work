using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donggyu_1023
{
    public partial class InfoView_D : Form
    {
        string nodeidStart="";
        string nodeidEnd="";
        
        public InfoView_D()
        {
            InitializeComponent();
            //DataManager_D.TrainSttnCode
            for (int i = 0; i < DataManager_D.TrainSttnCode.Count; i++)
            {
                trainComboEnd.Items.Add(DataManager_D.TrainSttnCode[i].nodename);
            }
            trainComboEnd.SelectedIndex = 0;
            arrPlaceLabel.Text = trainComboEnd.Text + "역 도착정보";
            foreach (var item in DataManager_D.AllTrainCode)
            {
                trainComboStart.Items.Add(item.nodename);
            }
            



        }
        //정보 출력
        private void infoClick_Click(object sender, EventArgs e)
        {
            

            if(trainComboStart.Text.Trim()!="" && trainComboEnd.Text.Trim() != "") 
            {
                try
                {
                    //도착역 확인
                    foreach (var item in DataManager_D.TrainSttnCode)
                    {
                        if(item.nodename == trainComboEnd.Text)
                        {
                            nodeidEnd = item.nodeid;
                            Console.WriteLine(nodeidEnd);
                        }
                    }
                    //출발역 확인
                    foreach (var item in DataManager_D.AllTrainCode)
                    {
                        if (item.nodename == trainComboStart.Text)
                        {
                            nodeidStart = item.nodeid;
                            Console.WriteLine(nodeidStart);
                        }
                    }
                    //데이터 출력하기위해 API 데이터 불러옴 오늘은 여기까지
                    DataManager_D.ShowInfo(nodeidStart, nodeidEnd, selectTrain());
                    dataGridView1.DataSource= null;
                    dataGridView1.DataSource = DataManager_D.TrainInfo;
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    throw;
                }
               
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StripLabel.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        //기차 종류 선택 코드 정보 입력
        private List<string> selectTrain()
        {

            List<string> st = new List<string>();
            st.Clear();

            if (radio1.Checked)
            {
                st.Add("ALL");
            }

            else if (radio2.Checked)
            {
                st.Add( DataManager_D.ITX_CHUNGCHUN1);
                st.Add( DataManager_D.ITX_CHUNGCHUN2);
            }

            else if (radio3.Checked)
            {
                st.Add(DataManager_D.KTX);
                st.Add(DataManager_D.SRT);
            }
            else if(radio4.Checked)
            {
                st.Add(DataManager_D.SAEMAEUL);
                st.Add(DataManager_D.ITX_SAEMAEUL);
            }
            else if (radio5.Checked)
            {
                st.Add(DataManager_D.MUGUNGHWA);
                st.Add(DataManager_D.NURIRO);
            }
            else if (radio6.Checked)
            {
                st.Add(DataManager_D.COMMUTER);
            }

            return st;
        }
    }
}
