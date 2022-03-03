using System;
using System.Windows.Forms;
using System.Drawing;

namespace Prakt_2
{
    public partial class Programm : Form
    {
        int SecondsSpend, MoveCount;
        Button[] Dices; 
        public Programm() 
        {
            InitializeComponent();
            ChangePosition(new object(), new EventArgs()); //Расчитать позицию при старте
            Dices = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7, 
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 }; //Положить кнопки в массив
            StartGame(new object(), new EventArgs()); //Запустить игру
        }

        private void MoveDice(object sender, EventArgs e) //При нажатии на кнопку перемещает 
        {
            int ButtonPressedId = Array.IndexOf(Dices, sender as Button); //Индекс нажадой кнопки в массиве
            if (ButtonPressedId - 4 >= 0 && Dices[ButtonPressedId - 4].Text == "16") //Если кнопка ниже существует и равна 
            {
                Dices[ButtonPressedId - 4].Text = Dices[ButtonPressedId].Text; 
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId - 4].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            } else if (ButtonPressedId + 4 <= 15 && Dices[ButtonPressedId + 4].Text == "16")
            {
                Dices[ButtonPressedId + 4].Text = Dices[ButtonPressedId].Text;
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId + 4].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            if (ButtonPressedId % 4 != 0 && Dices[ButtonPressedId - 1].Text == "16") {
                Dices[ButtonPressedId - 1].Text = Dices[ButtonPressedId].Text;
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId - 1].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            } else if (ButtonPressedId % 4 != 3 && Dices[ButtonPressedId + 1].Text == "16")
            {
                Dices[ButtonPressedId + 1].Text = Dices[ButtonPressedId].Text;
                Dices[ButtonPressedId].Text = "16";
                Dices[ButtonPressedId + 1].Visible = true;
                Dices[ButtonPressedId].Visible = false;
                IncreaseMoveCount();
            }
            if (CheckWin()) {
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
        }

        private void TimeCount(object sender, EventArgs e) //Увиличить счетчик секунд
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
            }
        }
    }
}