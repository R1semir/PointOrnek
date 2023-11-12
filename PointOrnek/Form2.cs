using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOrnek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point b = new Point();
            b.X = Convert.ToInt32(textBox1.Text);
            b.Y = Convert.ToInt32(textBox2.Text);
            pictureBox1.Location = b;
        }
    }
}
