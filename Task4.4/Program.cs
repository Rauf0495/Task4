using System;

namespace Task4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4) 1-1000 qeder ederlerin icerisinde
            11-e bolunub reqemleri cemi 11-den boyuk olan 11-ci eded hansidir?*/

            int counter = 0;            
            for (int i = 1; i < 1000; i++)
            {
                int sum = 0;

                int j = i;

                bool state=true;

                while (j%11!=0)
                {
                    state=false;
                    break;
                }

                while (state&&j>0)
                {
                    sum = sum + j % 10;
                    j /= 10;                   
                }

                if (sum > 11)
                {
                    counter++;
                }

                if (state&&sum>11&&counter==11)
                {
                    
                    Console.WriteLine($"Eleventh number:{i}");
                }
                               

            }



        }
    }
}
