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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new RSIJudgingSystemEntities())
            {
                var judge = db.JudgeProfile.FirstOrDefault(r => r.Username == txtBoxUsername.Text);

                if(judge != null)
                {
                    MainWindow form = new MainWindow(judge);

                    form.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username", "Login Error");
                }
            }
        }
    }
}
