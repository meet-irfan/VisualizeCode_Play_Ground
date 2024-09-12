using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r, g, b;
            Random rand = new Random();
            r = rand.Next(0, 255);
            g = rand.Next(0, 255);
            b = rand.Next(0, 255);

            b = (r + g) / 2;
            BackColor = Color.FromArgb(r, g, b);



        }
    }
}
