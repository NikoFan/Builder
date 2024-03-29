using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace BuilderPattern
{
    internal class Cube
    {
        private string Height;
        private string Width;
        private string Color;
        private string VerticalAgliment;

        public Cube()
        {
            Height = "0";
            Width = "0";
            Color = "#FF2218";
            VerticalAgliment = "Center";
        }

        public Border cubeInformation()
        {
            Border figure = new Border()
            {
                Height = Convert.ToInt32(Height),
                Width = Convert.ToInt32(Width),
                VerticalAlignment = VerticalAgliment == "Top" ? System.Windows.VerticalAlignment.Top : System.Windows.VerticalAlignment.Bottom,
                Background = (SolidColorBrush) new BrushConverter().ConvertFromString(Color)
            };
            
            return figure;
        }

        public void takeCubeColor(string colorCode)
        {
            this.Color = colorCode;
        }

        public void takeVerticalAgliment(string verticalAgliment) 
        {
            this.VerticalAgliment = verticalAgliment;
        }

        public void changeParams(string height, string width)
        {
            this.Height = height;
            this.Width = width;
        }
    }
}
