using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace DailyWallpaper
{
    public class WallpaperGenerator
    {
        private static readonly bool DEBUG = false;

        private BasicConfig config;
        private LastWallpaperInfo last;
        private Image image;
        private Graphics g;

        private Random random;

        private DateTime date;
        private TextItem textItem;
        private ImageItem imageItem;

        Font dateFont, titleFont, contentFont, authorFont, debugFont;
        private float dateWidth, dateHeight;
        private float textWidth, textHeight,
            titleWidth, contentWidth, authorWidth,
            titleHeight, contentHeight, authorHeight;

        private string imagePath;

        // Red - Item Border
        // Yellow - SubItem Border
        // Green - Item CenterPos
        // Cyan - Grid Line
        // Black - Text
        private Pen debugPenRed, debugPenYellow, debugPenGreen, debugPenCyan;
        private SolidBrush debugBrushBlack;

        public WallpaperGenerator(BasicConfig _config, LastWallpaperInfo _last, string imgPath)
        {
            if (_config == null) throw new ArgumentNullException("_config");
            config = _config;
            last = _last == null ? new LastWallpaperInfo() : _last;
            imagePath = imgPath;
            random = new Random();

            if(DEBUG)
            {
                debugPenRed = new Pen(Color.Red, 4f);
                debugPenYellow = new Pen(Color.Yellow, 4f);
                debugPenGreen = new Pen(Color.Lime, 4f);
                debugPenCyan = new Pen(Color.Cyan, 4f);
                debugBrushBlack = new SolidBrush(Color.Black);
            }
        }

        public void Generate(Size size, List<TextItem> text, List<ImageItem> image)
        {
            InitCanvas(size);
            SelectTextAndImage(text, image);
            LoadFont();
            DrawBackground(size);
            if(config.DateEnable)
            {
                date = DateTime.Now;
                CalcDateSize();
                PointF datePos = GetDatePos(size);
                DrawDate(datePos);
            }
            if(config.TextEnable)
            {
                DrawText(size);
            }
            UnloadFont();
            g.Dispose();
        }

        public Image GetImage()
        {
            return image;
        }

        private void InitCanvas(Size size)
        {
            if (g != null) g.Dispose();
            if (image != null) image.Dispose();
            image = new Bitmap(size.Width, size.Height);
            g = Graphics.FromImage(image);
            g.PageUnit = GraphicsUnit.Pixel;
        }

        private void SelectTextAndImage(List<TextItem> textList, List<ImageItem> imageList)
        {
            int index = 0;
            if(textList.Count > 0)
            {
                switch (config.TextSelection)
                {
                    case TextSelectionMode.List:
                        index = last.TextIndex + 1 >= textList.Count ? 0 : last.TextIndex + 1;
                        break;
                    case TextSelectionMode.Random:
                        index = random.Next(textList.Count);
                        break;
                    default:
                        break;
                }
                textItem = textList[index];
                last.TextIndex = index;
            }
            else
            {
                textItem = new TextItem("<无文本项目可用>", "请前往文本选项卡添加文本项目", "", false);
            }

            index = 0;
            if(imageList.Count > 0 )
            {
                switch (config.BackgroundSelection)
                {
                    case BackgroundMode.Solid:
                        break;
                    case BackgroundMode.List:
                        index = last.ImageIndex + 1 >= imageList.Count ? 0 : last.ImageIndex + 1;
                        break;
                    case BackgroundMode.Random:
                        index = random.Next(imageList.Count);
                        break;
                    default:
                        break;
                }
                imageItem = imageList[index];
                if (config.BackgroundSelection != BackgroundMode.Solid) last.ImageIndex = index;
            }
            else
            {
                imageItem = null;
            }
        }

        private void LoadFont()
        {
            dateFont = config.GetDateFont();
            titleFont = config.GetTextTitleFont();
            contentFont = config.GetTextContentFont();
            authorFont = config.GetTextAuthorFont();
            if (DEBUG) debugFont = new Font("宋体", 16f);
        }

        private void UnloadFont()
        {
            if (dateFont != null) dateFont.Dispose();
            if (titleFont != null) titleFont.Dispose();
            if (contentFont != null) contentFont.Dispose();
            if (authorFont != null) authorFont.Dispose();
            if (debugFont != null) debugFont.Dispose();
        }

        private void CalcDateSize()
        {
            SizeF size = g.MeasureString(date.ToString(config.DateFormat), dateFont);
            dateWidth = size.Width;
            dateHeight = size.Height;
        }

        private void CalcTextSize()
        {
            SizeF size;
            size = g.MeasureString(textItem.Title, titleFont);
            titleHeight = size.Height;
            titleWidth = size.Width;
            string[] lines = textItem.Content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            float width = 0f;
            float height = 0f;
            for(int i = 0; i < lines.Length; i++ )
            {
                size = g.MeasureString(lines[i], contentFont);
                width = Math.Max(width, size.Width);
                if (!string.IsNullOrWhiteSpace(lines[i])) height = size.Height;
            }
            contentWidth = width;
            contentHeight = height * lines.Length;
            size = g.MeasureString(textItem.Author, authorFont);
            authorHeight = size.Height;
            authorWidth = size.Width;
            textHeight = titleHeight + contentHeight + authorHeight;
            textWidth = Math.Max(Math.Max(titleWidth, contentWidth), authorWidth);
        }

        private PointF GetDatePos(Size size)
        {
            float x = size.Width * (config.DatePosX / 100f);
            float y = size.Height * (config.DatePosY / 100f);
            if(config.DateUseCenterPos)
            {
                x -= dateWidth / 2;
                y -= dateHeight / 2;
            }
            return new PointF(x, y);
        }

        private void GetTextPos(Size size, out PointF titlePos, out PointF contentPos, out PointF authorPos)
        {
            float x = size.Width * (config.TextPosX / 100f);
            float y = size.Height * (config.TextPosY / 100f);
            if(config.TextUseCenterPos)
            {
                x -= textWidth / 2;
                y -= textHeight / 2;
            }
            titlePos = new PointF(x + (textWidth - titleWidth) / 2f, y);
            contentPos = new PointF(x, y + titleHeight);
            authorPos = new PointF(x + (textWidth - authorWidth), y + (titleHeight + contentHeight));
        }

        private PointF[] GetContentLinePos(PointF point)
        {
            string[] lines = textItem.Content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            PointF[] array = new PointF[lines.Length];
            for(int i = 0; i < lines.Length; i++ )
            {
                SizeF size = g.MeasureString(lines[i], contentFont);
                float x, y;
                if(textItem.Center)
                {
                    x = point.X + (textWidth - size.Width) / 2f;
                }
                else
                {
                    x = point.X;
                }
                y = point.Y + size.Height * i;
                array[i] = new PointF(x, y);
            }
            return array;
        }

        private void DrawBackground(Size size)
        {
            if(config.BackgroundSelection == BackgroundMode.Solid || imageItem == null)
            {
                g.Clear(config.BackgroundColor);
            }
            else
            {
                g.Clear(Color.White);
                Image img = imageItem.GetImage(imagePath);
                g.DrawImage(img, new Rectangle(new Point(0, 0), size));
                img.Dispose();
            }

            if(DEBUG)
            {
                // Draw debug Grid Line
                g.DrawLine(debugPenCyan, size.Width / 2f, 0, size.Width / 2f, size.Height);
                g.DrawLine(debugPenCyan, 0, size.Height / 2f, size.Width, size.Height / 2f);
            }
        }

        private void DrawDate(PointF point)
        {
            string dateStr = date.ToString(config.DateFormat);
            SolidBrush br = new SolidBrush(config.DateColor);
            g.DrawString(dateStr, dateFont, br, point);
            br.Dispose();

            if(DEBUG)
            {
                int x1 = (int)point.X;
                int x2 = (int)(point.X + dateWidth);
                int y1 = (int)point.Y;
                int y2 = (int)(point.Y + dateHeight);
                // CenterPos
                g.DrawLine(debugPenGreen, x1, y1, x2, y2);
                g.DrawLine(debugPenGreen, x1, y2, x2, y1);
                // Border
                g.DrawRectangle(debugPenRed, new Rectangle(x1, y1, (int)dateWidth, (int)dateHeight));
            }
        }

        private void DrawText(Size size)
        {
            CalcTextSize();
            PointF titlePos, contentPos, authorPos;
            GetTextPos(size, out titlePos, out contentPos, out authorPos);
            PointF[] contentLinePos = GetContentLinePos(contentPos);
            Brush br = new SolidBrush(config.TextTitleColor);
            g.DrawString(textItem.Title, titleFont, br, titlePos);
            br.Dispose();
            br = new SolidBrush(config.TextAuthorColor);
            g.DrawString(textItem.Author, authorFont, br, authorPos);
            br.Dispose();
            string[] lines = textItem.Content.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            br = new SolidBrush(config.TextContentColor);
            for(int i = 0; i < lines.Length; i++ )
            {
                g.DrawString(lines[i], contentFont, br, contentLinePos[i]);
            }
            br.Dispose();

            if(DEBUG)
            {
                int x1 = (int)(size.Width * (config.TextPosX / 100f));
                int y1 = (int)(size.Height * (config.TextPosY / 100f));
                if (config.TextUseCenterPos)
                {
                    x1 -= (int)(textWidth / 2);
                    y1 -= (int)(textHeight / 2);
                }
                int x2 = (int)(x1 + textWidth);
                int y2 = (int)(y1 + textHeight);
                
                // Title Border
                g.DrawRectangle(debugPenYellow, titlePos.X, titlePos.Y, titleWidth, titleHeight);
                // Content Border
                g.DrawRectangle(debugPenYellow, contentPos.X, contentPos.Y, contentWidth, contentHeight);
                // Author Border
                g.DrawRectangle(debugPenYellow, authorPos.X, authorPos.Y, authorWidth, authorHeight);
                // CenterPos
                g.DrawLine(debugPenGreen, x1, y1, x2, y2);
                g.DrawLine(debugPenGreen, x1, y2, x2, y1);
                // Border
                g.DrawRectangle(debugPenRed, new Rectangle(x1, y1, (int)textWidth, (int)textHeight));
            }
        }
    }
}
