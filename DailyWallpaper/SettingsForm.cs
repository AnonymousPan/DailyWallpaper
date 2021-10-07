using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TaskScheduler;

namespace DailyWallpaper
{
    public partial class SettingsForm : Form
    {
        bool changed = false;

        public SettingsForm()
        {
            InitializeComponent();
            ApplyConfigValue(Program.Config);
            LoadText();
            LoadImage();
            changed = false;
        }

        private void ApplyConfigValue(BasicConfig config)
        {
            updateFreq.SelectedIndex = (int)config.UpdateFreq;
            autoDelete.Value = config.AutoDelete;

            enableDate.Checked = config.DateEnable;
            dateX.Value = config.DatePosX;
            dateY.Value = config.DatePosY;
            dateCenterPos.Checked = config.DateUseCenterPos;

            enableText.Checked = config.TextEnable;
            textX.Value = config.TextPosX;
            textY.Value = config.TextPosY;
            textCenterPos.Checked = config.TextUseCenterPos;
            textSelectionMode.SelectedIndex = (int)config.TextSelection;

            backgroundSelectionMode.SelectedIndex = (int)config.BackgroundSelection;
            btnBackgroundColor.BackColor = config.BackgroundColor;
        }
        
        private void LoadText()
        {
            textList.Items.Clear();
            foreach(TextItem item in Program.TextList)
            {
                ListViewItem lvi = new ListViewItem(new string[] { item.Title, item.Content.Replace(Environment.NewLine, " "), item.Author, item.Center.ToString() });
                textList.Items.Add(lvi);
            }
        }

        private void LoadImage()
        {
            imageList.Images.Clear();
            imageListView.Items.Clear();
            ImageItem.LoadImagesAsThumbnail(Program.ImageList, Program.ImagePath, 128, 72);
            foreach(ImageItem item in Program.ImageList)
            {
                imageList.Images.Add(item.Hash, item.Image);
                ListViewItem lvi = new ListViewItem(item.Title);
                lvi.ImageKey = item.Hash;
                imageListView.Items.Add(lvi);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDateFont_Click(object sender, EventArgs e)
        {
            TextStyleDialog dlg = new TextStyleDialog(Program.Config.DateFont, (FontStyle)Program.Config.DateFontStyle, Program.Config.DateColor, Program.Config.DateSize);
            DialogResult result = dlg.ShowDialog();
            if(result == DialogResult.OK)
            {
                changed = true;
                Program.Config.DateFont = dlg.FontFamily;
                Program.Config.DateFontStyle = (int)dlg.Style;
                Program.Config.DateColor = dlg.Color;
                Program.Config.DateSize = dlg.FontSize;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(changed)
            {
                Program.SaveConfig();
                changed = false;
            }
            Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                Program.SaveConfig();
                changed = false;
            }
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(changed)
            {
                switch(MessageBox.Show("配置已更改，退出之前是否保存？", "每日壁纸", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        Program.SaveConfig();
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                    default:
                        e.Cancel = true;
                        break;
                }
            }
        }

        private void dateX_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.DatePosX = (int)dateX.Value;
        }

        private void dateY_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.DatePosY = (int)dateY.Value;
        }

        private void textX_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.TextPosX = (int)textX.Value;
        }

        private void textY_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.TextPosY = (int)textY.Value;
        }

