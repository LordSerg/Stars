using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button1.BackgroundImage = Properties.Resources;
        }

        private void Form7_MouseEnter(object sender, EventArgs e)
        {
            //Graphics g = CreateGraphics();
            //Rectangle rect = new Rectangle(MousePosition.X,MousePosition.Y,5,5);
            //IntPtr inp = new  IntPtr(Convert.ToInt32(Properties.Resources._1));
            //this.Cursor=new Cursor(System.IntPtr.Subtract(inp,1));
        }
    }
}
