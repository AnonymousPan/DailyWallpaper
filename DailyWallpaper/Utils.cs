using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace DailyWallpaper
{
    public static class Utils
    {
        private static MD5CryptoServiceProvider md5Provider = new MD5CryptoServiceProvider();

        [DllImport("user32.dll")]
        private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

        static Utils()
        {
            md5Provider.Initialize();
        }

        public static string FileMD5String(string path)
        {
            byte[] file = File.ReadAllBytes(path);
            byte[] hash = md5Provider.ComputeHash(file);
            string str = "";
            foreach(byte b in hash)
            {
                str += b.ToString("X2");
            }
            return str.ToLower();
        }

        public static Size GetScreenSize()
        {
            return Screen.PrimaryScreen.Bounds.Size;
        }

        public static int ToUnixTimestamp(DateTime time)
        {
            return (int)((time.ToUniversalTime().Ticks - 621355968000000000) / 10000000);
        }

        public static DateTime FromUnixTimestamp(int timestamp)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            return startTime.AddSeconds(timestamp);
        }

        public static void SetWallpaper(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue("WallpaperStyle", "2", RegistryValueKind.String);
            key.SetValue("TileWallpaper", "0", RegistryValueKind.String);
            key.Close();
            SystemParametersInfo(0x0014, 1, path, 1);
        }

        public static void DeleteOldWallpaper(string path, int num)
        {
            List<(string, int)> list = new List<(string, int)>();
            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
            {
                if(file.EndsWith(".png") || file.EndsWith(".jpg"))
                {
                    int i = 0;
                    if(int.TryParse(Path.GetFileNameWithoutExtension(file), out i))
                    {
                        list.Add((file, i));
                    }
                }
            }
            
            if(list.Count > num)
            {
                list.Sort((x, y) => (x.Item2 > y.Item2 ? -1 : 1));
                for(int i = num; i < list.Count; i++ )
                {
                    File.Delete(list[i].Item1);
                }
            }
        }

        public static bool IsSameYear(DateTime t1, DateTime t2)
        {
            return t1.Year == t2.Year;
        }

        public static bool IsSameMonth(DateTime t1, DateTime t2)
        {
            return IsSameYear(t1, t2) && t1.Month == t2.Month;
        }

        public static bool IsSameWeek(DateTime t1, DateTime t2)
        {
            return IsSameYear(t1, t2) && ((t1.DayOfYear - 1) / 7 == (t2.DayOfYear - 1) / 7);
        }

        public static bool IsSameDay(DateTime t1, DateTime t2)
        {
            return IsSameMonth(t1, t2) && t1.Day == t2.Day;
        }

        public static bool IsSameHour(DateTime t1, DateTime t2)
        {
            return IsSameDay(t1, t2) && t1.Hour == t2.Hour;
        }
    }
}
