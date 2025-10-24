namespace Day3
{
    internal class Program
    {
        public static void move(Creature c) // YOU can pass any child object 
        {
            c.Move();
            /// write the intersected code to all childs 
        }
        public static void movee(Creature[] arr) // YOU can pass any child object 
        {
             
            /// write the intersected code to all childs 
        }
        static void Main(string[] args)
        {
            // Asscoiation ---> a Class uses Another Class (but the relation is short)
            // Aggrediation ---> CLass constains a set of actions of another class
            // Composition ---> Class constains one or more classes 
            #region Association

            //Marker m = new Marker();
            //Instructor ins = new Instructor();
            //ins.Write_on_board(m); // association  
            #endregion

            #region Aggregiation
            //ROOM R = new ROOM();
            //Instructor ins = new Instructor();
            //ROOM r2 = R;
            //R = null;

            //  r2.instructor_intered(ins);



            //  r2.turn_light_on();
            #endregion

            //Head head = new Head();

            //HumanBody body = new HumanBody();
            //  Human human = new Human("Human", 20);  // base constructor is executed first then the child
            // you can access public members of the parent class from main 
            //but you can’t access protected members of the parent class 
            //   human.print();
            //   c.Age = 99;  // impossible
            //  Console.WriteLine(c.Name);
            //  human.Move();
            //  Console.WriteLine(human.move);

            //-----polymorphism
            // human   ببصله علي انه human كدا اوبجكت من نوع  
          //  Human ob1 = new Human();
            // creature    ببصله علي انه  اوبجكت منhuman كدا اوبجكت من نوع  
            Creature ob2 = new Human(); //   بيأكسس الميمبرز المشتركه بينهم بس human  ميقدرش يأكسس الفانكشنز الخاصه ب creature
            //Creature ob3 = new Animal();
            // parent وتشاور عليه  بريفرنس  من ال child ينفع يكون معاك اوبجكت من ال  
            // child وتشاور عليه بريفرنس من ال  parent بس مينفعش يكون معاك أوبجكت من ال  
            ob2.Move();
            //  Human h = new Creature(); // xxxxxxxxxxx
            //  Human h = ob2; // notvalid
            //Human h = (Human)ob2; // human بس عشان تعمل الحركه ديه لازم يكون الاوبجكت الي بنعمله كاست بيشاور علي 
            //Creature h2 = new Creature();
            //Human h1 = (Human)h2; // inavalid cast exception as h2 refer to object of type creature not human
            //Creature[] arr = new Creature[3];
            //arr[0] = new Human();
            //arr[1]=new Creature();
            //arr[1]=new Animal();

            //Employee o = new Employee();
            //o.Move();


        }
    }
}
