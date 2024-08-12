using System;
using System.Collections.Generic;

public static class ListExtensions
{
    public static List<T> CustomSort<T>(this List<T> list) where T : IComparable<T>
    {
        List<T> sortedList = new List<T>(list);

        for (int i = 1; i < sortedList.Count; i++)
        {
            T key = sortedList[i];
            int j = i - 1;

            while (j >= 0 && sortedList[j].CompareTo(key) > 0)
            {
                sortedList[j + 1] = sortedList[j];
                j--;
            }

            sortedList[j + 1] = key;
        }

        return sortedList;
    }
}
