using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Builder
    {
        private IBuilder builder;

        public Builder(IBuilder builder) 
        {
            this.builder = builder;
        }

        public void setBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        public Cube createTopCube()
        {
            builder.takeColor();
            builder.takeVerticalAgliment();
            builder.takeLarge();
            return builder.returnFigure();
        }

        public Cube createBottomCube()
        {
            builder.takeColor();
            builder.takeVerticalAgliment();
            builder.takeLarge();
            return builder.returnFigure();
        }
    }
}
