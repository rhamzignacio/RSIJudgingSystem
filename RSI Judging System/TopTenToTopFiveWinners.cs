﻿using System;
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
    public partial class TopTenToTopFiveWinners : Form
    {
        JudgeProfile judgeProfile;
        public TopTenToTopFiveWinners(JudgeProfile _judgeProfile)
        {
            InitializeComponent();

            GetTop10();

            judgeProfile = _judgeProfile;
        }

        private void GetTop10()
        {
            using(var db = new RSIJudgingSystemEntities())
            {

                var query = from c in db.ContestantProfile
                            join j1 in db.Top10Judge1 on c.ContestantNo equals j1.ContestantNo into q1
                            from fj1 in q1.DefaultIfEmpty()
                            join j2 in db.Top10Judge2 on c.ContestantNo equals j2.ContestantNo into q2
                            from fj2 in q2.DefaultIfEmpty()
                            join j3 in db.Top10Judge3 on c.ContestantNo equals j3.ContestantNo into q3
                            from fj3 in q3.DefaultIfEmpty()
                            join j4 in db.Top10Judge4 on c.ContestantNo equals j4.ContestantNo into q4
                            from fj4 in q4.DefaultIfEmpty()
                            join j5 in db.Top10Judge5 on c.ContestantNo equals j5.ContestantNo into q5
                            from fj5 in q5.DefaultIfEmpty()
                            join j6 in db.Top10Judge6 on c.ContestantNo equals j6.ContestantNo into q6
                            from fj6 in q6.DefaultIfEmpty()
                            join j7 in db.Top10Judge7 on c.ContestantNo equals j7.ContestanceNo into q7
                            from fj7 in q6.DefaultIfEmpty()
                            select new Top5Model
                            {
                                contestantNo = c.ContestantNo,
                                panelInterview = c.PanelInterview,

                                beauty1 = fj1.Beauty,
                                intelligence1 = fj1.Intelligence,
                                delivery1 = fj1.Delivery,

                                beauty2 = fj2.Beauty,
                                intelligence2 = fj2.Intelligence,
                                delivery2 = fj2.Delivery,

                                beauty3 = fj3.Beauty,
                                intelligence3 = fj3.Intelligence,
                                delivery3 = fj3.Delivery,

                                beauty4 = fj4.Beauty,
                                intelligence4 = fj4.Intelligence,
                                delivery4 = fj4.Delivery,

                                beauty5 = fj5.Beauty,
                                intelligence5 = fj5.Intelligence,
                                delivery5 = fj5.Delivery,

                                beauty6 = fj6.Beauty,
                                intelligence6 = fj6.Intelligence,
                                delivery6 = fj6.Delivery,

                                beauty7 = fj7.Beauty,
                                intelligence7 = fj7.Intelligence,
                                delivery7 = fj7.Delivery,

                                TotalScoreLinq = ((((c.PanelInterview / 100) * 50) * 7) +
                                (fj1.Beauty + fj1.Intelligence + fj1.Delivery) +
                                (fj2.Beauty + fj2.Intelligence + fj2.Delivery) +
                                (fj3.Beauty + fj3.Intelligence + fj3.Delivery) +
                                (fj4.Beauty + fj4.Intelligence + fj4.Delivery) +
                                (fj5.Beauty + fj5.Intelligence + fj5.Delivery) +
                                (fj6.Beauty + fj6.Intelligence + fj6.Delivery) +
                                (fj7.Beauty + fj7.Intelligence + fj7.Delivery)) / 7
                            };

                var top10List = query.OrderByDescending(r=>r.TotalScoreLinq).ToList();

                for (int x = 0; x < top10List.Count; x++)
                {
                    if (x >= 10)
                        RemoveTab(top10List[x].contestantNo);
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

        private void TopTenToTopFiveWinners_Load(object sender, EventArgs e)
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty20.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty20.Text = "";
                }
            }

            if (txtBoxIntelligence20.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence20.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence20.Text = "";
                }
            }

            if (txtBoxDelivery20.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery20.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery20.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty20.Text, txtBoxIntelligence20.Text, txtBoxDelivery20.Text, judgeProfile.JudgeNo, "20", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery20.Enabled = txtBoxIntelligence20.Enabled
                        = txtBoxBeauty20.Enabled = btnSubmit20.Enabled = false;
                }
            }
        }

        private void btnSubmit1_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeautyNo1.Text == "")
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeautyNo1.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeautyNo1.Text = "";
                }
            }

            if (txtBoxIntelligenceNo1.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligenceNo1.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligenceNo1.Text = "";
                }
            }

            if (txtBoxDeliveryNo1.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDeliveryNo1.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDeliveryNo1.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeautyNo1.Text, txtBoxIntelligenceNo1.Text, txtBoxDeliveryNo1.Text, judgeProfile.JudgeNo, "1", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDeliveryNo1.Enabled = txtBoxIntelligenceNo1.Enabled
                        = txtBoxBeautyNo1.Enabled = btnSubmit2.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty2.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty2.Text = "";
                }
            }

            if (txtBoxIntelligence2.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence2.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence2.Text = "";
                }
            }

            if (txtBoxDelivery2.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery2.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery2.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty2.Text, txtBoxIntelligence2.Text, txtBoxDelivery2.Text, judgeProfile.JudgeNo, "2", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery2.Enabled = txtBoxIntelligence2.Enabled
                        = txtBoxBeauty2.Enabled = btnSubmit2.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty3.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty3.Text = "";
                }
            }

            if (txtBoxIntelligence3.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence3.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence3.Text = "";
                }
            }

            if (txtBoxDelivery3.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery3.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery3.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty3.Text, txtBoxIntelligence3.Text, txtBoxDelivery3.Text, judgeProfile.JudgeNo, "3", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery3.Enabled = txtBoxIntelligence3.Enabled
                        = txtBoxBeauty3.Enabled = btnSubmit3.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty4.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty4.Text = "";
                }
            }

            if (txtBoxIntelligence4.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence4.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence4.Text = "";
                }
            }

            if (txtBoxDelivery4.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery4.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery4.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty4.Text, txtBoxIntelligence4.Text, txtBoxDelivery4.Text, judgeProfile.JudgeNo, "4", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery4.Enabled = txtBoxIntelligence4.Enabled
                        = txtBoxBeauty4.Enabled = btnSubmit4.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty5.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty5.Text = "";
                }
            }

            if (txtBoxIntelligence5.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence5.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence5.Text = "";
                }
            }

            if (txtBoxDelivery5.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery5.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery5.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty5.Text, txtBoxIntelligence5.Text, txtBoxDelivery5.Text, judgeProfile.JudgeNo, "5", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery5.Enabled = txtBoxIntelligence5.Enabled
                        = txtBoxBeauty5.Enabled = btnSubmit5.Enabled = false;
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

        private void btnSubmit6_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxBeauty6.Text == "")
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty6.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty6.Text = "";
                }
            }

            if (txtBoxIntelligence6.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence6.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence6.Text = "";
                }
            }

            if (txtBoxDelivery6.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery6.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery6.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty6.Text, txtBoxIntelligence6.Text, txtBoxDelivery6.Text, judgeProfile.JudgeNo, "6", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery6.Enabled = txtBoxIntelligence6.Enabled
                        = txtBoxBeauty6.Enabled = btnSubmit6.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty7.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty7.Text = "";
                }
            }

            if (txtBoxIntelligence7.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence7.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence7.Text = "";
                }
            }

            if (txtBoxDelivery7.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery7.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery7.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty7.Text, txtBoxIntelligence7.Text, txtBoxDelivery7.Text, judgeProfile.JudgeNo, "7", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery7.Enabled = txtBoxIntelligence7.Enabled
                        = txtBoxBeauty7.Enabled = btnSubmit7.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty8.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty8.Text = "";
                }
            }

            if (txtBoxIntelligence8.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence8.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence8.Text = "";
                }
            }

            if (txtBoxDelivery8.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery8.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery8.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty8.Text, txtBoxIntelligence8.Text, txtBoxDelivery8.Text, judgeProfile.JudgeNo, "8", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery8.Enabled = txtBoxIntelligence8.Enabled
                        = txtBoxBeauty8.Enabled = btnSubmit8.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty9.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty9.Text = "";
                }
            }

            if (txtBoxIntelligence9.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence9.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence9.Text = "";
                }
            }

            if (txtBoxDelivery9.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery9.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery9.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty9.Text, txtBoxIntelligence9.Text, txtBoxDelivery9.Text, judgeProfile.JudgeNo, "9", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery9.Enabled = txtBoxIntelligence9.Enabled
                        = txtBoxBeauty9.Enabled = btnSubmit9.Enabled = false;
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
                errorMessage += "\n- Score for Beauty is required";
            else
            {
                if (double.Parse(txtBoxBeauty10.Text) > 50)
                {
                    errorMessage += "\n- Only 1 - 50 score are allowed in Beauty";

                    txtBoxBeauty10.Text = "";
                }
            }

            if (txtBoxIntelligence10.Text == "")
                errorMessage += "\n- Score for Intelligence is required";
            else
            {
                if (double.Parse(txtBoxIntelligence10.Text) > 30)
                {
                    errorMessage += "\n- Only 1 - 30 score are allowed in intelligence";

                    txtBoxIntelligence10.Text = "";
                }
            }

            if (txtBoxDelivery10.Text == "")
                errorMessage += "\n- Score for Poise is required";
            else
            {
                if (double.Parse(txtBoxDelivery10.Text) > 20)
                {
                    errorMessage += "\n- Only 1 - 20 score are allowed in poise";

                    txtBoxDelivery10.Text = "";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error");
            }
            else
            {
                DatabaseFunctions.SaveTop5(txtBoxBeauty10.Text, txtBoxIntelligence10.Text, txtBoxDelivery10.Text, judgeProfile.JudgeNo, "10", out errorMessage);

                if (errorMessage != "")
                {
                    MessageBox.Show(errorMessage, "Error");
                }
                else
                {
                    MessageBox.Show("Scores successfully submitted");

                    txtBoxDelivery10.Enabled = txtBoxIntelligence10.Enabled
                        = txtBoxBeauty10.Enabled = btnSubmit10.Enabled = false;
                }
            }

        }
    }
}
