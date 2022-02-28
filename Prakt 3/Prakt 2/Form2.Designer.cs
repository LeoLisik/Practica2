
namespace Prakt_2
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.LoginPlace = new System.Windows.Forms.TextBox();
            this.PasswordPlace = new System.Windows.Forms.TextBox();
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.TextLogin = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.Label();
            this.TextRepeatPassword = new System.Windows.Forms.Label();
            this.RepeatPasswordPlace = new System.Windows.Forms.TextBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.NonAuthorizeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginPlace
            // 
            this.LoginPlace.Location = new System.Drawing.Point(75, 23);
            this.LoginPlace.Name = "LoginPlace";
            this.LoginPlace.Size = new System.Drawing.Size(155, 20);
            this.LoginPlace.TabIndex = 0;
            this.LoginPlace.Enter += new System.EventHandler(this.InputLogin);
            this.LoginPlace.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockSymbolsInput);
            // 
            // PasswordPlace
            // 
            this.PasswordPlace.Location = new System.Drawing.Point(75, 76);
            this.PasswordPlace.Name = "PasswordPlace";
            this.PasswordPlace.PasswordChar = '*';
            this.PasswordPlace.Size = new System.Drawing.Size(155, 20);
            this.PasswordPlace.TabIndex = 1;
            this.PasswordPlace.Enter += new System.EventHandler(this.InputPassword);
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ButtonRegister.Location = new System.Drawing.Point(12, 158);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(145, 44);
            this.ButtonRegister.TabIndex = 2;
            this.ButtonRegister.Text = "Зарегистрироваться";
            this.ButtonRegister.UseVisualStyleBackColor = false;
            this.ButtonRegister.Click += new System.EventHandler(this.Register);
            // 
            // TextLogin
            // 
            this.TextLogin.AutoSize = true;
            this.TextLogin.Location = new System.Drawing.Point(133, 7);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(38, 13);
            this.TextLogin.TabIndex = 3;
            this.TextLogin.Text = "Логин";
            // 
            // TextPassword
            // 
            this.TextPassword.AutoSize = true;
            this.TextPassword.Location = new System.Drawing.Point(133, 60);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(45, 13);
            this.TextPassword.TabIndex = 4;
            this.TextPassword.Text = "Пароль";
            // 
            // TextRepeatPassword
            // 
            this.TextRepeatPassword.AutoSize = true;
            this.TextRepeatPassword.Location = new System.Drawing.Point(105, 108);
            this.TextRepeatPassword.Name = "TextRepeatPassword";
            this.TextRepeatPassword.Size = new System.Drawing.Size(100, 13);
            this.TextRepeatPassword.TabIndex = 5;
            this.TextRepeatPassword.Text = "Повторите пароль";
            // 
            // RepeatPasswordPlace
            // 
            this.RepeatPasswordPlace.Location = new System.Drawing.Point(75, 124);
            this.RepeatPasswordPlace.Name = "RepeatPasswordPlace";
            this.RepeatPasswordPlace.PasswordChar = '*';
            this.RepeatPasswordPlace.Size = new System.Drawing.Size(155, 20);
            this.RepeatPasswordPlace.TabIndex = 6;
            this.RepeatPasswordPlace.Enter += new System.EventHandler(this.InputRepeatPassword);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonEnter.Location = new System.Drawing.Point(153, 158);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(146, 44);
            this.ButtonEnter.TabIndex = 7;
            this.ButtonEnter.Text = "Войти";
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.Login);
            // 
            // NonAuthorizeButton
            // 
            this.NonAuthorizeButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NonAuthorizeButton.Location = new System.Drawing.Point(241, -2);
            this.NonAuthorizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.NonAuthorizeButton.Name = "NonAuthorizeButton";
            this.NonAuthorizeButton.Size = new System.Drawing.Size(69, 76);
            this.NonAuthorizeButton.TabIndex = 8;
            this.NonAuthorizeButton.Text = "Играть без авторизации";
            this.NonAuthorizeButton.UseVisualStyleBackColor = false;
            this.NonAuthorizeButton.Click += new System.EventHandler(this.NonAuthorizeEnter);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(310, 213);
            this.Controls.Add(this.NonAuthorizeButton);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.RepeatPasswordPlace);
            this.Controls.Add(this.TextRepeatPassword);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextLogin);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.PasswordPlace);
            this.Controls.Add(this.LoginPlace);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 252);
            this.MinimumSize = new System.Drawing.Size(326, 252);
            this.Name = "RegisterForm";
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
        private System.Windows.Forms.Button NonAuthorizeButton;
    }
}