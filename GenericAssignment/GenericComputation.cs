using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAssignment
{
    class GenericComputation
    {
        public static string FindMaxString(string FirstString,string SecondString,string ThirdString)
        {
            if (FirstString.CompareTo(SecondString) > 0 && FirstString.CompareTo(ThirdString)>0) 
            {
                return FirstString;
            }
            if(SecondString.CompareTo(FirstString)>0 && SecondString.CompareTo(ThirdString)>0)
            {
                return SecondString;
            }
            if(ThirdString.CompareTo(FirstString)>0 && ThirdString.CompareTo(SecondString)>0)
            {
                return ThirdString;
            }
                return FirstString;
                    
        }
        

    }
}
