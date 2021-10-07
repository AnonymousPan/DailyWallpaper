using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyWallpaper
{
    public partial class TextStyleDialog : Form
    {
        public string FontFamily { get; set; } = "宋体";
        public FontStyle Style { get; set; } = FontStyle.Regular;
        public Color Color { get; set; } = Color.Black;
        public float FontSize { get; set; } = 12;

        public TextStyleDialog()
        {
            InitializeComponent();
            btnFont.Text = FontFamily + " [" + Style.ToString() + "]";
            sizeLabel.Text = "字体大小: " + FontSize.ToString();
            preview.Font = new Font(FontFamily, FontSize, Style);
            fontDialog.Font = preview.Font;
            colorDialog.Color = Color;
            btnColor.BackColor = Color;
            preview.ForeColor = Color;
        }

        public TextStyleDialog(string family, FontStyle style, Color color, float size)
        {
            FontFamily = family;
            Style = style;
            Color = color;
            FontSize = size;

            InitializeComponent();
            btnFont.Text = FontFamily + " [" + Style.ToString() + "]";
            sizeLabel.Text = "字体大小: " + FontSize.ToString();
            preview.Font = new Font(FontFamily, FontSize, Style);
            fontDialog.Font = preview.Font;
            colorDialog.Color = Color;
            btnColor.BackColor = Color;
            preview.ForeColor = Color;
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            FontFamily = fontDialog.Font.FontFamily.Name;
            Style = fontDialog.Font.Style;
            btnFont.Text = FontFamily + " [" + Style.ToString() + "]";
            FontSize = fontDialog.Font.Size;
            sizeLabel.Text = "字体大小: " + FontSize.ToString();
            preview.Font = new System.Drawing.Font(FontFamily, FontSize, Style);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            Color= colorDialog.Color;
            btnColor.BackColor = Color;
            preview.ForeColor = Color;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
