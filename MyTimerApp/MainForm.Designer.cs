
namespace MyTimerApp
{
    partial class MainForm
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
            this.startPauseButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMinutesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаПредыдущихРезультатовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startPauseButton
            // 
            this.startPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startPauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startPauseButton.Location = new System.Drawing.Point(12, 97);
            this.startPauseButton.Name = "startPauseButton";
            this.startPauseButton.Size = new System.Drawing.Size(96, 36);
            this.startPauseButton.TabIndex = 0;
            this.startPauseButton.Text = "Старт/Пауза";
            this.startPauseButton.UseVisualStyleBackColor = true;
            this.startPauseButton.Click += new System.EventHandler(this.StartPauseButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(182, 97);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 36);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.ForeColor = System.Drawing.Color.Black;
            this.timerLabel.Location = new System.Drawing.Point(12, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(260, 76);
            this.timerLabel.TabIndex = 2;
            this.timerLabel.Text = "0:00:00";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMinutesMenuItem,
            this.saveTimeToolStripMenuItem,
            this.таблицаПредыдущихРезультатовToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(264, 92);
            // 
            // AddMinutesMenuItem
            // 
            this.AddMinutesMenuItem.Name = "AddMinutesMenuItem";
            this.AddMinutesMenuItem.Size = new System.Drawing.Size(263, 22);
            this.AddMinutesMenuItem.Text = "Добавить время";
            this.AddMinutesMenuItem.Click += new System.EventHandler(this.AddMinutesMenuItem_Click);
            // 
            // saveTimeToolStripMenuItem
            // 
            this.saveTimeToolStripMenuItem.Name = "saveTimeToolStripMenuItem";
            this.saveTimeToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.saveTimeToolStripMenuItem.Text = "Сохранить время";
            this.saveTimeToolStripMenuItem.Click += new System.EventHandler(this.SaveTimeToolStripMenuItem_Click);
            // 
            // таблицаПредыдущихРезультатовToolStripMenuItem
            // 
            this.таблицаПредыдущихРезультатовToolStripMenuItem.Name = "таблицаПредыдущихРезультатовToolStripMenuItem";
            this.таблицаПредыдущихРезультатовToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.таблицаПредыдущихРезультатовToolStripMenuItem.Text = "Таблица предыдущих результатов";
            this.таблицаПредыдущихРезультатовToolStripMenuItem.Click += new System.EventHandler(this.PreviousResultsToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.startPauseButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(299, 151);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startPauseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таймер";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startPauseButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddMinutesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаПредыдущихРезультатовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTimeToolStripMenuItem;
    }
}

