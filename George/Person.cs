using System;
using System.Collections.Generic;
using System.Text;

namespace George
{
    class Person : IPerson
    {
        public int myTears = 10;
        public void eat()
        {
            Console.WriteLine("Yum yum");
        }


        public int tears(int x)
        {
            return myTears += x;
        }
    }
}
