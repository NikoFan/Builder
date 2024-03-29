using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuilderPattern
{
    internal class BottomCubeDeveloper : IBuilder
    {
        private Cube cube;

        public BottomCubeDeveloper()
        {
            cube = new Cube();
        }

        public void takeLarge()
        {
            cube.changeParams("100", "200");
        }

        public void takeColor()
        {
            cube.takeCubeColor("#4618FF");
        }
        public void takeVerticalAgliment()
        {
            cube.takeVerticalAgliment("Bottom");
        }

        public Cube returnFigure()
        {
            return cube;
        }

    }
}
