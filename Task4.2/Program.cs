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

            int num =232;           
            int num1 = num;           
            int num2 = num;           
            int rev =0;
            int rem = 0;           
            
            bool polState=false;
            bool divide3=false;
            bool sum10=false;

            while (num>0)
            {
                rem = rem + num % 10;

                if (rem<10)
                {
                    sum10 = true;
                }

                num /= 10;               

            }

            while (num1 > 0)
            {
                rev = (rev*10)+ (num1 % 10);
                num1 /= 10;
            }

            if (rem== rev)
            {
                polState = true;
            }

            while (num2>0)
            {
                int qaliq = num2 % 10;

                if (qaliq==3)
                {
                    divide3 = true;
                    break;
                }
                num2/=10;

            }







        }
    }
}
