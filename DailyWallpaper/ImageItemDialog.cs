using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DailyWallpaper
{
    public partial class ImageItemDialog : Form
    {
        public string Title { get; set; }
        public string FilePath { get; set; }

        public ImageItemDialog()
        {
            InitializeComponent();
        }

        public ImageItemDialog(string title, string path)
        {
            Title = title;
            FilePath = path;
            InitializeComponent();
        }

        public ImageItemDialog(ImageItem item)
        {
            Title = item.Title;
            FilePath = item.Filename;
            imagePreview.ImageLocation = FilePath;
        }

        public ImageItem ToImageItem()
        {
            string hash = Utils.FileMD5String(FilePath);
            string format = Path.GetExtension(FilePath);
            ImageItem item = new ImageItem(Title, hash, format.Substring(1, format.Length - 1));
            return item;
        }

        public ImageItem CreateImage(string imgPath)
        {
            ImageItem item = ToImageItem();
            File.Copy(FilePath, Path.Combine(imgPath, item.Filename));
            return item;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Title = title.Text;
            try
            {
                if (File.Exists(filePath.Text))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("文件不存在", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("读取文件失败", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog.FileName;
                filePath.Text = FilePath;
                imagePreview.ImageLocation = FilePath;
                if(string.IsNullOrEmpty(title.Text.Trim()))
                {
                    Title = Path.GetFileNameWithoutExtension(FilePath);
                    title.Text = Title;
                }
            }
        }

        private void title_ChangeUICues(object sender, UICuesEventArgs e)
        {
            Title = title.Text;
        }

        private void filePath_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath.Text)) return;
            try
            {
                if(File.Exists(filePath.Text))
                {
                    FilePath = filePath.Text;
                    imagePreview.ImageLocation = FilePath;
                }
                else
                {
                    MessageBox.Show("文件不存在", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("读取文件失败", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImageItemDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(imagePreview != null && imagePreview.Image != null) imagePreview.Image.Dispose();
        }
    }
}
