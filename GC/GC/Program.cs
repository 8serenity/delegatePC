using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace GC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> list = new List<User>();
            for (int i = 0; i < 1000000000; i++)
            {
                User user = new User { Login = "admin", Password = "123" };

                //Получение поколения какого-то элемента

                Console.WriteLine(System.GC.GetGeneration(user));
                list.Add(user);
                System.GC.Collect();
            }

            for (int i = 0; i < 1000000000; i++)
            {
                list.RemoveAt(i);
            }
        }
    }
}
