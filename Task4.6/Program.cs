using System;

namespace Task4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6) Her hansi bir eded daxil et.
            Bu ededin daxilinden 5 ve 7 reqemlerini legv et.
            Neticenin I ve Sonuncu reqemlerini deyishib cap et.
            Alinan cavabin icerisinde nece dene tek reqem oldugunu yaz.*/

            Console.Write("Please enter a number:");
            bool check=int.TryParse(Console.ReadLine(), out int number);

            if (!check)
            {
                Console.WriteLine("Wrong data entered,please try again");
            }                      

            int counter = 0;
            int newN = 0;
            while (number>0)
            {
                if (number%10==5|| number % 10 == 7)
                {
                    number /= 10;

                }
                else
                {
                    newN = newN+ (number % 10)*Convert.ToInt32(Math.Pow(10,counter));
                    counter++;
                    number /= 10;
                }
            }        
            int lastNewN = newN % 10;
            int firstNewN = newN / Convert.ToInt32(Math.Pow(10, counter - 1));
            newN = newN / 10;
            newN = newN % Convert.ToInt32(Math.Pow(10, counter - 2));
            newN = lastNewN * Convert.ToInt32(Math.Pow(10, counter - 2)) + newN;
            newN = newN * 10 + firstNewN;

            Console.WriteLine(newN);

            counter = 0;

            while (newN>0)
            {
                if (newN%2!=0)
                {
                    counter++;
                    
                }

                newN /= 10;

            }

            Console.WriteLine($"Count of single numbers:{counter}");











        }
    }
}
