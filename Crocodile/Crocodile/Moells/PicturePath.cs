using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingDemo.Models
{
    public class PicturePath
    {
        public List<Point> Points { get; } = new List<Point>();
        public float Width { get; }
        public Color Color { get; }

        public PicturePath(Color color, float width)
        {
            Color = color;
            Width = width;
        }
    }
}
