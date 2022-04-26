using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a263 = Int32.Parse(Console.ReadLine());
            double b263 = Int32.Parse(Console.ReadLine());
            double c263 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a263, b263, c263);

            double delta = pt.delta(a263, b263, c263);
            int check263 = pt.nghiem(delta);
            if (check263 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check263 == 0)
            {
                double x = -b263 / (2 * a263);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b263 - Math.Sqrt(delta)) / (2 * a263);
                double x2 = (-b263 + Math.Sqrt(delta)) / (2 * a263);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }

            Console.ReadKey();
        }
    }

    class ptb2
    {
        private double a263;
        private double b263;
        private double c263;

        public ptb2()
        {
        }

        public ptb2(double a263, double b263, double c263)
        {
            A = a263;
            B = b263;
            C = c263;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a263, double b263, double c263)
        {
            return b263 * b263 - 4 * a263 * c263;
        }

        public int nghiem(double delta263)
        {
            if (delta263 < 0)
            {
                return -1;
            }
            else if (delta263 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}