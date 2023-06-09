namespace IdkWhat
{
    partial class RegisterForm
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
            userName = new TextBox();
            emailInput = new TextBox();
            passInput = new TextBox();
            passCheckInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            registerButton = new Button();
            loginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(600, 120);
            label1.Name = "label1";
            label1.Size = new Size(167, 54);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // userName
            // 
            userName.Location = new Point(550, 260);
            userName.Name = "userName";
            userName.Size = new Size(300, 27);
            userName.TabIndex = 1;
            userName.TextChanged += userName_TextChanged;
            // 
            // emailInput
            // 
            emailInput.Location = new Point(550, 340);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(300, 27);
            emailInput.TabIndex = 2;
            // 
            // passInput
            // 
            passInput.Location = new Point(550, 420);
            passInput.Name = "passInput";
            passInput.Size = new Size(300, 27);
            passInput.TabIndex = 3;
            // 
            // passCheckInput
            // 
            passCheckInput.Location = new Point(550, 500);
            passCheckInput.Name = "passCheckInput";
            passCheckInput.Size = new Size(300, 27);
            passCheckInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 230);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "user name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 317);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(553, 397);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 477);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 8;
            label5.Text = "password control";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(550, 586);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(300, 49);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(553, 652);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(300, 49);
            loginButton.TabIndex = 10;
            loginButton.Text = "Login instead";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 733);
            Controls.Add(loginButton);
            Controls.Add(registerButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passCheckInput);
            Controls.Add(passInput);
            Controls.Add(emailInput);
            Controls.Add(userName);
            Controls.Add(label1);
            MaximumSize = new Size(1400, 780);
            MinimumSize = new Size(700, 375);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private TextBox emailInput;
        private TextBox passInput;
        private TextBox passCheckInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button registerButton;
        private Button loginButton;
    }
}