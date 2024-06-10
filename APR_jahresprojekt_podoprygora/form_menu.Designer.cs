namespace APR_jahresprojekt_podoprygora
{
    partial class form_menu
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
            lb_highscoreUsername = new Label();
            lb_highscoreList = new Label();
            btn_play = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 0;
            label1.Text = "Best highscore:";
            // 
            // lb_highscoreUsername
            // 
            lb_highscoreUsername.AutoSize = true;
            lb_highscoreUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_highscoreUsername.Location = new Point(12, 65);
            lb_highscoreUsername.Name = "lb_highscoreUsername";
            lb_highscoreUsername.Size = new Size(0, 17);
            lb_highscoreUsername.TabIndex = 1;
            // 
            // lb_highscoreList
            // 
            lb_highscoreList.AutoSize = true;
            lb_highscoreList.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_highscoreList.Location = new Point(114, 67);
            lb_highscoreList.Name = "lb_highscoreList";
            lb_highscoreList.Size = new Size(0, 17);
            lb_highscoreList.TabIndex = 2;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(198, 36);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(110, 38);
            btn_play.TabIndex = 3;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            btn_play.Click += btn_play_Click;
            // 
            // form_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 396);
            Controls.Add(btn_play);
            Controls.Add(lb_highscoreList);
            Controls.Add(lb_highscoreUsername);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "form_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main menu";
            Load += form_menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lb_highscoreUsername;
        private Label lb_highscoreList;
        private Button btn_play;
    }
}