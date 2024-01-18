using System.Globalization;

namespace ShoppingListApp.Validators
{    
    internal class InputValidator    
    {
        /// <summary>
        /// Validates if the submitted value contains a valid name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="AggregateException"></exception>
        public static string ValidateName(string name) =>
            !string.IsNullOrWhiteSpace(name) 
            ? name 
            : throw new AggregateException("Name not entered");

        /// <summary>
        /// Validates if the submitted quantity is a valid int
        /// </summary>
        /// <param name="qty"></param>
        /// <returns></returns>
        /// <exception cref="AggregateException"></exception>
        public static int ValidateQty(string qty) =>
            int.TryParse(qty, out int validatedQty) 
            ? validatedQty 
            : throw new AggregateException("Item quantity is not entered or not a valid numeric value, e.g. 1.");

        /// <summary>
        /// Validates if the submitted price is a valid decimal
        /// </summary>
        /// <param name="price"></param>
        /// <returns></returns>
        /// <exception cref="AggregateException"></exception>
        public static decimal ValidatePrice(string price) =>
            decimal.TryParse(price, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal validatedPrice) 
            ? validatedPrice 
            : throw new AggregateException("Item price is not entered or not a valid decimal value, e.g. 2.95.");
    }
}
