﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4.Project1
{
    public abstract class Brush
    {
        protected double _transform, _opacity;

        protected Brush(double transform, double opacity)
        {
            _transform = transform;
            _opacity = opacity;
        }
        protected Brush()
        {
        }

        public abstract void Style();
    }
}
