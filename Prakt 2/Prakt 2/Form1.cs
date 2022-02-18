using System;
using System.Windows.Forms;
using System.Drawing;
using BCrypt;

namespace Prakt_2
{
    public partial class Programm : Form
    {
        int SecondsSpend;
        public Programm()
        {
            InitializeComponent();
            Programm_Resize(new object(), new EventArgs());
        }

        void MoveDice(object sender, EventArgs e)
        {
            Button[] buttons = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7,
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 };
            int ButtonPressedId = Array.IndexOf(buttons, sender as Button);
            if (ButtonPressedId - 4 >= 0 && buttons[ButtonPressedId - 4].Text == "16")
            {
                buttons[ButtonPressedId - 4].Text = buttons[ButtonPressedId].Text; 
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId - 4].Visible = true;
                buttons[ButtonPressedId].Visible = false;
            } else if (ButtonPressedId + 4 <= 15 && buttons[ButtonPressedId + 4].Text == "16")
            {
                buttons[ButtonPressedId + 4].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId + 4].Visible = true;
                buttons[ButtonPressedId].Visible = false;
            }
            if (ButtonPressedId % 4 != 0 && buttons[ButtonPressedId - 1].Text == "16") {
                buttons[ButtonPressedId - 1].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId - 1].Visible = true;
                buttons[ButtonPressedId].Visible = false;
            } else if (ButtonPressedId % 4 != 3 && buttons[ButtonPressedId + 1].Text == "16")
            {
                buttons[ButtonPressedId + 1].Text = buttons[ButtonPressedId].Text;
                buttons[ButtonPressedId].Text = "16";
                buttons[ButtonPressedId + 1].Visible = true;
                buttons[ButtonPressedId].Visible = false;
            }
            if (CheckWin()) { MessageBox.Show("You win"); }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            SecondsSpend++;
            if (SecondsSpend % 10 == 0) { Programm_Resize(new object(), new EventArgs()); }
            LabelTimeSpend.Text = "Прошло: " + Convert.ToString(SecondsSpend) + " Сек";
        }

        private void RandomizeDice()
        {
            Button[] buttons = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7,
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 };
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
            Button[] buttons = new Button[] { Dice0, Dice1, Dice2, Dice3, Dice4, Dice5, Dice6, Dice7,
                Dice8, Dice9, Dice10, Dice11, Dice12, Dice13, Dice14, Dice15 };
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
            SecondsSpend = 0;
            LabelTimeSpend.Text = "Прошло: 0 Сек";
        }

        private void ExitGame(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Programm_Resize(object sender, EventArgs e)
        {
            LabelTimeSpend.Location = new Point(this.Width - (LabelTimeSpend.Size.Width + (LabelTimeSpend.Size.Width / 2)), 8);
        }
    }
}
