namespace Day7
{
    enum Gender
    {
        Male = 0,
        Female = 1
    }
    [Flags]
    enum Color
    {
        Red =1,
        Pink = 4 ,
        Blue = 3
    }
   
    internal class Program
    {
        /*
         if you pass a value type to this function
         " Boxing "
        ---> a new object is created in heap for this value ( object that contains that value and this object is the parameter of the function )
        ---> main لأي فانكشن قيمتها تفضل ثابته في ال value type  الوجيك الطبيعي اني لما ابعت 
        ---> reference عشان كدا مش ببعتها ك ( so we need boxing)
        --->unboxing لما تروح للأوبجكت تاخد القيمه الي جواه وتحطها في متغير عادي ده اسمه 
        //     object class لأي فانكشن جوا  override  in struct تقدر بالطريقه ديه تعمل 
        //boxing && un_boxing لأن كل شوبه  performance بس هتقلل ال 
         */
        static void Test(object obj) 
        {
            
        }
        static void Main(string[] args)
        {
            #region Enum
            //Gender g = Gender.Female; //gender كده بتعرف متغير فيه قيمه واحده من الحاجات الي موجوده جوا 
            // ال variable  الي اسمه g
            //Gender الي جاي من داتا تايب اسمه 
            // بيحمل قيمه معينه
            //Console.WriteLine(g);

            //Employee e1 = new Employee();
            //e1.Gender = Gender.Male;
            //Console.WriteLine(e1.Gender);
            // e1.Gender --> Enum هيعرض اسم ال 
            // لو عايز تعرض القيمه اعمله كاست
            //(int)e1.Gender  ---> 0


            //  Color c = Color.Red | Color.Pink;
            //power ot two عشان النتيجه تطلع مختلفه اختار رقم يكون 
            /*
             bitwise or ---> the result should produce a different value from the Blue and Pink otherwise its useless
             0001
             0010
            oring
            0011 = 3 ---> Blue
             */
            // if the res of oring doesnot match a value that does exist in the enum
            // when you display it it shows the number not the name ( with or without casting)
            // Enum قبل ال Flag لو عايز تطبع اسم اللونين جنب بعض بتكتب كلمه 
            //  Console.WriteLine(c);

            // to concatenate two values from an enum use bitwise OR 
            #endregion

            //Comlex c; // وبيشيل قيمه struct ده مش متغير بيشيل عنوان لا ده متغير من نوع 
            //c.id = 9;
            //Console.WriteLine(c.id);

            //  Comlex c = new Comlex(); //  لاclass زي ال heap الجمله ديه مش بتعرف ريفرنس في ال 
            //but it intillaize the struct data with non paramatrized constructor

            // بس struct وتقدر تعمل كدا مع اي داتا تايب مش ال 

            //  int x = new int(); // intillaize to x by zero كدا انت عملت 
            // default constructor from class int() بدلاله ال 
            // but it is not common
            // Console.WriteLine(x);
            Comlex c = new Comlex(8,9);
            Console.WriteLine($"{c.Real} {c.IMG} ");
            Comlex c2 = c;// copy all data from c and put it in c2
            // after this there is no relation between the two structs
            #region Notes
            //polymorphism ملهاش لازمه من غير ال  inheritance ال 
            // لأن ملهاش لازمه أصلا inheritance  يبقي بديهي مفيش struct في ال polymorphism  وبما ان مفيش 

            //   عشان تلزم الناس انهم constructor في الكلاس انت بتعمل 
            // يعملوا اوبجكت بطريقه معينه 

            //  اصلا struct  ال
            //فهو متعرف ومحجوزله مكان في الميموري  constructor من غير ما تستخدم 
            //لكل الداتا  intillaize عشان تعمل constructor بس انت بتسخدم ال 
            // parameterized constructor لو عملت  
            // Default constructor still exists فال  
            #endregion

            LaunchStatus l = new LaunchStatus();
            l.dispaly();
        }
    }
}
