using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.MouseEnter += button2_MouseEnter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хорошо");
            Application.Exit();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int maxX = this.ClientSize.Width - button2.Width;
            int maxY = this.ClientSize.Height - button2.Height;
            button2.Location = new Point(rnd.Next(maxX), rnd.Next(maxY));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
