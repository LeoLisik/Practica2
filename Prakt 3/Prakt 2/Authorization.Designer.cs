
namespace Prakt_2
{
    partial class AuthorizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizeForm));
            this.LoginPlace = new System.Windows.Forms.TextBox();
            this.PasswordPlace = new System.Windows.Forms.TextBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextRepeatPassword = new System.Windows.Forms.Label();
            this.RepeatPasswordPlace = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.NonAuthorizeEnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginPlace
            // 
            this.LoginPlace.Location = new System.Drawing.Point(100, 28);
            this.LoginPlace.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPlace.Name = "LoginPlace";
            this.LoginPlace.Size = new System.Drawing.Size(205, 22);
            this.LoginPlace.TabIndex = 0;
            this.LoginPlace.Enter += new System.EventHandler(this.InputLogin);
            this.LoginPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockSymbolsInput);
            // 
            // PasswordPlace
            // 
            this.PasswordPlace.Location = new System.Drawing.Point(100, 94);
            this.PasswordPlace.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordPlace.Name = "PasswordPlace";
            this.PasswordPlace.PasswordChar = '*';
            this.PasswordPlace.Size = new System.Drawing.Size(205, 22);
            this.PasswordPlace.TabIndex = 1;
            this.PasswordPlace.Enter += new System.EventHandler(this.InputPassword);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonRegister.Location = new System.Drawing.Point(16, 194);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(193, 54);
            this.ButtonRegister.TabIndex = 2;
            this.ButtonRegister.Text = "Зарегистрироваться";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.Register);
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Location = new System.Drawing.Point(177, 9);
            this.TextLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(47, 17);
            this.TextLogin.TabIndex = 3;
            this.TextLogin.Text = "Логин";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Location = new System.Drawing.Point(177, 74);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(57, 17);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.Text = "Пароль";
            // 
            // TextRepeatPassword
            // 
            this.TextRepeatPassword.AutoSize = true;
            this.TextRepeatPassword.Location = new System.Drawing.Point(140, 133);
            this.TextRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextRepeatPassword.Name = "TextRepeatPassword";
            this.TextRepeatPassword.Size = new System.Drawing.Size(130, 17);
            this.TextRepeatPassword.TabIndex = 5;
            this.TextRepeatPassword.Text = "Повторите пароль";
            // 
            // RepeatPasswordPlace
            // 
            this.RepeatPasswordPlace.Location = new System.Drawing.Point(100, 153);
            this.RepeatPasswordPlace.Margin = new System.Windows.Forms.Padding(4);
            this.RepeatPasswordPlace.Name = "RepeatPasswordPlace";
            this.RepeatPasswordPlace.PasswordChar = '*';
            this.RepeatPasswordPlace.Size = new System.Drawing.Size(205, 22);
            this.RepeatPasswordPlace.TabIndex = 6;
            this.RepeatPasswordPlace.Enter += new System.EventHandler(this.InputRepeatPassword);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonEnter.Location = new System.Drawing.Point(204, 194);
            this.ButtonEnter.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(195, 54);
            this.ButtonEnter.TabIndex = 7;
            this.ButtonEnter.Text = "Войти";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.Login);
            // 
            // NonAuthorizeEnterButton
            // 
            this.NonAuthorizeEnterButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NonAuthorizeEnterButton.Location = new System.Drawing.Point(321, -2);
            this.NonAuthorizeEnterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NonAuthorizeEnterButton.Name = "NonAuthorizeEnterButton";
            this.NonAuthorizeEnterButton.Size = new System.Drawing.Size(92, 94);
            this.NonAuthorizeEnterButton.TabIndex = 8;
            this.NonAuthorizeEnterButton.Text = "Играть без авторизации";
            this.NonAuthorizeEnterButton.UseVisualStyleBackColor = false;
            this.NonAuthorizeEnterButton.Click += new System.EventHandler(this.NonAuthorizeEnter);
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(411, 252);
            this.Controls.Add(this.NonAuthorizeEnterButton);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.RepeatPasswordPlace);
            this.Controls.Add(this.TextRepeatPassword);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.PasswordPlace);
            this.Controls.Add(this.LoginPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 299);
            this.MinimumSize = new System.Drawing.Size(429, 299);
            this.Name = "AuthorizeForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginPlace;
        private System.Windows.Forms.TextBox PasswordPlace;
        private System.Windows.Forms.Button ButtonRegister;
        private System.Windows.Forms.Label TextLogin;
        private System.Windows.Forms.Label TextPassword;
        private System.Windows.Forms.Label TextRepeatPassword;
        private System.Windows.Forms.TextBox RepeatPasswordPlace;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button NonAuthorizeEnterButton;
    }
}