using System;

namespace OOPSConcepts
{
  public  class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

   public class Car : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }
   public class Shape
    {
        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();

            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);

            Overloading d = new Overloading();
            int sum1 = d.Sum(24, 28);
            Console.WriteLine("sum of the two "
            + "integer value : " + sum1);
            int sum2 = d.Sum(10, 20, 30);
            Console.WriteLine("sum of the three "
            + "integer value : " + sum2);
            Console.ReadLine();

        }
    }
}
