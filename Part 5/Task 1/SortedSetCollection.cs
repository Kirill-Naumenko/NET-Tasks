﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class SortedSetCollection
    {

        public static double GetAddTime(SortedSet<int> collection, int count)
        {

            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                collection.Add(i);
            }
            Time.Stop();
            double addOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return addOperation;
        }


        public static double GetReadTime(SortedSet<int> collection, int count)
        {
            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                int x = collection.ElementAt(i);
            }
            Time.Stop();
            double GetOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return GetOperation;
        }

        public static double GetDeleteTime(SortedSet<int> collection, int count)
        {
            Stopwatch Time = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                collection.Remove(i);
            }
            Time.Stop();
            double removeOperation = (Time.ElapsedTicks * 1000.0) / Stopwatch.Frequency;
            return removeOperation;
        }

        public static double GetFindTime(SortedSet<int> collection, int count)
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
