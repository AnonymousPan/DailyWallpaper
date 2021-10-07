using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Xml;

namespace DailyWallpaper
{
    public class ImageItem
    {
        public ImageItem()
        {
            
        }

        public ImageItem(string title, string hash, string format)
        {
            Title = title;
            Hash = hash;
            Format = format;
        }

        public void LoadImage(string imagePath)
        {
            string path = Path.Combine(imagePath, Filename);
            Image = Image.FromFile(path);
        }

        public void LoadImageAsThumbnail(string imagePath, int width, int height)
        {
            string path = Path.Combine(imagePath, Filename);
            Image img = Image.FromFile(path);
            Image = img.GetThumbnailImage(width, height, null, IntPtr.Zero);
            img.Dispose();
        }

        public Image GetImage(string imagePath)
        {
            string path = Path.Combine(imagePath, Filename);
            return Image.FromFile(path);
        }

        public void UnloadImage()
        {
            Image.Dispose();
            Image = null;
        }

        public static List<ImageItem> FromXml(string path)
        {
            try
            {
                List<ImageItem> list = new List<ImageItem>();
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode root = doc.SelectSingleNode("/ImageList");
                foreach(XmlElement elem in root.ChildNodes)
                {
                    XmlAttributeCollection attr = elem.Attributes;
                    ImageItem item = new ImageItem(attr["Title"].Value, attr["Hash"].Value, attr["Format"].Value);
                    list.Add(item);
                }
                return list;
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public static void ToXml(string path, List<ImageItem> list)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"), root);
                XmlElement listElem = doc.CreateElement("ImageList");
                foreach(ImageItem item in list)
                {
                    XmlElement elem = doc.CreateElement("Item");
                    elem.SetAttribute("Title", item.Title);
                    elem.SetAttribute("Hash", item.Hash);
                    elem.SetAttribute("Format", item.Format);
                    listElem.AppendChild(elem);
                }
                doc.AppendChild(listElem);
                doc.Save(path);

            }
            catch (Exception err)
            {
                throw err;
            }
        }

        public static void LoadImages(List<ImageItem> list, string path)
        {
            foreach(ImageItem item in list)
            {
                item.LoadImage(path);
            }
        }

        public static void LoadImagesAsThumbnail(List<ImageItem> list, string path, int width, int height)
        {
            foreach (ImageItem item in list)
            {
                item.LoadImageAsThumbnail(path, width, height);
            }
        }

        public static void UnloadImages(List<ImageItem> list)
        {
            foreach(ImageItem item in list)
            {
                item.UnloadImage();
            }
        }

        public string Title { get; set; }
        public string Hash { get; set; }
        public string Format { get; set; }
        public string Filename { get { return Hash.ToLower() + "." + Format.ToLower(); } }
        public Image Image { get; private set; }
    }
}