        private void dateCenterPos_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.DateUseCenterPos = dateCenterPos.Checked;
        }

        private void textCenterPos_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.TextUseCenterPos = textCenterPos.Checked;
        }

        private void enableDate_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.DateEnable = enableDate.Checked;
        }

        private void enableText_CheckedChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.TextEnable = enableText.Checked;
        }

        private void updateFreq_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.UpdateFreq = (UpdateFrequency)updateFreq.SelectedIndex;
        }

        private void autoDelete_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.AutoDelete = (int)autoDelete.Value;
        }

        private void textSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.TextSelection = (TextSelectionMode)textSelectionMode.SelectedIndex;
        }

        private void btnTitleFont_Click(object sender, EventArgs e)
        {
            TextStyleDialog dlg = new TextStyleDialog(Program.Config.TextTitleFont, (FontStyle)Program.Config.TextTitleFontStyle, Program.Config.TextTitleColor, Program.Config.TextTitleSize);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                changed = true;
                Program.Config.TextTitleFont = dlg.FontFamily;
                Program.Config.TextTitleFontStyle = (int)dlg.Style;
                Program.Config.TextTitleColor = dlg.Color;
                Program.Config.TextTitleSize = dlg.FontSize;
            }
        }

        private void btnContentFont_Click(object sender, EventArgs e)
        {
            TextStyleDialog dlg = new TextStyleDialog(Program.Config.TextContentFont, (FontStyle)Program.Config.TextContentFontStyle, Program.Config.TextContentColor, Program.Config.TextContentSize);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                changed = true;
                Program.Config.TextContentFont = dlg.FontFamily;
                Program.Config.TextContentFontStyle = (int)dlg.Style;
                Program.Config.TextContentColor = dlg.Color;
                Program.Config.TextContentSize = dlg.FontSize;
            }
        }

        private void btnAuthorFont_Click(object sender, EventArgs e)
        {
            TextStyleDialog dlg = new TextStyleDialog(Program.Config.TextAuthorFont, (FontStyle)Program.Config.TextAuthorFontStyle, Program.Config.TextAuthorColor, Program.Config.TextAuthorSize);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                changed = true;
                Program.Config.TextAuthorFont = dlg.FontFamily;
                Program.Config.TextAuthorFontStyle = (int)dlg.Style;
                Program.Config.TextAuthorColor = dlg.Color;
                Program.Config.TextAuthorSize = dlg.FontSize;
            }
        }

        private void btnDateFormat_Click(object sender, EventArgs e)
        {
            DateFormatDialog dlg = new DateFormatDialog(Program.Config.DateFormat);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                changed = true;
                Program.Config.DateFormat = dlg.FormatString;
            }
        }

        private void btnTextAdd_Click(object sender, EventArgs e)
        {
            TextItemDialog dlg = new TextItemDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                Program.TextList.Add(dlg.ToTextItem());
                ListViewItem lvi = new ListViewItem(new string[] { dlg.Title, dlg.Content.Replace(Environment.NewLine, " "), dlg.Author, dlg.Center.ToString() });
                textList.Items.Add(lvi);
                Program.SaveTextList();
            }
        }

        private void btnTextEdit_Click(object sender, EventArgs e)
        {
            if(textList.SelectedIndices.Count == 1)
            {
                int index = textList.SelectedIndices[0];
                TextItem item = Program.TextList[index];
                TextItemDialog dlg = new TextItemDialog(item);
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    Program.TextList[index] = dlg.ToTextItem();
                    ListViewItem lvi = new ListViewItem(new string[] { dlg.Title, dlg.Content.Replace(Environment.NewLine, " "), dlg.Author, dlg.Center.ToString() });
                    textList.Items[index] = lvi;
                    Program.SaveTextList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTextRemove_Click(object sender, EventArgs e)
        {
            if (textList.SelectedIndices.Count >= 1)
            {
                foreach(int index in textList.SelectedIndices)
                {
                    Program.TextList[index] = null;
                }
                Program.TextList.RemoveAll((i) => ( i == null ));
                foreach(ListViewItem item in textList.SelectedItems)
                {
                    textList.Items.Remove(item);
                }
                Program.SaveTextList();
            }
            else
            {
                MessageBox.Show("请选择一项或多项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTextUp_Click(object sender, EventArgs e)
        {
            if (textList.SelectedIndices.Count == 1)
            {
                int index = textList.SelectedIndices[0];
                if(index > 0)
                {
                    TextItem item = Program.TextList[index];
                    Program.TextList.RemoveAt(index);
                    Program.TextList.Insert(index - 1, item);
                    ListViewItem lvi = textList.Items[index];
                    textList.Items.RemoveAt(index);
                    textList.Items.Insert(index - 1, lvi);
                    Program.SaveTextList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTextDown_Click(object sender, EventArgs e)
        {
            if (textList.SelectedIndices.Count == 1)
            {
                int index = textList.SelectedIndices[0];
                if (index < Program.TextList.Count - 1)
                {
                    TextItem item = Program.TextList[index];
                    Program.TextList.RemoveAt(index);
                    Program.TextList.Insert(index + 1, item);
                    ListViewItem lvi = textList.Items[index];
                    textList.Items.RemoveAt(index);
                    textList.Items.Insert(index + 1, lvi);
                    Program.SaveTextList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTextClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要清空吗？", "每日壁纸", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.TextList.Clear();
                textList.Items.Clear();
                Program.SaveTextList();
            }
        }

        private void btnTextImport_Click(object sender, EventArgs e)
        {
            if(importTextDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<TextItem> list = TextItem.FromXml(importTextDialog.FileName);
                    Program.TextList.AddRange(list);
                    foreach(TextItem item in list)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] { item.Title, item.Content.Replace(Environment.NewLine, " "), item.Author, item.Center.ToString() });
                        textList.Items.Add(lvi);
                    }
                    Program.SaveTextList();
                    MessageBox.Show(string.Format("成功添加了{0}个文本项目", list.Count), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception err)
                {
                    MessageBox.Show("无法导入文本项目，可能是因为文件读取失败或无效。\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTextExport_Click(object sender, EventArgs e)
        {
            if (textList.SelectedIndices.Count >= 1)
            {
                if(exportTextDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<TextItem> list = new List<TextItem>();
                        foreach (int index in textList.SelectedIndices)
                        {
                            list.Add(Program.TextList[index]);
                        }
                        TextItem.ToXml(exportTextDialog.FileName, list);
                        MessageBox.Show(string.Format("成功地导出了{0}个项目，\n位于 {1}", list.Count, exportTextDialog.FileName), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("无法导出文本项目\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择一项或多项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            changed = true;
            Program.Config.BackgroundSelection = (BackgroundMode)backgroundSelectionMode.SelectedIndex;
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            if(backgroundColor.ShowDialog() == DialogResult.OK)
            {
                changed = true;
                Program.Config.BackgroundColor = backgroundColor.Color;
                btnBackgroundColor.BackColor = backgroundColor.Color;
            }
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            ImageItemDialog dlg = new ImageItemDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string hash = Utils.FileMD5String(dlg.FilePath);
                if(Program.ImageList.Exists((item) => (item.Hash == hash)))
                {
                    MessageBox.Show("图像已经存在", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ImageItem item = dlg.CreateImage(Program.ImagePath);
                    item.LoadImageAsThumbnail(Program.ImagePath, 128, 72);
                    Program.ImageList.Add(item);
                    imageList.Images.Add(item.Hash, item.Image);
                    ListViewItem lvi = new ListViewItem(item.Title);
                    lvi.ImageKey = item.Hash;
                    imageListView.Items.Add(lvi);
                    Program.SaveImageList();
                }
            }
            dlg.Dispose();
        }

        private void btnImageRemove_Click(object sender, EventArgs e)
        {
            if (imageListView.SelectedIndices.Count >= 1)
            {
                
                foreach (int index in imageListView.SelectedIndices)
                {
                    imageList.Images[index].Dispose();
                    imageList.Images.RemoveByKey(Program.ImageList[index].Hash);
                    Program.ImageList[index].UnloadImage();
                    File.Delete(Path.Combine(Program.ImagePath, Program.ImageList[index].Filename));
                    Program.ImageList[index] = null;
                }
                Program.ImageList.RemoveAll((i) => (i == null));
                foreach (ListViewItem item in imageListView.SelectedItems)
                {
                    imageListView.Items.Remove(item);
                }
                Program.SaveImageList();
            }
            else
            {
                MessageBox.Show("请选择一项或多项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImageUp_Click(object sender, EventArgs e)
        {
            if (imageListView.SelectedIndices.Count == 1)
            {
                int index = imageListView.SelectedIndices[0];
                if (index > 0)
                {
                    ImageItem item = Program.ImageList[index];
                    Program.ImageList.RemoveAt(index);
                    Program.ImageList.Insert(index - 1, item);
                    ListViewItem lvi = imageListView.Items[index];
                    imageListView.Items.RemoveAt(index);
                    imageListView.Items.Insert(index - 1, lvi);
                    // Fix the FUCKING ListView sorting bug
                    // Fuck you Microsoft
                    imageListView.Alignment = ListViewAlignment.Default;
                    imageListView.Alignment = ListViewAlignment.Top;
                    Program.SaveImageList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImageDown_Click(object sender, EventArgs e)
        {
            if (imageListView.SelectedIndices.Count == 1)
            {
                int index = imageListView.SelectedIndices[0];
                if (index < Program.ImageList.Count - 1)
                {
                    ImageItem item = Program.ImageList[index];
                    Program.ImageList.RemoveAt(index);
                    Program.ImageList.Insert(index + 1, item);
                    ListViewItem lvi = imageListView.Items[index];
                    imageListView.Items.RemoveAt(index);
                    imageListView.Items.Insert(index + 1, lvi);
                    // Fix the FUCKING ListView sorting bug
                    // Fuck you Microsoft
                    imageListView.Alignment = ListViewAlignment.Default;
                    imageListView.Alignment = ListViewAlignment.Top;
                    Program.SaveImageList();
                }
            }
            else
            {
                MessageBox.Show("请选择一项", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Program.Generator.Generate(Utils.GetScreenSize(), Program.TextList, Program.ImageList);
            Image img = Program.Generator.GetImage();
            ImagePreviewDialog dlg = new ImagePreviewDialog(img);
            dlg.ShowDialog();
            img.Dispose();
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("请将程序放在一个固定的位置后再进行安装，是否继续？", "每日壁纸", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    TaskSchedulerClass ts = new TaskSchedulerClass();
                    ts.Connect();
                    ITaskFolder folder = ts.GetFolder("\\");

                    bool exists = false;
                    IRegisteredTaskCollection list = folder.GetTasks(0);
                    foreach(IRegisteredTask t in list)
                    {
                        if(t.Name == "DailyWallpaper")
                        {
                            exists = true;
                            break;
                        }
                    }
                    if(exists)
                    {
                        folder.DeleteTask("DailyWallpaper", 0);
                    }
                    
                    ITaskDefinition task = ts.NewTask(0);
                    task.RegistrationInfo.Author = "DailyWallpaper";
                    task.RegistrationInfo.Description = "DailyWallpaper wallpaper update task.";
                    ITrigger trig = null;
                    switch (Program.Config.UpdateFreq)
                    {
                        case UpdateFrequency.EveryHour:
                            trig = task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
                            trig.Repetition.Interval = "PT60M";
                            break;
                        case UpdateFrequency.EveryHalfDay:
                            trig = task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_TIME);
                            trig.Repetition.Interval = "PT720M";
                            break;
                        case UpdateFrequency.EveryDay:
                            trig = task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_DAILY);
                            break;
                        case UpdateFrequency.EveryWeek:
                            trig = task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_WEEKLY);
                            break;
                        case UpdateFrequency.EveryMonth:
                            trig = task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_MONTHLY);
                            break;
                        default:
                            break;
                    }
                    if(trig != null) trig.StartBoundary = "1970-01-01T00:00:00";
                    ILogonTrigger logonTrig = (ILogonTrigger)task.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
                    logonTrig.UserId = Environment.UserName;
                    IExecAction action = (IExecAction)task.Actions.Create(_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                    action.Path = Application.ExecutablePath;
                    action.Arguments = "-a";
                    action.WorkingDirectory = Application.StartupPath;
                    IRegisteredTask regTask = folder.RegisterTaskDefinition(
                        "DailyWallpaper",
                        task,
                        0,
                        null,
                        null,
                        _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN,
                        ""
                    );
                    regTask.Run(null);
                    MessageBox.Show("安装成功\n", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show("执行安装时出错(请尝试使用管理员身份执行此程序)\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            try
            {
                TaskSchedulerClass ts = new TaskSchedulerClass();
                ts.Connect();
                ITaskFolder folder = ts.GetFolder("\\");

                bool exists = false;
                IRegisteredTaskCollection list = folder.GetTasks(0);
                foreach (IRegisteredTask t in list)
                {
                    if (t.Name == "DailyWallpaper")
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists)
                {
                    folder.DeleteTask("DailyWallpaper", 0);
                    MessageBox.Show("卸载成功", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("尚未安装或已经卸载", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("执行卸载时出错(请尝试使用管理员身份执行此程序)\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否确认重置配置？", "每日壁纸", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Program.ResetConfig();
                Program.SaveConfig();
                ApplyConfigValue(Program.Config);
                changed = false;
                MessageBox.Show("配置已重置", "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
