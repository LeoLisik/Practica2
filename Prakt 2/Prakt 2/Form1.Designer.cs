
namespace Prakt_2
{
    partial class Programm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Dice15 = new System.Windows.Forms.Button();
            this.Dice14 = new System.Windows.Forms.Button();
            this.Dice13 = new System.Windows.Forms.Button();
            this.Dice12 = new System.Windows.Forms.Button();
            this.Dice11 = new System.Windows.Forms.Button();
            this.Dice10 = new System.Windows.Forms.Button();
            this.Dice9 = new System.Windows.Forms.Button();
            this.Dice8 = new System.Windows.Forms.Button();
            this.Dice7 = new System.Windows.Forms.Button();
            this.Dice6 = new System.Windows.Forms.Button();
            this.Dice5 = new System.Windows.Forms.Button();
            this.Dice4 = new System.Windows.Forms.Button();
            this.Dice3 = new System.Windows.Forms.Button();
            this.Dice1 = new System.Windows.Forms.Button();
            this.Dice0 = new System.Windows.Forms.Button();
            this.Dice2 = new System.Windows.Forms.Button();
            this.GameMenu = new System.Windows.Forms.MenuStrip();
            this.ButtonStart = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLeaderboards = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonAccountExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LabelTimeSpend = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.GameMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Dice15, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dice14, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dice13, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dice12, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dice11, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dice10, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dice9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dice8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Dice7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dice6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dice5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dice4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Dice3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dice1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dice0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dice2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Dice15
            // 
            this.Dice15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice15.Location = new System.Drawing.Point(567, 318);
            this.Dice15.Name = "Dice15";
            this.Dice15.Size = new System.Drawing.Size(183, 101);
            this.Dice15.TabIndex = 15;
            this.Dice15.Text = "16";
            this.Dice15.UseVisualStyleBackColor = true;
            this.Dice15.Visible = false;
            this.Dice15.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice14
            // 
            this.Dice14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice14.Location = new System.Drawing.Point(379, 318);
            this.Dice14.Name = "Dice14";
            this.Dice14.Size = new System.Drawing.Size(182, 101);
            this.Dice14.TabIndex = 14;
            this.Dice14.Text = "15";
            this.Dice14.UseVisualStyleBackColor = true;
            this.Dice14.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice13
            // 
            this.Dice13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice13.Location = new System.Drawing.Point(191, 318);
            this.Dice13.Name = "Dice13";
            this.Dice13.Size = new System.Drawing.Size(182, 101);
            this.Dice13.TabIndex = 13;
            this.Dice13.Text = "14";
            this.Dice13.UseVisualStyleBackColor = true;
            this.Dice13.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice12
            // 
            this.Dice12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice12.Location = new System.Drawing.Point(3, 318);
            this.Dice12.Name = "Dice12";
            this.Dice12.Size = new System.Drawing.Size(182, 101);
            this.Dice12.TabIndex = 12;
            this.Dice12.Text = "13";
            this.Dice12.UseVisualStyleBackColor = true;
            this.Dice12.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice11
            // 
            this.Dice11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice11.Location = new System.Drawing.Point(567, 213);
            this.Dice11.Name = "Dice11";
            this.Dice11.Size = new System.Drawing.Size(183, 99);
            this.Dice11.TabIndex = 11;
            this.Dice11.Text = "12";
            this.Dice11.UseVisualStyleBackColor = true;
            this.Dice11.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice10
            // 
            this.Dice10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice10.Location = new System.Drawing.Point(379, 213);
            this.Dice10.Name = "Dice10";
            this.Dice10.Size = new System.Drawing.Size(182, 99);
            this.Dice10.TabIndex = 10;
            this.Dice10.Text = "11";
            this.Dice10.UseVisualStyleBackColor = true;
            this.Dice10.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice9
            // 
            this.Dice9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice9.Location = new System.Drawing.Point(191, 213);
            this.Dice9.Name = "Dice9";
            this.Dice9.Size = new System.Drawing.Size(182, 99);
            this.Dice9.TabIndex = 9;
            this.Dice9.Text = "10";
            this.Dice9.UseVisualStyleBackColor = true;
            this.Dice9.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice8
            // 
            this.Dice8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice8.Location = new System.Drawing.Point(3, 213);
            this.Dice8.Name = "Dice8";
            this.Dice8.Size = new System.Drawing.Size(182, 99);
            this.Dice8.TabIndex = 8;
            this.Dice8.Text = "9";
            this.Dice8.UseVisualStyleBackColor = true;
            this.Dice8.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice7
            // 
            this.Dice7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice7.Location = new System.Drawing.Point(567, 108);
            this.Dice7.Name = "Dice7";
            this.Dice7.Size = new System.Drawing.Size(183, 99);
            this.Dice7.TabIndex = 7;
            this.Dice7.Text = "8";
            this.Dice7.UseVisualStyleBackColor = true;
            this.Dice7.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice6
            // 
            this.Dice6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice6.Location = new System.Drawing.Point(379, 108);
            this.Dice6.Name = "Dice6";
            this.Dice6.Size = new System.Drawing.Size(182, 99);
            this.Dice6.TabIndex = 6;
            this.Dice6.Text = "7";
            this.Dice6.UseVisualStyleBackColor = true;
            this.Dice6.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice5
            // 
            this.Dice5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice5.Location = new System.Drawing.Point(191, 108);
            this.Dice5.Name = "Dice5";
            this.Dice5.Size = new System.Drawing.Size(182, 99);
            this.Dice5.TabIndex = 5;
            this.Dice5.Text = "6";
            this.Dice5.UseVisualStyleBackColor = true;
            this.Dice5.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice4
            // 
            this.Dice4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice4.Location = new System.Drawing.Point(3, 108);
            this.Dice4.Name = "Dice4";
            this.Dice4.Size = new System.Drawing.Size(182, 99);
            this.Dice4.TabIndex = 4;
            this.Dice4.Text = "5";
            this.Dice4.UseVisualStyleBackColor = true;
            this.Dice4.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice3
            // 
            this.Dice3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice3.Location = new System.Drawing.Point(567, 3);
            this.Dice3.Name = "Dice3";
            this.Dice3.Size = new System.Drawing.Size(183, 99);
            this.Dice3.TabIndex = 3;
            this.Dice3.Text = "4";
            this.Dice3.UseVisualStyleBackColor = true;
            this.Dice3.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice1
            // 
            this.Dice1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice1.Location = new System.Drawing.Point(191, 3);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(182, 99);
            this.Dice1.TabIndex = 2;
            this.Dice1.Text = "2";
            this.Dice1.UseVisualStyleBackColor = true;
            this.Dice1.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice0
            // 
            this.Dice0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice0.Location = new System.Drawing.Point(3, 3);
            this.Dice0.Name = "Dice0";
            this.Dice0.Size = new System.Drawing.Size(182, 99);
            this.Dice0.TabIndex = 1;
            this.Dice0.Text = "1";
            this.Dice0.UseVisualStyleBackColor = true;
            this.Dice0.Click += new System.EventHandler(this.MoveDice);
            // 
            // Dice2
            // 
            this.Dice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dice2.Location = new System.Drawing.Point(379, 3);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(182, 99);
            this.Dice2.TabIndex = 0;
            this.Dice2.Text = "3";
            this.Dice2.UseVisualStyleBackColor = true;
            this.Dice2.Click += new System.EventHandler(this.MoveDice);
            // 
            // GameMenu
            // 
            this.GameMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GameMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonStart,
            this.ButtonLeaderboards,
            this.ButtonAccountExit,
            this.ButtonExit});
            this.GameMenu.Location = new System.Drawing.Point(0, 0);
            this.GameMenu.Name = "GameMenu";
            this.GameMenu.Size = new System.Drawing.Size(753, 28);
            this.GameMenu.TabIndex = 1;
            this.GameMenu.Text = "menuStrip1";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(72, 24);
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.Click += new System.EventHandler(this.StartGame);
            // 
            // ButtonLeaderboards
            // 
            this.ButtonLeaderboards.Name = "ButtonLeaderboards";
            this.ButtonLeaderboards.Size = new System.Drawing.Size(78, 24);
            this.ButtonLeaderboards.Text = "Лидеры";
            // 
            // ButtonAccountExit
            // 
            this.ButtonAccountExit.Name = "ButtonAccountExit";
            this.ButtonAccountExit.Size = new System.Drawing.Size(151, 24);
            this.ButtonAccountExit.Text = "Выйти из аккаунта";
            // 
            // ButtonExit
            // 
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(115, 24);
            this.ButtonExit.Text = "Закрыть игру";
            this.ButtonExit.Click += new System.EventHandler(this.ExitGame);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // LabelTimeSpend
            // 
            this.LabelTimeSpend.AutoSize = true;
            this.LabelTimeSpend.Location = new System.Drawing.Point(636, 8);
            this.LabelTimeSpend.Name = "LabelTimeSpend";
            this.LabelTimeSpend.Size = new System.Drawing.Size(105, 17);
            this.LabelTimeSpend.TabIndex = 2;
            this.LabelTimeSpend.Text = "Прошло: 0 Сек";
            // 
            // Programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.LabelTimeSpend);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GameMenu);
            this.MainMenuStrip = this.GameMenu;
            this.MinimumSize = new System.Drawing.Size(620, 300);
            this.Name = "Programm";
            this.Text = "Пятнашки";
            this.Resize += new System.EventHandler(this.Programm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.GameMenu.ResumeLayout(false);
            this.GameMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip GameMenu;
        private System.Windows.Forms.ToolStripMenuItem ButtonStart;
        private System.Windows.Forms.ToolStripMenuItem ButtonLeaderboards;
        private System.Windows.Forms.ToolStripMenuItem ButtonAccountExit;
        private System.Windows.Forms.Button Dice15;
        private System.Windows.Forms.Button Dice14;
        private System.Windows.Forms.Button Dice13;
        private System.Windows.Forms.Button Dice12;
        private System.Windows.Forms.Button Dice11;
        private System.Windows.Forms.Button Dice10;
        private System.Windows.Forms.Button Dice9;
        private System.Windows.Forms.Button Dice8;
        private System.Windows.Forms.Button Dice7;
        private System.Windows.Forms.Button Dice6;
        private System.Windows.Forms.Button Dice5;
        private System.Windows.Forms.Button Dice4;
        private System.Windows.Forms.Button Dice3;
        private System.Windows.Forms.Button Dice1;
        private System.Windows.Forms.Button Dice0;
        private System.Windows.Forms.Button Dice2;
        private System.Windows.Forms.ToolStripMenuItem ButtonExit;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LabelTimeSpend;
    }
}

