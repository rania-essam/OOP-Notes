using System;
using System.Collections;

namespace Practice
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            //for(int num = 1; num <= 496; num++)
            //{
            //    int sum = 1;
            //    Console.WriteLine($"num = {num}");
            //    for(int i = 2; i <= num / i; i++)
            //    {
            //        if(num % i == 0)
            //        {
            //            int fac1 = i, fac2 = num / i;
            //            sum += fac1;
            //            sum += fac2;
            //            Console.WriteLine(fac1 + " " + fac2);
            //        }
            //    }
            //    if (sum == num) Console.WriteLine(num);
            //}

            Shape[] s = new Shape[3]; // you can create a refernce of abstract class but you can’t create an object of an abstract class
            Picture p = new Picture();
            double Len = double.Parse(Console.ReadLine());
            double wid = double.Parse(Console.ReadLine());
            s[0] = new Square(); // object intiliazer
            
            Len= double.Parse(Console.ReadLine());
            wid= double.Parse(Console.ReadLine());
            s[1] = new Rectangle { length = Len , width = wid};
            Len = double.Parse(Console.ReadLine()); // height
            wid = double.Parse(Console.ReadLine()); //base
            s[2] = new Triangle { Base = wid , height = Len};

            p.Display_Area_of_all_shapes(s);

            Rectangle r = new Rectangle();
            Square rr = new Square();
            rr.
         
        }
       

    }
}
