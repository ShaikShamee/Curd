using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSConcepts
{
         public  class Shapes
        {
            protected int width, height;

            public Shapes(int a = 0, int b = 0)
            {
                width = a;
                height = b;
            }
            public virtual int area()
            {
                Console.WriteLine("Parent class area :");
                return 0;
            }
        }
       public class Rectangle : Shapes
        {
            public Rectangle(int a = 0, int b = 0) : base(a, b)
            {

            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * height);
            }
        }
       public  class Triangle : Shapes
        {
            public Triangle(int a = 0, int b = 0) : base(a, b)
            {
            }
            public override int area()
            {
                Console.WriteLine("Triangle class area :");
                return (width * height / 2);
            }
        }
       public class Caller
        {
            public void CallArea(Shapes sh)
            {
                int a;
                a = sh.area();
                Console.WriteLine("Area: {0}", a);
            }
        }
        public class Tester
        {
            static void Main(string[] args)
            {
                Caller c = new Caller();
                Rectangle r = new Rectangle(10, 7);
                Triangle t = new Triangle(10, 5);

                c.CallArea(r);
                c.CallArea(t);
                Console.ReadLine();
            }
        }
    }
    

