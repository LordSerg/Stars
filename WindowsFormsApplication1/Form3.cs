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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            int x = (this.Size.Width)-50;
            int y = (this.Size.Height)-50;
            int q = r.Next(3);
            
            label1.Location = new Point(r.Next(x), r.Next(y));
            label1.Size = new Size(r.Next(20,50), r.Next(20,50));
            label2.Location = new Point(r.Next(x), r.Next(y));
            label2.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label3.Location = new Point(r.Next(x), r.Next(y));
            label3.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label4.Location = new Point(r.Next(x), r.Next(y));
            label4.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label5.Location = new Point(r.Next(x), r.Next(y));
            label5.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label6.Location = new Point(r.Next(x), r.Next(y));
            label6.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label7.Location = new Point(r.Next(x), r.Next(y));
            label7.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label8.Location = new Point(r.Next(x), r.Next(y));
            label8.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label9.Location = new Point(r.Next(x), r.Next(y));
            label9.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label10.Location = new Point(r.Next(x), r.Next(y));
            label10.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label11.Location = new Point(r.Next(x), r.Next(y));
            label11.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label12.Location = new Point(r.Next(x), r.Next(y));
            label12.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label13.Location = new Point(r.Next(x), r.Next(y));
            label13.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label14.Location = new Point(r.Next(x), r.Next(y));
            label14.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label15.Location = new Point(r.Next(x), r.Next(y));
            label15.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label16.Location = new Point(r.Next(x), r.Next(y));
            label16.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label17.Location = new Point(r.Next(x), r.Next(y));
            label17.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label18.Location = new Point(r.Next(x), r.Next(y));
            label18.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label19.Location = new Point(r.Next(x), r.Next(y));
            label19.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            label20.Location = new Point(r.Next(x), r.Next(y));
            label20.Size = new Size(r.Next(20, 50), r.Next(20, 50));
            button1.Location = new Point(r.Next(x), r.Next(y));
            button1.Size = new Size(r.Next(50,100), r.Next(20, 50));
            button2.Location = new Point(r.Next(x), r.Next(y));
            button2.Size = new Size(r.Next(50,100), r.Next(20, 50));
            if (q == 0)
            {
                this.BackColor = Color.Red;
                label1.Font = new Font("MT Extra", r.Next(20, 50));
                label2.Font = new Font("Broadway", r.Next(20, 50));
                label3.Font = new Font("Vivaldi", r.Next(20, 50));
                label4.Font = new Font("MT Extra", r.Next(20, 50));
                label5.Font = new Font("Broadway", r.Next(20, 50));
                label6.Font = new Font("MT Extra", r.Next(20, 50));
                label7.Font = new Font("Vivaldi", r.Next(20, 50));
                label8.Font = new Font("MT Extra", r.Next(20, 50));
                label9.Font = new Font("Vivaldi", r.Next(20, 50));
                label10.Font = new Font("Broadway", r.Next(20, 50));
                label11.Font = new Font("Vivaldi", r.Next(20, 50));
                label12.Font = new Font("Broadway", r.Next(20, 50));
                label13.Font = new Font("Vivaldi", r.Next(20, 50));
                label14.Font = new Font("Vivaldi", r.Next(20, 50));
                label15.Font = new Font("Broadway", r.Next(20, 50));
                label16.Font = new Font("Broadway", r.Next(20, 50));
                label17.Font = new Font("Vivaldi", r.Next(20, 50));
                label18.Font = new Font("MT Extra", r.Next(20, 50));
                label19.Font = new Font("Broadway", r.Next(20, 50));
                label20.Font = new Font("Vivaldi", r.Next(20, 50));
                button1.Font = new Font("Vivaldi", r.Next(20, 50));
                button2.Font = new Font("MT Extra", r.Next(20, 50));

            }
            else if (q == 1)
            {
                this.BackColor = Color.Yellow;
                label1.Font = new Font("Vivaldi", r.Next(20, 50));
                label2.Font = new Font("MT Extra", r.Next(20, 50));
                label3.Font = new Font("MT Extra", r.Next(20, 50));
                label4.Font = new Font("Vivaldi", r.Next(20, 50));
                label5.Font = new Font("Vivaldi", r.Next(20, 50));
                label6.Font = new Font("Broadway", r.Next(20, 50));
                label7.Font = new Font("MT Extra", r.Next(20, 50));
                label8.Font = new Font("MT Extra", r.Next(20, 50));
                label9.Font = new Font("MT Extra", r.Next(20, 50));
                label10.Font = new Font("MT Extra", r.Next(20, 50));
                label11.Font = new Font("Vivaldi", r.Next(20, 50));
                label12.Font = new Font("MT Extra", r.Next(20, 50));
                label13.Font = new Font("Broadway", r.Next(20, 50));
                label14.Font = new Font("MT Extra", r.Next(20, 50));
                label15.Font = new Font("Vivaldi", r.Next(20, 50));
                label16.Font = new Font("MT Extra", r.Next(20, 50));
                label17.Font = new Font("MT Extra", r.Next(20, 50));
                label18.Font = new Font("Broadway", r.Next(20, 50));
                label19.Font = new Font("MT Extra", r.Next(20, 50));
                label20.Font = new Font("Vivaldi", r.Next(20, 50));
                button1.Font = new Font("MT Extra", r.Next(20, 50));
                button2.Font = new Font("Vivaldi", r.Next(20, 50));

            }

            else
            {
                this.BackColor = Color.Blue;
                label1.Font = new Font("Vivaldi", r.Next(20, 50));
                label2.Font = new Font("MT Extra", r.Next(20, 50));
                label3.Font = new Font("Vivaldi", r.Next(20, 50));
                label4.Font = new Font("Vivaldi", r.Next(20, 50));
                label5.Font = new Font("MT Extra", r.Next(20, 50));
                label6.Font = new Font("Vivaldi", r.Next(20, 50));
                label7.Font = new Font("Broadway", r.Next(20, 50));
                label8.Font = new Font("Broadway", r.Next(20, 50));
                label9.Font = new Font("Vivaldi", r.Next(20, 50));
                label10.Font = new Font("MT Extra", r.Next(20, 50));
                label11.Font = new Font("Broadway", r.Next(20, 50));
                label12.Font = new Font("Vivaldi", r.Next(20, 50));
                label13.Font = new Font("Broadway", r.Next(20, 50));
                label14.Font = new Font("Broadway", r.Next(20, 50));
                label15.Font = new Font("Vivaldi", r.Next(20, 50));
                label16.Font = new Font("MT Extra", r.Next(20, 50));
                label17.Font = new Font("Broadway", r.Next(20, 50));
                label18.Font = new Font("Vivaldi", r.Next(20, 50));
                label19.Font = new Font("MT Extra", r.Next(20, 50));
                label20.Font = new Font("Vivaldi", r.Next(20, 50));
                button1.Font = new Font("MT Extra", r.Next(20, 50));
                button2.Font = new Font("Vivaldi", r.Next(20, 50));


            }

        }

        private void Form3_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            //this.BackColor=Color.FromArgb(250, r.Next(150, 250), r.Next(50), r.Next(50));

            button1.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            button2.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label1.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label1.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label2.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label3.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label4.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label5.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label6.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label7.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label8.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label9.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label10.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label11.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label12.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label13.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label14.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label15.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label16.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label17.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label18.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label19.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));
            label20.BackColor = Color.FromArgb(250, r.Next(250), r.Next(250), r.Next(250));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            msb();
            msb();
        }
        public void msb()
        {
            Form3 f = new Form3();
            Random r = new Random();
            int x = r.Next(200, 1000), y = r.Next(200, 1000);
            f.Size = new Size(x,y);
            f.Location = new Point(r.Next(1000), r.Next(1000));
            f.Show();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
