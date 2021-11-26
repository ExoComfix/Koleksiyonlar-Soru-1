using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
    public static bool prime(int number)
        {
            bool IsPrime = true;
            int check = 0;
 
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                {
                    check = 1;
                    break;
                }
            }
            if (check == 1)
            {
                IsPrime = false;
            }
            return IsPrime;
        }
 
        static void Main(string[] args)
        {
            ArrayList primeList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Type a number : ");
                int b = Convert.ToInt32(Console.ReadLine());
                if (prime(b))
                {
                    primeList.Add(b);
                }
            }
            Console.WriteLine("******* Prime Numbers *******");
            foreach (int number in primeList)
            {
                Console.Write(number + "    ");
            }
            Console.ReadKey();
        }
    }
}
