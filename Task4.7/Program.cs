using System;

namespace Task4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Kitabxana sistemi

            Kitab təsviri üçün Data Structure yaratmaq - Book.cs

            Kitabın təsviri üçün aşağıdakı memberlər olmalıdır

            Kitabın adı (Name)

            Müəllifin adı (AuthorName)

            Nəşr ili (PublishedDate)

            Səhifə sayı (PageCount) (10-dan az reqem daxil etmek olmasin)*/

            Book b1=new Book();

            Console.Write("Please enter book name:");
            b1.bookName = Console.ReadLine();

            Console.Write("Please enter Author name:");
            b1.AuthorName = Console.ReadLine();

            Console.Write("Please enter published year:");
            b1.PublishedDate = int.Parse(Console.ReadLine());

            Console.Write("Please enter page count:");
            b1.PageCount = int.Parse(Console.ReadLine());


            Console.WriteLine(b1);

            b1.Print();

            

            



           

            







        }
    }
}
