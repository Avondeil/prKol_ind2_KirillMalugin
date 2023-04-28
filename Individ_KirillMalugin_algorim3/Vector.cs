using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt15algoritm {
    class Vector {
        private double x;
        private double y;
        private double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x + vec2.x, vec1.y + vec2.y, vec1.z + vec2.z);
        }
        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.x - vec2.x, vec1.y - vec2.y, vec1.z - vec2.z);
        }
        public static double operator *(Vector vec1, Vector vec2)
        {
            return (vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z);
        }
        public double VecLenght()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
        public double Cos(Vector vec)
        {
            double num = this * vec;
            double leng = this.VecLenght() * vec.VecLenght();
            return num / leng;
        }
    }
}
