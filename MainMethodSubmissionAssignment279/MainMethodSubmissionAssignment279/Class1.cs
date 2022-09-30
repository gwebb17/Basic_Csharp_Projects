using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment279
{
    public class Class1 
    {
        public int Method1(int x) //public = can be used elsewhere int = return data type x = param
        {
            int result1 = x + 100;
            return result1;   ///need to return final answer
        }

        public int Method2(double y)  //returns an int but takes in a decimal for purpose of assignment
        {
            double conversionResult = y * 100; //doesn't work with decimal data type but works with double
            int result2 = Convert.ToInt32(conversionResult);  //convert decimal to int to be returned
            return result2;
        }


        public int Method2(string z) //returns an int but takes in a string
        {
            int result3 = Convert.ToInt32(z);  //convert string to # 
            int result4 = result3 + 1;  //if we don't use a new var result4 to perform more operations on
            return result4;             //the result concatenates z to result3 instead of doing math on it

        }
       
        

    }
}
