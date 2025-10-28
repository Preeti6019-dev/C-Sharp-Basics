using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while (true)
            {
                Console.WriteLine("Please enter the Value == ");
                input = Console.ReadLine();

                if(input.Equals("S" , StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("OK testing Finsished here.............");
                    break;
                }
                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter Some character instead of space only...");
                    continue;
                }
                //FindFrequency(input);
                FindFrequecyUsingDictionary(input);
                Console.WriteLine("====================================== ");

            }
        }

        /// <summary>
        /// Find Frequency of character 
        /// </summary>
        /// <param name="inp"></param>
        public static void FindFrequency(string inp)
        {
            char[] array = inp.ToCharArray();
            var dup = array.GroupBy(x => x).Select(x => new { key = x, value = x.Count() }).ToList();
            for (int i = 0; i < dup.Count(); i++)
            {
                Console.WriteLine("character " + dup[i].key.Key + " Exists " + dup[i].value + " times ");
            }
        }

        public static void FindFrequecyUsingDictionary(string str)
        {
            Dictionary<char, int> keyValuePair = new Dictionary<char, int>();
            char[] array = new char[0];
            array = str.ToCharArray();
            for(int i = 0; i < array.Length; i++)
            {
                if (keyValuePair.Keys.Contains(array[i]))
                {
                    keyValuePair[array[i]]++;
                }
                else
                {
                    keyValuePair.Add(array[i], 1);
                }
            }

            for(int k = 0; k < keyValuePair.ToList().Count; k++)
            {
                Console.WriteLine($"{keyValuePair.ToList()[k].Key}   exist {keyValuePair.ToList()[k].Value}");
            }
        }


        //char[] dup = Array.Empty<char>();
        //char[] dup = new char[0];
    }
}
