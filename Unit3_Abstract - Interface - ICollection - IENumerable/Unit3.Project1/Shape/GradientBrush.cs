﻿using System;

namespace ShapeAbstractClass
{
    public class GradientBrush : Brush
    {
        private string _colorGra;
        private double _offset;

        public GradientBrush(string colorGra, double offset, double opacity, double transform)
        {
            _colorGra = colorGra;
            _offset = offset;
            _opacity = opacity;
            _transform = transform;
        }
        public GradientBrush()
        {

        }
        public override void Style()
        {
            Console.WriteLine("##### Kieu co ve mau chuyen sac #####");
            Console.WriteLine("Mau chuyen sac: {0}", _colorGra);
            Console.WriteLine("Dinh vi tri chuyen mau: {0}", _offset);
            Console.WriteLine("Do mo cua mau: {0}", _opacity);
            Console.WriteLine("Thay doi vi tri: {0}", _transform);

        }
    }
}
