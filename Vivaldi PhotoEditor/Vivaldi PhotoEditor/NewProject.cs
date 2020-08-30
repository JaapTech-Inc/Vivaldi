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
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            Program.projectname = zeroitLollipopTextBox1.Text;
            this.Hide();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
