using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace DailyWallpaper
{
    public class BasicConfig
    {
        public BasicConfig()
        {

        }

        public static BasicConfig GetDefault()
        {
            return new BasicConfig();
        }

        public static BasicConfig Load(string path)
        {
            BasicConfig config = new BasicConfig();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            // Common Settings
            XmlNode common = doc.SelectSingleNode("/BasicConfig/Common");
            config.UpdateFreq = (UpdateFrequency)int.Parse(common["UpdateFreq"].InnerText);
            config.AutoDelete = int.Parse(common["AutoDelete"].InnerText);

            // Background
            XmlNode background = doc.SelectSingleNode("/BasicConfig/Background");
            config.BackgroundSelection = (BackgroundMode)int.Parse(background["Mode"].InnerText);
            config.BackgroundColor = Color.FromArgb(int.Parse(background["Color"].InnerText));

            // Date
            XmlNode date = doc.SelectSingleNode("/BasicConfig/Date");
            config.DateEnable = bool.Parse(date.Attributes["Enable"].Value);
            XmlAttributeCollection attr = date["Position"].Attributes;
            config.DatePosX = int.Parse(attr["X"].Value);
            config.DatePosY = int.Parse(attr["Y"].Value);
            config.DateUseCenterPos = bool.Parse(attr["UseCenterPos"].Value);
            string font;
            int style;
            Color color;
            float size;
            ReadTextStyleNode(date["Style"], out font, out style, out color, out size);
            config.DateFont = font;
            config.DateFontStyle = style;
            config.DateColor = color;
            config.DateSize = size;
            config.DateFormat = date["Format"].InnerText;

            // Text
            XmlNode text = doc.SelectSingleNode("/BasicConfig/Text");
            config.TextEnable = bool.Parse(text.Attributes["Enable"].Value);
            config.TextSelection = (TextSelectionMode)int.Parse(text["Mode"].InnerText);
            attr = text["Position"].Attributes;
            config.TextPosX = int.Parse(attr["X"].Value);
            config.TextPosY = int.Parse(attr["Y"].Value);
            config.TextUseCenterPos = bool.Parse(attr["UseCenterPos"].Value);
            ReadTextStyleNode(text["Title"], out font, out style, out color, out size);
            config.TextTitleFont = font;
            config.TextTitleFontStyle = style;
            config.TextTitleColor = color;
            config.TextTitleSize = size;
            ReadTextStyleNode(text["Content"], out font, out style, out color, out size);
            config.TextContentFont = font;
            config.TextContentFontStyle = style;
            config.TextContentColor = color;
            config.TextContentSize = size;
            ReadTextStyleNode(text["Author"], out font, out style, out color, out size);
            config.TextAuthorFont = font;
            config.TextAuthorFontStyle = style;
            config.TextAuthorColor = color;
            config.TextAuthorSize = size;
            return config;
        }

        public void Save(string path)
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(doc.CreateXmlDeclaration("1.0", "UTF-8", "yes"), root);
            XmlElement config = doc.CreateElement("BasicConfig");
            config.SetAttribute("Version", "1");
            doc.AppendChild(config);
            XmlElement elem;

            XmlElement common = doc.CreateElement("Common");
            elem = doc.CreateElement("UpdateFreq");
            elem.InnerText = ((int)UpdateFreq).ToString();
            common.AppendChild(elem);
            elem = doc.CreateElement("AutoDelete");
            elem.InnerText = AutoDelete.ToString();
            common.AppendChild(elem);
            config.AppendChild(common);

            XmlElement background = doc.CreateElement("Background");
            elem = doc.CreateElement("Mode");
            elem.InnerText = ((int)BackgroundSelection).ToString();
            background.AppendChild(elem);
            elem = doc.CreateElement("Color");
            elem.InnerText = BackgroundColor.ToArgb().ToString();
            background.AppendChild(elem);
            config.AppendChild(background);

            XmlElement date = doc.CreateElement("Date");
            date.SetAttribute("Enable", DateEnable.ToString());
            elem = doc.CreateElement("Position");
            elem.SetAttribute("X", DatePosX.ToString());
            elem.SetAttribute("Y", DatePosY.ToString());
            elem.SetAttribute("UseCenterPos", DateUseCenterPos.ToString());
            date.AppendChild(elem);
            elem = WriteTextStyleNode(doc, "Style", DateFont, DateFontStyle, DateColor, DateSize);
            date.AppendChild(elem);
            elem = doc.CreateElement("Format");
            elem.InnerText = DateFormat;
            date.AppendChild(elem);
            config.AppendChild(date);

            XmlElement text = doc.CreateElement("Text");
            text.SetAttribute("Enable", TextEnable.ToString());
            elem = doc.CreateElement("Mode");
            elem.InnerText = ((int)TextSelection).ToString();
            text.AppendChild(elem);
            elem = doc.CreateElement("Position");
            elem.SetAttribute("X", TextPosX.ToString());
            elem.SetAttribute("Y", TextPosY.ToString());
            elem.SetAttribute("UseCenterPos", TextUseCenterPos.ToString());
            text.AppendChild(elem);
            elem = WriteTextStyleNode(doc, "Title", TextTitleFont, TextTitleFontStyle, TextTitleColor, TextTitleSize);
            text.AppendChild(elem);
            elem = WriteTextStyleNode(doc, "Content", TextContentFont, TextContentFontStyle, TextContentColor, TextContentSize);
            text.AppendChild(elem);
            elem = WriteTextStyleNode(doc, "Author", TextAuthorFont, TextAuthorFontStyle, TextAuthorColor, TextAuthorSize);
            text.AppendChild(elem);
            config.AppendChild(text);

            doc.Save(path);
        }

        private static XmlElement WriteTextStyleNode(XmlDocument doc, string tagName, string family, int style, Color color, float size)
        {
            XmlElement elem = doc.CreateElement(tagName);
            elem.SetAttribute("Font", family);
            elem.SetAttribute("Style", style.ToString());
            elem.SetAttribute("Color", color.ToArgb().ToString());
            elem.SetAttribute("Size", size.ToString());
            return elem;
        }

        private static void ReadTextStyleNode(XmlNode node, out string family, out int style, out Color color, out float size)
        {
            XmlAttributeCollection attr = node.Attributes;
            family = attr["Font"].Value;
            style = int.Parse(attr["Style"].Value);
            color = Color.FromArgb(int.Parse(attr["Color"].Value));
            size = float.Parse(attr["Size"].Value);
        }

        public Font GetDateFont()
        {
            return new Font(DateFont, DateSize, (FontStyle)DateFontStyle);
        }

        public Font GetTextTitleFont()
        {
            return new Font(TextTitleFont, TextTitleSize, (FontStyle)TextTitleFontStyle);
        }
        public Font GetTextContentFont()
        {
            return new Font(TextContentFont, TextContentSize, (FontStyle)TextContentFontStyle);
        }
        public Font GetTextAuthorFont()
        {
            return new Font(TextAuthorFont, TextAuthorSize, (FontStyle)TextAuthorFontStyle);
        }

        public UpdateFrequency UpdateFreq { get; set; } = UpdateFrequency.EveryDay;
        public int AutoDelete { get; set; } = 0;

        public bool DateEnable { get; set; } = true;
        public bool DateUseCenterPos { get; set; } = false;
        public int DatePosX { get; set; } = 5;
        public int DatePosY { get; set; } = 5;
        public string DateFont { get; set; } = "宋体";
        public int DateFontStyle { get; set; } = 0;
        public Color DateColor { get; set; } = Color.Black;
        public float DateSize { get; set; } = 16.0f;
        public string DateFormat { get; set; } = "yyyy年MM月dd日";

        public bool TextEnable { get; set; } = true;
        public bool TextUseCenterPos { get; set; } = true;
        public int TextPosX { get; set; } = 50;
        public int TextPosY { get; set; } = 50;
        public TextSelectionMode TextSelection { get; set; } = TextSelectionMode.List;
        public Color TextTitleColor { get; set; } = Color.Black;
        public Color TextContentColor { get; set; } = Color.Gray;
        public Color TextAuthorColor { get; set; } = Color.Black;
        public string TextTitleFont { get; set; } = "宋体";
        public string TextContentFont { get; set; } = "宋体";
        public string TextAuthorFont { get; set; } = "宋体";
        public int TextTitleFontStyle { get; set; } = 0;
        public int TextContentFontStyle { get; set; } = 0;
        public int TextAuthorFontStyle { get; set; } = 0;
        public float TextTitleSize { get; set; } = 36.0f;
        public float TextContentSize { get; set; } = 24;
        public float TextAuthorSize { get; set; } = 24;

        public BackgroundMode BackgroundSelection { get; set; } = BackgroundMode.Solid;
        public Color BackgroundColor { get; set; } = Color.White;
    }
}
