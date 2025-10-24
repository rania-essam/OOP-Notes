namespace Day6
{
    internal class Program
    {
   
        static void Main(string[] args)
        {
            Human h = new Human();
            h.name = "rania";
            h.id = 1000;
            Human hh = new Human();
            hh.name = "mo_to_ACPC";
            hh.id = 100;

            //Console.WriteLine(object.Equals(h, hh));
            Console.WriteLine(h.ToString());
            Console.WriteLine(h);

            Human h2 = h.Clone();

            Console.WriteLine($"{h2.id} {h2.name}");
           
           
        }
    }
}
