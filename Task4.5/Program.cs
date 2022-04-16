using System;

namespace Task4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*5) Her hansi bir eded daxil et.
            Eger eded polindromdursa o zaman bu ededin evveline ve axirin 1 reqemini artir ve cap et.
            Eks halda ededin ozunu cap et.   polindrom eded:  123321 ;  12321 --guzgu effekti*/
                
            Console.Write("Please enter a number:");
            l1:
            bool check = int.TryParse(Console.ReadLine(), out int number);

            if (check)
            {
                double numbeerC = number;

                int rev = 0;

                while (number > 0)
                {
                    rev = rev * 10 + number % 10;

                    number /= 10;

                }

                if (numbeerC == rev)
                {
                    double quan = Math.Floor(Math.Log10(numbeerC) + 1);

                    numbeerC = (numbeerC + Math.Pow(10, quan)) * 10 + 1;

                    Console.WriteLine(numbeerC);
                }

                else
                {
                    Console.WriteLine(numbeerC);
                }
            }

            else
            {
                Console.WriteLine("Wrong data entered please try again");

                goto l1;
            }
            
            


        }
    }
}
