using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    struct Comlex
    {
        public int Real;
        public int IMG;

        // if you create constrctor to intiialize a variable you should intialize all variables in the struct
        // ليهم كلهم intialize  في الكلاس كان عادي متعملش 
        //ليهم بشكل تلقائي intialize  ويعمل heap  بيحجزلهم مكان في ال heap لأن الاوبجكت لما بيتكريت في ال 

        public Comlex(int Real, int IMG)
        {
            Real = Real;
            this.IMG = IMG;
        }
        //public override bool Equals(object obj) // cast obj to struct and compare it with cur struct
        //{
        //    return true;
        //}
        // if you donnot override function equals it will compare structs as referneces 


        //overloaded ---> compare the data of the two referneces
        // you can do operator overloading in struct 
        public static bool operator == (Comlex c1 , Comlex c2)
        {
            return c1.Real == c2.Real;
        }
        public static bool operator != (Comlex c1 ,Comlex c2)
        {
            return c1.Real != c2.Real || c1.IMG == c2.IMG;
        }
    }
}
