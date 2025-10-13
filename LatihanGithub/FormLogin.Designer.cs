namespace LatihanGithub
{
    partial class FormLogin
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
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            btnLogin = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(230, 86);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(457, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(230, 180);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(457, 31);
            txtPass.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(129, 86);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(91, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(129, 180);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(87, 25);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(230, 246);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(554, 246);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
        private Button btnLogin;
        private Button btnExit;
    }
}
