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
            btn_surrender = new NotFocusableButton();
            SuspendLayout();
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Microsoft Sans Serif", 18.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_score.Location = new Point(15, 29);
            lb_score.Margin = new Padding(4, 0, 4, 0);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(100, 29);
            lb_score.TabIndex = 16;
            lb_score.Text = "Score:0";
            // 
            // btn_surrender
            // 
            btn_surrender.CausesValidation = false;
            btn_surrender.Location = new Point(176, 29);
            btn_surrender.Name = "btn_surrender";
            btn_surrender.Size = new Size(82, 29);
            btn_surrender.TabIndex = 394593485;
            btn_surrender.TabStop = false;
            btn_surrender.Text = "Surrender";
            btn_surrender.UseVisualStyleBackColor = true;
            btn_surrender.Click += btn_surrender_Click;
            // 
            // form_minigame1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 361);
            Controls.Add(btn_surrender);
            Controls.Add(lb_score);
            Margin = new Padding(4, 3, 4, 3);
            Name = "form_minigame1";
            Text = "2048";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_score;
        private Button btn_surrender;
    }
}