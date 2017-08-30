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

            GetTop5();
        }

        private void GetTop5()
        {
            using (var db = new RSIJudgingSystemEntities())
            {
                var contestant = db.ContestantProfile.OrderByDescending(r => r.PanelInterview).ToList();

                List<Top5Model> top10List = new List<Top5Model>();

                for (int x = 0; x < contestant.Count; x++)
                {
                    if (x >= 10)
                    {
                        RemoveTab(contestant[x].ContestantNo);
                    }
                    else
                    {
                        var contesNo = contestant[x].ContestantNo;

                        var query = from c in db.ContestantProfile
                                    join j1 in db.Top10Judge1 on c.ContestantNo equals j1.ContestantNo
                                    join j2 in db.Top10Judge2 on c.ContestantNo equals j2.ContestantNo
                                    join j3 in db.Top10Judge3 on c.ContestantNo equals j3.ContestantNo
                                    join j4 in db.Top10Judge4 on c.ContestantNo equals j4.ContestantNo
                                    join j5 in db.Top10Judge5 on c.ContestantNo equals j5.ContestantNo
                                    join j6 in db.Top10Judge6 on c.ContestantNo equals j6.ContestantNo
                                    join j7 in db.Top10Judge7 on c.ContestantNo equals j7.ContestanceNo
                                    where c.ContestantNo == contesNo
                                    select new Top5Model
                                    {
                                        contestantNo = c.ContestantNo,
                                        panelInterview = c.PanelInterview,

                                        beauty1 = j1.Beauty,
                                        intelligence1 = j1.Intelligence,
                                        delivery1 = j1.Delivery,

                                        beauty2 = j2.Beauty,
                                        intelligence2 = j2.Intelligence,
                                        delivery2 = j2.Delivery,

                                        beauty3 = j3.Beauty,
                                        intelligence3 = j3.Intelligence,
                                        delivery3 = j3.Delivery,

                                        beauty4 = j4.Beauty,
                                        intelligence4 = j4.Intelligence,
                                        delivery4 = j4.Delivery,

                                        beauty5 = j5.Beauty,
                                        intelligence5 = j5.Intelligence,
                                        delivery5 = j5.Delivery,

                                        beauty6 = j6.Beauty,
                                        intelligence6 = j6.Intelligence,
                                        delivery6 = j6.Delivery,

                                        beauty7 = j7.Beauty,
                                        intelligence7 = j7.Intelligence,
                                        delivery7 = j7.Delivery
                                    };

                        top10List.Add(query.SingleOrDefault());
                    }
                }

                var temp = top10List.OrderByDescending(r => r.TotalScore).ToList();

                for(int x = 0; x < temp.Count; x++)
                {
                    if (x >= 5)
                    {
                        RemoveTab(temp[x].contestantNo);
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
