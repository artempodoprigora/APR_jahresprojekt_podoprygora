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
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_password
            // 
            tb_password.Location = new Point(112, 151);
            tb_password.Margin = new Padding(2);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(188, 23);
            tb_password.TabIndex = 0;
            tb_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(222, 178);
            btn_login.Margin = new Padding(2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(78, 23);
            btn_login.TabIndex = 1;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(112, 86);
            lb_username.Margin = new Padding(2, 0, 2, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(60, 15);
            lb_username.TabIndex = 2;
            lb_username.Text = "Username";
            // 
            // llb_signup
            // 
            llb_signup.AutoSize = true;
            llb_signup.LinkColor = Color.Black;
            llb_signup.Location = new Point(363, 5);
            llb_signup.Margin = new Padding(2, 0, 2, 0);
            llb_signup.Name = "llb_signup";
            llb_signup.Size = new Size(48, 15);
            llb_signup.TabIndex = 3;
            llb_signup.TabStop = true;
            llb_signup.Text = "Sign Up";
            llb_signup.LinkClicked += llb_signup_LinkClicked;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(112, 108);
            tb_username.Margin = new Padding(2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(188, 23);
            tb_username.TabIndex = 4;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(112, 134);
            lb_password.Margin = new Padding(2, 0, 2, 0);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(57, 15);
            lb_password.TabIndex = 5;
            lb_password.Text = "Password";
            lb_password.Click += lb_password_Click;
            // 
            // llb_forgotPassword
            // 
            llb_forgotPassword.AutoSize = true;
            llb_forgotPassword.LinkColor = Color.Black;
            llb_forgotPassword.Location = new Point(190, 134);
            llb_forgotPassword.Margin = new Padding(2, 0, 2, 0);
            llb_forgotPassword.Name = "llb_forgotPassword";
            llb_forgotPassword.Size = new Size(100, 15);
            llb_forgotPassword.TabIndex = 6;
            llb_forgotPassword.TabStop = true;
            llb_forgotPassword.Text = "Forgot password?";
            llb_forgotPassword.LinkClicked += llb_forgotPassword_LinkClicked;
            // 
            // lb_gamename
            // 
            lb_gamename.AutoSize = true;
            lb_gamename.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_gamename.Location = new Point(180, 54);
            lb_gamename.Margin = new Padding(2, 0, 2, 0);
            lb_gamename.Name = "lb_gamename";
            lb_gamename.Size = new Size(52, 25);
            lb_gamename.TabIndex = 7;
            lb_gamename.Text = "2048";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 8;
            label1.Text = "Don´t have an account yet?";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 271);
            Controls.Add(label1);
            Controls.Add(lb_gamename);
            Controls.Add(llb_forgotPassword);
            Controls.Add(lb_password);
            Controls.Add(tb_username);
            Controls.Add(llb_signup);
            Controls.Add(lb_username);
            Controls.Add(btn_login);
            Controls.Add(tb_password);
            Margin = new Padding(2);
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
    }
}
