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
    public partial class MainWindow : Form
    {
        JudgeProfile judgeProfile;

        public MainWindow(JudgeProfile _judgeProfile)
        {
            InitializeComponent();

            judgeProfile = _judgeProfile;

            lblJudgeName.Text = "Welcome " + judgeProfile.Name + "! ! !";
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            TopTenWinners form = new TopTenWinners(judgeProfile);

            form.ShowDialog();
        }

        private void btnTop5_Click(object sender, EventArgs e)
        {
            TopFiveWinners form = new TopFiveWinners(judgeProfile);

            form.ShowDialog();
        }
    }
}
