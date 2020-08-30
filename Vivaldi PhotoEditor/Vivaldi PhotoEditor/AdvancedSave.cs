using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivaldi_PhotoEditor
{
    public partial class AdvancedSave : Form
    {
        public AdvancedSave()
        {
            InitializeComponent();
        }

        private void zeroitLollipopButton1_Click(object sender, EventArgs e)
        {
            if(guna2ComboBox1.Text == "PNG")
            {
                try
                {
                    Program.photo.Save(zeroitLollipopTextBox1.Text + "." + guna2ComboBox1.Text, ImageFormat.Png);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (guna2ComboBox1.Text == "JPEG")
            {
                try
                {
                    Program.photo.Save(zeroitLollipopTextBox1.Text + "." + guna2ComboBox1.Text, ImageFormat.Jpeg);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (guna2ComboBox1.Text == "GIF")
            {
                try
                {
                    Program.photo.Save(zeroitLollipopTextBox1.Text + "." + guna2ComboBox1.Text, ImageFormat.Gif);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (guna2ComboBox1.Text == "BMP")
            {
                try
                {
                    Program.photo.Save(zeroitLollipopTextBox1.Text + "." + guna2ComboBox1.Text, ImageFormat.Bmp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            this.Hide();
        }

        private void zeroitLollipopButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            zeroitLollipopTextBox1.Text = saveFileDialog1.FileName;
        }
    }
}
