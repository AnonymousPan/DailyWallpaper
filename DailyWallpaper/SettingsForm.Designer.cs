
namespace DailyWallpaper
{
    partial class SettingsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.btnClearLastWallpaperInfo = new System.Windows.Forms.Button();
            this.btnForceUpdate = new System.Windows.Forms.Button();
            this.btnInstall2 = new System.Windows.Forms.Button();
            this.btnDateFormat = new System.Windows.Forms.Button();
            this.btnDateFont = new System.Windows.Forms.Button();
            this.textCenterPos = new System.Windows.Forms.CheckBox();
            this.textY = new System.Windows.Forms.NumericUpDown();
            this.textX = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.enableText = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateCenterPos = new System.Windows.Forms.CheckBox();
            this.dateY = new System.Windows.Forms.NumericUpDown();
            this.dateX = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.enableDate = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoDelete = new System.Windows.Forms.NumericUpDown();
            this.updateFreq = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageText = new System.Windows.Forms.TabPage();
            this.btnTextExport = new System.Windows.Forms.Button();
            this.btnTextImport = new System.Windows.Forms.Button();
            this.btnTextClear = new System.Windows.Forms.Button();
            this.btnAuthorFont = new System.Windows.Forms.Button();
            this.btnContentFont = new System.Windows.Forms.Button();
            this.btnTitleFont = new System.Windows.Forms.Button();
            this.btnTextDown = new System.Windows.Forms.Button();
            this.btnTextUp = new System.Windows.Forms.Button();
            this.btnTextEdit = new System.Windows.Forms.Button();
            this.btnTextRemove = new System.Windows.Forms.Button();
            this.btnTextAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textList = new System.Windows.Forms.ListView();
            this.columnHeaderTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCenter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textSelectionMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBackground = new System.Windows.Forms.TabPage();
            this.btnImageDown = new System.Windows.Forms.Button();
            this.btnImageUp = new System.Windows.Forms.Button();
            this.btnImageRemove = new System.Windows.Forms.Button();
            this.imageListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnImageAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundSelectionMode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPageAbout = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.importTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.exportTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.backgroundColor = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDelete)).BeginInit();
            this.tabPageText.SuspendLayout();
            this.tabPageBackground.SuspendLayout();
            this.tabPageAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(509, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(428, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(266, 415);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "预览壁纸";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHome);
            this.tabControl1.Controls.Add(this.tabPageText);
            this.tabControl1.Controls.Add(this.tabPageBackground);
            this.tabControl1.Controls.Add(this.tabPageAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 397);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageHome
            // 
            this.tabPageHome.Controls.Add(this.btnClearLastWallpaperInfo);
            this.tabPageHome.Controls.Add(this.btnForceUpdate);
            this.tabPageHome.Controls.Add(this.btnInstall2);
            this.tabPageHome.Controls.Add(this.btnDateFormat);
            this.tabPageHome.Controls.Add(this.btnDateFont);
            this.tabPageHome.Controls.Add(this.textCenterPos);
            this.tabPageHome.Controls.Add(this.textY);
            this.tabPageHome.Controls.Add(this.textX);
            this.tabPageHome.Controls.Add(this.label13);
            this.tabPageHome.Controls.Add(this.enableText);
            this.tabPageHome.Controls.Add(this.label12);
            this.tabPageHome.Controls.Add(this.dateCenterPos);
            this.tabPageHome.Controls.Add(this.dateY);
            this.tabPageHome.Controls.Add(this.dateX);
            this.tabPageHome.Controls.Add(this.label11);
            this.tabPageHome.Controls.Add(this.enableDate);
            this.tabPageHome.Controls.Add(this.label9);
            this.tabPageHome.Controls.Add(this.btnInstall);
            this.tabPageHome.Controls.Add(this.btnUninstall);
            this.tabPageHome.Controls.Add(this.btnReset);
            this.tabPageHome.Controls.Add(this.label5);
            this.tabPageHome.Controls.Add(this.label4);
            this.tabPageHome.Controls.Add(this.autoDelete);
            this.tabPageHome.Controls.Add(this.updateFreq);
            this.tabPageHome.Controls.Add(this.label3);
            this.tabPageHome.Location = new System.Drawing.Point(4, 22);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(568, 371);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "主页";
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // btnClearLastWallpaperInfo
            // 
            this.btnClearLastWallpaperInfo.Location = new System.Drawing.Point(331, 284);
            this.btnClearLastWallpaperInfo.Name = "btnClearLastWallpaperInfo";
            this.btnClearLastWallpaperInfo.Size = new System.Drawing.Size(150, 23);
            this.btnClearLastWallpaperInfo.TabIndex = 26;
            this.btnClearLastWallpaperInfo.Text = "清除上一次的壁纸信息";
            this.btnClearLastWallpaperInfo.UseVisualStyleBackColor = true;
            this.btnClearLastWallpaperInfo.Click += new System.EventHandler(this.btnClearLastWallpaperInfo_Click);
            // 
            // btnForceUpdate
            // 
            this.btnForceUpdate.Location = new System.Drawing.Point(331, 313);
            this.btnForceUpdate.Name = "btnForceUpdate";
            this.btnForceUpdate.Size = new System.Drawing.Size(150, 23);
            this.btnForceUpdate.TabIndex = 25;
            this.btnForceUpdate.Text = "强制更新壁纸";
            this.btnForceUpdate.UseVisualStyleBackColor = true;
            this.btnForceUpdate.Click += new System.EventHandler(this.btnForceUpdate_Click);
            // 
            // btnInstall2
            // 
            this.btnInstall2.Location = new System.Drawing.Point(331, 342);
            this.btnInstall2.Name = "btnInstall2";
            this.btnInstall2.Size = new System.Drawing.Size(150, 23);
            this.btnInstall2.TabIndex = 24;
            this.btnInstall2.Text = "安装为开机启动";
            this.btnInstall2.UseVisualStyleBackColor = true;
            this.btnInstall2.Click += new System.EventHandler(this.btnInstall2_Click);
            // 
            // btnDateFormat
            // 
            this.btnDateFormat.Location = new System.Drawing.Point(473, 69);
            this.btnDateFormat.Name = "btnDateFormat";
            this.btnDateFormat.Size = new System.Drawing.Size(75, 23);
            this.btnDateFormat.TabIndex = 23;
            this.btnDateFormat.Text = "格式设置";
            this.btnDateFormat.UseVisualStyleBackColor = true;
            this.btnDateFormat.Click += new System.EventHandler(this.btnDateFormat_Click);
            // 
            // btnDateFont
            // 
            this.btnDateFont.Location = new System.Drawing.Point(392, 69);
            this.btnDateFont.Name = "btnDateFont";
            this.btnDateFont.Size = new System.Drawing.Size(75, 23);
            this.btnDateFont.TabIndex = 22;
            this.btnDateFont.Text = "字体设置";
            this.btnDateFont.UseVisualStyleBackColor = true;
            this.btnDateFont.Click += new System.EventHandler(this.btnDateFont_Click);
            // 
            // textCenterPos
            // 
            this.textCenterPos.AutoSize = true;
            this.textCenterPos.Location = new System.Drawing.Point(314, 100);
            this.textCenterPos.Name = "textCenterPos";
            this.textCenterPos.Size = new System.Drawing.Size(72, 16);
            this.textCenterPos.TabIndex = 21;
            this.textCenterPos.Text = "中心坐标";
            this.textCenterPos.UseVisualStyleBackColor = true;
            this.textCenterPos.CheckedChanged += new System.EventHandler(this.textCenterPos_CheckedChanged);
            // 
            // textY
            // 
            this.textY.Location = new System.Drawing.Point(258, 99);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(50, 21);
            this.textY.TabIndex = 20;
            this.textY.ValueChanged += new System.EventHandler(this.textY_ValueChanged);
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(202, 99);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(50, 21);
            this.textX.TabIndex = 19;
            this.textX.ValueChanged += new System.EventHandler(this.textX_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 12);
            this.label13.TabIndex = 18;
            this.label13.Text = "位置(X,Y,百分比)";
            // 
            // enableText
            // 
            this.enableText.AutoSize = true;
            this.enableText.Location = new System.Drawing.Point(41, 101);
            this.enableText.Name = "enableText";
            this.enableText.Size = new System.Drawing.Size(48, 16);
            this.enableText.TabIndex = 17;
            this.enableText.Text = "显示";
            this.enableText.UseVisualStyleBackColor = true;
            this.enableText.CheckedChanged += new System.EventHandler(this.enableText_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 16;
            this.label12.Text = "文字";
            // 
            // dateCenterPos
            // 
            this.dateCenterPos.AutoSize = true;
            this.dateCenterPos.Location = new System.Drawing.Point(314, 73);
            this.dateCenterPos.Name = "dateCenterPos";
            this.dateCenterPos.Size = new System.Drawing.Size(72, 16);
            this.dateCenterPos.TabIndex = 15;
            this.dateCenterPos.Text = "中心坐标";
            this.dateCenterPos.UseVisualStyleBackColor = true;
            this.dateCenterPos.CheckedChanged += new System.EventHandler(this.dateCenterPos_CheckedChanged);
            // 
            // dateY
            // 
            this.dateY.Location = new System.Drawing.Point(258, 72);
            this.dateY.Name = "dateY";
            this.dateY.Size = new System.Drawing.Size(50, 21);
            this.dateY.TabIndex = 14;
            this.dateY.ValueChanged += new System.EventHandler(this.dateY_ValueChanged);
            // 
            // dateX
            // 
            this.dateX.Location = new System.Drawing.Point(202, 72);
            this.dateX.Name = "dateX";
            this.dateX.Size = new System.Drawing.Size(50, 21);
            this.dateX.TabIndex = 13;
            this.dateX.ValueChanged += new System.EventHandler(this.dateX_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(95, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "位置(X,Y,百分比)";
            // 
            // enableDate
            // 
            this.enableDate.AutoSize = true;
            this.enableDate.Location = new System.Drawing.Point(41, 73);
            this.enableDate.Name = "enableDate";
            this.enableDate.Size = new System.Drawing.Size(48, 16);
            this.enableDate.TabIndex = 9;
            this.enableDate.Text = "显示";
            this.enableDate.UseVisualStyleBackColor = true;
            this.enableDate.CheckedChanged += new System.EventHandler(this.enableDate_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "日期";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(487, 284);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 7;
            this.btnInstall.Text = "安装";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(487, 313);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 6;
            this.btnUninstall.Text = "卸载";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(487, 342);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置设置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "注:0代表永不删除旧壁纸";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "壁纸保留数量";
            // 
            // autoDelete
            // 
            this.autoDelete.Location = new System.Drawing.Point(89, 32);
            this.autoDelete.Name = "autoDelete";
            this.autoDelete.Size = new System.Drawing.Size(121, 21);
            this.autoDelete.TabIndex = 2;
            this.autoDelete.ValueChanged += new System.EventHandler(this.autoDelete_ValueChanged);
            // 
            // updateFreq
            // 
            this.updateFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.updateFreq.FormattingEnabled = true;
            this.updateFreq.Items.AddRange(new object[] {
            "每小时",
            "每半天",
            "每天",
            "每周",
            "每月"});
            this.updateFreq.Location = new System.Drawing.Point(89, 6);
            this.updateFreq.Name = "updateFreq";
            this.updateFreq.Size = new System.Drawing.Size(121, 20);
            this.updateFreq.TabIndex = 1;
            this.updateFreq.SelectedIndexChanged += new System.EventHandler(this.updateFreq_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "壁纸切换频率";
            // 
            // tabPageText
            // 
            this.tabPageText.Controls.Add(this.btnTextExport);
            this.tabPageText.Controls.Add(this.btnTextImport);
            this.tabPageText.Controls.Add(this.btnTextClear);
            this.tabPageText.Controls.Add(this.btnAuthorFont);
            this.tabPageText.Controls.Add(this.btnContentFont);
            this.tabPageText.Controls.Add(this.btnTitleFont);
            this.tabPageText.Controls.Add(this.btnTextDown);
            this.tabPageText.Controls.Add(this.btnTextUp);
            this.tabPageText.Controls.Add(this.btnTextEdit);
            this.tabPageText.Controls.Add(this.btnTextRemove);
            this.tabPageText.Controls.Add(this.btnTextAdd);
            this.tabPageText.Controls.Add(this.label2);
            this.tabPageText.Controls.Add(this.textList);
            this.tabPageText.Controls.Add(this.textSelectionMode);
            this.tabPageText.Controls.Add(this.label1);
            this.tabPageText.Location = new System.Drawing.Point(4, 22);
            this.tabPageText.Name = "tabPageText";
            this.tabPageText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageText.Size = new System.Drawing.Size(568, 371);
            this.tabPageText.TabIndex = 1;
            this.tabPageText.Text = "文本";
            this.tabPageText.UseVisualStyleBackColor = true;
            // 
            // btnTextExport
            // 
            this.btnTextExport.Location = new System.Drawing.Point(457, 32);
            this.btnTextExport.Name = "btnTextExport";
            this.btnTextExport.Size = new System.Drawing.Size(50, 23);
            this.btnTextExport.TabIndex = 14;
            this.btnTextExport.Text = "导出";
            this.btnTextExport.UseVisualStyleBackColor = true;
            this.btnTextExport.Click += new System.EventHandler(this.btnTextExport_Click);
            // 
            // btnTextImport
            // 
            this.btnTextImport.Location = new System.Drawing.Point(401, 32);
            this.btnTextImport.Name = "btnTextImport";
            this.btnTextImport.Size = new System.Drawing.Size(50, 23);
            this.btnTextImport.TabIndex = 13;
            this.btnTextImport.Text = "导入";
            this.btnTextImport.UseVisualStyleBackColor = true;
            this.btnTextImport.Click += new System.EventHandler(this.btnTextImport_Click);
            // 
            // btnTextClear
            // 
            this.btnTextClear.Location = new System.Drawing.Point(345, 32);
            this.btnTextClear.Name = "btnTextClear";
            this.btnTextClear.Size = new System.Drawing.Size(50, 23);
            this.btnTextClear.TabIndex = 12;
            this.btnTextClear.Text = "清空";
            this.btnTextClear.UseVisualStyleBackColor = true;
            this.btnTextClear.Click += new System.EventHandler(this.btnTextClear_Click);
            // 
            // btnAuthorFont
            // 
            this.btnAuthorFont.Location = new System.Drawing.Point(354, 4);
            this.btnAuthorFont.Name = "btnAuthorFont";
            this.btnAuthorFont.Size = new System.Drawing.Size(75, 23);
            this.btnAuthorFont.TabIndex = 11;
            this.btnAuthorFont.Text = "作者栏字体";
            this.btnAuthorFont.UseVisualStyleBackColor = true;
            this.btnAuthorFont.Click += new System.EventHandler(this.btnAuthorFont_Click);
            // 
            // btnContentFont
            // 
            this.btnContentFont.Location = new System.Drawing.Point(273, 4);
            this.btnContentFont.Name = "btnContentFont";
            this.btnContentFont.Size = new System.Drawing.Size(75, 23);
            this.btnContentFont.TabIndex = 10;
            this.btnContentFont.Text = "内容字体";
            this.btnContentFont.UseVisualStyleBackColor = true;
            this.btnContentFont.Click += new System.EventHandler(this.btnContentFont_Click);
            // 
            // btnTitleFont
            // 
            this.btnTitleFont.Location = new System.Drawing.Point(192, 4);
            this.btnTitleFont.Name = "btnTitleFont";
            this.btnTitleFont.Size = new System.Drawing.Size(75, 23);
            this.btnTitleFont.TabIndex = 9;
            this.btnTitleFont.Text = "标题栏字体";
            this.btnTitleFont.UseVisualStyleBackColor = true;
            this.btnTitleFont.Click += new System.EventHandler(this.btnTitleFont_Click);
            // 
            // btnTextDown
            // 
            this.btnTextDown.Location = new System.Drawing.Point(289, 33);
            this.btnTextDown.Name = "btnTextDown";
            this.btnTextDown.Size = new System.Drawing.Size(50, 23);
            this.btnTextDown.TabIndex = 8;
            this.btnTextDown.Text = "下移";
            this.btnTextDown.UseVisualStyleBackColor = true;
            this.btnTextDown.Click += new System.EventHandler(this.btnTextDown_Click);
            // 
            // btnTextUp
            // 
            this.btnTextUp.Location = new System.Drawing.Point(233, 32);
            this.btnTextUp.Name = "btnTextUp";
            this.btnTextUp.Size = new System.Drawing.Size(50, 23);
            this.btnTextUp.TabIndex = 7;
            this.btnTextUp.Text = "上移";
            this.btnTextUp.UseVisualStyleBackColor = true;
            this.btnTextUp.Click += new System.EventHandler(this.btnTextUp_Click);
            // 
            // btnTextEdit
            // 
            this.btnTextEdit.Location = new System.Drawing.Point(121, 32);
            this.btnTextEdit.Name = "btnTextEdit";
            this.btnTextEdit.Size = new System.Drawing.Size(50, 23);
            this.btnTextEdit.TabIndex = 6;
            this.btnTextEdit.Text = "编辑";
            this.btnTextEdit.UseVisualStyleBackColor = true;
            this.btnTextEdit.Click += new System.EventHandler(this.btnTextEdit_Click);
            // 
            // btnTextRemove
            // 
            this.btnTextRemove.Location = new System.Drawing.Point(177, 32);
            this.btnTextRemove.Name = "btnTextRemove";
            this.btnTextRemove.Size = new System.Drawing.Size(50, 23);
            this.btnTextRemove.TabIndex = 6;
            this.btnTextRemove.Text = "删除";
            this.btnTextRemove.UseVisualStyleBackColor = true;
            this.btnTextRemove.Click += new System.EventHandler(this.btnTextRemove_Click);
            // 
            // btnTextAdd
            // 
            this.btnTextAdd.Location = new System.Drawing.Point(65, 32);
            this.btnTextAdd.Name = "btnTextAdd";
            this.btnTextAdd.Size = new System.Drawing.Size(50, 23);
            this.btnTextAdd.TabIndex = 5;
            this.btnTextAdd.Text = "添加";
            this.btnTextAdd.UseVisualStyleBackColor = true;
            this.btnTextAdd.Click += new System.EventHandler(this.btnTextAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文本列表";
            // 
            // textList
            // 
            this.textList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTitle,
            this.columnHeaderContent,
            this.columnHeaderAuthor,
            this.columnHeaderCenter});
            this.textList.FullRowSelect = true;
            this.textList.HideSelection = false;
            this.textList.Location = new System.Drawing.Point(8, 61);
            this.textList.Name = "textList";
            this.textList.Size = new System.Drawing.Size(554, 304);
            this.textList.TabIndex = 3;
            this.textList.UseCompatibleStateImageBehavior = false;
            this.textList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTitle
            // 
            this.columnHeaderTitle.Text = "标题";
            this.columnHeaderTitle.Width = 100;
            // 
            // columnHeaderContent
            // 
            this.columnHeaderContent.Text = "内容";
            this.columnHeaderContent.Width = 240;
            // 
            // columnHeaderAuthor
            // 
            this.columnHeaderAuthor.Text = "作者/出处";
            this.columnHeaderAuthor.Width = 100;
            // 
            // columnHeaderCenter
            // 
            this.columnHeaderCenter.Text = "居中显示";
            // 
            // textSelectionMode
            // 
            this.textSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textSelectionMode.FormattingEnabled = true;
            this.textSelectionMode.Items.AddRange(new object[] {
            "顺序选择",
            "随机选择"});
            this.textSelectionMode.Location = new System.Drawing.Point(65, 6);
            this.textSelectionMode.Name = "textSelectionMode";
            this.textSelectionMode.Size = new System.Drawing.Size(121, 20);
            this.textSelectionMode.TabIndex = 2;
            this.textSelectionMode.SelectedIndexChanged += new System.EventHandler(this.textSelectionMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择方式";
            // 
            // tabPageBackground
            // 
            this.tabPageBackground.Controls.Add(this.btnImageDown);
            this.tabPageBackground.Controls.Add(this.btnImageUp);
            this.tabPageBackground.Controls.Add(this.btnImageRemove);
            this.tabPageBackground.Controls.Add(this.imageListView);
            this.tabPageBackground.Controls.Add(this.btnImageAdd);
            this.tabPageBackground.Controls.Add(this.label8);
            this.tabPageBackground.Controls.Add(this.btnBackgroundColor);
            this.tabPageBackground.Controls.Add(this.label7);
            this.tabPageBackground.Controls.Add(this.backgroundSelectionMode);
            this.tabPageBackground.Controls.Add(this.label6);
            this.tabPageBackground.Location = new System.Drawing.Point(4, 22);
            this.tabPageBackground.Name = "tabPageBackground";
            this.tabPageBackground.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBackground.Size = new System.Drawing.Size(568, 371);
            this.tabPageBackground.TabIndex = 2;
            this.tabPageBackground.Text = "背景";
            this.tabPageBackground.UseVisualStyleBackColor = true;
            // 
            // btnImageDown
            // 
            this.btnImageDown.Location = new System.Drawing.Point(308, 32);
            this.btnImageDown.Name = "btnImageDown";
            this.btnImageDown.Size = new System.Drawing.Size(75, 23);
            this.btnImageDown.TabIndex = 11;
            this.btnImageDown.Text = "下移";
            this.btnImageDown.UseVisualStyleBackColor = true;
            this.btnImageDown.Click += new System.EventHandler(this.btnImageDown_Click);
            // 
            // btnImageUp
            // 
            this.btnImageUp.Location = new System.Drawing.Point(227, 32);
            this.btnImageUp.Name = "btnImageUp";
            this.btnImageUp.Size = new System.Drawing.Size(75, 23);
            this.btnImageUp.TabIndex = 10;
            this.btnImageUp.Text = "上移";
            this.btnImageUp.UseVisualStyleBackColor = true;
            this.btnImageUp.Click += new System.EventHandler(this.btnImageUp_Click);
            // 
            // btnImageRemove
            // 
            this.btnImageRemove.Location = new System.Drawing.Point(146, 32);
            this.btnImageRemove.Name = "btnImageRemove";
            this.btnImageRemove.Size = new System.Drawing.Size(75, 23);
            this.btnImageRemove.TabIndex = 9;
            this.btnImageRemove.Text = "移除";
            this.btnImageRemove.UseVisualStyleBackColor = true;
            this.btnImageRemove.Click += new System.EventHandler(this.btnImageRemove_Click);
            // 
            // imageListView
            // 
            this.imageListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.imageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.imageListView.FullRowSelect = true;
            this.imageListView.HideSelection = false;
            this.imageListView.LargeImageList = this.imageList;
            this.imageListView.Location = new System.Drawing.Point(8, 61);
            this.imageListView.Name = "imageListView";
            this.imageListView.ShowGroups = false;
            this.imageListView.Size = new System.Drawing.Size(554, 307);
            this.imageListView.TabIndex = 8;
            this.imageListView.UseCompatibleStateImageBehavior = false;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(128, 72);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnImageAdd
            // 
            this.btnImageAdd.Location = new System.Drawing.Point(65, 32);
            this.btnImageAdd.Name = "btnImageAdd";
            this.btnImageAdd.Size = new System.Drawing.Size(75, 23);
            this.btnImageAdd.TabIndex = 7;
            this.btnImageAdd.Text = "添加";
            this.btnImageAdd.UseVisualStyleBackColor = true;
            this.btnImageAdd.Click += new System.EventHandler(this.btnImageAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "填充颜色";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(265, 4);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundColor.TabIndex = 5;
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "图片列表";
            // 
            // backgroundSelectionMode
            // 
            this.backgroundSelectionMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.backgroundSelectionMode.FormattingEnabled = true;
            this.backgroundSelectionMode.Items.AddRange(new object[] {
            "纯色填充",
            "顺序选择",
            "随机选择"});
            this.backgroundSelectionMode.Location = new System.Drawing.Point(65, 6);
            this.backgroundSelectionMode.Name = "backgroundSelectionMode";
            this.backgroundSelectionMode.Size = new System.Drawing.Size(121, 20);
            this.backgroundSelectionMode.TabIndex = 3;
            this.backgroundSelectionMode.SelectedIndexChanged += new System.EventHandler(this.backgroundSelectionMode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "选择方式";
            // 
            // tabPageAbout
            // 
            this.tabPageAbout.Controls.Add(this.linkLabel1);
            this.tabPageAbout.Controls.Add(this.label10);
            this.tabPageAbout.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbout.Name = "tabPageAbout";
            this.tabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbout.Size = new System.Drawing.Size(568, 371);
            this.tabPageAbout.TabIndex = 3;
            this.tabPageAbout.Text = "关于";
            this.tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 12F);
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(8, 46);
            this.linkLabel1.Location = new System.Drawing.Point(23, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(451, 24);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github: https://github.com/AnonymousPan/DailyWallpaper";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(20, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 64);
            this.label10.TabIndex = 0;
            this.label10.Text = "关于 每日壁纸\r\n版本: V1.0.1\r\n作者: 潘某人-AnonymousPan\r\nE-mail: pansichen666@gmail.com";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(347, 415);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // importTextDialog
            // 
            this.importTextDialog.DefaultExt = "xml";
            this.importTextDialog.Filter = "XML文档|*.xml";
            this.importTextDialog.Title = "导入文本";
            // 
            // exportTextDialog
            // 
            this.exportTextDialog.DefaultExt = "xml";
            this.exportTextDialog.Filter = "XML文档|*.xml";
            this.exportTextDialog.Title = "导出文本";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "每日壁纸";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.tabPageHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoDelete)).EndInit();
            this.tabPageText.ResumeLayout(false);
            this.tabPageText.PerformLayout();
            this.tabPageBackground.ResumeLayout(false);
            this.tabPageBackground.PerformLayout();
            this.tabPageAbout.ResumeLayout(false);
            this.tabPageAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageText;
        private System.Windows.Forms.ComboBox textSelectionMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView textList;
        private System.Windows.Forms.ColumnHeader columnHeaderTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderContent;
        private System.Windows.Forms.ColumnHeader columnHeaderAuthor;
        private System.Windows.Forms.ComboBox updateFreq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageBackground;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown autoDelete;
        private System.Windows.Forms.Button btnTextDown;
        private System.Windows.Forms.Button btnTextUp;
        private System.Windows.Forms.Button btnTextEdit;
        private System.Windows.Forms.Button btnTextRemove;
        private System.Windows.Forms.Button btnTextAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox backgroundSelectionMode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImageDown;
        private System.Windows.Forms.Button btnImageUp;
        private System.Windows.Forms.Button btnImageRemove;
        private System.Windows.Forms.ListView imageListView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnImageAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.NumericUpDown dateY;
        private System.Windows.Forms.NumericUpDown dateX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox enableDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeaderCenter;
        private System.Windows.Forms.CheckBox textCenterPos;
        private System.Windows.Forms.NumericUpDown textY;
        private System.Windows.Forms.NumericUpDown textX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox enableText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox dateCenterPos;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnDateFormat;
        private System.Windows.Forms.Button btnDateFont;
        private System.Windows.Forms.Button btnAuthorFont;
        private System.Windows.Forms.Button btnContentFont;
        private System.Windows.Forms.Button btnTitleFont;
        private System.Windows.Forms.Button btnTextExport;
        private System.Windows.Forms.Button btnTextImport;
        private System.Windows.Forms.Button btnTextClear;
        private System.Windows.Forms.OpenFileDialog importTextDialog;
        private System.Windows.Forms.SaveFileDialog exportTextDialog;
        private System.Windows.Forms.ColorDialog backgroundColor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TabPage tabPageAbout;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClearLastWallpaperInfo;
        private System.Windows.Forms.Button btnForceUpdate;
        private System.Windows.Forms.Button btnInstall2;
    }
}

