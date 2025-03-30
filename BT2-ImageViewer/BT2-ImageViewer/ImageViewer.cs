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

namespace BT2_ImageViewer
{
    public partial class imageViewerForm : Form
    {
        public imageViewerForm()
        {
            InitializeComponent();
        }

        private void loadFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            var res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                var path = dialog.SelectedPath;
                string[] files = Directory.GetFiles(path);

                
                imageFlowLayoutPanel.Controls.Clear();

                foreach (var file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith(".png"))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Cursor = Cursors.Hand;
                        pictureBox.Load(file);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Tag = file;

                       
                        pictureBox.Width = 150;
                        pictureBox.Height = 100;

                        pictureBox.Click += PictureBox_Click;

                        imageFlowLayoutPanel.Controls.Add(pictureBox);
                    }
                }
            }

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string imgPath = pictureBox.Tag.ToString();
                imagePictureBox.Load(imgPath);
                imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pathLabel.Text = "File: " + imgPath + " is loaded.";
            }
        }

        
    }
}
