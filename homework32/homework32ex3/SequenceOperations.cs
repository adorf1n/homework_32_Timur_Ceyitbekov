using System;
using System.Collections.Generic;
using System.Linq;

public static class SequenceOperations
{
    public static List<int> Method1(List<int> lst)
    {
        return lst.Where(x => x < 0 && x % 2 == 0).ToList();
    }

    public static int Method2(List<int> lst)
    {
        return lst.Where(x => x > 0).DefaultIfEmpty(0).Min();
    }

    public static List<string> Method3(List<int> lst)
    {
        return lst.Where(x => x % 2 != 0)
                  .Select(x => x.ToString())
                  .OrderBy(x => x)
                  .ToList();
    }

    public static List<int> Method4(List<int> lst, int digit)
    {
        return lst.Where(x => x > 0 && x % 10 == digit)
                  .Distinct()
                  .ToList();
    }

    public static List<string> Method5(List<string> lst, int idx)
    {
        return lst.Take(idx)
                  .Where(s => s.Length % 2 != 0 && char.IsUpper(s[0]))
                  .Reverse()
                  .ToList();
    }

    public static List<int> Method6(List<int> lst)
    {
        return lst.Select((x, i) => x * (i + 1))
                  .Where(x => x >= 10 && x < 100)
                  .Reverse()
                  .ToList();
    }
}
