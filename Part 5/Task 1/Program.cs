using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {


            {
               

                string pathFile = ConfigurationManager.AppSettings["log"];
                StreamWriter writer = new StreamWriter(pathFile, true);
                int count = Int32.Parse(ConfigurationManager.AppSettings["count"]);



                List<int> list = new List<int>();
                LinkedList<int> linkedList = new LinkedList<int>();
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                Queue<int> queue = new Queue<int>();
                Stack<int> stack = new Stack<int>();
                SortedSet<int> sortedSet = new SortedSet<int>();
                SortedDictionary<int, int> sortedDictionary = new SortedDictionary<int, int>();

                Console.WriteLine("Скорость работы list, команда Add : " + Math.Round(ListCollection.GetAddTime(list, count), 3));
                Console.WriteLine("Скорость работы list, команда get : " + Math.Round(ListCollection.GetReadTime(list, count), 3));
                Console.WriteLine("Скорость работы list, команда Remove : " + Math.Round(ListCollection.GetDeleteTime(list, count), 3));
                Console.WriteLine("Скорость работы list, команда Contains : " + Math.Round(ListCollection.GetFindTime(list, count), 3));

                Console.WriteLine("Скорость работы LinkedList, команда Add : " + Math.Round(LinkedListCollection.GetAddTime(linkedList, count), 3));
                Console.WriteLine("Скорость работы LinkedList, команда get : " + Math.Round(LinkedListCollection.GetReadTime(linkedList, count), 3));
                Console.WriteLine("Скорость работы LinkedList, команда Remove : " + Math.Round(LinkedListCollection.GetDeleteTime(linkedList, count), 3));
                Console.WriteLine("Скорость работы LinkedList, команда Contains : " + Math.Round(LinkedListCollection.GetFindTime(linkedList, count), 3));

                Console.WriteLine("Скорость работы Dictionary, команда Add : " + Math.Round(DictionaryCollection.GetAddTime(dictionary, count), 3));
                Console.WriteLine("Скорость работы Dictionary, команда get : " + Math.Round(DictionaryCollection.GetReadTime(dictionary, count), 3));
                Console.WriteLine("Скорость работы Dictionary, команда Remove : " + Math.Round(DictionaryCollection.GetDeleteTime(dictionary, count), 3));
                Console.WriteLine("Скорость работы Dictionary, команда Contains : " + Math.Round(DictionaryCollection.GetFindTime(dictionary, count), 3));

                Console.WriteLine("Скорость работы Queue, команда Add : " + Math.Round(QueueCollection.GetAddTime(queue, count), 3));
                Console.WriteLine("Скорость работы Queue, команда Remove : " + Math.Round(QueueCollection.GetDeleteTime(queue, count), 3));
                Console.WriteLine("Скорость работы Queue, команда Contains : " + Math.Round(QueueCollection.GetFindTime(queue, count), 3));

                Console.WriteLine("Скорость работы Stack, команда Add : " + Math.Round(StackCollection.GetAddTime(stack, count), 3));
                Console.WriteLine("Скорость работы Stack, команда Remove : " + Math.Round(StackCollection.GetDeleteTime(stack, count), 3));
                Console.WriteLine("Скорость работы Stack, команда Contains : " + Math.Round(StackCollection.GetFindTime(stack, count), 3));

                Console.WriteLine("Скорость работы SortedSet, команда Add : " + Math.Round(SortedSetCollection.GetAddTime(sortedSet, count), 3));
                Console.WriteLine("Скорость работы SortedSet, команда get : " + Math.Round(SortedSetCollection.GetReadTime(sortedSet, count), 3));
                Console.WriteLine("Скорость работы SortedSet, команда Remove : " + Math.Round(SortedSetCollection.GetDeleteTime(sortedSet, count), 3));
                Console.WriteLine("Скорость работы SortedSet, команда Contains : " + Math.Round(SortedSetCollection.GetFindTime(sortedSet, count), 3));

                Console.WriteLine("Скорость работы SortedDictionary, команда Add : " + Math.Round(SortedDictionaryCollection.GetAddTime(sortedDictionary, count), 3));
                Console.WriteLine("Скорость работы SortedDictionary, команда get : " + Math.Round(SortedDictionaryCollection.GetReadTime(sortedDictionary, count), 3));
                Console.WriteLine("Скорость работы SortedDictionary, команда Remove : " + Math.Round(SortedDictionaryCollection.GetDeleteTime(sortedDictionary, count), 3));
                Console.WriteLine("Скорость работы SortedDictionary, команда Contains : " + Math.Round(SortedDictionaryCollection.GetFindTime(sortedDictionary, count), 3));


                writer.WriteLine("Скорость работы list, команда Add : " + Math.Round(ListCollection.GetAddTime(list, count), 3));
                writer.WriteLine("Скорость работы list, команда get : " + Math.Round(ListCollection.GetReadTime(list, count), 3));
                writer.WriteLine("Скорость работы list, команда Remove : " + Math.Round(ListCollection.GetDeleteTime(list, count), 3));
                writer.WriteLine("Скорость работы list, команда Contains : " + Math.Round(ListCollection.GetFindTime(list, count), 3));

                writer.WriteLine("Скорость работы LinkedList, команда Add : " + Math.Round(LinkedListCollection.GetAddTime(linkedList, count), 3));
                writer.WriteLine("Скорость работы LinkedList, команда get : " + Math.Round(LinkedListCollection.GetReadTime(linkedList, count), 3));
                writer.WriteLine("Скорость работы LinkedList, команда Remove : " + Math.Round(LinkedListCollection.GetDeleteTime(linkedList, count), 3));
                writer.WriteLine("Скорость работы LinkedList, команда Contains : " + Math.Round(LinkedListCollection.GetFindTime(linkedList, count), 3));

                writer.WriteLine("Скорость работы Dictionary, команда Add : " + Math.Round(DictionaryCollection.GetAddTime(dictionary, count), 3));
                writer.WriteLine("Скорость работы Dictionary, команда get : " + Math.Round(DictionaryCollection.GetReadTime(dictionary, count), 3));
                writer.WriteLine("Скорость работы Dictionary, команда Remove : " + Math.Round(DictionaryCollection.GetDeleteTime(dictionary, count), 3));
                writer.WriteLine("Скорость работы Dictionary, команда Contains : " + Math.Round(DictionaryCollection.GetFindTime(dictionary, count), 3));

                writer.WriteLine("Скорость работы Queue, команда Add : " + Math.Round(QueueCollection.GetAddTime(queue, count), 3));
                writer.WriteLine("Скорость работы Queue, команда Remove : " + Math.Round(QueueCollection.GetDeleteTime(queue, count), 3));
                writer.WriteLine("Скорость работы Queue, команда Contains : " + Math.Round(QueueCollection.GetFindTime(queue, count), 3));

                writer.WriteLine("Скорость работы Stack, команда Add : " + Math.Round(StackCollection.GetAddTime(stack, count), 3));
                writer.WriteLine("Скорость работы Stack, команда Remove : " + Math.Round(StackCollection.GetDeleteTime(stack, count), 3));
                writer.WriteLine("Скорость работы Stack, команда Contains : " + Math.Round(StackCollection.GetFindTime(stack, count), 3));

                writer.WriteLine("Скорость работы SortedSet, команда Add : " + Math.Round(SortedSetCollection.GetAddTime(sortedSet, count), 3));
                writer.WriteLine("Скорость работы SortedSet, команда get : " + Math.Round(SortedSetCollection.GetReadTime(sortedSet, count), 3));
                writer.WriteLine("Скорость работы SortedSet, команда Remove : " + Math.Round(SortedSetCollection.GetDeleteTime(sortedSet, count), 3));
                writer.WriteLine("Скорость работы SortedSet, команда Contains : " + Math.Round(SortedSetCollection.GetFindTime(sortedSet, count), 3));

                writer.WriteLine("Скорость работы SortedDictionary, команда Add : " + Math.Round(SortedDictionaryCollection.GetAddTime(sortedDictionary, count), 3));
                writer.WriteLine("Скорость работы SortedDictionary, команда get : " + Math.Round(SortedDictionaryCollection.GetReadTime(sortedDictionary, count), 3));
                writer.WriteLine("Скорость работы SortedDictionary, команда Remove : " + Math.Round(SortedDictionaryCollection.GetDeleteTime(sortedDictionary, count), 3));
                writer.WriteLine("Скорость работы SortedDictionary, команда Contains : " + Math.Round(SortedDictionaryCollection.GetFindTime(sortedDictionary, count), 3));

                writer.Close();


                Console.ReadKey();



            }

        }
    }
}
