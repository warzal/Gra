using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Gra
{
    public partial class Top_Quiz : Form
    {
        public Top_Quiz()
        {
            InitializeComponent();
            timer1.Start();
           
        }

        private void Pyt_tb_TextChanged(object sender, EventArgs e)
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    label1.Text = "1.Topologia niepustej przestrzeni X jest:\n a)Zbiorem elementów X\n b)Dowolną rodziną podzbiorów X\n c)Rodziną podzbiorów X spełniającą pewne warunki\n d)Iloczynem kartezjańskim X i X\n";
                    label6.Text = "c";
                    Pyt_tb.Text = label1.Text;
                    break;
                 default:
                    Pyt_tb.Text = "Siara";
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
