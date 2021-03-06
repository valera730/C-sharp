﻿namespace Tetris
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьЗановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitF10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.labelRecord = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(321, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.label2.Location = new System.Drawing.Point(321, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьЗановоToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.exitF10ToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.менюToolStripMenuItem.Text = "Menu";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            this.начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            this.начатьЗановоToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.начатьЗановоToolStripMenuItem.Text = "New game (F2)";
            this.начатьЗановоToolStripMenuItem.Click += new System.EventHandler(this.OnAgainButtonClick);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.паузаToolStripMenuItem.Text = "Pause";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.OnPauseButtonClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.справкаToolStripMenuItem.Text = "Help";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.OnInfoPressed);
            // 
            // exitF10ToolStripMenuItem
            // 
            this.exitF10ToolStripMenuItem.Name = "exitF10ToolStripMenuItem";
            this.exitF10ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.exitF10ToolStripMenuItem.Text = "Exit (F10)";
            this.exitF10ToolStripMenuItem.Click += new System.EventHandler(this.OnExitPressed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.Location = new System.Drawing.Point(43, 172);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(215, 73);
            this.labelPause.TabIndex = 4;
            this.labelPause.Text = "Pause";
            this.labelPause.Visible = false;
            this.labelPause.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelRecord
            // 
            this.labelRecord.AutoSize = true;
            this.labelRecord.Location = new System.Drawing.Point(326, 279);
            this.labelRecord.Name = "labelRecord";
            this.labelRecord.Size = new System.Drawing.Size(35, 13);
            this.labelRecord.TabIndex = 5;
            this.labelRecord.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.labelRecord);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitF10ToolStripMenuItem;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Label labelRecord;
    }
}