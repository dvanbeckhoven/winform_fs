﻿namespace ShoppingListApp.Models
{
    public class ShoppingListItem
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
