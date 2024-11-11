using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    static class Messages
    {

        public static void Hello(string name) 
        {
            Console.WriteLine($"Hello {name}");
        }    

       public static void Busy(string name) 
        {
            Console.WriteLine($"Am busy now {name}");    
        }
    }
}
