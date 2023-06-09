namespace IdkWhat
{
    partial class ScoreboardForm
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
            backButton = new Button();
            scoreboardList = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(536, 90);
            label1.Name = "label1";
            label1.Size = new Size(327, 53);
            label1.TabIndex = 1;
            label1.Text = "Top 10 players";
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            backButton.Location = new Point(12, 90);
            backButton.Name = "backButton";
            backButton.Size = new Size(213, 53);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // scoreboardList
            // 
            scoreboardList.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            scoreboardList.FormattingEnabled = true;
            scoreboardList.ItemHeight = 32;
            scoreboardList.Location = new Point(500, 218);
            scoreboardList.Name = "scoreboardList";
            scoreboardList.Size = new Size(400, 484);
            scoreboardList.TabIndex = 4;
            scoreboardList.SelectedIndexChanged += scroboardList_SelectedIndexChanged;
            // 
            // ScoreboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 733);
            Controls.Add(scoreboardList);
            Controls.Add(backButton);
            Controls.Add(label1);
            Name = "ScoreboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScoreboardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button backButton;
        private ListBox scoreboardList;
    }
}