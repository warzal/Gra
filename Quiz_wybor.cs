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
    public partial class Quiz_wybor : Form
    {

        private string result;    
        public Quiz_wybor()
        {
            InitializeComponent();
        }
     
        private void wyb_top_but_Click(object sender, EventArgs e)
        {
            int result = 0;
            DialogResult answer1 = MessageBox.Show("Czy każda przestrzeń topologiczna jest metryzowalna?","Pytanie 1.", MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (answer1==DialogResult.Yes)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

           
            DialogResult answer2 = MessageBox.Show("Czy pojęcia metryki i normy są torżsame?", "Pytanie 2.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer2 == DialogResult.Yes)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

            DialogResult answer3 = MessageBox.Show("Czy topologia jest ciekawa?", "Pytanie 3.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer3 == DialogResult.No)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

            
            textBox1.Text = result.ToString();
            MessageBox.Show( textBox1.Text, "Na 3 punkty masz: ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void wyb_PG_but_Click(object sender, EventArgs e)
        {
            int result = 0;
            DialogResult answer1 = MessageBox.Show("Czy PG w roku 2016 miała 120. urodziny?", "Pytanie 1.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer1 == DialogResult.Yes)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

            DialogResult answer2 = MessageBox.Show("Czy prowadzący nosi okulary?", "Pytanie 2.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer2 == DialogResult.No)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

            DialogResult answer3 = MessageBox.Show("Czy autor tego pytania chce zdać ten przedmniot?", "Pytanie 1.", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (answer3 == DialogResult.No)
            {
                pcb.Image = Properties.Resources.wstyd;
            }
            else
            {
                pcb.Image = Properties.Resources.smiley;
                result++;
            }

            textBox1.Text = result.ToString();
            MessageBox.Show(textBox1.Text, "Na 3 punkty masz: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
