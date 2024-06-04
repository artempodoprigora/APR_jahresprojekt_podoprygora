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
            lb_score.Font = new Font("Microsoft Sans Serif", 18.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_score.Location = new Point(109, 30);
            lb_score.Margin = new Padding(4, 0, 4, 0);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(27, 29);
            lb_score.TabIndex = 16;
            lb_score.Text = "0";
            // 
            // lb_scoretext
            // 
            lb_scoretext.AutoSize = true;
            lb_scoretext.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_scoretext.Location = new Point(12, 34);
            lb_scoretext.Name = "lb_scoretext";
            lb_scoretext.Size = new Size(65, 24);
            lb_scoretext.TabIndex = 17;
            lb_scoretext.Text = "Score:";
            // 
            // form_minigame1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 361);
            Controls.Add(lb_scoretext);
            Controls.Add(lb_score);
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_minigame1";
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