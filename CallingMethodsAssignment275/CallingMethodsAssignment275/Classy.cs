using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment275
{
    public class Classy    //define class
    {
        public static int Method1(int x) //data type and variable name to be used in method (parameter)
        {
            int store1 = x * 7;   //save result of operation as var
            return store1;        //return that var


        }

        public static int Method2(int x)
        {
            int store2 = x / 2;   //save result of operation as var
            return store2;        //return that var
        }

        public static int Method3(int x)
        {
            int store3 = x + 1000;
            return store3;
        }

    }
}
