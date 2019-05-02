using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quering_module
{
    public partial class Start : Form
    {
        Form1 F = new Form1();
        public Start()
        {
            InitializeComponent();
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.03;

            }
            else
            {
                timer1.Stop();
                F.ShowDialog();
            }
        }
    }
}
