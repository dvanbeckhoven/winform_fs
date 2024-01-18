using ShoppingListApp.Models;
using ShoppingListApp.Validators;

namespace ShoppingListApp.Forms
{
    public partial class ItemAddForm : Form
    {
        private int _itemId;

        public ItemAddForm(int newId)
        {            
            InitializeComponent();
            _itemId = newId;
        }

        private void SaveItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all input fields                
                var itemName = InputValidator.ValidateName(itemNameValue.Text);
                var itemDescription = itemDescriptionValue.Text;
                var itemPrice = InputValidator.ValidatePrice(itemPriceValue.Text);
                var itemQty = InputValidator.ValidateQty(itemQtyValue.Text);

                // No exceptions, add item to current shopping list
               var item = new ShoppingListItem()
                {
                    Id = _itemId,
                    Name = itemName,
                    Description = itemDescription,
                    Price = itemPrice,
                    Quantity = itemQty
                };

                // Add data to MainForm
                MainForm mainForm = new MainForm();
                mainForm.AddItemToList(item);

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured when saving the item: " + ex);
            }
        }
    }
}
