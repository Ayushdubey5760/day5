using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            { "apple" , "cherry" , "banana" ,"date" , "elderberry" }

            Console.WriteLine("Total number of elements is : " + fruits.count);

            Console.WriteLine("\n");

            Console.WriteLine("1. Insert Item \t 2. Remove Item\t Search Item");

            int res = int.Parse(Console.ReadLine());

            Console.WriteLine("Input Item");

            string item = Console.ReadLine();

            switch (res)
            {
                case 1:
                    {
                        fruits.Add(item);
                        break;
                    }
                case 2:
                    {
                        fruits.Remove(item);
                        break;
                    }
                case 3:
                    {
                        if (fruits.Contains(items))
                        {
                            Console.WriteLine(item);
                        }
                        else
                        {
                            Console.WriteLine(item Not Found);
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Invalid operation");
                        break;

                    }

    }

}
            
            






            







            }






        }
    }
}
