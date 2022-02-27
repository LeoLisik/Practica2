using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Prakt_2
{
    public partial class Programm : Form
    {
        int SecondsSpend, MoveCount;
        Button[] buttons; 
        string[] PlayersResults;
        Form AccountForm, LeaderboardForm;
        Label Title = new Label();
        Label FasterPlayerStats = new Label();
        Label SmarterPlayerStats = new Label();
        public Programm()
        {
            InitializeComponent();
            ChangePosition(new object(), new EventArgs());
            buttons = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7,
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 };
            AccountMenu(new object(), new EventArgs());
        }

        private void MoveDice(object sender, EventArgs e)
        {
            int ButtonPressedId = Array.IndexOf(buttons, sender as Button);
            if (ButtonPressedId - 4 >= 0 && buttons[ButtonPressedId - 4].Text == "16")
            {
                buttons[ButtonPressedId - 4].Text = buttons[ButtonPressedId].Text; 
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId - 4].Visible = true;
                buttons[ButtonPressedId].Visible = false;
                MoveCount++;
                LabelMoveCount.Text = "Передвинуто цифр: " + MoveCount;
            } else if (ButtonPressedId + 4 <= 15 && buttons[ButtonPressedId + 4].Text == "16")
            {
                buttons[ButtonPressedId + 4].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId + 4].Visible = true;
                buttons[ButtonPressedId].Visible = false;
                MoveCount++;
                LabelMoveCount.Text = "Передвинуто цифр: " + MoveCount;
            }
            if (ButtonPressedId % 4 != 0 && buttons[ButtonPressedId - 1].Text == "16") {
                buttons[ButtonPressedId - 1].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId - 1].Visible = true;
                buttons[ButtonPressedId].Visible = false;
                MoveCount++;
                LabelMoveCount.Text = "Передвинуто цифр: " + MoveCount;
            } else if (ButtonPressedId % 4 != 3 && buttons[ButtonPressedId + 1].Text == "16")
            {
                buttons[ButtonPressedId + 1].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId + 1].Visible = true;
                buttons[ButtonPressedId].Visible = false;
                MoveCount++;
                LabelMoveCount.Text = "Передвинуто цифр: " + MoveCount;
            }
            if (CheckWin()) {
                Win();
            }
        }

        private void Win()
        {
            foreach (Button Buff in buttons)
            {
                Buff.Enabled = false;
                Timer.Enabled = false;
            }
            MessageBox.Show("Ты выиграл!");
            if (Data.Value != null && File.Exists("Leaderboard.txt"))
            {
                StreamWriter sw = new StreamWriter("Leaderboard.txt", true);
                sw.WriteLine(Data.Value + ':' + SecondsSpend + ':' + MoveCount);
                sw.Close();
                MessageBox.Show("Твой результат был записан в рекорды.");
            } else { MessageBox.Show("Для записи рекордов зарегистрируйся.\nЕсли по прежнему появляется это сообщение - переустанови программу."); }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            SecondsSpend++;
            if (SecondsSpend % 10 == 0) { ChangePosition(new object(), new EventArgs()); }
            LabelTimeSpend.Text = "Прошло: " + Convert.ToString(SecondsSpend) + " Сек";
        }

        private void RandomizeDice()
        {
            Random rnd = new Random();
            int FirstButtonId, LastButtonId;
            string Buff;
            for (int i = 0; i < 50; i++)
            {
                FirstButtonId = rnd.Next() % 16;
                LastButtonId = rnd.Next() % 16;
                Buff = buttons[FirstButtonId].Text;
                buttons[FirstButtonId].Text = buttons[LastButtonId].Text;
                buttons[LastButtonId].Text = Buff;
            }
            foreach (Button buff in buttons)
            {
                if (buff.Text == "16") { buff.Visible = false; }
                else { buff.Visible = true; }
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 16; i++)
            {
                if (Convert.ToInt32(buttons[i].Text) != i + 1) { return false; }
            }
            return true;
        }

        private void StartGame(object sender, EventArgs e)
        {
            RandomizeDice();
            Timer.Enabled = true;
            LabelTimeSpend.Text = "Прошло: 0 Сек";
            LabelMoveCount.Text = "Передвинуто цифр: 0";
            SecondsSpend = 0;
            MoveCount = 0;
            ButtonPause.Enabled = true;
            foreach (Button Buff in buttons)
            {
                Buff.Enabled = true;
            }
        }

        private void Help(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.logozavr.ru/1640/");
        }

        private void PauseGame(object sender, EventArgs e)
        {
            Timer.Enabled = !Timer.Enabled;
            foreach (Button Buff in buttons)
            {
                Buff.Enabled = !Buff.Enabled;
            }
            TableMacket.Visible = !TableMacket.Visible;
            Label PauseText = new Label();
            PauseText.AutoSize = true;
            PauseText.Text = "Игра на паузе. Нажмите P для продолжения...";
            PauseText.Location = new Point(this.Width / 2 - PauseText.Size.Width, this.Height / 2);
            this.Controls.Add(PauseText);
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePosition(object sender, EventArgs e)
        {
            LabelTimeSpend.Location = new Point(this.Width - (LabelTimeSpend.Size.Width + (LabelTimeSpend.Size.Width / 2)), 8);
            LabelMoveCount.Location = new Point(LabelTimeSpend.Location.X - LabelMoveCount.Size.Width, LabelTimeSpend.Location.Y);
        }

        private void PressedButtons(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 'P' && ButtonPause.Enabled) { PauseGame(new object(), new EventArgs()); }
            if (e.KeyValue == 'W') {
                for (int i = 0; i < 16; i++)
                {
                    buttons[i].Text = Convert.ToString(i+1);
                }
            }
        }

        private void AccountMenu(object sender, EventArgs e)
        {
            if (buttons[15].Enabled == true)
            {
                PauseGame(new object(), new EventArgs());
            }
            AccountForm = new RegisterForm();
            AccountForm.ShowDialog();
        }

        private void CreateLeaderboardForm(int IdFastest, int IdSmartest)
        {
            LeaderboardForm = new Form();
            LeaderboardForm.Text = "Рекорды";
            LeaderboardForm.Name = "LeaderboardForm";
            LeaderboardForm.Size = new Size(500, 500);
            LeaderboardForm.Icon = new Icon("Fifteen.ico");
            LeaderboardForm.BackColor = SystemColors.AppWorkspace;
            ////////////////////////////////////////
            Label Title = new Label();
            Title.Text = "Рекорды";
            Title.Font = new Font("Microsoft Sans Serif", 25);
            Title.AutoSize = true;
            Title.Location = new Point(LeaderboardForm.Size.Width / 2 - Title.Size.Width, 10);
            LeaderboardForm.Controls.Add(Title);
            ///////////////////////////////////////
            Label FasterPlayerStats = new Label();
            FasterPlayerStats.Text = PlayersResults[IdFastest].Split(':')[0] + " был самым быстрым. Его время составило всего " + PlayersResults[IdFastest].Split(':')[1] + " Сек.";
            FasterPlayerStats.Font = new Font("Microsoft Sans Serif", 10);
            FasterPlayerStats.AutoSize = true;
            FasterPlayerStats.Location = new Point(10, Title.Location.Y + Title.Size.Height + FasterPlayerStats.Size.Height);
            LeaderboardForm.Controls.Add(FasterPlayerStats);
            //////////////////////////////////////
            Label SmarterPlayerStats = new Label();
            SmarterPlayerStats.Text = PlayersResults[IdSmartest].Split(':')[0] + " был самым умным. Он победил передвинув кости всего " + PlayersResults[IdFastest].Split(':')[2] + " Раз.";
            SmarterPlayerStats.Font = new Font("Microsoft Sans Serif", 10);
            SmarterPlayerStats.AutoSize = true;
            SmarterPlayerStats.Location = new Point(10, FasterPlayerStats.Location.Y + FasterPlayerStats.Size.Height + SmarterPlayerStats.Size.Height);
            LeaderboardForm.Controls.Add(SmarterPlayerStats);
            //////////////////////////////////////
            LeaderboardForm.Show();
        }

        

        private void Leaders(object sender, EventArgs e)
        {
            string Ids;
            if (!File.Exists("Leaderboard.txt"))
            {
                MessageBox.Show("Нужные файлы не найдены. Проверьте правильность установки программы."); 
                return;
            }
            PlayersResults = File.ReadAllLines("Leaderboard.txt");
            if (PlayersResults.Length != 0)
            {
                Ids = FindInArr();
            } else { MessageBox.Show("Рекордов пока нет."); Ids = "-1"; }
            if (Ids != "-1")
            {
                CreateLeaderboardForm(Convert.ToInt32(Ids.Split(':')[0]), Convert.ToInt32(Ids.Split(':')[1]));
            }
        }
        private string FindInArr()
        {
            int SmallestTime = 10000, IdSmallestTime = -1, SmallestMoves = 10000, IdSmallestMoves = -1;
            try
            {
                for (int i = 0; i < PlayersResults.Length; i++)
                {
                    if (Convert.ToInt32(PlayersResults[i].Split(':')[1]) < SmallestTime)
                    {
                        SmallestTime = Convert.ToInt32(PlayersResults[i].Split(':')[1]);
                        IdSmallestTime = i;
                    }
                    if (Convert.ToInt32(PlayersResults[i].Split(':')[2]) < SmallestMoves)
                    {
                        SmallestMoves = Convert.ToInt32(PlayersResults[i].Split(':')[2]);
                        IdSmallestMoves = i;
                    }
                }
                return Convert.ToString(IdSmallestTime) + ':' + Convert.ToString(IdSmallestMoves);
            }
            catch { MessageBox.Show("Файлы программы повреждены. Попробуйте переустановить программу."); return "-1"; }
        } 
    }
}