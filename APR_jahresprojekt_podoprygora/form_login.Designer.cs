namespace APR_jahresprojekt_podoprygora
{
    partial class form_login
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
            tb_password = new TextBox();
            btn_login = new Button();
            lb_username = new Label();
            llb_signup = new LinkLabel();
            tb_username = new TextBox();
            lb_password = new Label();
            llb_forgotPassword = new LinkLabel();
            lb_gamename = new Label();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(239, 195);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(208, 31);
            tb_password.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(335, 237);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += this.btn_login_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(142, 161);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(91, 25);
            lb_username.TabIndex = 2;
            lb_username.Text = "Username";
            // 
            // llb_signup
            // 
            llb_signup.AutoSize = true;
            llb_signup.LinkColor = Color.Black;
            llb_signup.Location = new Point(146, 237);
            llb_signup.Name = "llb_signup";
            llb_signup.Size = new Size(75, 25);
            llb_signup.TabIndex = 3;
            llb_signup.TabStop = true;
            llb_signup.Text = "Sign Up";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(239, 158);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(208, 31);
            tb_username.TabIndex = 4;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(146, 198);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(87, 25);
            lb_password.TabIndex = 5;
            lb_password.Text = "Password";
            // 
            // llb_forgotPassword
            // 
            llb_forgotPassword.AutoSize = true;
            llb_forgotPassword.LinkColor = Color.Black;
            llb_forgotPassword.Location = new Point(146, 274);
            llb_forgotPassword.Name = "llb_forgotPassword";
            llb_forgotPassword.Size = new Size(148, 25);
            llb_forgotPassword.TabIndex = 6;
            llb_forgotPassword.TabStop = true;
            llb_forgotPassword.Text = "Forgot password";
            // 
            // lb_gamename
            // 
            lb_gamename.AutoSize = true;
            lb_gamename.Font = new Font("Segoe UI", 14F);
            lb_gamename.Location = new Point(216, 76);
            lb_gamename.Name = "lb_gamename";
            lb_gamename.Size = new Size(171, 38);
            lb_gamename.TabIndex = 7;
            lb_gamename.Text = "Game Name";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 489);
            Controls.Add(lb_gamename);
            Controls.Add(llb_forgotPassword);
            Controls.Add(lb_password);
            Controls.Add(tb_username);
            Controls.Add(llb_signup);
            Controls.Add(lb_username);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Name = "form_login";
            Text = "Login";
            Load += form_login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_password;
        private Button btn_login;
        private Label lb_username;
        private LinkLabel llb_signup;
        private TextBox tb_username;
        private Label lb_password;
        private LinkLabel llb_forgotPassword;
        private Label lb_gamename;
    }
}
