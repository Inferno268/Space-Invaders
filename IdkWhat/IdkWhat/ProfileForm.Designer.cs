namespace IdkWhat
{
    partial class ProfileForm
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
            profileText = new Label();
            backButton = new Button();
            nameHolder = new Label();
            bestScoreHolder = new Label();
            label1 = new Label();
            nameText = new Label();
            bestScoreText = new Label();
            emailText = new Label();
            SuspendLayout();
            // 
            // profileText
            // 
            profileText.AutoSize = true;
            profileText.Font = new Font("Arial", 32F, FontStyle.Regular, GraphicsUnit.Point);
            profileText.Location = new Point(24, 29);
            profileText.Name = "profileText";
            profileText.Size = new Size(146, 49);
            profileText.TabIndex = 0;
            profileText.Text = "Profile";
            profileText.Click += profileText_Click;
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(994, 29);
            backButton.Margin = new Padding(3, 2, 3, 2);
            backButton.Name = "backButton";
            backButton.Size = new Size(186, 40);
            backButton.TabIndex = 4;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // nameHolder
            // 
            nameHolder.AutoSize = true;
            nameHolder.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            nameHolder.Location = new Point(64, 93);
            nameHolder.Name = "nameHolder";
            nameHolder.Size = new Size(127, 45);
            nameHolder.TabIndex = 5;
            nameHolder.Text = "Name -";
            // 
            // bestScoreHolder
            // 
            bestScoreHolder.AutoSize = true;
            bestScoreHolder.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            bestScoreHolder.Location = new Point(64, 153);
            bestScoreHolder.Name = "bestScoreHolder";
            bestScoreHolder.Size = new Size(187, 45);
            bestScoreHolder.TabIndex = 6;
            bestScoreHolder.Text = "Best score -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(64, 220);
            label1.Name = "label1";
            label1.Size = new Size(118, 45);
            label1.TabIndex = 7;
            label1.Text = "Email -";
            // 
            // nameText
            // 
            nameText.AutoSize = true;
            nameText.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(187, 93);
            nameText.Name = "nameText";
            nameText.Size = new Size(65, 45);
            nameText.TabIndex = 8;
            nameText.Text = "xxx";
            // 
            // bestScoreText
            // 
            bestScoreText.AutoSize = true;
            bestScoreText.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            bestScoreText.Location = new Point(247, 153);
            bestScoreText.Name = "bestScoreText";
            bestScoreText.Size = new Size(80, 45);
            bestScoreText.TabIndex = 9;
            bestScoreText.Text = "xxxx";
            // 
            // emailText
            // 
            emailText.AutoSize = true;
            emailText.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            emailText.Location = new Point(188, 220);
            emailText.Name = "emailText";
            emailText.Size = new Size(80, 45);
            emailText.TabIndex = 10;
            emailText.Text = "xxxx";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 550);
            Controls.Add(emailText);
            Controls.Add(bestScoreText);
            Controls.Add(nameText);
            Controls.Add(label1);
            Controls.Add(bestScoreHolder);
            Controls.Add(nameHolder);
            Controls.Add(backButton);
            Controls.Add(profileText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label profileText;
        private Button backButton;
        private Label nameHolder;
        private Label bestScoreHolder;
        private Label label1;
        private Label nameText;
        private Label bestScoreText;
        private Label emailText;
    }
}