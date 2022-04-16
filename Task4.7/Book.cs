using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4._7
{
    internal class Book
    {
        internal string bookName;
        internal string AuthorName;
        internal int  PublishedDate;
        int pageCount;

        public int PageCount
        {
            get
            {
               return pageCount;

            }

            set
            {
                if (value > 10)
                {
                    pageCount = value;
                }

                else
                {
                    throw new Exception("Minimum 10 page counts needed");
                }
                


            }

        }
       


        public override string ToString()
        {
            return $"{AuthorName} {bookName} {PublishedDate}";
        }

        public void Print()
        {

            Console.WriteLine($"Composition:{bookName}\n" +
                             $"Author:{AuthorName}\n" +
                             $"Year of release:{PublishedDate}\n" +
                             $"Page counts:{pageCount}");
        }

    }
}
