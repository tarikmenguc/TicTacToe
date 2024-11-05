using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void plyr1nametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oyuncuadi1 = plyr1nametxt.Text;
            string oyuncuadi2 = plyr2nametxt.Text;
            Form1 form = new Form1();
            form.oyuncuadi1= oyuncuadi1;
            form.oyuncuadi2= oyuncuadi2;
          this.Hide();
            form.ShowDialog();
        }
    }
}
