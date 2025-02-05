using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3
{
    delegate string MyDelegate(Book B);
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, MyDelegate func)
        {
            foreach (Book B in bList)
                Console.WriteLine(func(B));

        }
        
       
    }
}
