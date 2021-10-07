
namespace DailyWallpaper
{
    partial class ImageItemDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.imagePreview = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图片路径";
            // 
            // filePath
            // 
            this.filePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePath.Location = new System.Drawing.Point(71, 12);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(245, 21);
            this.filePath.TabIndex = 1;
            this.filePath.Leave += new System.EventHandler(this.filePath_Leave);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFileDialog.Location = new System.Drawing.Point(322, 10);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(50, 23);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "浏览";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "图片标题";
            // 
            // imagePreview
            // 
            this.imagePreview.Location = new System.Drawing.Point(14, 66);
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.Size = new System.Drawing.Size(358, 104);
            this.imagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePreview.TabIndex = 4;
            this.imagePreview.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Location = new System.Drawing.Point(71, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(301, 21);
            this.title.TabIndex = 5;
            this.title.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.title_ChangeUICues);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(297, 176);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(216, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "所有图像|*.bmp;*.jpg;*.jpeg;*.png|位图|*.bmp|JPEG图像|*.jpg;*.jpeg|PNG图像|*.png";
            // 
            // ImageItemDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.title);
            this.Controls.Add(this.imagePreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageItemDialog";
            this.Text = "图片项目";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ImageItemDialog_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imagePreview;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}