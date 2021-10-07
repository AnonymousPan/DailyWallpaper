using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;

namespace DailyWallpaper
{
    public class LastWallpaperInfo
    {
        public LastWallpaperInfo()
        {

        }

        public LastWallpaperInfo(string xmlPath)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);
                XmlNode root = doc.SelectSingleNode("/LastWallpaper");
                Time = int.Parse(root["Time"].InnerText);
                TextIndex = int.Parse(root["TextIndex"].InnerText);
                ImageIndex = int.Parse(root["ImageIndex"].InnerText);
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static LastWallpaperInfo FromXml(string path)
        {
            return new LastWallpaperInfo(path);
        }

        public void ToXml(string path)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"), root);
                XmlElement rootElem = doc.CreateElement("LastWallpaper");
                XmlElement elem = doc.CreateElement("Time");
                elem.InnerText = Time.ToString();
                rootElem.AppendChild(elem);
                elem = doc.CreateElement("TextIndex");
                elem.InnerText = TextIndex.ToString();
                rootElem.AppendChild(elem);
                elem = doc.CreateElement("ImageIndex");
                elem.InnerText = ImageIndex.ToString();
                rootElem.AppendChild(elem);
                doc.AppendChild(rootElem);
                doc.Save(path);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public bool NeedToUpdate(UpdateFrequency freq)
        {
            DateTime time = Utils.FromUnixTimestamp(Time);
            DateTime now = DateTime.Now;
            
            switch (freq)
            {
                case UpdateFrequency.EveryHour:
                    return !Utils.IsSameHour(time, now);
                case UpdateFrequency.EveryHalfDay:
                    return !Utils.IsSameDay(time, now) && (time.Hour / 12 != now.Hour / 12);
                case UpdateFrequency.EveryDay:
                    return !Utils.IsSameDay(time, now);
                case UpdateFrequency.EveryWeek:
                    return !Utils.IsSameWeek(time, now);
                case UpdateFrequency.EveryMonth:
                    return !Utils.IsSameMonth(time, now);
                default:
                    return false;
            }
        }

        public int Time { get; set; } = 0;
        public int TextIndex { get; set; } = 0;
        public int ImageIndex { get; set; } = 0;
        
    }
}
