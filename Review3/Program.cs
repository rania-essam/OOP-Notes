namespace review
{

   interface I3
    {
        void Foo();
    }

    public class baseclass:I3
    {
        public virtual void Foo() { Console.WriteLine("BaseClass.Foo"); }

    }
    public class overridder : baseclass , I3
    {
        public override void Foo()
        {
            Console.WriteLine("overridder.Foo");
        }
    }
    public class hider : baseclass
    {
        public new void Foo()
        {
            Console.WriteLine("hider.foo");
        }
    }

    // two interfaces have the same function name

    public interface I1
    {
        void Foo();
    }
    public interface I2
    {
        void Foo();
    }
    public class c : I1, I2
    {
       public void Foo()
        {
            Console.WriteLine("I1");
        }

       void I2.Foo()
        {
            Console.WriteLine("I2");

        }
    }

 
    internal class Program
    {
       
        static void Main(string[] args)
        {

            //overridder ob1 = new overridder();
            //ob1.Foo();
            //baseclass r = ob1;
            //r.Foo();

            //hider ob2 = new hider();
            //ob2.Foo();

            //r = ob2;
            //r.Foo();
            //   overridder ob1 = new overridder();

            //  c ob = new c();
            //  ob.Foo();

            //  ((I2)ob).Foo();

            //( (I1)ob).Foo();

            //overridder o1 = new overridder();
            //o1.Foo();

            //((baseclass)o1).Foo();

            //((I3)o1).Foo();

            //object ob = 10;
            //long x = (int)ob;
            //double y = (double)(int)ob;

            //object ob2 = 9.7;
            //int r = (int)(double)ob2;
            ////Console.WriteLine(r);
            ///

       
               
        }
    }
}
