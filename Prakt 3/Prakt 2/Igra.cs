using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Prakt_2
{
    public partial class Programm : Form
    {
        private int SecondsSpend, MoveCount;
        private Button[] Dices;
        private string[] PlayersResults, SortPlayerResults;
        private Form AccountForm, LeaderboardForm;

        public Programm()
        {
            InitializeComponent();
            ChangePosition(new object(), new EventArgs()); //Расчитать позицию при старте
            Dices = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7,
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 }; //Положить кнопки в массив
            AccountMenu(new object(), new EventArgs()); //Запустить авторизацию
        }

        private void MoveDice(object sender, EventArgs e) //При нажатии на кнопку перемещает 
        {
            int ButtonPressedId = Array.IndexOf(Dices, sender as Button); //Индекс нажадой кнопки в массиве
            if (ButtonPressedId - 4 >= 0 && Dices[ButtonPressedId - 4].Text == "16") //Если кнопка ниже существует и её значение 16
            {
                Dices[ButtonPressedId - 4].Text = Dices[ButtonPressedId].Text; //Поменять значения
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId - 4].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            else if (ButtonPressedId + 4 <= 15 && Dices[ButtonPressedId + 4].Text == "16") //Если кнопка выше существует
            {
                Dices[ButtonPressedId + 4].Text = Dices[ButtonPressedId].Text; //Поменять значения
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId + 4].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            if (ButtonPressedId % 4 != 0 && Dices[ButtonPressedId - 1].Text == "16") //Если кнопка слева в том же ряду
            {
                Dices[ButtonPressedId - 1].Text = Dices[ButtonPressedId].Text; //Поменять значения
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId - 1].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            else if (ButtonPressedId % 4 != 3 && Dices[ButtonPressedId + 1].Text == "16") //Если кнопка справа в том же ряду
            {
                Dices[ButtonPressedId + 1].Text = Dices[ButtonPressedId].Text; //Поменять значения
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId + 1].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            if (CheckWin())
            { //Если условия победы выполнены
                Win();
            }
        }

        private void IncreaseMoveCount() //Увеличить счетчик ходов
        {
            MoveCount++;
            LabelMoveCount.Text = "Передвинуто цифр: " + MoveCount;
        }

        private void Win() //Выключаем наличие кнопок, таймер и выводим сообщение о победе
        {
            foreach (Button Buff in Dices)
            {
                Buff.Enabled = false;
            }
            Timer.Enabled = false;
            MessageBox.Show("Ты выиграл!");
            if (Data.Value != null && File.Exists("Leaderboard.txt")) //Если имя пользователя не null и файл лидеров существует
            {
                string[] Leaders = File.ReadAllLines("Leaderboard.txt");
                try
                {
                    for (int i = 0; i < Leaders.Length; i++) //Перебрать все строчки в лидерах
                    {
                        if (Data.Value == Leaders[i].Split(':')[0] && SecondsSpend < Convert.ToInt32(Leaders[i].Split(':')[1])) //Если имя совпадёт с текущим пользователем и счет лучше - перезаписать
                        {
                            Leaders[i] = Data.Value + ':' + SecondsSpend + ':' + MoveCount; 
                            File.WriteAllLines("Leaderboard.txt", Leaders);
                            MessageBox.Show("Твой результат обновлён!");
                            return;
                        } else if (Data.Value == Leaders[i].Split(':')[0])
                        {
                            return;
                        }
                    }
                    StreamWriter sw = new StreamWriter("Leaderboard.txt", true); //Если записей этого пользователя нет, то записать рекорд
                    sw.WriteLine(Data.Value + ':' + SecondsSpend + ':' + MoveCount);
                    sw.Close();
                    MessageBox.Show("Твой результат был записан в рекорды.");
                } catch { MessageBox.Show("Файлы программы повреждены. Попробуйте переустановить программу."); }
            } else { MessageBox.Show("Для записи рекордов зарегистрируйся.\nЕсли по прежнему появляется это сообщение - переустанови программу."); }
        }

        private void TimeCount(object sender, EventArgs e) //Увеличить счетчик секунд
        {
            SecondsSpend++;
            if (SecondsSpend % 10 == 0) { ChangePosition(new object(), new EventArgs()); }
            LabelTimeSpend.Text = "Прошло: " + Convert.ToString(SecondsSpend) + " Сек";
        }

        private void RandomizeDice() //Размешать кнопки
        {
            Random Rnd = new Random();
            int FirstButtonId, LastButtonId;
            string Buff;
            for (int i = 0; i < 50; i++) //50 раз обменять случайные кнопки значениями
            {
                FirstButtonId = Rnd.Next() % 16;
                LastButtonId = Rnd.Next() % 16;
                Buff = Dices[FirstButtonId].Text;
                Dices[FirstButtonId].Text = Dices[LastButtonId].Text;
                Dices[LastButtonId].Text = Buff;
            }
            foreach (Button buff in Dices) //Выключить кнопку 16, остальные включить
            {
                if (buff.Text == "16") { buff.Visible = false; }
                else { buff.Visible = true; }
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 16; i++) //Проверка чисел в кнопках на соответствие победе
            {
                if (Convert.ToInt32(Dices[i].Text) != i + 1) { return false; }
            }
            return true;
        }

        private void StartGame(object sender, EventArgs e) //При начале игры размешать кнопки, включить таймер и сбросить значения.
        {
            RandomizeDice();
            Timer.Enabled = true;
            LabelTimeSpend.Text = "Прошло: 0 Сек";
            LabelMoveCount.Text = "Передвинуто цифр: 0";
            SecondsSpend = 0;
            MoveCount = 0;
            ButtonPause.Enabled = true; //Активировать кнопку паузы
            foreach (Button Buff in Dices) //Включить все кнопки игры
            {
                Buff.Enabled = true;
            }
        }

        private void Help(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.logozavr.ru/1640/"); //Открыть сайт с правилами
        }

        private void PauseGame(object sender, EventArgs e) //При паузе остановить таймер, выключить кнопки,
                                                           //изменить видимость таблицы с кнопками и создать надпись о паузе. 
                                                           //При снятии с паузы происходит обратное.
        {
            Timer.Enabled = !Timer.Enabled;
            foreach (Button Buff in Dices)
            {
                Buff.Enabled = !Buff.Enabled;
            }
            TableMacket.Visible = !TableMacket.Visible;
            Label PauseText = new Label();
            PauseText.AutoSize = true;
            PauseText.Font = new Font("Sans-serif", 11);
            PauseText.Text = "Игра на паузе. Нажмите P для продолжения...";
            PauseText.Location = new Point(this.Width / 2 - PauseText.Size.Width, this.Height / 2);
            this.Controls.Add(PauseText);
        }

        private void ExitGame(object sender, EventArgs e) //Закрыть приложение
        {
            Application.Exit();
        }

        private void ChangePosition(object sender, EventArgs e) //Перерасчитать позиции элементов
        {
            LabelTimeSpend.Location = new Point(this.Width - (LabelTimeSpend.Size.Width + (LabelTimeSpend.Size.Width / 2)), 8);
            LabelMoveCount.Location = new Point(LabelTimeSpend.Location.X - LabelMoveCount.Size.Width, LabelTimeSpend.Location.Y);
        }

        private void KeyInputListener(object sender, KeyEventArgs e) //Слушаем ввод и запускаем соотв. функции
        {
            if (e.KeyValue == 'P' && ButtonPause.Enabled) { PauseGame(new object(), new EventArgs()); }
            if (e.KeyValue == 'W')
            {
                for (int i = 0; i < 16; i++)
                {
                    Dices[i].Text = Convert.ToString(i + 1);
                }
                foreach (Button buff in Dices) //Выключить кнопку 16, остальные включить
                {
                    if (buff.Text == "16") { buff.Visible = false; }
                    else { buff.Visible = true; }
                }
            }
        }

        private void AccountMenu(object sender, EventArgs e)
        {
            if (Dices[15].Enabled == true)
            {
                PauseGame(new object(), new EventArgs());
            }
            AccountForm = new AuthorizeForm();
            AccountForm.ShowDialog();
        }

        private void CreateLeaderboardForm(int IdFastest, int IdSmartest)
        {
            LeaderboardForm = new Form();
            LeaderboardForm.Text = "Рекорды";
            LeaderboardForm.Name = "LeaderboardForm";
            LeaderboardForm.Size = new Size(500, 500);
            if (File.Exists("Fifteen.ico"))
            {
                LeaderboardForm.Icon = new Icon("Fifteen.ico");
            } else
            {
                MessageBox.Show("Файлы программы повреждены!");
                return;
            }
            LeaderboardForm.BackColor = SystemColors.AppWorkspace;
            LeaderboardForm.AutoScroll = true;
            LeaderboardForm.MaximumSize = new Size(LeaderboardForm.Size.Width + 200, 1080);
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
            SmarterPlayerStats.Text = PlayersResults[IdSmartest].Split(':')[0] + " был самым умным. Он победил передвинув кости всего " + PlayersResults[IdSmartest].Split(':')[2] + " Раз.";
            SmarterPlayerStats.Font = new Font("Microsoft Sans Serif", 10);
            SmarterPlayerStats.AutoSize = true;
            SmarterPlayerStats.Location = new Point(10, FasterPlayerStats.Location.Y + FasterPlayerStats.Size.Height + SmarterPlayerStats.Size.Height);
            LeaderboardForm.Controls.Add(SmarterPlayerStats);
            //////////////////////////////////////
            Label StatisticLegend = new Label();
            StatisticLegend.Text = "Имя  Время  Количество ходов";
            StatisticLegend.Font = new Font("Microsoft Sans Serif", 12);
            StatisticLegend.AutoSize = true;
            StatisticLegend.Location = new Point(10, SmarterPlayerStats.Location.Y + SmarterPlayerStats.Size.Height + StatisticLegend.Size.Height / 2);
            LeaderboardForm.Controls.Add(StatisticLegend);
            //////////////////////////////////////
            SortLeaders();
            Label[] StatsLabels = new Label[SortPlayerResults.Length];
            for (int i = 0; i < SortPlayerResults.Length; i++)
            {
                StatsLabels[i] = new Label();
                StatsLabels[i].Text = SortPlayerResults[i].Split(':')[0] + "  " + SortPlayerResults[i].Split(':')[1] + " сек. " + SortPlayerResults[i].Split(':')[2] + " ходов.";
                StatsLabels[i].Font = new Font("Microsoft Sans Serif", 10);
                StatsLabels[i].AutoSize = true;
                StatsLabels[i].Location = new Point(10, StatisticLegend.Location.Y + StatisticLegend.Size.Height + StatsLabels[i].Size.Height * i);
                LeaderboardForm.Controls.Add(StatsLabels[i]);
            }
            //////////////////////////////////////
            LeaderboardForm.Show();
        }

        private void SortLeaders()
        {
            SortPlayerResults = File.ReadAllLines("Leaderboard.txt");
            string temp;
            for (int i = 0; i < SortPlayerResults.Length; i++)
            {
                for (int j = 0; j < SortPlayerResults.Length; j++)
                {
                    if (Convert.ToInt32(SortPlayerResults[i].Split(':')[1]) < Convert.ToInt32(SortPlayerResults[j].Split(':')[1]))
                    {
                        temp = SortPlayerResults[i];
                        SortPlayerResults[i] = SortPlayerResults[j];
                        SortPlayerResults[j] = temp;
                    }
                }
            }
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
            int SmallestTime, IdSmallestTime = -1, SmallestMoves, IdSmallestMoves = -1;
            try
            {
                SmallestTime = Convert.ToInt32(PlayersResults[0].Split(':')[1]);
                SmallestMoves = Convert.ToInt32(PlayersResults[0].Split(':')[2]);
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