using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdkWhat
{
    public partial class MainpageForm : Form
    {

        private Users user;
        public MainpageForm()
        {
            InitializeComponent();
        }
        public MainpageForm(Users user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Visible = false;
            login.ShowDialog();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(user);
            Visible = false;
            gameForm.Show();
        }

        //Kill app on close
        static void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }

        private void MainpageForm_Load(object sender, EventArgs e)
        {

        }

        private void scoreboard_Click(object sender, EventArgs e)
        {
            ScoreboardForm scoreboard = new ScoreboardForm(user);
            scoreboard.ShowDialog();
            Visible = false;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profile = new ProfileForm(user);
            profile.ShowDialog();
            Visible = false;
        }
    }
}
