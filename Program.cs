using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_programming_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(g1(5, 6));
            f1(7.5f, 4.5f);
            s1(15, 20, 12);
            num(80, 63);
            p1(10, 10);
            E1(0);
            L1(3);
            Q1(12);
            X1(17);
            int number = 12345;
            Console.WriteLine(u2(number));
            
        {


        Console.WriteLine("enter your grade");
        int input = int.Parse(Console.ReadLine());
        if (input >= 18)
        {
        Console.WriteLine("your average is Good");
        }
        else
        {
        Console.WriteLine("your average is bad");
        }

        }

        }


        static int g1(int x, int y)
        {
            int s = x * y;
            int p = (x + y) * 2;
            return p;

        }


        static void f1(float a, float b)
        {
            float sum = (a * a) + (b * b);
            Console.WriteLine(sum);
        }



        static void s1(int x, int y, int z)
        {
            int sum = x + y + z;
            int average = x + y + z / 3;
            Console.WriteLine(average);
        }



        static void num(int r, int d)
        {
            r = r + d;
            d = r - d;
            r = r - d;
            Console.WriteLine(r);
            Console.WriteLine(d);
        }



        static void p1(int O, int p)
        {
            for (int i = 1; i <= O; i++)
            {
            for (int j = 1; j <= p; j++)
            {
            Console.WriteLine(i * j + " \t");
            }


            }

        }



        static void E1(int K)
        {
            for (int i = 1; i <= 10; i++)
            {
                K = K + i;
            }
            Console.WriteLine(K);
        }



        static void L1(Double r)
        {
            Double result = (r * r) * 3.14;
            Double output = 2 * r * 3.14;
            Console.WriteLine(result);
            Console.WriteLine(output);

        }



        static void Q1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
            if (n % i == 0)
            {
            Console.WriteLine(i);
            }

            }

        }




        static void X1(int q)
        {
            int masahat = q * q;
            int mohit = 4 * q;

            Console.WriteLine(masahat);
            Console.WriteLine(mohit);

        }


        static int u2(int number)
        {
            int u2 = 0;
            while (number != 0)
            {
                int D = number % 10;
                u2 = u2 * 10;
                u2 = u2 + D;
                number = number / 10;
            }
            return u2;
        }


    }
}


        
    


        
   
    

            
        
    


           

 

      
        
    
            




            
        
       


    

