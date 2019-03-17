namespace WindowsFormsApplication1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.glControl1 = new OpenTK.GLControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.на1кмсЗа10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьНа3кмсЗа50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на5кмсЗа100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.на10кмсЗа50ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьВыстрелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скоростьПерезарядкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.силуВыстрелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.лазерныйЩитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.механическийЩитToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // glControl1
            // 
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(724, 624);
            this.glControl1.TabIndex = 351;
            this.glControl1.VSync = false;
            this.glControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.glControl1_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.менюToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 352;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.скоростьВыстрелаToolStripMenuItem,
            this.скоростьПерезарядкиToolStripMenuItem,
            this.силуВыстрелаToolStripMenuItem,
            this.лазерныйЩитToolStripMenuItem,
            this.механическийЩитToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.toolStripMenuItem1.Text = "Улучшить...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.на1кмсЗа10ToolStripMenuItem,
            this.увеличитьНа3кмсЗа50ToolStripMenuItem,
            this.на5кмсЗа100ToolStripMenuItem,
            this.на10кмсЗа50ToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem4.Text = "Скорость самолета";
            // 
            // на1кмсЗа10ToolStripMenuItem
            // 
            this.на1кмсЗа10ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.на1кмсЗа10ToolStripMenuItem.Name = "на1кмсЗа10ToolStripMenuItem";
            this.на1кмсЗа10ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.на1кмсЗа10ToolStripMenuItem.Text = "на 1 (км/с) за 10()";
            // 
            // увеличитьНа3кмсЗа50ToolStripMenuItem
            // 
            this.увеличитьНа3кмсЗа50ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.увеличитьНа3кмсЗа50ToolStripMenuItem.Name = "увеличитьНа3кмсЗа50ToolStripMenuItem";
            this.увеличитьНа3кмсЗа50ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.увеличитьНа3кмсЗа50ToolStripMenuItem.Text = "на 3 (км/с) за 20()";
            // 
            // на5кмсЗа100ToolStripMenuItem
            // 
            this.на5кмсЗа100ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.на5кмсЗа100ToolStripMenuItem.Name = "на5кмсЗа100ToolStripMenuItem";
            this.на5кмсЗа100ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.на5кмсЗа100ToolStripMenuItem.Text = "на 5 (км/с) за 30()";
            // 
            // на10кмсЗа50ToolStripMenuItem
            // 
            this.на10кмсЗа50ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.на10кмсЗа50ToolStripMenuItem.Name = "на10кмсЗа50ToolStripMenuItem";
            this.на10кмсЗа50ToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.на10кмсЗа50ToolStripMenuItem.Text = "на 10 (км/с) за 50()";
            // 
            // скоростьВыстрелаToolStripMenuItem
            // 
            this.скоростьВыстрелаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.скоростьВыстрелаToolStripMenuItem.Name = "скоростьВыстрелаToolStripMenuItem";
            this.скоростьВыстрелаToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.скоростьВыстрелаToolStripMenuItem.Text = "Скорость выстрела";
            // 
            // скоростьПерезарядкиToolStripMenuItem
            // 
            this.скоростьПерезарядкиToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.скоростьПерезарядкиToolStripMenuItem.Name = "скоростьПерезарядкиToolStripMenuItem";
            this.скоростьПерезарядкиToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.скоростьПерезарядкиToolStripMenuItem.Text = "Скорость перезарядки";
            // 
            // силуВыстрелаToolStripMenuItem
            // 
            this.силуВыстрелаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.силуВыстрелаToolStripMenuItem.Name = "силуВыстрелаToolStripMenuItem";
            this.силуВыстрелаToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.силуВыстрелаToolStripMenuItem.Text = "Мощь выстрела";
            // 
            // лазерныйЩитToolStripMenuItem
            // 
            this.лазерныйЩитToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.лазерныйЩитToolStripMenuItem.Name = "лазерныйЩитToolStripMenuItem";
            this.лазерныйЩитToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.лазерныйЩитToolStripMenuItem.Text = "Лазерный щит";
            // 
            // механическийЩитToolStripMenuItem
            // 
            this.механическийЩитToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.механическийЩитToolStripMenuItem.Name = "механическийЩитToolStripMenuItem";
            this.механическийЩитToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.механическийЩитToolStripMenuItem.Text = "Механический щит";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = "Настройки";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(111, 20);
            this.toolStripMenuItem3.Text = "Остановить игру";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 622);
            this.ControlBox = false;
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem на1кмсЗа10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem увеличитьНа3кмсЗа50ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьПерезарядкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem силуВыстрелаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скоростьВыстрелаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на5кмсЗа100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem лазерныйЩитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem механическийЩитToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem на10кмсЗа50ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}