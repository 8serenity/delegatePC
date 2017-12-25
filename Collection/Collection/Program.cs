using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    1.
    Удалить все нечетные элементы списка ArrayList
                
    2.
    Дана коллекция. Вывести на экран элементы, значение которых больше 
    среднего арифметического всех элементов коллекции.
*/


namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(1);
                Console.WriteLine(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (i / 2 == 0)
                {
                    list.RemoveAt(i);
                }
            }


            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            Console.Read();

        }
    }
}