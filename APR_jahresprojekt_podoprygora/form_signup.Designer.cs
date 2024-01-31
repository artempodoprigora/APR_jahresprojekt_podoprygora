namespace APR_jahresprojekt_podoprygora
{
    partial class form_signup
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
            tb_username = new TextBox();
            btn_next = new Button();
            lb_username = new Label();
            lb_password = new Label();
            tb_password = new TextBox();
            btn_signup = new Button();
            llb_AHAC = new LinkLabel();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Location = new Point(138, 89);
            tb_username.Margin = new Padding(2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(164, 23);
            tb_username.TabIndex = 0;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(224, 116);
            btn_next.Margin = new Padding(2);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(78, 25);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            btn_next.Click += btn_next_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(138, 72);
            lb_username.Margin = new Padding(2, 0, 2, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(60, 15);
            lb_username.TabIndex = 2;
            lb_username.Text = "Username";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(141, 114);
            lb_password.Margin = new Padding(2, 0, 2, 0);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(57, 15);
            lb_password.TabIndex = 3;
            lb_password.Text = "Password";
            lb_password.Visible = false;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(138, 132);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(164, 23);
            tb_password.TabIndex = 4;
            tb_password.Visible = false;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(224, 160);
            btn_signup.Margin = new Padding(2);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(78, 25);
            btn_signup.TabIndex = 5;
            btn_signup.Text = "Sign Up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Visible = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // llb_AHAC
            // 
            llb_AHAC.AutoSize = true;
            llb_AHAC.LinkColor = Color.FromArgb(64, 64, 64);
            llb_AHAC.Location = new Point(12, 9);
            llb_AHAC.Name = "llb_AHAC";
            llb_AHAC.Size = new Size(142, 15);
            llb_AHAC.TabIndex = 6;
            llb_AHAC.TabStop = true;
            llb_AHAC.Text = "Already have an account?";
            llb_AHAC.LinkClicked += llb_AHAC_LinkClicked;
            // 
            // form_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 270);
            Controls.Add(llb_AHAC);
            Controls.Add(btn_signup);
            Controls.Add(tb_password);
            Controls.Add(lb_password);
            Controls.Add(lb_username);
            Controls.Add(btn_next);
            Controls.Add(tb_username);
            Margin = new Padding(2);
            Name = "form_signup";
            Text = "form_signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_username;
        private Button btn_next;
        private Label lb_username;
        private Label lb_password;
        private TextBox tb_password;
        private Button btn_signup;
        private LinkLabel llb_AHAC;
    }
}