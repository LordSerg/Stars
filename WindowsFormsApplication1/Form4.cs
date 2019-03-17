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
using OpenTK.Graphics;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform.Windows;


namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double x1 = 0, y1 = 0;
        int n = 1000;
        Vector3d[] a;
        Vector3d [,]plane;
        private void Form4_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            a = new Vector3d[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i].X = 0.001 * r.Next(-1000, 2000);
                a[i].Y = 0.001 * r.Next(-1000, 2000);
                //a[i].Z = 0.001 * r.Next(-1000, 2000);

                //GL.Begin(PrimitiveType.Points);
                //GL.Color3(Color.Red);
                //GL.Vertex3(a[i]);
                //GL.Flush();
                //GL.End();
            }
            glControl1.Location = new Point(0, 0);
            glControl1.Width = this.Width;
            glControl1.Height = this.Height;

            glControl1.SwapBuffers();
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer2.Enabled = true;
            timer2.Interval = 1;
            timer3.Enabled = true;
            timer3.Interval = 1;
            menuStrip1.Visible = true;
            plane = new Vector3d[1, 5];
            x1 = 0;
            y1 = 0;
            pl_1(plane, x1, y1);
        }
        private void stars_2()
        {
            GL.Begin(PrimitiveType.Points);
            for(int i=0;i<n;i++)
            {
                //GL.Vertex3(a[i]);
                a[i].X = a[i].X;
                a[i].Y = a[i].Y;
                GL.Color3(Color.White);
                GL.Vertex3(a[i]);
            }
            GL.End();
        }
        private void stars_1(double x,double y)
        {
            int q = 20000;
            
            for (int i = 0; i < n; i++)
            {
                if (y <= 0)
                {
                    if (x <= 0)
                    {
                        if ((a[i].Y < -1) || (a[i].X > 1))
                        {
                            a[i].Y = -a[i].Y;
                            a[i].X = -a[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(a[i]);
                            a[i].Y -= Math.Abs(y / q);
                            a[i].X += Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(a[i]);
                        }
                    }
                    else
                    {
                        if ((a[i].Y < -1) || (a[i].X < -1))
                        {
                            a[i].Y = -a[i].Y;
                            a[i].X = -a[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(a[i]);
                            a[i].Y -= Math.Abs(y / q);
                            a[i].X -= Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(a[i]);
                        }
                    }
                }
                if (y > 0)
                {
                    if (x <= 0)
                    {
                        if ((a[i].Y > 1) || (a[i].X > 1))
                        {
                            a[i].Y = -a[i].Y;
                            a[i].X = -a[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(a[i]);
                            a[i].Y += Math.Abs(y / q);
                            a[i].X += Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(a[i]);
                        }
                    }

                    else
                    {
                        if ((a[i].Y > 1) || (a[i].X < -1))
                        {
                            a[i].Y = -a[i].Y;
                            a[i].X = -a[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(a[i]);
                            a[i].Y += Math.Abs(y / q);
                            a[i].X -= Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(a[i]);
                        }
                    }
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            double x = MousePosition.X - glControl1.Width / 2;
            double y = MousePosition.Y - glControl1.Height / 2;
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);

            if (Math.Abs(x) > 200 || Math.Abs(y) > 200)
            {
                GL.Begin(PrimitiveType.Lines);
                stars_1(x, y);
                GL.End();
            }
            else
                stars_2();
            GL.Flush();
            GL.Begin(PrimitiveType.Polygon);
            pl_1(plane, x1, y1);
            for (int i = 0; i < 4; i++)
            {
                GL.Color3(Color.White);
                GL.Vertex3(plane[0, i]);
                GL.Vertex3(plane[0, i + 1]);
            }
            GL.Flush();
            GL.End();
            glControl1.SwapBuffers();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            double x = MousePosition.X - glControl1.Width / 2;
            double y = MousePosition.Y - glControl1.Height / 2;
            if (MousePosition.Y < 50)
            {
                glControl1.Location = new Point(0, menuStrip1.Height);
                menuStrip1.Visible = true;
            }
            else
            {
                glControl1.Location = new Point(0, 0);                
                menuStrip1.Visible = false;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }
        private void pl_1(Vector3d[,] plane,double x1,double y1)
        {
            plane[0, 0].X = x1;
            plane[0, 0].Y = y1+0.1;

            plane[0, 1].X = x1+0.15;
            plane[0, 1].Y = y1-0.15;

            plane[0, 2].X = x1;
            plane[0, 2].Y = y1;

            plane[0, 3].X = x1-0.15;
            plane[0, 3].Y = y1-0.15;

            plane[0, 4].X = x1;
            plane[0, 4].Y = y1+0.1;

            //plane[0, 5].X = x;
            //plane[0, 5].Y = y+0.2;
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled==true)
            {
                toolStripMenuItem3.Text = "Продолжить игру";
                timer1.Enabled = false;
            }
            else
            {
                toolStripMenuItem3.Text = "Остановить игру";
                timer1.Enabled = true;
            }
        }

        private void glControl1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar.CompareTo('w') == 0)
            {
                y1 += 0.01;
            }
            if (e.KeyChar.CompareTo('s') == 0)
            {
                y1 -= 0.01;
            }
            if (e.KeyChar.CompareTo('d') == 0)
            {
                x1 += 0.01;
            }
            if (e.KeyChar.CompareTo('a') == 0)
            {
                x1 -= 0.01;
            }
        }
    }
}

    
