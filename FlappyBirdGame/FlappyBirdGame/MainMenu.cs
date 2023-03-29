using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flappyBirdForm flappydragon = new flappyBirdForm();
            flappydragon.Show();
            this.Hide();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
