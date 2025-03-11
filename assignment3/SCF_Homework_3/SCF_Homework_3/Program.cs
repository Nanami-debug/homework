using System.Diagnostics;
using System.Xml.Linq;

namespace SCF_Homework_3
{
    internal class Program
    {
        class shape
        {
            protected double area;
            public double Area
            {
                get
                {
                    return area;
                }
                set
                {
                    area = calArea(out double x);
                }

            }
            virtual protected double calArea(out double x) 
            { 
                x = 0;
                return x;
            }
        }

        class rectangle : shape
        {
            private int l;
            private int r;
            protected override double calArea(out double x)
            {
                x = l * r;
                return x;
            }
            public rectangle(int l = 0, int r = 0)
            {
                this.l = l;
                this.r = r;
                area = calArea(out double x);
            }
            public void L(int m) { l = m; area = calArea(out double x); }
            public void R(int m) { r = m; area = calArea(out double x); }

        }
        class square : rectangle
        {
            public square(int a = 0) : base(a, a) { }
              
        }

        class circle:shape
        {
            private double r;
            public double R
            {
                get
                {
                    return r;
                }
                set
                {
                    r = value;
                    area = calArea(out double x);
                }
            }
            public circle(double r=0)
            {
                this.r = r;
                area = calArea(out double x);
            }
            protected override double calArea(out double x)
            {
                x = 3.14 * r * r;
                return x;
            }
        }
        static void Main(string[] args)
        {
            Random ran = new Random();
            double sum = 0;
            for (int i = 1; i <=10; i++)
            {
                int a = ran.Next(1,4);
                switch (a)
                {
                    case 1:
                        rectangle rect = new rectangle(ran.Next(1, 9), 
                                                       ran.Next(1, 9));
                        Console.WriteLine($"第{i}个图形为长方形，面积为{rect.Area}");
                        sum += rect.Area;break;
                    case 2:
                        square squ = new square(ran.Next(1, 9));                                            
                        Console.WriteLine($"第{i}个图形为正方形，面积为{squ.Area}");
                        sum += squ.Area; break;
                    case 3:
                        circle cir = new circle(ran.Next(1, 9));                                                    
                        Console.WriteLine($"第{i}个图形为圆形，面积为{cir.Area}");
                        sum += cir.Area; break;
                }
            }
            Console.WriteLine($"面积总和为{sum}");
        }
    }
}
