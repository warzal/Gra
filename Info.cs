using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra
{
    public partial class Info_menu : Form
    {
        public Info_menu()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void powrot_info_but_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
         

        }

        private void graj_info_but_Click(object sender, EventArgs e)
        {
            new Quiz_wybor().ShowDialog();
        }
    }
}
