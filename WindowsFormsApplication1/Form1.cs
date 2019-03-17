using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

using System.Media;
using WMPLib;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x0=0, y0=0;
        int x, y,n=0;
        bool r, l, u, d;
        //new game
        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = !timer1.Enabled;
            Choose_the_game.Visible = false;
            Exit.Visible = true;
            Control.Visible = true;
            Load_game.Visible = true;
            New_game.Visible = true;
            free_game.Visible = false;
            Back.Location = new Point(525, 160);
            Back.Visible = true;
        }
        //Exit
        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show.BackColor=Color.Red;
            //.BackColor = Color.Red;
            this.Refresh();
            n = 1;
            DialogResult result = MessageBox.Show("Do you realy want to exit?", "Exit",MessageBoxButtons.OKCancel);
            //MessageBoxButtons 
            //Control.MousePosition(0,0);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                this.Refresh();
                n = 0;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Mouse.Hide();
            //mousePath = new System.Drawing.Drawing2D.GraphicsPath();
            int p_y = 240;
            //1
            New_game.Location = new Point(525, p_y);
            New_game.BackColor = Color.LightBlue;
            //2
            Load_game.Location = new Point(525, p_y+60);
            Load_game.BackColor = Color.LightBlue;
            //3
            Control.Location = new Point(525, p_y+120);
            Control.BackColor = Color.LightBlue;
            //4
            Exit.Location = new Point(525, p_y+180);
            Exit.BackColor = Color.DeepPink;

            Choose_the_game.Visible = false;
            Choose_the_game.BackColor = Color.LightBlue;

            Back.Visible = false;
            Back.BackColor = Color.LightBlue;

            free_game.Visible = false;
            free_game.Location = new Point(525,160);

            listBox1.Visible = false;
            listBox1.BackColor = Color.LightGreen;

            timer2.Interval = 1;
            timer2.Enabled = true;

            timer1.Interval = 1;
            timer1.Enabled = true;

            //panel1.Visible = false;


            n = 0;

            r = false;
            l = false;
            u = false;
            d = false;                      

            this.BackColor = Color.Black;

            //Form7 F = new Form7();
            //F.Show();
            //this.Hide();

        }
        //load game
        private void button2_Click(object sender, EventArgs e)
        {
            this.Refresh();
            n = 2;
            Choose_the_game.Visible = true;
            Back.Visible = true;
            listBox1.Visible = true;
            Exit.Visible = false;
            Control.Visible = false;
            Load_game.Visible = false;
            New_game.Visible = false;
            free_game.Visible = false;
            Choose_the_game.Location = new Point(525, 340);
            Back.Location = new Point(525, 400);
            listBox1.Location = new Point(525, 160);

        }
        //back
        private void button6_Click(object sender, EventArgs e)
        {
            this.Refresh();
            n = 0;
            Choose_the_game.Visible = false;
            Back.Visible = false;
            Exit.Visible = true;
            Control.Visible = true;
            Load_game.Visible = true;
            New_game.Visible = true;
            free_game.Visible = false;
            //button1.Visible = false;
            //button2.Visible = false;
            //button3.Visible = false;
            //button4.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = true;
            //
            listBox1.Visible = false;
            //panel1.Visible = false;
        }
        //voises:
        public void on()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Windows\media\Speech On.wav");
            sound.Play();
        }
        public void off()
        {
            SoundPlayer sound = new SoundPlayer(@"C:\Windows\media\Speech Off.wav");
            sound.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer(@"D:\Сережа\mузыка\metallica-i_disappear.mp3");
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Graphics g = CreateGraphics();
            Random rx = new Random();
            Random ry = new Random();
            Point p=new Point(1000);
            Random r1 = new Random();
            Random r2 = new Random();
            Random r3 = new Random();
            Pen P = new Pen(Color.FromArgb(250, r1.Next(50), r2.Next(50, 150), r3.Next(150, 250)), 2);
            Pen P2 = new Pen(Color.Black,3);
            if (n == 0)
            {
                P = new Pen(Color.FromArgb(250, r1.Next(50), r2.Next(50, 150), r3.Next(150, 250)), 2);
            }
            if(n==1)
            {
                P = new Pen(Color.FromArgb(250, r1.Next(150,250), r2.Next(50), r3.Next(50)), 2);
            }
            if(n==2)
            {
                P = new Pen(Color.FromArgb(250, r1.Next(50), r2.Next(50,150), r3.Next(50,150)), 2);
            }
            if (n == 3)
            {
                P = new Pen(Color.FromArgb(250, r1.Next(50,150), r2.Next(150,250), r3.Next(50, 150)), 2);
            }
            for (int i = 0; i < 1000; i++)
            {
                p.X = rx.Next(1023);
                p.Y = ry.Next(1279);
            }
            g.DrawLine(P, x, y, x,y );
            if(y<1025)
            {
                g.DrawLine(P, x, y-50, 0, 0);
                g.DrawLine(P, x-50, y , 0, 0);
                g.DrawLine(P, x, y+50, 0, 1023);
                g.DrawLine(P, x-50, y, 0, 1023);
                g.DrawLine(P, x, y+50, 1279, 1023);
                g.DrawLine(P, x+50, y, 1279, 1023);
                g.DrawLine(P, x, y-50, 1279, 0);
                g.DrawLine(P, x+50, y, 1279, 0);
                g.DrawLine(P, x + 50, y - 50, 1279 / 2, 0);
                g.DrawLine(P, x - 50, y - 50, 1279 / 2, 0);
                g.DrawLine(P, x - 50, y - 50, 0, 1023 / 2);
                g.DrawLine(P, x - 50, y + 50, 0, 1023 / 2);
                g.DrawLine(P, x + 50, y - 50, 1279, 1023 / 2);
                g.DrawLine(P, x + 50, y + 50, 1279, 1023 / 2);
                g.DrawLine(P, x + 50, y + 50, 1279 / 2, 1023);
                g.DrawLine(P, x - 50, y + 50, 1279 / 2, 1023);

                //g.DrawLine(P2, x, y - 50, 0, 0);
                //g.DrawLine(P2, x - 50, y, 0, 0);
                //g.DrawLine(P2, x, y + 50, 0, 1023);
                //g.DrawLine(P2, x - 50, y, 0, 1023);
                //g.DrawLine(P2, x, y + 50, 1279, 1023);
                //g.DrawLine(P2, x + 50, y, 1279, 1023);
                //g.DrawLine(P2, x, y - 50, 1279, 0);
                //g.DrawLine(P2, x + 50, y, 1279, 0);
                //g.DrawLine(P2, x + 50, y - 50, 1279 / 2, 0);
                //g.DrawLine(P2, x - 50, y - 50, 1279 / 2, 0);
                //g.DrawLine(P2, x - 50, y - 50, 0, 1023 / 2);
                //g.DrawLine(P2, x - 50, y + 50, 0, 1023 / 2);
                //g.DrawLine(P2, x + 50, y - 50, 1279, 1023 / 2);
                //g.DrawLine(P2, x + 50, y + 50, 1279, 1023 / 2);
                //g.DrawLine(P2, x + 50, y + 50, 1279 / 2, 1023);
                //g.DrawLine(P2, x - 50, y + 50, 1279 / 2, 1023);
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = MousePosition.X;
            y = MousePosition.Y;
        }

        //how to play
        private void Control_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            this.Refresh();
            n = 3;
            Choose_the_game.Visible = false;
            Back.Location = new Point(10, 10);
            Back.Visible = true;
            listBox1.Visible = false;
            Exit.Visible = false;
            Control.Visible = false;
            Load_game.Visible = false;
            New_game.Visible = false;
            free_game.Visible = false;

           
            

            //button6.Visible = true;
            //button6.Location = new Point();
            //button6.Size = new Size(100, 100);
        }
        


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            //x:0-450
            //y:120-450
            SolidBrush b = new SolidBrush(Color.Gold);
            SolidBrush b2 = new SolidBrush(Color.Black);
            if (l==true)
            {
                //x0 = 400;
                //y0 = 285;
                if (x0 > 10)
                {
                    ship(x0, y0, b2);
                    x0--;
                    ship(x0, y0, b);
                    

                }
            }
            if(r)
            {
                if (x0 < 500)
                {
                    ship(x0, y0, b2);
                    x0++;
                    ship(x0, y0, b);
                    
                }
            }
            if(u)
            {
                if (y0 > 100)
                {
                    ship(x0, y0, b2);
                    y0--;
                    ship(x0, y0, b);
                    
                }
            }
            if(d)
            {
                if (y0 < 500)
                {
                    ship(x0, y0, b2);
                    y0++;
                    ship(x0, y0, b);
                    
                    
                }
            }
            
        }
        private void ship(int x0, int y0,SolidBrush b)
        {
            //background
            int n = 10;
            Graphics g = CreateGraphics();
            Point[] p =
                {
                new Point (x0,y0),
                new Point (x0+3*n,y0),
                new Point (x0+3*n,y0-2*n),
                new Point (x0+4*n,y0-2*n),
                new Point (x0+4*n,y0-4*n),
                new Point (x0+5*n,y0-4*n),
                new Point (x0+5*n,y0-2*n),
                new Point (x0+6*n,y0-2*n),
                new Point (x0+6*n,y0),
                new Point (x0+9*n,y0),
                new Point (x0+9*n,y0+9*n),
                new Point (x0,y0+9*n),
                new Point (x0,y0)
            };
        
            g.FillPolygon(b,p);
        }
        
    }
}
/*Choose_the_game.Visible = false;
Back.Visible = false;
Exit.Visible = true;
Control.Visible = true;
Load_game.Visible = true;
New_game.Visible = true;
free_game.Visible = false;
button1.Visible = false;
button2.Visible = false;
button3.Visible = false;
button4.Visible = false;
button5.Visible = false;
button6.Visible = false;
 */
