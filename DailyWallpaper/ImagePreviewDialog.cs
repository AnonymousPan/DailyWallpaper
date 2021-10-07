using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace DailyWallpaper
{
    public partial class ImagePreviewDialog : Form
    {
        public ImagePreviewDialog(Image img)
        {
            InitializeComponent();
            pictureBox.Image = img;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK && pictureBox.Image != null)
            {
                try
                {
                    switch(saveFileDialog.FilterIndex)
                    {
                        case 1:
                            // PNG
                            pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                            break;
                        case 2:
                            // JPEG
                            pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                            break;
                        case 3: 
                            // BMP
                            pictureBox.Image.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                            break;
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("无法保存图片\n" + err.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
