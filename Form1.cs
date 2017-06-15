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
    public partial class Quiz_menu : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Quiz_menu()
        {
            InitializeComponent();
            player.SoundLocation ="Heart of Courage.wav";
        }

        private void start_but_Click(object sender, EventArgs e)
        {
            new Info_menu().ShowDialog();
        }

        private void wyniki_but_Click(object sender, EventArgs e)
        {
            new Dzieki().ShowDialog();
        }

        private void wyjdz_but_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Użytkowniku, jesteś tego pewny?", "Ostatnia szansa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
                //Uwielbiam tę linijkę
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
