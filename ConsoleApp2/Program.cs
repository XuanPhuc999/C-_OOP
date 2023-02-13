using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TamGiac
    {
        private double a;
        private double b;
        private double c;
        private double p;
        private double s;

        public TamGiac(double[] arrTamGiac)
        {
            this.a = arrTamGiac[0];
            this.b = arrTamGiac[1];
            this.c = arrTamGiac[2];
        }

        public double getA()
        {
            return a;
        }

        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        public double nuaChuVi()
        {
            p = (a + b + c) / 2;
            return p;
        }

        public double dienTichTamGiac()
        {
            s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }

        public double dienTichTamGiacMax(double maxTamGiac)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double maxTamGiac = 0;
            double[] arrTamGiac = new double[3];
            Console.WriteLine("Nhap bao nhieu tam giac: ");
            int n = int.Parse(Console.ReadLine());
            while(n > 0)
            {
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Nhap canh: " + i);
                    arrTamGiac[i] = double.Parse(Console.ReadLine());
                }
                TamGiac tg = new TamGiac(arrTamGiac);
                tg.nuaChuVi();
                maxTamGiac = tg.dienTichTamGiac();
                dienTichTamGiacMax(maxTamGiac);

                --n;
            }

            
        }
    }
}
