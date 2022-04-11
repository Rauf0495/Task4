using System;

namespace Task4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-1000 qeder CUT ederlerin icerisinde
            //reqemleri cemi 5 ile 7 arasinda olan en boyuk eded hansidir?
            int num = 0;

            int sum = 0;
            
            for (int i = 2; i < 1000; i+=2)
            {               

                if (i%2==0)
                {
                    int a = i;
                    
                    while (a>0)
                    {                        
                        sum = sum + a % 10;

                        a = a / 10;                       
                    }

                    if (sum == 6)
                    {
                        num = i;
                        Console.WriteLine(num);
                    }


                }

                sum = 0;
                
            }

            




        }
    }
}
