using System.Collections.Generic;
using System.Linq;

namespace LinqPractice;

class Program
{
    static async Task Main(string[] args)
    {
        List<Item> items = await Utils.GetAllItems();

        // Using method syntax
        // ItemQueries.PrintAllItemNamesQS(items);

        // Using query syntax
        ItemQueries.PrintAllItemNamesQS(items);
    }

    
}
