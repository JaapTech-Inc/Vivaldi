using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivaldi_PhotoEditor
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath + "/Projects/");
            FileInfo[] Files = d.GetFiles("*.vp"); //Getting Text files
            listView1.LargeImageList = imageList1;
            foreach (FileInfo file in Files)
            {
                listView1.Items.Add(file.Name, 0);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewProject newp = new NewProject();
            newp.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
