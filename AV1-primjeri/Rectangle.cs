using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
    public class Rectangle
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public float GetCircumference()
        {
            return 2 * (Width + Height);
        }
        public float GetArea()
        {
            return Width * Height;
        }
        public void Scale(float factor)
        {
            Width *= factor;
            Height *= factor;
        }

        public void GetDescription()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}, Circumference: {GetCircumference()}, Area: {GetArea()}");
        }
    }
}
