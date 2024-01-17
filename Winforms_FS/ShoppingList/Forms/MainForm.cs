using ShoppingList.Models;
using ShoppingList.Forms;
using System.Globalization;

namespace ShoppingList
{
    public partial class MainForm : Form
    {
        public static List<ShoppingListItem> shoppingListItems = new List<ShoppingListItem>();
        BindingSource itemsBindingSource = [];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // Bind the the list of items to the binding source and show items in DataGridView
            itemsBindingSource.DataSource = shoppingListItems;
            shoppingListItemsView.DataSource = itemsBindingSource;

            // Hide the Id column as it is for internal use only and doesn't add any meaningful value for the user
            shoppingListItemsView.Columns["Id"].Visible = false;
            // Make sure decimals are shown properly
            shoppingListItemsView.Columns["Price"].DefaultCellStyle.Format = "N2";
            shoppingListItemsView.Columns["Price"].DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
        }

        internal void AddItemToList(ShoppingListItem item)
        {
            // Adds item to the current list
            shoppingListItems.Add(item);
            itemsBindingSource.ResetBindings(false);
        }

        internal void RemoveItemFromList(int i)
        {
            // Removes item from the current list on supplied index (if exists)
            if (i >= 0)
            {
                // Show confirmation modal for delete and delete on yes
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + shoppingListItems[i].Name + "?", "Confirm Delete", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    shoppingListItems.RemoveAt(i);
                    itemsBindingSource.ResetBindings(false);
                }
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // Update datagrid with new item(s)
            itemsBindingSource.ResetBindings(false);
        }

        #region ButtonActions

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Pass along the last item Id
            var newItemId = shoppingListItems.LastOrDefault()?.Id ?? 0;

            ItemAddForm itemForm = new ItemAddForm(newItemId);
            itemForm.ShowDialog();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            // Pass along the current list of items
            ItemDeleteForm itemForm = new ItemDeleteForm(shoppingListItems);
            itemForm.ShowDialog();
        }

        private void PriceTotalBox_Click(object sender, EventArgs e)
        {
            // Load/Update total price in bottom textbox
            priceTotalBox.Text = shoppingListItems.Sum(i => i.Price * i.Quantity).ToString();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            // Clear out the entire current list
            shoppingListItems.Clear();
            itemsBindingSource.ResetBindings(false);
        }

        private void SortingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortingDropdown.SelectedItem?.ToString())
            {
                case "A -> Z":
                    shoppingListItems.Sort((x, y) => x.Name.CompareTo(y.Name));
                    // shoppingListItems = shoppingListItems.OrderBy(i => i.Name).ToList();
                    itemsBindingSource.ResetBindings(false);
                    break;
                case "Z -> A":
                    shoppingListItems.Sort((x, y) => x.Name.CompareTo(y.Name));
                    shoppingListItems.Reverse();
                    // shoppingListItems = shoppingListItems.OrderByDescending(i => i.Name).ToList();
                    itemsBindingSource.ResetBindings(false);
                    break;
                case "0 -> 100":
                    shoppingListItems.Sort((x, y) => x.Price.CompareTo(y.Price));
                    // shoppingListItems = shoppingListItems.OrderBy(i => i.Price).ToList();
                    itemsBindingSource.ResetBindings(false);
                    break;
                case "100 -> 0":
                    shoppingListItems.Sort((x, y) => x.Price.CompareTo(y.Price));
                    shoppingListItems.Reverse();
                    // shoppingListItems = shoppingListItems.OrderByDescending(i => i.Price).ToList();
                    itemsBindingSource.ResetBindings(false);
                    break;
            }
        }

        #endregion
    }
}