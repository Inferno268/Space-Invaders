namespace IdkWhat
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            passInput = new TextBox();
            Head = new Label();
            label1 = new Label();
            loginButton = new Button();
            registerButton = new Button();
            label2 = new Label();
            label3 = new Label();
            userNameInput = new TextBox();
            SuspendLayout();
            // 
            // passInput
            // 
            passInput.CausesValidation = false;
            passInput.Location = new Point(481, 263);
            passInput.Margin = new Padding(3, 2, 3, 2);
            passInput.Name = "passInput";
            passInput.Size = new Size(263, 23);
            passInput.TabIndex = 1;
            // 
            // Head
            // 
            Head.AutoSize = true;
            Head.BackColor = SystemColors.MenuHighlight;
            Head.ForeColor = SystemColors.ButtonFace;
            Head.Location = new Point(327, 31);
            Head.Name = "Head";
            Head.Size = new Size(0, 15);
            Head.TabIndex = 2;
            Head.TextAlign = ContentAlignment.TopCenter;
            Head.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(559, 94);
            label1.Name = "label1";
            label1.Size = new Size(99, 45);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(481, 338);
            loginButton.Margin = new Padding(3, 2, 3, 2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(262, 37);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(481, 391);
            registerButton.Margin = new Padding(3, 2, 3, 2);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(262, 37);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 178);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 6;
            label2.Text = "user name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 246);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "password";
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(481, 196);
            userNameInput.Margin = new Padding(3, 2, 3, 2);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(263, 23);
            userNameInput.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 550);
            Controls.Add(userNameInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(Head);
            Controls.Add(passInput);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1225, 589);
            MinimumSize = new Size(614, 291);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passInput;
        private Label Head;
        private Label label1;
        private Button loginButton;
        private Button registerButton;
        private Label label2;
        private Label label3;
        private TextBox userNameInput;
    }
}