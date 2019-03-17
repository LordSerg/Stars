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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //int n = 0;
        }
        public void msbox()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Form3 f = new Form3();
                f.Size = new Size(r.Next(200,1000),r.Next(200,1000));
                f.Location = new Point(r.Next(1000), r.Next(1000));
                f.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            msbox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
