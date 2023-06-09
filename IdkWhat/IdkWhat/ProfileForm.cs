﻿using Microsoft.VisualBasic.Logging;
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
    public partial class ProfileForm : Form
    {
        string userName;
        string userPass;
        string userEmail;
        int userBestScore;

        Users user = new Users();

        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(Users user)
        {
            InitializeComponent();
            this.user = user;

            this.userName = user.GetUserName() ;
            this.userPass = user.GetPassword();
            this.userEmail = user.GetEmail();
            this.userBestScore = user.GetBestScore();

            
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            nameText.Text = userName; // Update the profileText TextBox with the userName value
            emailText.Text = userEmail;
            bestScoreText.Text = userBestScore.ToString();
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            MainpageForm mainpage = new MainpageForm(user);
            this.Close();
            mainpage.ShowDialog();
        }

        private void profileText_Click(object sender, EventArgs e)
        {

        }
    }

}
