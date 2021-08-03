using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistoryEngine.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                SKImageInfo imageInfo = new SKImageInfo(pictureBox1.Width,pictureBox1.Height);
                using (SKSurface surface = SKSurface.Create(imageInfo))
                {
                    SKCanvas canvas = surface.Canvas;

                    canvas.Clear(SKColors.White);
                    using (SKPaint paint = new SKPaint())
                    {
                        paint.Color = SKColors.Black;
                        paint.IsAntialias = true;
                        paint.StrokeWidth = 1;
                        paint.Style = SKPaintStyle.Stroke;
                        canvas.DrawLine(new SKPoint(0, 0), new SKPoint(129, 50),paint);
                       
                    }

                    using (SKImage image = surface.Snapshot())
                    using (SKData data = image.Encode(SKEncodedImageFormat.Png, 100))
                    using (MemoryStream mStream = new MemoryStream(data.ToArray()))
                    {
                        Bitmap bm = new Bitmap(mStream, false);
                        pictureBox1.Image = bm;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
