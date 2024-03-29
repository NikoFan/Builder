using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class TopCubeDeveloper : IBuilder
    {
        private Cube cube;

        public TopCubeDeveloper()
        {
            cube = new Cube();
        }

        public void takeLarge()
        {
            cube.changeParams("100", "300");
        }

        public void takeColor()
        {
            cube.takeCubeColor("#44FF18");
        }
        public void takeVerticalAgliment()
        {
            cube.takeVerticalAgliment("Top");
        }

        public Cube returnFigure()
        {
            return cube;
        }
    }
}
