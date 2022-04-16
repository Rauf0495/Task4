using System;

namespace Task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3) 1-100000 qeder ederlerin icerisinden ele ededleri cap etki :
            //hem butun reqemleri eyni olsun,
            //hem reqemleri cemi 5 den boyuk olsun
            //hem reqemleri arasinda 5 reqemi olmasin           


            for (int i = 0; i < 100000; i++)
            {
                int j = i;
                int lastj = j % 10;
                int sum = 0;
                bool state=false;

                while (j > 0)
                {
                    sum = sum + j % 10;

                    if (j%10!=lastj||j%10==5)
                    {                        
                        state=true;
                        break;

                    }

                    j /= 10;

                }


                if (!state&&sum>5)
                {
                    Console.WriteLine(i);
                }





            }






        }
    }
}
