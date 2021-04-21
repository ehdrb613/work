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

            foreach (var item in DataManager_D.AllTrainCode)
            {
                trainComboStart.Items.Add(item.nodename);
            }
            



        }

        private void infoClick_Click(object sender, EventArgs e)
        {
            if(trainComboStart.Text.Trim()!="" && trainComboEnd.Text.Trim() != "") 
            {
                try
                {
                    foreach (var item in DataManager_D.TrainSttnCode)
                    {
                        if(item.nodename == trainComboEnd.Text)
                        {
                            nodeidEnd = item.nodeid;
                            Console.WriteLine(nodeidEnd);
                        }
                    }
                    foreach (var item in DataManager_D.AllTrainCode)
                    {
                        if (item.nodename == trainComboStart.Text)
                        {
                            nodeidStart = item.nodeid;
                            Console.WriteLine(nodeidStart);

                        }
                    }
                
                    DataManager_D.ShowInfo(nodeidStart, nodeidEnd);
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
    }
}
