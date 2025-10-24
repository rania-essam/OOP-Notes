using Collections;
using System.Collections;

namespace review2
{

 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generic Collections 

            //Generic List 

            #region List
            //List<int> l = new List<int>();
            //l.Add(8);
            //l.Add(9);
            //l.Add(10);
            //Console.WriteLine(l[0]);

            //foreach (int x in l)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            // Generic Dictionary
            #region dict

            //Dictionary<int, String> dict = new Dictionary<int, string>();
            //// not sorted  , distinct keys 
            //dict[10] = "rania";
            //dict[2] = "MIbrahim";
            //dict[2] = "MIbrahim";
            //dict.Add(6, "ps");
            //foreach (KeyValuePair<int, string> pair in dict)
            //{
            //    Console.WriteLine($"{pair.Key} {pair.Value}");
            //}
            #endregion

            // GENERIC Sorted list
            #region SLIST
            //SortedList<int, int> slist = new SortedList<int, int>(); //  no reapeted keys , list is sorted ascending by keys
            //slist[1] = 9;
            //slist[2] = 8;
            //slist[2] = 7;
            //slist[2] = 6;
            //foreach(KeyValuePair<int,int> p in slist)
            //{
            //    Console.WriteLine($"{p.Key} , {p.Value} ");
            //} 
            #endregion

            // GENERIC STACK
            #region stack

            //   Stack<int> s = new Stack<int>();
            //   s.Push(1);
            //   s.Push(2);
            //   Console.WriteLine(s.Peek()); 
            ////   s.Pop();
            //   Console.WriteLine(s.Peek()); 
            #endregion
            //GENERIC QUEUE 

            #region queue
            //Queue<string> q = new Queue<string>();
            //q.Enqueue("rania");
            //q.Enqueue("Gelen");
            //q.Enqueue("Eljaz");
            //foreach(string s in q)
            //{
            //    Console.WriteLine(s);
            //} 
            #endregion

            // [ non generics ]
            // Array_list --> its size change dynamically , can hold different datatypes

            #region ARR_L
            //int x = 10;
            //string name = "rania";
            //DateTime date = DateTime.Parse("13-dec-2003");

            //ArrayList arrL = new ArrayList();
            //arrL.Add(date);
            //arrL.Add(name);
            //arrL.Add(x);

            //foreach (var ele in arrL) Console.WriteLine(ele); 
            #endregion

            // Hash_Table
            #region hashtable
            //   Hashtable h = new Hashtable();
            //   h.Add(1, "rania");
            //   h.Add(2, 0);
            //   h.Add(4, 0);
            //   h.Add(3, 0);
            ////   h.Add(2, 5);

            //   foreach (DictionaryEntry p in h)
            //       Console.WriteLine($"{p.Key}  {p.Value} "); 
            #endregion

            // non_generic  sorted_list
            // It is similar to the generic Sorted list, except we don't have to specify specific data type.
            // all keys should be of the same type as it should be sorted 
            #region sorted_list
            // SortedList l = new SortedList();
            // l.Add(8,8);
            // l.Add(9, "jfkrf");
            //// l.Add("9",8);
            // l.Add(0,0);

            // foreach (DictionaryEntry p in l)
            //     Console.WriteLine($"{p.Key} {p.Value} "); 
            #endregion


            // non generic stack ----> works as generic stack ( you doesn’t specify datatype)
            #region non_gen stack
            // can hold different types
            //Stack s = new Stack();
            //s.Push(8);
            //s.Push(100000);
            //s.Push("rania");
            //s.Push(100);
            //s.Push(9.9);

            //foreach(object i in s)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            // non_generic queue 

            #region non_gen queue

            //Queue q = new Queue();
            //q.Enqueue(1);
            //q.Enqueue("number theory");
            //q.Enqueue(9.8);
            //q.Enqueue(DateTime.Now);

            //foreach (object o in q) Console.WriteLine(o); 
            #endregion



            // 

            ch c = new ch();
            Console.WriteLine(c.p());
            Console.WriteLine(c.p(8));

        }
    }
}
