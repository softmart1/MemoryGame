using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HighScores high = new HighScores();
            high.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Local loc = new Local();
            loc.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Online online = new Online();
            online.Show();
            this.Hide();
        }
    }
}
