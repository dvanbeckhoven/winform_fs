using ShoppingList.Models;

namespace ShoppingList.Actions
{
    internal class ItemController
    {
        internal static List<ShoppingListItem> GetItems()
        {
            var list = new List<ShoppingListItem>
            {
                new ShoppingListItem()
                {
                    Id = 1,
                    Name = "Brood",
                    Description = "Lekker heel volkoren brood",
                    Price = 2.95m,
                    Quantity = 1
                },
                new ShoppingListItem()
                {
                    Id = 2,
                    Name = "Melk",
                    Description = "Halfvolle melk vers van het land",
                    Price = 1.45m,
                    Quantity = 2
                },
            };

            return list;
        }
    }
}
