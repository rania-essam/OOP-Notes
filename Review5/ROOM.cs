using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class ROOM
    {
        // room has many students so you create array of references 
        Instructor instructor;  // a reference to use it in the whole class not only in a  function
        Student [] students; // this array is not intialized , this is reference that can point to array of 'Student' objects and memory isnot allocated at this time

        public ROOM()
        {
            instructor = null;
            students = new Student[10];// allocate memory for the previous array 
        }

        public void instructor_intered(Instructor ins)
        {
            if (ins == null) Console.WriteLine(0);
            // assign reference of instructor an object 
            instructor = ins;   
        }

        public void turn_light_on()
        {
            if (instructor == null) Console.WriteLine(0);
            instructor.on();
            Console.WriteLine(instructor.light_on);
        }
        // ممكن احنا ننهي الريفرنس بايدينا او الاوبجكت الي احنا بنشاور عليه ذات نفسه ممكن يموت وانت لسا بتشاور عليه
        // عشان كده قبل ما تستخدمه لازم تشوف هو لسا موجود ولالا
        //يعني انت مش بتكرييت الاوبجكت انت بس بتستخدمه واستخدامك ده تعدي فانكشن واحده انما الاوبجكت متكريت اصلا برا الكلاس 

        public void instructor_leave()
        {
            instructor = null;
        }
        int idx = 0;
        public void student_entered(Student std)
        {
            students[idx++] = std;
        }

    }
}
