namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.New_game = new System.Windows.Forms.Button();
            this.Load_game = new System.Windows.Forms.Button();
            this.Control = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Choose_the_game = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.free_game = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // New_game
            // 
            this.New_game.BackColor = System.Drawing.Color.White;
            this.New_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.New_game.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.New_game.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.New_game.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_game.Location = new System.Drawing.Point(12, 216);
            this.New_game.Name = "New_game";
            this.New_game.Size = new System.Drawing.Size(157, 62);
            this.New_game.TabIndex = 0;
            this.New_game.TabStop = false;
            this.New_game.Text = "New game";
            this.New_game.UseVisualStyleBackColor = false;
            this.New_game.Click += new System.EventHandler(this.button1_Click);
            // 
            // Load_game
            // 
            this.Load_game.BackColor = System.Drawing.Color.White;
            this.Load_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Load_game.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Load_game.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Load_game.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_game.Location = new System.Drawing.Point(12, 284);
            this.Load_game.Name = "Load_game";
            this.Load_game.Size = new System.Drawing.Size(157, 62);
            this.Load_game.TabIndex = 1;
            this.Load_game.TabStop = false;
            this.Load_game.Text = "Load game";
            this.Load_game.UseVisualStyleBackColor = false;
            this.Load_game.Click += new System.EventHandler(this.button2_Click);
            // 
            // Control
            // 
            this.Control.BackColor = System.Drawing.Color.White;
            this.Control.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Control.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Control.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Control.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Control.Location = new System.Drawing.Point(12, 352);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(157, 62);
            this.Control.TabIndex = 2;
            this.Control.TabStop = false;
            this.Control.Text = "How to play";
            this.Control.UseVisualStyleBackColor = false;
            this.Control.Click += new System.EventHandler(this.Control_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Exit.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 420);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(157, 62);
            this.Exit.TabIndex = 3;
            this.Exit.TabStop = false;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Choose_the_game
            // 
            this.Choose_the_game.BackColor = System.Drawing.Color.White;
            this.Choose_the_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Choose_the_game.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Choose_the_game.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Choose_the_game.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_the_game.Location = new System.Drawing.Point(12, 12);
            this.Choose_the_game.Name = "Choose_the_game";
            this.Choose_the_game.Size = new System.Drawing.Size(157, 62);
            this.Choose_the_game.TabIndex = 5;
            this.Choose_the_game.TabStop = false;
            this.Choose_the_game.Text = "Choose the game";
            this.Choose_the_game.UseVisualStyleBackColor = false;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Back.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(12, 80);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(157, 62);
            this.Back.TabIndex = 6;
            this.Back.TabStop = false;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(175, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 188);
            this.listBox1.TabIndex = 7;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // free_game
            // 
            this.free_game.BackColor = System.Drawing.Color.White;
            this.free_game.Cursor = System.Windows.Forms.Cursors.Hand;
            this.free_game.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.free_game.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.free_game.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.free_game.Location = new System.Drawing.Point(12, 148);
            this.free_game.Name = "free_game";
            this.free_game.Size = new System.Drawing.Size(157, 62);
            this.free_game.TabIndex = 8;
            this.free_game.TabStop = false;
            this.free_game.Text = "Free game";
            this.free_game.UseVisualStyleBackColor = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 532);
            this.ControlBox = false;
            this.Controls.Add(this.free_game);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Choose_the_game);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Load_game);
            this.Controls.Add(this.New_game);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_game;
        private System.Windows.Forms.Button Load_game;
        private System.Windows.Forms.Button Control;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Choose_the_game;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button free_game;
        private System.Windows.Forms.Timer timer3;
    }
}

