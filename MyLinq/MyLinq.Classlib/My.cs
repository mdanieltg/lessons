namespace MyLinq.Classlib;

public static class My
{
    // Where
    public static IEnumerable<T> Where<T>(this IEnumerable<T> collection, Func<T, bool> condition)
    {
        var list = new List<T>();
        foreach (var item in collection)
            if (condition(item))
                list.Add(item);

        return list;
    }

    // OrderBy
    public static IEnumerable<T> OrderBy<T, TSelector>(this IEnumerable<T> collection, Func<T, TSelector> selector)
    {
        var sortedList = new SortedSet<T>();
        foreach (var item in collection)
        {
            sortedList.Add(selector(item));
        }
        return sortedList.ToList();
    }

    // First
    public static T First<T>(this IEnumerable<T> collection, Func<T, bool> condition)
    {
        foreach (var item in collection)
            if (condition(item))
                return item;

        throw new Exception("No se encontró ningún valor en la colección que satisfaga la condición dada.");
    }

    public static T First<T>(this IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            return item;
        }

        throw new Exception("La colección está vacía.");
    }

    // FirstOrDefault
    public static T? FirstOrDefault<T>(this IEnumerable<T> collection, Func<T, bool> condition)
    {
        foreach (var item in collection)
            if (condition(item))
                return item;

        return default(T);
    }

    // Select
}
