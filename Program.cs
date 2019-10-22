using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            myPrint();
            g1("fatemh");
            f1(63, 32);
           Console.WriteLine(area(5,5)+10);
        }

        static void myPrint()
        {
            Console.WriteLine("welcome frinds");
            Console.WriteLine("!have a nice day");
        }

        static void g1(string name)
        {
            Console.WriteLine("welcome frind "+name);
            Console.WriteLine("!have a nice day");
        }

        static void f1(int x,int y)
        {
            Console.WriteLine("now the 1st number is :{0} and the 2nd number is :{1}",x,y);
        }

        static int area(int x,int y)
        {
            int result=x*y;
            int output=(x+y)*2;
            return output;
        }






    }
}
