using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilllTheSpiders
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Programmers programmers = new Programmers();
            programmers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KillTheSpiders killTheSpiders = new KillTheSpiders();

            this.Hide();
            killTheSpiders.Show();
            
        }
    }
}
