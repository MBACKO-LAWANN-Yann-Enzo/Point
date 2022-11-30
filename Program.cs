using System;

namespace Point
{
    class Program
    {
        public class Point
        {
            private int x;
            private int y;

            public Point(){}
            
            public void setX(int x1)
            {
                this.x = x1;
            }
            public void setY(int y1)
            {
                this.y = y1;
            }

            public int getX()
            {
                return x;
            }
            public int getY()
            {
                return y;
            }

            public double distance()
            {
                return Math.Sqrt(x * x + y * y);
            } 

            public void egalite(Point p)
            {
                if((p.x.Equals(x)) && (p.y.Equals (y)){

                    Console.WriteLine("les valeurs sont egaux");
                else
                    {
                        Console.WriteLine("ces derniers ne sont pas égaux");
                    }

                }
            }

            public void translation(int x1, int dy)
            {
                this.x = x+x1;
                this.y = y+dy;
            }

        }
        static void Main(string[] args)
        {
           // Point p = new Point();


            Console.WriteLine("Hello World!");
        }
    }
}
