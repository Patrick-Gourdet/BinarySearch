using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Binary
    {

        static int searchRecursive(List<int> sort, int num,int mid)
        {
            if (mid >= sort.Count || mid < 0)
                return -1;
            if (sort[mid] == num)
                return mid; 
            if(sort[mid]>num)
                return searchRecursive(sort, num, (mid / 2) + 1);
            if (sort[mid] < num)
                return searchRecursive(sort, num, sort.Count - (mid / 2) - 1);
            return -1;
        }

        static int searchIterative(List<int> sort, int num, int mid)
        {
            while (true)
            {
                if (mid >= sort.Count || mid < 0) return 0;
                if (sort[mid] == num) return mid;
                if (sort[mid] > num)
                {
                    mid = (mid / 2) + 1;
                    continue;
                }

                if (sort[mid] < num)
                {
                    var sort1 = sort;
                    mid = sort1.Count - (mid / 2) - 1;
                    continue;
                }

                
                break;
            }
            return -1;
        }

        static int Main()
        {

            IList<int> sort = new List<int>() { 4, 5, 8, 9, 65, 67, 68, 69, 99};
            var currentNumber =68;
            Console.WriteLine(searchIterative((List<int>)sort, currentNumber, sort.Count /2));
            return 0;
        }
    }
}