namespace ShoppingListApp.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<ShoppingListItem>? Items { get; set; }
    }
}
