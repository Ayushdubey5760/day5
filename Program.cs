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
            fruits.Add("apple");
            fruits.Add("cherry");

            fruits.Add("banana");

            fruits.Add("date");

            fruits.Add("elderberry");


            Console.WriteLine("Total number of elements is : " + fruits.Count);
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");



            while (true)
            {
                Console.WriteLine("add. Insert Item \t remove. Remove Item\t Search. search Item");

                string res = Console.ReadLine();

                Console.WriteLine("Input Item");

                string item = Console.ReadLine();

                switch (res)
                {
                    case "add":
                        {
                            Console.WriteLine("Enter Index");
                            int index = int.Parse(Console.ReadLine());
                            fruits.Insert(index, item);
                            Console.WriteLine("Item Added");

                            break;
                        }
                    case "remove":
                        {
                            fruits.Remove(item);
                            break;
                        }
                    case "search":
                        {
                            if (fruits.Contains(item))
                            {
                                Console.WriteLine(item);
                            }
                            else
                            {
                                Console.WriteLine("item Not Found");
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
    

