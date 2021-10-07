using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace DailyWallpaper
{
    public class TextItem
    {
        public TextItem()
        {

        }

        public TextItem(string title, string content, string author, bool center)
        {
            Title = title;
            Content = content;
            Author = author;
            Center = center;
        }

        public static List<TextItem> FromXml(string path)
        {
            try
            {
                List<TextItem> list = new List<TextItem>();
                XmlDocument doc = new XmlDocument();
                doc.Load(path);
                XmlNode root = doc.SelectSingleNode("/TextList");
                foreach (XmlElement elem in root.ChildNodes)
                {
                    TextItem item = new TextItem();
                    item.Title = elem["Title"].InnerText;
                    item.Author = elem["Author"].InnerText;
                    item.Center = bool.Parse(elem.Attributes["Center"].Value);
                    XmlElement l = elem["Content"];
                    XmlNodeList nodes = l.ChildNodes;
                    for(int i = 0; i < nodes.Count; i++ )
                    {
                        item.Content += nodes[i].InnerText;
                        if (i < nodes.Count - 1) item.Content += Environment.NewLine;
                    }
                    list.Add(item);
                }
                return list;
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public static void ToXml(string path, List<TextItem> list)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"), root);
                XmlElement listElem = doc.CreateElement("TextList");
                foreach (TextItem item in list)
                {
                    XmlElement itemElem = doc.CreateElement("Item");
                    itemElem.SetAttribute("Center", item.Center.ToString());
                    XmlElement elem = doc.CreateElement("Title");
                    elem.InnerText = item.Title;
                    itemElem.AppendChild(elem);
                    elem = doc.CreateElement("Author");
                    elem.InnerText = item.Author;
                    itemElem.AppendChild(elem);
                    elem = doc.CreateElement("Content");
                    string[] lines = item.Content.TrimEnd(new char[] { '\r', '\n' })
                        .Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                    foreach (string line in lines)
                    {
                        XmlElement lineElem = doc.CreateElement("Line");
                        if (!string.IsNullOrWhiteSpace(line)) lineElem.InnerText = line;
                        elem.AppendChild(lineElem);
                    }
                    itemElem.AppendChild(elem);
                    listElem.AppendChild(itemElem);
                }
                doc.AppendChild(listElem);
                doc.Save(path);
            }
            catch(Exception err)
            {
                throw err;
            }
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public bool Center { get; set; }
    }
}
