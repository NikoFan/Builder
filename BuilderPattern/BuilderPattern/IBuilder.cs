using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BuilderPattern
{
    internal interface IBuilder
    {
        void takeLarge();
        void takeColor();
        void takeVerticalAgliment();

        Cube returnFigure();
    }
}
