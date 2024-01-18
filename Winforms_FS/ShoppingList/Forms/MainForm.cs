using ShoppingListApp.Models;
using ShoppingListApp.Forms;
using System.Globalization;

namespace ShoppingListApp
{
    public partial class MainForm : Form
    {
        public static List<ShoppingList> _shoppingLists = SetDefaultList();
        private static List<ShoppingList> SetDefaultList() =>
            new List<ShoppingList>()
            {
                new ShoppingList()
                {
                    Id = 1,
                    Name = "Default",
                    Items = new List<ShoppingListItem>()
                }
            };
        public static List<ShoppingListItem> _shoppingListItems = new List<ShoppingListItem>();
        BindingSource _listBindingSource = [];
        BindingSource _itemsBindingSource = [];

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            // Bind the the list of items to the binding source and show items in DataGridView
            _itemsBindingSource.DataSource = _shoppingListItems;
            shoppingListItemsView.DataSource = _itemsBindingSource;

            // Bind the shopping lists to the binding source
            _listBindingSource.DataSource = _shoppingLists;

            // Hide the Id column as it is for internal use only and doesn't add any meaningful value for the user
            shoppingListItemsView.Columns["Id"].Visible = false;
            // Make sure decimals are shown properly
            shoppingListItemsView.Columns["Price"].DefaultCellStyle.Format = "N2";
            shoppingListItemsView.Columns["Price"].DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;
        }

        #region Items

        internal void AddItemToList(ShoppingListItem item)
        {
            // Adds item to the current list
            _shoppingListItems.Add(item);
            _itemsBindingSource.ResetBindings(false);
        }

        internal void RemoveItemFromList(int i)
        {
            // Removes item from the current list on supplied index (if exists)
            if (i >= 0)
            {
                // Show confirmation modal for delete and delete on yes
                DialogResult result = MessageBox.Show("Are you sure you want to delete " + _shoppingListItems[i].Name + "?", "Confirm Delete", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    _shoppingListItems.RemoveAt(i);
                    _itemsBindingSource.ResetBindings(false);
                }
            }
        }

        #endregion

        #region Lists

        internal void AddNewList(ShoppingList list)
        {
            // Adds item to the current list
            _shoppingLists.Add(list);
            _itemsBindingSource.ResetBindings(false);
        }

        internal void LoadSelectedList(int i)
        {
            // Clear the current shopping list and set the values of the shoppingListItems to the selected list
            if (i >= 0 && _shoppingLists[i]?.Items?.Count > 0)
            {
                _shoppingListItems.Clear();
                _shoppingListItems.AddRange(_shoppingLists[i].Items);
                _listBindingSource.ResetBindings(false);
                _itemsBindingSource.ResetBindings(false);
            }            
        }

        #endregion

        private void MainForm_Activated(object sender, EventArgs e)
        {
            // Update datagrid with new item(s)
            _itemsBindingSource.ResetBindings(false);
        }

        #region ButtonActions

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Pass along the last item Id
            var newItemId = _shoppingListItems.LastOrDefault()?.Id ?? 0;

            ItemAddForm itemForm = new ItemAddForm(newItemId);
            itemForm.ShowDialog();
        }

        private void DeleteItemButton_Click(object sender, EventArgs e)
        {
            // Pass along the current list of items
            itemDeleteForm itemForm = new itemDeleteForm(_shoppingListItems);
            itemForm.ShowDialog();
        }

        private void PriceTotalBox_Click(object sender, EventArgs e)
        {
            // Load/Update total price in bottom textbox
            // ToDo: Make this update automatically (event) on not via manual click
            priceTotalBox.Text = _shoppingListItems.Sum(i => i.Price * i.Quantity).ToString();
        }

        private void ClearListButton_Click(object sender, EventArgs e)
        {
            // Clear out the entire current list
            _shoppingListItems.Clear();
            _itemsBindingSource.ResetBindings(false);
        }

        private void NewListButton_Click(object sender, EventArgs e)
        {
            // Pass along the last item Id
            var newListId = _shoppingLists.LastOrDefault()?.Id ?? 0;

            ListAddForm listAddForm = new ListAddForm(newListId);
            listAddForm.ShowDialog();
        }

        private void SelectListButton_Click(object sender, EventArgs e)
        {
            // Pass along the current list of items
            ListSelectForm listSelectForm = new ListSelectForm(_shoppingLists);
            listSelectForm.ShowDialog();
        }

        private void SortingDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sortingDropdown.SelectedItem?.ToString())
            {
                case "A -> Z":
                    _shoppingListItems.Sort((x, y) => x.Name.CompareTo(y.Name));                    
                    _itemsBindingSource.ResetBindings(false);
                    break;
                case "Z -> A":
                    _shoppingListItems.Sort((x, y) => x.Name.CompareTo(y.Name));
                    _shoppingListItems.Reverse();
                    _itemsBindingSource.ResetBindings(false);
                    break;
                case "0 -> 100":
                    _shoppingListItems.Sort((x, y) => x.Price.CompareTo(y.Price));                    
                    _itemsBindingSource.ResetBindings(false);
                    break;
                case "100 -> 0":
                    _shoppingListItems.Sort((x, y) => x.Price.CompareTo(y.Price));
                    _shoppingListItems.Reverse();                    
                    _itemsBindingSource.ResetBindings(false);
                    break;
            }
        }

        #endregion
    }
}