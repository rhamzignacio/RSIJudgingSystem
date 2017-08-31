using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Judging_System
{
    public partial class TopTenWinners : Form
    {
        JudgeProfile judgeProfile;

        public TopTenWinners(JudgeProfile _judgeProfile)
        {
            InitializeComponent();

            lblJudgeName.Text = _judgeProfile.Name;

            judgeProfile = _judgeProfile;

            GetTop10();
        }

        private void GetTop10()
        {
            using (var db = new RSIJudgingSystemEntities())
            {
                var contestant = db.ContestantProfile.OrderByDescending(r => r.PanelInterview).ToList();

                for (int x = 0; x < contestant.Count; x++)
                {
                    if (contestant[x].ContestantNo == "1")
                        txtBoxPanelInterviewNo1.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "2")
                        txtBoxPanelInterviewNo2.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "3")
                        txtBoxPanelInterviewNo3.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "4")
                        txtBoxPINo4.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "5")
                        txtBoxPINo5.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "6")
                        txtBoxPINo6.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "7")
                        txtBoxPINo7.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "8")
                        txtBoxPINo8.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "9")
                        txtBoxPINo9.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "10")
                        txtBoxPINo10.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "11")
                        txtBoxPINo11.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "12")
                        txtBoxPINo12.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "13")
                        txtBoxPINo13.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "14")
                        txtBoxPINo14.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "15")
                        txtBoxPINo15.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "16")
                        txtBoxPINo16.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "17")
                        txtBoxPINo17.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "19")
                        txtBoxPINo19.Text = contestant[x].PanelInterview.ToString();
                    else if (contestant[x].ContestantNo == "20")
                        txtBoxPINo20.Text = contestant[x].PanelInterview.ToString();
                }
            }
        }

        private string ConvertPI(decimal score)
        {
            return ((double.Parse(score.ToString()) / 100) * 50).ToString();
        }

        private void RemoveTab(string no)

        {
            if (no == "1")
                tabControl1.TabPages.Remove(tabPage1);
            else if(no == "2")
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

        private void tabPage15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void btnNextNo1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnNextNo2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnNextNo9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
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

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevNo10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

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

        private void tabPage17_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevNo17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void tabPage18_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevNo19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void btnNextNo19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void btnPrevNo20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private bool TextBoxDigitOnly(object sender,KeyPressEventArgs e)
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



        private void txtBoxBeautyNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }



        private void txtBoxIntelligenceNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }


        private void txtBoxDeliveryNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeautyNo1.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if(double.Parse(txtBoxBeautyNo1.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeautyNo1.Text = "";
                }
            }

            if (txtBoxDeliveryNo1.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if(double.Parse(txtBoxDeliveryNo1.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDeliveryNo1.Text = "";
                }
            }

            if (txtBoxIntelligenceNo1.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if(double.Parse(txtBoxIntelligenceNo1.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligenceNo1.Text = "";
                }
            }

            if(errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeautyNo1.Text, txtBoxIntelligenceNo1.Text, txtBoxDeliveryNo1.Text,
                    judgeProfile.JudgeNo, "1", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeautyNo1.Enabled = txtBoxDeliveryNo1.Enabled = txtBoxIntelligenceNo1.Enabled =
                        btnSubmit1.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty2.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty2.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty2.Text = "";
                }
            }

            if (txtBoxDelivery2.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery2.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery2.Text = "";
                }
            }

            if (txtBoxIntelligence2.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence2.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence2.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty2.Text, txtBoxIntelligence2.Text, txtBoxDelivery2.Text,
                    judgeProfile.JudgeNo, "2", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty2.Enabled = txtBoxDelivery2.Enabled = txtBoxIntelligence2.Enabled =
                        btnSubmit2.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit3_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty3.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty3.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty3.Text = "";
                }
            }

            if (txtBoxDelivery3.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery3.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery3.Text = "";
                }
            }

            if (txtBoxIntelligence3.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence3.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence3.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty3.Text, txtBoxIntelligence3.Text, txtBoxDelivery3.Text,
                    judgeProfile.JudgeNo, "3", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty3.Enabled = txtBoxDelivery3.Enabled = txtBoxIntelligence3.Enabled =
                        btnSubmit3.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit4_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty4.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty4.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty4.Text = "";
                }
            }

            if (txtBoxDelivery4.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery4.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery4.Text = "";
                }
            }

            if (txtBoxIntelligence4.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence4.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence4.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty4.Text, txtBoxIntelligence4.Text, txtBoxDelivery4.Text,
                    judgeProfile.JudgeNo, "4", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty4.Enabled = txtBoxDelivery4.Enabled = txtBoxIntelligence4.Enabled =
                        btnSubmit4.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit5_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty5.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty5.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty5.Text = "";
                }
            }

            if (txtBoxDelivery5.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery5.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery5.Text = "";
                }
            }

            if (txtBoxIntelligence5.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence5.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence5.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty5.Text, txtBoxIntelligence5.Text, txtBoxDelivery5.Text,
                    judgeProfile.JudgeNo, "5", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty5.Enabled = txtBoxDelivery5.Enabled = txtBoxIntelligence5.Enabled =
                        btnSubmit5.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit6_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty6.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty6.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty6.Text = "";
                }
            }

            if (txtBoxDelivery6.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery6.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery6.Text = "";
                }
            }

            if (txtBoxIntelligence6.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence6.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence6.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty6.Text, txtBoxIntelligence6.Text, txtBoxDelivery6.Text,
                    judgeProfile.JudgeNo, "6", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty6.Enabled = txtBoxDelivery6.Enabled = txtBoxIntelligence6.Enabled =
                        btnSubmit6.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit7_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty7.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty7.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty7.Text = "";
                }
            }

            if (txtBoxDelivery7.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery7.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery7.Text = "";
                }
            }

            if (txtBoxIntelligence7.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence7.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence7.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty7.Text, txtBoxIntelligence7.Text, txtBoxDelivery7.Text,
                    judgeProfile.JudgeNo, "7", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty7.Enabled = txtBoxDelivery7.Enabled = txtBoxIntelligence7.Enabled =
                        btnSubmit7.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit8_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty8.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty8.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty8.Text = "";
                }
            }

            if (txtBoxDelivery8.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery8.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery8.Text = "";
                }
            }

            if (txtBoxIntelligence8.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence8.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence8.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty8.Text, txtBoxIntelligence8.Text, txtBoxDelivery8.Text,
                    judgeProfile.JudgeNo, "8", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty8.Enabled = txtBoxDelivery8.Enabled = txtBoxIntelligence8.Enabled =
                        btnSubmit8.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit9_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty9.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty9.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty9.Text = "";
                }
            }

            if (txtBoxDelivery9.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery9.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery9.Text = "";
                }
            }

            if (txtBoxIntelligence9.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence9.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence9.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty9.Text, txtBoxIntelligence9.Text, txtBoxDelivery9.Text,
                    judgeProfile.JudgeNo, "9", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty9.Enabled = txtBoxDelivery9.Enabled = txtBoxIntelligence9.Enabled =
                        btnSubmit9.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit10_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty10.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty10.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty10.Text = "";
                }
            }

            if (txtBoxDelivery10.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery10.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery10.Text = "";
                }
            }

            if (txtBoxIntelligence10.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence10.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence10.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty10.Text, txtBoxIntelligence10.Text, txtBoxDelivery10.Text,
                    judgeProfile.JudgeNo, "10", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty10.Enabled = txtBoxDelivery10.Enabled = txtBoxIntelligence10.Enabled =
                        btnSubmit10.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit11_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty11.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty11.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty11.Text = "";
                }
            }

            if (txtBoxDelivery11.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery11.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery11.Text = "";
                }
            }

            if (txtBoxIntelligence11.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence11.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence11.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty11.Text, txtBoxIntelligence11.Text, txtBoxDelivery11.Text,
                    judgeProfile.JudgeNo, "11", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty11.Enabled = txtBoxDelivery11.Enabled = txtBoxIntelligence11.Enabled =
                        btnSubmit11.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit12_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty12.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty12.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty12.Text = "";
                }
            }

            if (txtBoxDelivery12.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery12.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery12.Text = "";
                }
            }

            if (txtBoxIntelligence12.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence12.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence12.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty12.Text, txtBoxIntelligence12.Text, txtBoxDelivery12.Text,
                    judgeProfile.JudgeNo, "12", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty12.Enabled = txtBoxDelivery12.Enabled = txtBoxIntelligence12.Enabled =
                        btnSubmit12.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit13_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty13.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty13.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty13.Text = "";
                }
            }

            if (txtBoxDelivery13.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery13.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery13.Text = "";
                }
            }

            if (txtBoxIntelligence13.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence13.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence13.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty13.Text, txtBoxIntelligence13.Text, txtBoxDelivery13.Text,
                    judgeProfile.JudgeNo, "13", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty13.Enabled = txtBoxDelivery13.Enabled = txtBoxIntelligence13.Enabled =
                        btnSubmit13.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit14_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty14.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty14.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty14.Text = "";
                }
            }

            if (txtBoxDelivery14.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery14.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery14.Text = "";
                }
            }

            if (txtBoxIntelligence14.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence14.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence14.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty14.Text, txtBoxIntelligence14.Text, txtBoxDelivery14.Text,
                    judgeProfile.JudgeNo, "14", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty14.Enabled = txtBoxDelivery14.Enabled = txtBoxIntelligence14.Enabled =
                        btnSubmit14.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit15_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty15.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty15.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty15.Text = "";
                }
            }

            if (txtBoxDelivery15.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery15.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery15.Text = "";
                }
            }

            if (txtBoxIntelligence15.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence15.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence15.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty15.Text, txtBoxIntelligence15.Text, txtBoxDelivery15.Text,
                    judgeProfile.JudgeNo, "15", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty15.Enabled = txtBoxDelivery15.Enabled = txtBoxIntelligence15.Enabled =
                        btnSubmit15.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit16_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty16.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty16.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty16.Text = "";
                }
            }

            if (txtBoxDelivery16.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery16.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery16.Text = "";
                }
            }

            if (txtBoxIntelligence16.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence16.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence16.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty16.Text, txtBoxIntelligence16.Text, txtBoxDelivery16.Text,
                    judgeProfile.JudgeNo, "16", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty16.Enabled = txtBoxDelivery16.Enabled = txtBoxIntelligence16.Enabled =
                        btnSubmit16.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit17_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty17.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty17.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty17.Text = "";
                }
            }

            if (txtBoxDelivery17.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery17.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery17.Text = "";
                }
            }

            if (txtBoxIntelligence17.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence17.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence17.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty17.Text, txtBoxIntelligence17.Text, txtBoxDelivery17.Text,
                    judgeProfile.JudgeNo, "17", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty17.Enabled = txtBoxDelivery17.Enabled = txtBoxIntelligence17.Enabled =
                        btnSubmit17.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty19_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence19_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery19_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit19_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty19.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty19.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty19.Text = "";
                }
            }

            if (txtBoxDelivery19.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery19.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery19.Text = "";
                }
            }

            if (txtBoxIntelligence19.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence19.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence19.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty19.Text, txtBoxIntelligence19.Text, txtBoxDelivery19.Text,
                    judgeProfile.JudgeNo, "19", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty19.Enabled = txtBoxDelivery19.Enabled = txtBoxIntelligence19.Enabled =
                        btnSubmit19.Enabled = false;
                }
            }
        }

        private void txtBoxBeauty20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxIntelligence20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void txtBoxDelivery20_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = TextBoxDigitOnly(sender, e);
        }

        private void btnSubmit20_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty20.Text == "")
                errorMessage += "\n- Score for Face is required";
            else
            {
                if (double.Parse(txtBoxBeauty20.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in Face";

                    txtBoxBeauty20.Text = "";
                }
            }

            if (txtBoxDelivery20.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery20.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Poise";

                    txtBoxDelivery20.Text = "";
                }
            }

            if (txtBoxIntelligence20.Text == "")
                errorMessage += "\n- Score for Figure is required";
            else
            {
                if (double.Parse(txtBoxIntelligence20.Text) > 15)
                {
                    errorMessage += "\n- Only 1 - 15 score are allowed in Figure";

                    txtBoxIntelligence20.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop10(txtBoxBeauty20.Text, txtBoxIntelligence20.Text, txtBoxDelivery20.Text,
                    judgeProfile.JudgeNo, "20", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxBeauty20.Enabled = txtBoxDelivery20.Enabled = txtBoxIntelligence20.Enabled =
                        btnSubmit20.Enabled = false;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
