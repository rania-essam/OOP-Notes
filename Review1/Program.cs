using System.Security.Cryptography;

namespace review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// object for first point
            //_3Dpoint ob1 = new _3Dpoint { x = 1, y = 2, z = 4 };

            //// object for second point

            //_3Dpoint ob2 = new _3Dpoint { x = 5, y = 6, z = 7 };

            //ob1.display();
            //ob2.display();

            //Console.WriteLine(ob1.cal_distance(ob2));

            //---------------------------------------------------

            //Fractionn f1 = new Fractionn(1, 2);
            //Fractionn f2 = new Fractionn(1, 4);



            // Fractionn add = f1.add1(f1, f2);
            //Console.WriteLine($"{add.nom}  {add.dom} ");
            //  f1.p = 99;
            //Console.WriteLine(f1.dom);


            //---------------------------

            //chain ob1 = new chain("ranonoaaa" , 99);
            //Console.WriteLine($"{ob1.name} {ob1.age}");

            //_3Dpoint ob = new _3Dpoint(6);
            //Console.WriteLine($"{ob.x} {ob.y} {ob.z} ");
            //Fractionn ob = new Fractionn(6,9);
            //Console.WriteLine($"{ob.nom} {ob.dom} ");

            //_3Dpoint p = new _3Dpoint(5,6,7);
            //_3Dpoint p2 = new _3Dpoint(5,9,7);
            //if (p == p2) Console.WriteLine("they are equal");
            //else Console.WriteLine("Not Equal");
            Fractionn f1 = new Fractionn(1, 2);
            //Fractionn f2 = new Fractionn(1, 2);
            //f1 = f1 + f2;// fractionn.operator+(f1,f2)
            //Console.WriteLine($"{f1.nom/f1.dom} ");

            //int n = (int)f1; // explicit 
            //f1 = n; //implicit

            //Console.WriteLine(n);
            //Console.WriteLine($"{f1.nom} {f1.dom}");
            ++f1;
            Console.WriteLine(++f1.cnt);
            Console.WriteLine(f1.cnt);





        }
    }
}
