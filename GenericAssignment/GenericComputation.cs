﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericAssignment
{
    class GenericComputation
    {
        public static double FindMaxDouble(double FirstValue,double SecondValue,double ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue)>0) 
            {
                return FirstValue;
            }
            if(SecondValue.CompareTo(FirstValue)>0 && SecondValue.CompareTo(ThirdValue)>0)
            {
                return SecondValue;
            }
            if(ThirdValue.CompareTo(FirstValue)>0 && ThirdValue.CompareTo(SecondValue)>0)
            {
                return ThirdValue;
            }
                return FirstValue;
                    
        }
        

    }
}
