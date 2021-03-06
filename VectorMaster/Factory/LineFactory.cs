﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorMaster.Factory
{
    public class LineFactory : IFactory
    {
        public AFigure CreateFigure()
        {
            return new LineFigure();
        }
        public AFigure CreateFigure(Pen pen)
        {
            return new LineFigure(pen);
        }
    }
}
