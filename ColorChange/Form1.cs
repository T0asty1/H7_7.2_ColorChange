using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorChange
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
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //MEssage.Show("mouse click event")
            // this.BackColor = Color.Red;
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Red;

            }

            if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Blue;
            }
        }   
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = Color.Green;
            }

            if (e.Button == MouseButtons.Right)
            {
                this.BackColor = Color.Yellow;
            }
        }
    }
}
