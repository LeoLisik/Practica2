
namespace Praktika11
{
    partial class Game
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.CleanButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.GamePlace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GamePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(18, 147);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(18, 106);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(75, 23);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Очистка";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.ClearColors);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(18, 65);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(75, 23);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Остановить";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseClick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(18, 24);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start);
            // 
            // GamePlace
            // 
            this.GamePlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GamePlace.Location = new System.Drawing.Point(111, 0);
            this.GamePlace.Name = "GamePlace";
            this.GamePlace.Size = new System.Drawing.Size(700, 554);
            this.GamePlace.TabIndex = 0;
            this.GamePlace.TabStop = false;
            this.GamePlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrintColor);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 555);
            this.Controls.Add(this.GamePlace);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Game";
            this.Text = "Игра \"Жизнь\"";
            ((System.ComponentModel.ISupportInitialize)(this.GamePlace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CleanButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.PictureBox GamePlace;
    }
}

