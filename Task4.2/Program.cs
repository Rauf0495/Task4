using System;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-1000 qeder ederlerin icerisinden ele ededleri cap etki :
            //hem polindrom olsun,
            //hem ededin reqemleri daxilinde 3 olmasin
            //hem ededin reqemleri cemi 10 dan boyuk olsun                       
             

            for (int i = 1; i < 1000; i++)
            {
                int rev = 0;
                int sum = 0;
                int num1 = i;

                while (num1 > 0)
                {
                    sum = sum + num1 % 10;

                    rev = rev * 10 + num1 % 10;

                    num1 /= 10;              

                }

                if (rev== i && i%10!=3 && (i/10) % 10 != 3 && sum>10)
                {
                    Console.WriteLine($"Numbers={i}");

                }



            }
               
                   
                   
            







        }
    }
}
