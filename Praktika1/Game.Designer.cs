
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
            this.ExitButton.Location = new System.Drawing.Point(24, 181);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 28);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CleanButton
            // 
            this.CleanButton.Location = new System.Drawing.Point(24, 131);
            this.CleanButton.Margin = new System.Windows.Forms.Padding(4);
            this.CleanButton.Name = "CleanButton";
            this.CleanButton.Size = new System.Drawing.Size(100, 28);
            this.CleanButton.TabIndex = 3;
            this.CleanButton.Text = "Очистка";
            this.CleanButton.UseVisualStyleBackColor = true;
            this.CleanButton.Click += new System.EventHandler(this.ClearColors);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(24, 80);
            this.PauseButton.Margin = new System.Windows.Forms.Padding(4);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(100, 28);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Остановить";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseClick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(24, 30);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(100, 28);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // GamePlace
            // 
            this.GamePlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GamePlace.Location = new System.Drawing.Point(148, 0);
            this.GamePlace.Margin = new System.Windows.Forms.Padding(4);
            this.GamePlace.Name = "GamePlace";
            this.GamePlace.Size = new System.Drawing.Size(934, 682);
            this.GamePlace.TabIndex = 0;
            this.GamePlace.TabStop = false;
            this.GamePlace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PrintColor);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 683);
            this.Controls.Add(this.GamePlace);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CleanButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Game";
            this.Text = "Игра \"Жизнь\"";
            this.Resize += new System.EventHandler(this.ChangePosition);
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

