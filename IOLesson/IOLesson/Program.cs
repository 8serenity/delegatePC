using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace IOLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.Start("http://10.3.6.80/$1");

            Process.Start("http://10.3.6.80/$2");

            Console.Read();
        }
        
        
    }


}
