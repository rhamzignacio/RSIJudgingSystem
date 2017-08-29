using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Judging_System
{
    public partial class TopFiveWinners : Form
    {
        JudgeProfile judgeProfile;

        public TopFiveWinners(JudgeProfile _judgeProfile)
        {
            InitializeComponent();

            lblJudgeName.Text = _judgeProfile.Name;

            judgeProfile = _judgeProfile;
        }

        private void GetTop5()
        {
            using (var db = new RSIJudgingSystemEntities())
            {
                var contestant = db.ContestantProfile.OrderByDescending(r => r.PanelInterview).ToList();

                List<Top5Model> top5 = new List<Top5Model>();

                for (int x = 0; x < contestant.Count; x++)
                {
                    if (x >= 10)
                    {
                        RemoveTab(contestant[x].ContestantNo);
                    }
                    else
                    {
                        Top5Model top = new Top5Model
                        {
                            contestantNo = contestant[x].ContestantNo,
                            TotalScore = contestant[x].PanelInterview 
                        };
                    }
                }
            }
        }

        private void RemoveTab(string no)

        {
            if (no == "1")
                tabControl1.TabPages.Remove(tabPage1);
            else if (no == "2")
                tabControl1.TabPages.Remove(tabPage2);
            else if (no == "3")
                tabControl1.TabPages.Remove(tabPage3);
            else if (no == "4")
                tabControl1.TabPages.Remove(tabPage4);
            else if (no == "5")
                tabControl1.TabPages.Remove(tabPage5);
            else if (no == "6")
                tabControl1.TabPages.Remove(tabPage6);
            else if (no == "7")
                tabControl1.TabPages.Remove(tabPage7);
            else if (no == "8")
                tabControl1.TabPages.Remove(tabPage8);
            else if (no == "9")
                tabControl1.TabPages.Remove(tabPage9);
            else if (no == "10")
                tabControl1.TabPages.Remove(tabPage10);
            else if (no == "11")
                tabControl1.TabPages.Remove(tabPage11);
            else if (no == "12")
                tabControl1.TabPages.Remove(tabPage12);
            else if (no == "13")
                tabControl1.TabPages.Remove(tabPage13);
            else if (no == "14")
                tabControl1.TabPages.Remove(tabPage14);
            else if (no == "15")
                tabControl1.TabPages.Remove(tabPage15);
            else if (no == "16")
                tabControl1.TabPages.Remove(tabPage16);
            else if (no == "17")
                tabControl1.TabPages.Remove(tabPage17);
            else if (no == "19")
                tabControl1.TabPages.Remove(tabPage18);
            else if (no == "20")
                tabControl1.TabPages.Remove(tabPage19);
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage16_Click(object sender, EventArgs e)
        {

        }
    }
}
