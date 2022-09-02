using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class ReferenceandValueType
    {
        //static void ChangeValue(int x)
        //{
        //    x = 200;

        //    Console.WriteLine(x);
        //}

        //static void Main()
        //{
        //    int i = 100;

        //    Console.WriteLine(i);

        //    ChangeValue(i);

        //    Console.WriteLine(i);
        //}

        public class Student
        {

            public string StudentName { get; set; }

        }

        static void ChangeReferenceType(Student std2)
        {
            std2.StudentName = "Steve";
        }

        static void Main(string[] args)
        {
            Student std1 = new Student();
            std1.StudentName = "Bill";

            ChangeReferenceType(std1);

            Console.WriteLine(std1.StudentName);
        }
    }


}
