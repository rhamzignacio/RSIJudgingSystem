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

        private bool TextBoxDigitOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                return true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                return true;
            }

            return false;
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality1.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if(double.Parse(txtBoxPersonality1.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality1.Text = "";
                }
            }

            if (txtBoxWIT1.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if(double.Parse(txtBoxWIT1.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT1.Text = "";
                }
            }

            if(errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality1.Text, txtBoxWIT1.Text, judgeProfile.JudgeNo, "1",
                    out errorMessage);

                if(errorMessage !="")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT1.Enabled = txtBoxPersonality1.Enabled = btnSubmit1.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxPersonality2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality2.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality2.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality2.Text = "";
                }
            }

            if (txtBoxWIT2.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT2.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT2.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality2.Text, txtBoxWIT2.Text, judgeProfile.JudgeNo, "2",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT2.Enabled = txtBoxPersonality2.Enabled = btnSubmit2.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit3_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality3.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality3.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality3.Text = "";
                }
            }

            if (txtBoxWIT3.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT3.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT3.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality3.Text, txtBoxWIT3.Text, judgeProfile.JudgeNo, "3",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT3.Enabled = txtBoxPersonality3.Enabled = btnSubmit3.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit4_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality4.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality4.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality4.Text = "";
                }
            }

            if (txtBoxWIT4.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT4.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT4.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality4.Text, txtBoxWIT4.Text, judgeProfile.JudgeNo, "4",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT4.Enabled = txtBoxPersonality4.Enabled = btnSubmit4.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit5_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality5.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality5.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality5.Text = "";
                }
            }

            if (txtBoxWIT5.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT5.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT5.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality5.Text, txtBoxWIT5.Text, judgeProfile.JudgeNo, "5",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT5.Enabled = txtBoxPersonality5.Enabled = btnSubmit5.Enabled = false;
                }
            }
        }

        private void txtPersonality6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit6_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtPersonality6.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtPersonality6.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtPersonality6.Text = "";
                }
            }

            if (txtBoxWIT6.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT6.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT6.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtPersonality6.Text, txtBoxWIT6.Text, judgeProfile.JudgeNo, "6",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT6.Enabled = txtPersonality6.Enabled = btnSubmit6.Enabled = false;
                }
            }
        }

        private void btnSubmit7_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality7.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality7.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality7.Text = "";
                }
            }

            if (txtBoxWIT7.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT7.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT7.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality7.Text, txtBoxWIT7.Text, judgeProfile.JudgeNo, "7",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT7.Enabled = txtBoxPersonality7.Enabled = btnSubmit7.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxPersonality8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit8_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality8.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality8.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality8.Text = "";
                }
            }

            if (txtBoxWIT8.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT8.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT8.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality8.Text, txtBoxWIT8.Text, judgeProfile.JudgeNo, "8",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT8.Enabled = txtBoxPersonality8.Enabled = btnSubmit8.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit9_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality9.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality9.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality9.Text = "";
                }
            }

            if (txtBoxWIT9.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT9.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT9.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality9.Text, txtBoxWIT9.Text, judgeProfile.JudgeNo, "9",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT9.Enabled = txtBoxPersonality9.Enabled = btnSubmit9.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit10_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality10.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality10.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality10.Text = "";
                }
            }

            if (txtBoxWIT10.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT10.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT10.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality10.Text, txtBoxWIT10.Text, judgeProfile.JudgeNo, "10",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT10.Enabled = txtBoxPersonality10.Enabled = btnSubmit10.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit11_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality11.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality11.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality11.Text = "";
                }
            }

            if (txtBoxWIT11.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT11.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT11.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality11.Text, txtBoxWIT11.Text, judgeProfile.JudgeNo, "11",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT11.Enabled = txtBoxPersonality11.Enabled = btnSubmit11.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit12_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality12.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality12.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality12.Text = "";
                }
            }

            if (txtBoxWIT12.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT12.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT12.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality12.Text, txtBoxWIT12.Text, judgeProfile.JudgeNo, "12",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT12.Enabled = txtBoxPersonality12.Enabled = btnSubmit12.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit13_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality13.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality13.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality13.Text = "";
                }
            }

            if (txtBoxWIT13.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT13.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT13.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality13.Text, txtBoxWIT13.Text, judgeProfile.JudgeNo, "13",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT13.Enabled = txtBoxPersonality13.Enabled = btnSubmit13.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit14_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality14.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality14.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality14.Text = "";
                }
            }

            if (txtBoxWIT14.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT14.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT14.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality14.Text, txtBoxWIT14.Text, judgeProfile.JudgeNo, "14",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT14.Enabled = txtBoxPersonality14.Enabled = btnSubmit14.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit15_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality15.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality15.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality15.Text = "";
                }
            }

            if (txtBoxWIT15.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT15.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT15.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality15.Text, txtBoxWIT15.Text, judgeProfile.JudgeNo, "15",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT15.Enabled = txtBoxPersonality15.Enabled = btnSubmit15.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality16_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBoxPersonality16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit16_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality16.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality16.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality16.Text = "";
                }
            }

            if (txtBoxWIT16.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT16.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT16.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality16.Text, txtBoxWIT16.Text, judgeProfile.JudgeNo, "16",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT16.Enabled = txtBoxPersonality16.Enabled = btnSubmit16.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit17_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality17.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality17.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality17.Text = "";
                }
            }

            if (txtBoxWIT17.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT17.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT17.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality17.Text, txtBoxWIT1.Text, judgeProfile.JudgeNo, "17",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT17.Enabled = txtBoxPersonality17.Enabled = btnSubmit17.Enabled = false;
                }
            }
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxPersonality19_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT19_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit19_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality19.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality19.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality19.Text = "";
                }
            }

            if (txtBoxWIT19.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT19.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT19.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality19.Text, txtBoxWIT19.Text, judgeProfile.JudgeNo, "19",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT19.Enabled = txtBoxPersonality19.Enabled = btnSubmit19.Enabled = false;
                }
            }
        }

        private void txtBoxPersonality20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxWIT20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit20_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxPersonality20.Text == "")
                errorMessage += "\n- Score for Personality is required";
            else
            {
                if (double.Parse(txtBoxPersonality20.Text) > 60)
                {
                    errorMessage += "\n- Only 1 - 60 score are allowed in Personality";

                    txtBoxPersonality20.Text = "";
                }
            }

            if (txtBoxWIT20.Text == "")
                errorMessage += "\n- Score for WIT is required";
            else
            {
                if (double.Parse(txtBoxWIT20.Text) > 40)
                {
                    errorMessage += "\n- Only 1 - 40 score are allowed in WIT";

                    txtBoxWIT20.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxPersonality20.Text, txtBoxWIT20.Text, judgeProfile.JudgeNo, "20",
                    out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxWIT20.Enabled = txtBoxPersonality20.Enabled = btnSubmit20.Enabled = false;
                }
            }
        }

        private void btnNextNo1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNext12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNext20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }
    }
}
