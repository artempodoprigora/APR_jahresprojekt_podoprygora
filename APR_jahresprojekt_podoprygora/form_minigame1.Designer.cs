namespace APR_jahresprojekt_podoprygora
{
    partial class form_minigame1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lb_score = new Label();
            lb_scoretext = new Label();
            SuspendLayout();
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_score.Location = new Point(109, 9);
            lb_score.Margin = new Padding(6, 0, 6, 0);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(20, 24);
            lb_score.TabIndex = 16;
            lb_score.Text = "0";
            // 
            // lb_scoretext
            // 
            lb_scoretext.AutoSize = true;
            lb_scoretext.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_scoretext.Location = new Point(13, 9);
            lb_scoretext.Margin = new Padding(4, 0, 4, 0);
            lb_scoretext.Name = "lb_scoretext";
            lb_scoretext.Size = new Size(65, 24);
            lb_scoretext.TabIndex = 17;
            lb_scoretext.Text = "Score:";
            // 
            // form_minigame1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(244, 342);
            Controls.Add(lb_scoretext);
            Controls.Add(lb_score);
            Margin = new Padding(6, 5, 6, 5);
            Name = "form_minigame1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2048";
            Load += form_minigame1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_score;
        private Label lb_scoretext;
    }
}