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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        Vector3d[] a;
        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            timer1.Interval = 1;
            timer1.Enabled = !timer1.Enabled;
            a = new Vector3d[500];
            for(int i=0;i<500;i++)
            {
                a[i].X = 0.001 * r.Next(-500, 500);
                a[i].Y = 0.001 * r.Next(-500, 500);
                a[i].Z = 0.001 * r.Next(-500, 500);
            }
        }
        void abc()
        {
            for (int i = 0; i < 500; i++)
            {
                if (a[i].Z < 1)
                {

                    a[i].Z += 0.01;
                    GL.Color3(Color.FromArgb(Convert.ToInt32(Math.Abs(a[i].Z * a[i].Z + a[i].Z) * 100), Convert.ToInt32(Math.Abs(a[i].Z * a[i].Z - a[i].Z) * 120), Convert.ToInt32(Math.Abs(a[i].X * a[i].Y) * 100)));
                    GL.Vertex3(a[i]);
                }
                else
                {

                    a[i].Z = -1;
                    GL.Color3(Color.FromArgb(Convert.ToInt32(Math.Abs(a[i].Z * a[i].Z + a[i].Z) * 100), Convert.ToInt32(Math.Abs(a[i].Z * a[i].Z - a[i].Z) * 120), Convert.ToInt32(Math.Abs(a[i].X * a[i].Y) * 100)));
                    GL.Vertex3(a[i]);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GL.ClearColor(Color.FromArgb(0,0,0));
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Polygon);
            abc();
            GL.Flush();
            GL.End();
            glControl1.SwapBuffers();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            double x = this.Width / 2 - MousePosition.X;
            double y = this.Width / 2 - MousePosition.Y;
            GL.Begin(PrimitiveType.Patches);
            GL.Rotate(1, x, y, x-y);
            GL.End();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = false;
            timer2.Interval = 1;
            timer2.Enabled = !timer2.Enabled;

        }
    }
}
