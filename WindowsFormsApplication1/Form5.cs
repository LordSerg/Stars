using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        Random r = new Random();
        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer3.Interval = 100;
            timer3.Enabled = true;
            label12.Visible = false;
            label13.Visible = false;
        }
        int i,x,y;
        double t;
        private void Form5_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar.CompareTo('w') == 0)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y - 5);
            }
            if (e.KeyChar.CompareTo('s') == 0)
            {
                label1.Location = new Point(label1.Location.X, label1.Location.Y + 5);
            }
            if (e.KeyChar.CompareTo('d') == 0)
            {
                label1.Location = new Point(label1.Location.X + 5, label1.Location.Y);
            }
            if (e.KeyChar.CompareTo('a') == 0)
            {
                label1.Location = new Point(label1.Location.X - 5, label1.Location.Y);
            }

        }


        private void Form5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift.Equals(true)&&(timer1.Enabled==false))
            {   i = 0;
                x = label1.Location.X + (label1.Width) / 2;
                y = label1.Location.Y;
                timer1.Interval = 1;
                timer1.Enabled = true;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = false;
            label13.Visible = false;
            timer3.Enabled = true;
            t = 0;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label14.Text = t.ToString()+"s";
            t += 0.1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            if (y <this.Height)
            {
                g.DrawLine(Pens.Yellow, x, y, x, y + i+5);
                y += i;
                i++;
                g.DrawLine(Pens.Black, x, y, x, y + i);
            }
            else
                timer1.Enabled = false;
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (y > label2.Location.Y && x < label2.Location.X + label2.Width && x > label2.Location.X)
            {
                label2.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label3.Location.Y && x < label3.Location.X + label3.Width && x > label3.Location.X)
            {
                label3.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label4.Location.Y && x < label4.Location.X + label4.Width && x > label4.Location.X)
            {
                label4.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label5.Location.Y && x < label5.Location.X + label5.Width && x > label5.Location.X)
            {
                label5.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label6.Location.Y && x < label6.Location.X + label6.Width && x > label6.Location.X)
            {
                label6.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label7.Location.Y && x < label7.Location.X + label7.Width && x > label7.Location.X)
            {
                label7.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label8.Location.Y && x < label8.Location.X + label8.Width && x > label8.Location.X)
            {
                label8.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label9.Location.Y && x < label9.Location.X + label9.Width && x > label9.Location.X)
            {
                label9.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label10.Location.Y && x < label10.Location.X + label10.Width && x > label10.Location.X)
            {
                label10.Visible = false;
                timer1.Enabled = false;
            }
            if (y > label11.Location.Y && x < label11.Location.X + label11.Width && x > label11.Location.X)
            {
                label11.Visible = false;
                timer1.Enabled = false;
            }
            if (label2.Visible == false && label3.Visible == false && label4.Visible == false && label5.Visible == false && label6.Visible == false && label7.Visible == false && label8.Visible == false && label9.Visible == false && label10.Visible == false && label11.Visible == false)
            {
                Text = "YOU WON THIS GAME";
                label12.Visible = true;
                label13.Visible = true;
                timer3.Enabled = false;
            }
        }

    }
}
