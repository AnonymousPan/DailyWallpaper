using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DailyWallpaper
{
    public partial class DateFormatDialog : Form
    {
        public string FormatString { get; set; }

        public DateFormatDialog()
        {
            InitializeComponent();
            preview.Text = "<请输入格式字符串>";
        }

        public DateFormatDialog(string str)
        {
            InitializeComponent();
            FormatString = str;
            input.Text = FormatString;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            FormatString = input.Text;
            if(!string.IsNullOrEmpty(FormatString)) preview.Text = DateTime.Now.ToString(FormatString);
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FormatString)) preview.Text = DateTime.Now.ToString(FormatString);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
