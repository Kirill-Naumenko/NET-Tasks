using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class StackCollection
    {

        public static double GetAddTime(Stack<int> collection, int count)
        {

            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                collection.Push(i);
            }
            Time.Stop();
            double addOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return addOperation;
        }


        public static double GetReadTime(Stack<int> collection, int count)
        {

            return 0;
        }

        public static double GetDeleteTime(Stack<int> collection, int count)
        {
            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                int x = collection.Pop();
            }
            Time.Stop();
            double removeOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return removeOperation;
        }

        public static double GetFindTime(Stack<int> collection, int count)
        {
            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                bool temp = collection.Contains(i);
            }
            Time.Stop();
            double findOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return findOperation;
        }

    }

}
