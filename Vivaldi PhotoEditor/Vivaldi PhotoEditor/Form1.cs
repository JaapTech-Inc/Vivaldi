using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.LollipopControls;
using Zeroit.Framework.LollipopControls.Controls;

namespace Vivaldi_PhotoEditor
{
    public partial class Form1 : Form
    {
        public string[] fileNames;
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox PictureBox;
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.AllowDrop = true;
            this.Text = "Vivaldi - " + Program.projectname;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                fileNames = data as string[];
                if(fileNames.Length>0)
                {
                    PictureBox = new PictureBox();
                    PictureBox.Image = Image.FromFile(fileNames[0]);
                    PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    PictureBox.Dock = DockStyle.Fill;
                    panel1.Controls.Clear();
                    panel1.Controls.Add(PictureBox);
                    ZeroitLollipopSmallCard layer = new ZeroitLollipopSmallCard();
                    layer.Text = fileNames[0];
                    flowLayoutPanel1.Controls.Add(layer);
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public float green;
        public float red;
        public float blue;
        private void colorGradingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;

            // we change some picels
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255, 255, c.G, c.B));
                    green = c.G;
                    red = c.R;
                    blue = c.B;
                }
            // we need to re-assign the changed bitmap
            PictureBox.Image = (Bitmap)bmp;
            trackBar1.Value = (int)red;
            trackBar2.Value = (int)green;
            trackBar1.Value = (int)blue;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;

            // we change some picels
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    
                    
                    byte rojo = (byte)Convert.ToByte(trackBar1.Value);
                    byte verde = (byte)Convert.ToByte(trackBar2.Value);
                    byte azul = (byte)Convert.ToByte(trackBar3.Value);
                    rojo = (byte)Math.Min(rojo + c.R, 255);
                    verde = (byte)Math.Min(verde + c.R, 255);
                    azul = (byte)Math.Min(azul + c.R, 255);
                    
    
                    bmp.SetPixel(x, y, Color.FromArgb(255, rojo, verde, azul));
                }
            // we need to re-assign the changed bitmap
            PictureBox.Image = (Bitmap)bmp;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;

            // we change some picels
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);


                    byte rojo = (byte)Convert.ToByte(trackBar1.Value);
                    byte verde = (byte)Convert.ToByte(trackBar2.Value);
                    byte azul = (byte)Convert.ToByte(trackBar3.Value);
                    rojo = (byte)Math.Min(rojo + c.R, 255);
                    verde = (byte)Math.Min(verde + c.R, 255);
                    azul = (byte)Math.Min(azul + c.R, 255);


                    bmp.SetPixel(x, y, Color.FromArgb(255, rojo, verde, azul));
                }
            // we need to re-assign the changed bitmap
            PictureBox.Image = (Bitmap)bmp;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;

            // we change some picels
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);


                    byte rojo = (byte)Convert.ToByte(trackBar1.Value);
                    byte verde = (byte)Convert.ToByte(trackBar2.Value);
                    byte azul = (byte)Convert.ToByte(trackBar3.Value);
                    rojo = (byte)Math.Min(rojo + c.R, 255);
                    verde = (byte)Math.Min(verde + c.R, 255);
                    azul = (byte)Math.Min(azul + c.R, 255);


                    bmp.SetPixel(x, y, Color.FromArgb(255, rojo, verde, azul));
                }
            // we need to re-assign the changed bitmap
            PictureBox.Image = (Bitmap)bmp;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)PictureBox.Image;

            // we change some picels
            for (int y = 0; y < bmp.Height; y++)
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    bmp.SetPixel(x, y, Color.FromArgb(255, 0, c.G, c.B));
                }
            // we need to re-assign the changed bitmap
            PictureBox.Image = (Bitmap)bmp;
        }

        private void fastAsPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG File | *.png";
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    PictureBox.Image.Save(saveFileDialog1.FileName, ImageFormat.Png);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void advancedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.photo = (Bitmap)PictureBox.Image;
            AdvancedSave advancedSave = new AdvancedSave();
            advancedSave.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private async void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Vivaldi Projects | *.vp";
            saveFileDialog1.ShowDialog();
            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
            {
                this.UseWaitCursor = true;
                await sw.WriteLineAsync(fileNames[0] + "|" + trackBar1.Value.ToString() + "," + trackBar2.Value.ToString() + "," + trackBar3.Value.ToString());
                this.UseWaitCursor = false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string file = File.ReadAllText(ofd.FileName);
                    string[] filecontent = file.Split('|');
                    string[] rgb = filecontent[1].Split(',');
                    int r = Int32.Parse(rgb[0]);
                    int g = Int32.Parse(rgb[1]);
                    int b = Int32.Parse(rgb[2]);
                    trackBar1.Value = r;
                    trackBar2.Value = g;
                    trackBar3.Value = b;
                    //MessageBox.Show(rgb[0] + "," + rgb[1] + "," + rgb[2]);
                    panel1.Controls.Clear();
                    PictureBox = new PictureBox();
                    PictureBox.Image = Image.FromFile(filecontent[0]);
                    PictureBox.Dock = DockStyle.Fill;
                    PictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    panel1.Controls.Add(PictureBox);
                    Bitmap bmp = (Bitmap)PictureBox.Image;

                    // we change some picels
                    for (int y = 0; y < bmp.Height; y++)
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            Color c = bmp.GetPixel(x, y);


                            byte rojo = (byte)Convert.ToByte(trackBar1.Value);
                            byte verde = (byte)Convert.ToByte(trackBar2.Value);
                            byte azul = (byte)Convert.ToByte(trackBar3.Value);
                            rojo = (byte)Math.Min(rojo + c.R, 255);
                            verde = (byte)Math.Min(verde + c.R, 255);
                            azul = (byte)Math.Min(azul + c.R, 255);


                            bmp.SetPixel(x, y, Color.FromArgb(255, rojo, verde, azul));
                        }
                    // we need to re-assign the changed bitmap
                    PictureBox.Image = (Bitmap)bmp;
                }
            }
        }

        private async void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "/Projects/" + Program.projectname + ".vp"))
            {
                this.UseWaitCursor = true;
                await sw.WriteLineAsync(fileNames[0] + "|" + trackBar1.Value.ToString() + "," + trackBar2.Value.ToString() + "," + trackBar3.Value.ToString());
                this.UseWaitCursor = false;
                Program.isSaved = true;
            }
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Program.isSaved == false)
            {
                e.Cancel = false;
                if(MessageBox.Show("Do you want to save changes to your project", "Want to save changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(Application.StartupPath + "/Projects/" + Program.projectname + ".vp"))
                    {
                        this.UseWaitCursor = true;
                        await sw.WriteLineAsync(fileNames[0] + "|" + trackBar1.Value.ToString() + "," + trackBar2.Value.ToString() + "," + trackBar3.Value.ToString());
                        this.UseWaitCursor = false;
                        Program.isSaved = true;
                        this.Hide();
                    }
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
