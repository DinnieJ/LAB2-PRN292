using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercise1
{
    class HinhChuNhat
    {
        private int length;
        private int width;

        public HinhChuNhat()
        {
        }

        public HinhChuNhat(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length { get => length; set => length = value; }
        public int Width { get => width; set => width = value; }

        public int GetArea() => length * width;

        public double GetPerimeter() => (length + width) / 2;

        public override string ToString() 
            => $"Length:{length}\tWidth:{width}\tArea:{GetArea()}\tPerimeter:{GetPerimeter()}";

        public void Show() => Console.WriteLine(this.ToString());
    }
}
