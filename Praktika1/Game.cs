using System;
using System.Drawing;
using System.Windows.Forms;

namespace Praktika11
{
    public partial class Game : Form
    {
        private Graphics Grafica;  
        private int CellSize = 10;  
        private bool[,] RedCells;  
        private bool[,] BlueCells; 
        private int Rows; 
        private int Columns; 

        public Game() //создание формы
        {
            InitializeComponent();
            ChangePosition(new object(), new EventArgs());
        }

        private void StartGame()  //При начале игры запустить таймер
        {
            if (Timer.Enabled)
            {
                return;
            }
            Timer.Start();  
        }
        private int CountNeighbors(int x, int y, bool[,] a)  //Подсчет кол-ва соседей клетки
        {
            int CountNeighbors = 0;  
            for (int i = -1; i < 2; i++)  //В циклах обрабатываем всех соседей
            {
                for (int j = -1; j < 2; j++)
                {
                    int NeighboringCol = (x + i + Columns) % Columns; //Нахождение соседних столбцов
                    int NeighboringRow = (y + j + Rows) % Rows; //Нахождение соседних строк
                    bool Samoproverka = NeighboringCol == x && NeighboringRow == y; //является ли проверка соседа самопроверкой
                    bool IsAlive = a[NeighboringCol, NeighboringRow];
                    if (IsAlive && !Samoproverka)  //Если клетка имеет жизнь и не самопроверка, увеличить кол-во соседей
                    {
                        CountNeighbors++; 
                    }
                }
            }
            return CountNeighbors;
        }
        private void NextGeneration()  //Просчет следующего поколения
        {
            Grafica.Clear(Color.White);  //Очистить поле
            var NewRedCells = new bool[Columns, Rows];
            var NewBlueCells = new bool[Columns, Rows];
            for (int x = 0; x < Columns; x++)  //2 цикла for для прохода по всем клеткам массивов 
            {
                for (int y = 0; y < Rows; y++)
                {
                    int NeighborsRed = CountNeighbors(x, y, RedCells);
                    bool IsAliveRed = RedCells[x, y];  
                    int NeighborsBlue = CountNeighbors(x, y, BlueCells); 
                    bool IsAliveBlue = BlueCells[x, y]; 
                    if (IsAliveRed && !IsAliveBlue && NeighborsBlue == 3) //если синяя клетка появляется там, где жива красная
                    {
                        NewRedCells[x, y] = true; 
                        NewBlueCells[x, y] = false; 
                        Grafica.FillRectangle(Brushes.Blue, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                        continue; 
                    }
                    if (IsAliveBlue && !IsAliveRed && NeighborsRed == 3)  //если красная клетка появляется там, где жива синяя 
                    {
                        NewBlueCells[x, y] = true;  
                        NewRedCells[x, y] = false;  
                        Grafica.FillRectangle(Brushes.Red, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                        continue;  
                    }
                    if ((!IsAliveRed && !IsAliveBlue) && (NeighborsRed == 3 && NeighborsBlue == 3))  //если синяя и красная на пустой
                    {
                        NewBlueCells[x, y] = true;  
                        Grafica.FillRectangle(Brushes.Red, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                        continue; 
                    }
                    if (!IsAliveRed && NeighborsRed == 3)  //если клетка пуста и 3 соседа красных 
                    {
                        NewRedCells[x, y] = true; 
                    }
                    else if (IsAliveRed && (NeighborsRed < 2 || NeighborsRed > 3)) //если красная жива и рядом меньше 2 или больше 3 соседей
                    {
                        NewRedCells[x, y] = false; 
                    }
                    else //Если ни одно условие не сработало, клетка остаётся такой же
                    {
                        NewRedCells[x, y] = RedCells[x, y];
                    }
                    if (!IsAliveBlue && NeighborsBlue == 3) //если клетка пуста и имеет 3 соседа синих
                    {
                        NewBlueCells[x, y] = true; 
                    }
                    else if (IsAliveBlue && (NeighborsBlue < 2 || NeighborsBlue > 3))  //если синяя клетка жива и рядом меньше 2 или больше 3 соседей
                    {
                        NewBlueCells[x, y] = false;
                    }
                    else //Если ни одно условие не сработало, клетка остаётся такой же
                    {
                        NewBlueCells[x, y] = BlueCells[x, y];
                    }
                    if (NewRedCells[x, y])  //Если клетка по координатам красная, то покрасить клетку
                    {
                        Grafica.FillRectangle(Brushes.Red, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                    else if (NewBlueCells[x, y])  //Если клетка по координатам синяя, то покрасить клетку
                    {
                        Grafica.FillRectangle(Brushes.Blue, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                }
            }
            RedCells = NewRedCells; //Новые поколения становятся текущими
            BlueCells = NewBlueCells;  
            GamePlace.Refresh();  //Отрисовываются изменения
        }
        private void TimerTick(object sender, EventArgs e)  //Каждый тик расчитывать новое поколение
        {
            NextGeneration(); 
        }
        private void PauseClick(object sender, EventArgs e)  //Пауза
        {
            Timer.Enabled = !Timer.Enabled;
        }
        private void PrintColor(object sender, MouseEventArgs e)  //Закрасить клетку
        {
            if (Timer.Enabled)  //Если таймер включен, то рисовать нельзя
            {
                return;
            }
            int x = e.Location.X / CellSize;  //координаты клика
            int y = e.Location.Y / CellSize;  

            if (ClickPositionCheck(x, y))  //если координата клетки в пределах поля
            {
                if (e.Button == MouseButtons.Left)  //если нажата ЛКМ
                {
                    if (RedCells[x, y])  //если клетка уже существует - стереть
                    {
                        RedCells[x, y] = false;  
                        Grafica.FillRectangle(Brushes.White, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                    else  //если клетки ещё не существует - создать
                    {
                        RedCells[x, y] = true;  
                        Grafica.FillRectangle(Brushes.Red, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                }
                if (e.Button == MouseButtons.Right)  //если нажата ПКМ
                {
                    if (BlueCells[x, y])  //если клетка уже существует - стереть
                    {
                        BlueCells[x, y] = false; 
                        Grafica.FillRectangle(Brushes.White, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                    else  //если клетки ещё не существует - создать
                    {
                        BlueCells[x, y] = true;
                        Grafica.FillRectangle(Brushes.Blue, x * CellSize, y * CellSize, CellSize - 1, CellSize - 1);
                    }
                }
            }
            GamePlace.Refresh();  //Отобразить изменения
        }
        private bool ClickPositionCheck(int x, int y)  //Проверка нахождение клика в границах поля
        {
            return x >= 0 && y >= 0 && x < Columns && y < Rows;  
        }
        private void Start_Click(object sender, EventArgs e) //Запустить игру при нажатии кнопки
        {
            StartGame(); 
        }
        private void Exit_Click(object sender, EventArgs e) //Закрыть приложение
        {
            Application.Exit(); 
        }
        private void ChangePosition(object sender, EventArgs e)
        {
            Rows = GamePlace.Height / CellSize; 
            Columns = GamePlace.Width / CellSize; 
            RedCells = new bool[Columns, Rows];  //Инициализируем новый размер массивов для 2-х цветов
            BlueCells = new bool[Columns, Rows];
            GamePlace.Image = new Bitmap(GamePlace.Width, GamePlace.Height);  //Создаём сетку игры 
            Grafica = Graphics.FromImage(GamePlace.Image);  //Переносим сетку в изображение
            Grafica.Clear(Color.White);  //Заполняем графику белым цветом
        }
        private void ClearColors(object sender, EventArgs e)
        {
            Timer.Enabled = false;  //остановить таймер
            GamePlace.Image = new Bitmap(GamePlace.Width, GamePlace.Height);  //Создать новое поле 
            Grafica = Graphics.FromImage(GamePlace.Image);  //Инициализировать переменную Grafica полем 
            Grafica.Clear(Color.White);  //заполнение поля белым цветом
            for (int i = 0; i < Columns; i++)  //В двойном цикле пройтись по всему массиву и очистить его.
            {
                for (int j = 0; j < Rows; j++) 
                {
                   RedCells[i, j] = false; 
                   BlueCells[i, j] = false; 
                }
            }
        }
    }
}
