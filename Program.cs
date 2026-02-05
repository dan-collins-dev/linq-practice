using System.Collections.Generic;
using System.Linq;

namespace LinqPractice;

class Program
{
    static async Task Main(string[] args)
    {
        List<Item> items = await Utils.GetAllItems();

        // Using method syntax
        PrintAllItemNamesMS(items);

        // Using query syntax
        // PrintAllItemNamesQS(items);
    }

    static void PrintAllItemNamesMS(List<Item> items)
    {
        List<string?> itemNames = items.Select(item => item.Name).ToList();

        foreach (string name in itemNames)
        {
            Console.WriteLine(name);
        }
    }

    static void PrintAllItemNamesQS(List<Item> items)
    {
        List<string> itemNames = (from item in items
                         select item.Name).ToList();

        foreach (string name in itemNames)
        {
            Console.WriteLine(name);
        }
    }
}
