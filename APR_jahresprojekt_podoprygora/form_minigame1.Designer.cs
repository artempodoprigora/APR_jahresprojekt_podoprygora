namespace APR_jahresprojekt_podoprygora
{
    partial class form_minigame1
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
            lb_highscore = new Label();
            SuspendLayout();
            // 
            // lb_highscore
            // 
            lb_highscore.AutoSize = true;
            lb_highscore.Location = new Point(235, 224);
            lb_highscore.Name = "lb_highscore";
            lb_highscore.Size = new Size(89, 15);
            lb_highscore.TabIndex = 0;
            lb_highscore.Text = "your highscore:";
            // 
            // form_minigame1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 459);
            Controls.Add(lb_highscore);
            Name = "form_minigame1";
            Text = "form_minigame1";
            Load += form_minigame1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_highscore;
    }
}