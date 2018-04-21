using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatePatternLab
{
    public partial class Form1 : Form
    {
        CPanel panel = null;

        public Form1()
        {
            InitializeComponent();
            panel = new CPanel();
            panel.Location = new Point(10, 10);
            panel.Size = new Size(90, 90);
            this.Controls.Add(panel);
        }

        public void Form1_Load(Object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.push();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel.pull();

        }
    }
}
