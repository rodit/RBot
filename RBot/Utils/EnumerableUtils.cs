using System;
using System.Collections.Generic;

namespace RBot.Utils;

public delegate void Consumer<T>(T arg);

public static class EnumerableUtils
{
    public static void ForEach<T>(this IEnumerable<T> enumerable, Consumer<T> func)
    {
        foreach (T item in enumerable)
            func(item);
    }

    public static bool Contains<T>(this IEnumerable<T> enumerable, Predicate<T> pred)
    {
        foreach (T item in enumerable)
            if (pred(item))
                return true;
        return false;
    }

    public static IList<T> Swap<T>(this IList<T> list, int indexA, int indexB)
    {
        T tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
        return list;
    }

    public static IEnumerable<Tuple<T, T>> PairUp<T>(this IEnumerable<T> list)
    {
        using IEnumerator<T> iterator = list.GetEnumerator();
        while (iterator.MoveNext())
        {
            var first = iterator.Current;
            var second = iterator.MoveNext() ? iterator.Current : default(T);
            yield return Tuple.Create(first, second);
        }
    }
}
