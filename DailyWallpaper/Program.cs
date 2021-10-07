using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace DailyWallpaper
{
    static class Program
    {
        public static BasicConfig Config { get; private set; }
        public static List<TextItem> TextList { get; private set; } = new List<TextItem>();
        public static List<ImageItem> ImageList { get; private set; } = new List<ImageItem>();
        public static LastWallpaperInfo LastWallpaper { get; private set; }
        public static WallpaperGenerator Generator { get; private set; }
        public static string ImagePath { get; }  = "Image/";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                if (!File.Exists("BasicConfig.xml"))
                {
                    Config = BasicConfig.GetDefault();
                    Config.Save("BasicConfig.xml");
                }
                else
                {
                    Config = BasicConfig.Load("BasicConfig.xml");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("无法创建或加载配置文件\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!File.Exists("TextList.xml"))
                {
                    TextItem.ToXml("TextList.xml", TextList);
                }
                else
                {
                    TextList.AddRange(TextItem.FromXml("TextList.xml"));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("无法创建或加载文本列表文件\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!File.Exists("ImageList.xml"))
                {
                    ImageItem.ToXml("ImageList.xml", ImageList);
                }
                else
                {
                    ImageList.AddRange(ImageItem.FromXml("ImageList.xml"));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("无法创建或加载图片列表文件\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!Directory.Exists("Image"))
                {
                    Directory.CreateDirectory("Image");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("无法创建图像文件夹\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (!Directory.Exists("Wallpaper"))
                {
                    Directory.CreateDirectory("Wallpaper");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("无法创建壁纸文件夹\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if(!File.Exists("LastWallpaper.xml"))
                {
                    LastWallpaper = new LastWallpaperInfo();
                    LastWallpaper.ToXml("LastWallpaper.xml");
                }
                else
                {
                    LastWallpaper = new LastWallpaperInfo("LastWallpaper.xml");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("无法加载上一次的壁纸信息\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LastWallpaper = new LastWallpaperInfo();
            }

            try
            {
                Generator = new WallpaperGenerator(Config, LastWallpaper, ImagePath);
            }
            catch (Exception err)
            {
                MessageBox.Show("无法初始化壁纸生成器\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> args = new List<string>(Environment.GetCommandLineArgs());
            bool flag = args.Contains("-f");
            if(flag || args.Contains("-a"))
            {
                try
                {
                    if (flag || LastWallpaper.NeedToUpdate(Config.UpdateFreq))
                    {
                        Generator.Generate(Utils.GetScreenSize(), TextList, ImageList);
                        Image img = Generator.GetImage();
                        string path = string.Format("Wallpaper/{0}.png", Utils.ToUnixTimestamp(DateTime.Now));
                        img.Save(path, System.Drawing.Imaging.ImageFormat.Png);
                        img.Dispose();
                        Utils.SetWallpaper(Path.GetFullPath(path));
                        LastWallpaper.Time = Utils.ToUnixTimestamp(DateTime.Now);
                        LastWallpaper.ToXml("LastWallpaper.xml");
                        if (Config.AutoDelete > 0)
                        {
                            Utils.DeleteOldWallpaper(Path.GetFullPath("Wallpaper"), Config.AutoDelete);
                        }
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("更新壁纸时出错\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(args.Contains("-c"))
            {
                try
                {
                    if (Config.AutoDelete > 0)
                    {
                        Utils.DeleteOldWallpaper(Path.GetFullPath("Wallpaper"), Config.AutoDelete);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("删除旧壁纸时出错\n" + err.ToString(), "每日壁纸", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SettingsForm());
            }
        }

        public static void ResetConfig()
        {
            Config = BasicConfig.GetDefault();
        }

        public static void SaveConfig()
        {
            Config.Save("BasicConfig.xml");
        }

        public static void SaveTextList()
        {
            TextItem.ToXml("TextList.xml", TextList);
        }

        public static void SaveImageList()
        {
            ImageItem.ToXml("ImageList.xml", ImageList);
        }
    }
}
