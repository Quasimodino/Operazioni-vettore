using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operazioni_vettore
{
    internal class Vector
    {
        public Vector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public static Vector Parse(string s)
        {
            var a=s.Split(',');
            var b= new Vector(int.Parse(a[0]), int.Parse(a[1]));
            return b;
        }
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector((a.X+b.X), (a.Y+b.Y));
        }
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector((a.X - b.X), (a.Y - b.Y));
        }
        public static Vector operator *(Vector a,Vector b)
        {
            return new Vector((a.X*b.X),(a.Y*b.Y));
        }
        public static Vector operator -(Vector a) {
            return new Vector((-a.X), (-a.Y));
        }
        public static Vector operator +(Vector a)
        {
            return new Vector((+a.X), (+a.Y));
        }
        public static Vector operator *(Vector a,double s)
        {
            return new Vector((a.X * s), (a.Y * s));
        }

    }
}
