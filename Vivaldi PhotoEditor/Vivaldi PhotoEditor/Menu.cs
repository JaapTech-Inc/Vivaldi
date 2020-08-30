using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivaldi_PhotoEditor
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu main = new frmMenu();
            main.Show();
            timer1.Stop();
        }
    }
}
