namespace IdkWhat
{
    partial class MainpageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            playButton = new Button();
            logOutButton = new Button();
            scoreboard = new Button();
            profileButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(579, 101);
            label1.Name = "label1";
            label1.Size = new Size(247, 45);
            label1.TabIndex = 0;
            label1.Text = "Game Name";
            // 
            // playButton
            // 
            playButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            playButton.Location = new Point(544, 222);
            playButton.Name = "playButton";
            playButton.Size = new Size(300, 60);
            playButton.TabIndex = 1;
            playButton.Text = "Play";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.Location = new Point(544, 605);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(300, 60);
            logOutButton.TabIndex = 2;
            logOutButton.Text = "Logout";
            logOutButton.UseVisualStyleBackColor = true;
            logOutButton.Click += logOutButton_Click;
            // 
            // scoreboard
            // 
            scoreboard.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            scoreboard.Location = new Point(544, 505);
            scoreboard.Name = "scoreboard";
            scoreboard.Size = new Size(300, 60);
            scoreboard.TabIndex = 3;
            scoreboard.Text = "Scoreboard";
            scoreboard.UseVisualStyleBackColor = true;
            scoreboard.Click += scoreboard_Click;
            // 
            // profileButton
            // 
            profileButton.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            profileButton.Location = new Point(544, 405);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(300, 60);
            profileButton.TabIndex = 4;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = true;
            profileButton.Click += profileButton_Click;
            // 
            // MainpageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 733);
            Controls.Add(profileButton);
            Controls.Add(scoreboard);
            Controls.Add(logOutButton);
            Controls.Add(playButton);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "MainpageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainpageForm";
            Load += MainpageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button playButton;
        private Button logOutButton;
        private Button scoreboard;
        private Button profileButton;
    }
}