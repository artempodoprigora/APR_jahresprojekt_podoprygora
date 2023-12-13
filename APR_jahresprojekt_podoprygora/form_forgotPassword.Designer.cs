namespace APR_jahresprojekt_podoprygora
{
    partial class form_forgotPassword
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
            components = new System.ComponentModel.Container();
            lb_username = new Label();
            errorProvider1 = new ErrorProvider(components);
            tb_username = new TextBox();
            btn_usernameCheck = new Button();
            tb_newPassword = new TextBox();
            lb_newPassword = new Label();
            btn_change = new Button();
            llb_back = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(50, 88);
            lb_username.Margin = new Padding(2, 0, 2, 0);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(60, 15);
            lb_username.TabIndex = 0;
            lb_username.Text = "Username";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(50, 105);
            tb_username.Margin = new Padding(2, 2, 2, 2);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(148, 23);
            tb_username.TabIndex = 1;
            // 
            // btn_usernameCheck
            // 
            btn_usernameCheck.Location = new Point(120, 132);
            btn_usernameCheck.Margin = new Padding(2, 2, 2, 2);
            btn_usernameCheck.Name = "btn_usernameCheck";
            btn_usernameCheck.Size = new Size(78, 22);
            btn_usernameCheck.TabIndex = 2;
            btn_usernameCheck.Text = "Next step";
            btn_usernameCheck.UseVisualStyleBackColor = true;
            btn_usernameCheck.Click += btn_usernameCheck_Click;
            // 
            // tb_newPassword
            // 
            tb_newPassword.Location = new Point(50, 156);
            tb_newPassword.Margin = new Padding(2, 2, 2, 2);
            tb_newPassword.Name = "tb_newPassword";
            tb_newPassword.Size = new Size(148, 23);
            tb_newPassword.TabIndex = 3;
            tb_newPassword.Visible = false;
            tb_newPassword.WordWrap = false;
            // 
            // lb_newPassword
            // 
            lb_newPassword.AutoSize = true;
            lb_newPassword.Location = new Point(50, 139);
            lb_newPassword.Margin = new Padding(2, 0, 2, 0);
            lb_newPassword.Name = "lb_newPassword";
            lb_newPassword.Size = new Size(84, 15);
            lb_newPassword.TabIndex = 4;
            lb_newPassword.Text = "New Password";
            lb_newPassword.Visible = false;
            // 
            // btn_change
            // 
            btn_change.Location = new Point(120, 183);
            btn_change.Margin = new Padding(2, 2, 2, 2);
            btn_change.Name = "btn_change";
            btn_change.Size = new Size(78, 24);
            btn_change.TabIndex = 5;
            btn_change.Text = "Confrim";
            btn_change.UseVisualStyleBackColor = true;
            btn_change.Visible = false;
            btn_change.Click += btn_change_Click;
            // 
            // llb_back
            // 
            llb_back.ActiveLinkColor = Color.DarkGray;
            llb_back.AutoSize = true;
            llb_back.ForeColor = SystemColors.ControlText;
            llb_back.LinkColor = Color.FromArgb(64, 64, 64);
            llb_back.Location = new Point(12, 9);
            llb_back.Name = "llb_back";
            llb_back.Size = new Size(32, 15);
            llb_back.TabIndex = 6;
            llb_back.TabStop = true;
            llb_back.Text = "Back";
            llb_back.LinkClicked += llb_back_LinkClicked;
            // 
            // form_forgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 313);
            Controls.Add(llb_back);
            Controls.Add(btn_change);
            Controls.Add(lb_newPassword);
            Controls.Add(tb_newPassword);
            Controls.Add(btn_usernameCheck);
            Controls.Add(tb_username);
            Controls.Add(lb_username);
            Margin = new Padding(2, 2, 2, 2);
            Name = "form_forgotPassword";
            Text = "Password recovery";
            Load += forgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_username;
        private ErrorProvider errorProvider1;
        private TextBox tb_newPassword;
        private Button btn_usernameCheck;
        private TextBox tb_username;
        private Label lb_newPassword;
        private Button btn_change;
        private LinkLabel llb_back;
    }
}