namespace LinqPractice;

public static class ItemQueries
{
    public static void PrintAllItemNamesMS(List<Item> items)
    {
        List<string?> itemNames = items.Select(item => item.Name).ToList();

        foreach (string name in itemNames)
        {
            Console.WriteLine(name);
        }
    }

    public static void PrintAllItemNamesQS(List<Item> items)
    {
        List<string> itemNames = (from item in items
                         select item.Name).ToList();

        foreach (string name in itemNames)
        {
            Console.WriteLine(name);
        }
    }
}