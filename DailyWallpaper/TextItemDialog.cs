using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyWallpaper
{
    public partial class TextItemDialog : Form
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public bool Center { get; set; }

        public TextItemDialog()
        {
            InitializeComponent();
        }

        public TextItemDialog(string _title, string _content, string _author, bool _center)
        {
            Title = _title;
            Content = _content;
            Author = _author;
            Center = _center;
            InitializeComponent();
            title.Text = _title;
            content.Text = _content;
            author.Text = _author;
            center.Checked = _center;
        }

        public TextItemDialog(TextItem item)
        {
            string _title = item.Title;
            string _content = item.Content;
            string _author = item.Author;
            bool _center = item.Center;
            Title = _title;
            Content = _content;
            Author = _author;
            Center = _center;
            InitializeComponent();
            title.Text = _title;
            content.Text = _content;
            author.Text = _author;
            center.Checked = _center;
        }

        public TextItem ToTextItem()
        {
            return new TextItem(Title, Content, Author, Center);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Title = title.Text;
            Content = content.Text;
            Author = author.Text;
            Center = center.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
