﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BCrypt;

namespace Prakt_2
{
    public partial class AuthorizeForm : Form
    {
        private string SavedLoginText;
        public AuthorizeForm()
        {
            InitializeComponent();
            RepeatPasswordPlace.Text = "Не требуется для входа";
            RepeatPasswordPlace.PasswordChar = '\0';
        }

        private void Login(object sender, EventArgs e)
        {
            RepeatPasswordPlace.Text = PasswordPlace.Text;
            if (CheckRegister())
            {
                ProgrammWait();
                RepeatPasswordPlace.Text = "Не требуется для входа";
                RepeatPasswordPlace.PasswordChar = '\0';
                string[] Accounts = File.ReadAllLines("Accounts.txt");
                try
                {
                    for (int i = 0; i < Accounts.Length; i++)
                    {
                        if (BCrypt.Net.BCrypt.Verify(LoginPlace.Text, Accounts[i].Split(':')[0]))
                        {
                            if (BCrypt.Net.BCrypt.Verify(PasswordPlace.Text, Accounts[i].Split(':')[1]))
                            {
                                MessageBox.Show("Вы вошли!");
                                Data.Value = LoginPlace.Text;
                                this.Close();
                                return;
                            }
                        }
                    }
                    MessageBox.Show("Неверный логин и/или пароль!");
                } catch { MessageBox.Show("Файлы программы повреждены. Попробуйте переустановить программу."); } finally { ProgrammWait(); }
            } else 
            {
                RepeatPasswordPlace.Text = "Не требуется для входа";
                RepeatPasswordPlace.PasswordChar = '\0';
            }
        }

        private void ProgrammWait()
        {
            ButtonEnter.Enabled = !ButtonEnter.Enabled;
            ButtonRegister.Enabled = !ButtonRegister.Enabled;
            if (ButtonEnter.Enabled == true)
            {
                ButtonRegister.Text = "Зарегистрироваться";
                ButtonEnter.Text = "Войти";
            } else
            {
                ButtonRegister.Text = "Подождите...";
                ButtonEnter.Text = "Подождите...";
            }
        }

        private bool CheckRegister()
        {
            SavedLoginText = LoginPlace.Text;
            if (LoginPlace.Text.Length < 1) { LoginPlace.Text = "Заполните поле!"; LoginPlace.ForeColor = Color.Red; return false; }
            if (PasswordPlace.Text.Length < 1) { PasswordPlace.Text = "Заполните поле!"; PasswordPlace.ForeColor = Color.Red; PasswordPlace.PasswordChar = '\0'; return false; }
            if (RepeatPasswordPlace.Text.Length < 1) { RepeatPasswordPlace.Text = "Заполните поле!"; RepeatPasswordPlace.ForeColor = Color.Red; RepeatPasswordPlace.PasswordChar = '\0'; return false; }
            if (RepeatPasswordPlace.Text != PasswordPlace.Text) { RepeatPasswordPlace.Text = "Пароли не совпадают!"; RepeatPasswordPlace.ForeColor = Color.Red; RepeatPasswordPlace.PasswordChar = '\0'; return false; }
            if (!File.Exists("Accounts.txt")) { MessageBox.Show("Нужные файлы не найдены. Проверьте правильность установки программы."); return false; }
            return true;
        }

        private void Register(object sender, EventArgs e)
        {
            if (CheckRegister()) 
            {
                ProgrammWait();
                string HashLogin = BCrypt.Net.BCrypt.HashPassword(LoginPlace.Text);
                string[] Accounts = File.ReadAllLines("Accounts.txt");
                try
                {
                    foreach (string Account in Accounts)
                    {
                        if (BCrypt.Net.BCrypt.Verify(LoginPlace.Text, Account.Split(':')[0]))
                        {
                            LoginPlace.Text = "Имя занято";
                            LoginPlace.ForeColor = Color.Red;
                            ProgrammWait();
                            return;
                        }
                    }
                    StreamWriter sw = new StreamWriter("Accounts.txt", true);
                    sw.WriteLine(HashLogin + ':' + BCrypt.Net.BCrypt.HashPassword(PasswordPlace.Text));
                    sw.Close();
                    MessageBox.Show("Вы успешно зарегистрировались!");
                    ProgrammWait();
                    Login(new object(), new EventArgs());
                } catch { MessageBox.Show("Файлы программы повреждены. Попробуйте переустановить программу.");  }
            }
        }

        private void InputLogin(object sender, EventArgs e)
        {
            LoginPlace.ForeColor = Color.Black;
            LoginPlace.Text = SavedLoginText;
        }

        private void InputPassword(object sender, EventArgs e)
        {
            PasswordPlace.ForeColor = Color.Black;
            PasswordPlace.Text = "";
            PasswordPlace.PasswordChar = '*';
        }

        private void InputRepeatPassword(object sender, EventArgs e)
        {
            RepeatPasswordPlace.ForeColor = Color.Black;
            RepeatPasswordPlace.Text = "";
            RepeatPasswordPlace.PasswordChar = '*';
        }

        private void NonAuthorizeEnter(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BlockSymbolsInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ':')
            {
                e.Handled = true;
                MessageBox.Show(": запрещённый символ!");
            }
        }
    }
}