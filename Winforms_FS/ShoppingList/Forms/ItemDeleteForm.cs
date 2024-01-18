using ShoppingListApp.Models;

namespace ShoppingListApp.Forms
{
    public partial class itemDeleteForm : Form
    {
        private static List<ShoppingListItem>? _shoppingListItems;

        public itemDeleteForm(List<ShoppingListItem> shoppingListItems)
        {
            _shoppingListItems = shoppingListItems;
            InitializeComponent();
        }

        private void ItemDeleteForm_Load(object sender, EventArgs e)
        {
            itemListBox.DataSource = _shoppingListItems;
            itemListBox.DisplayMember = "Name";
            itemListBox.ValueMember = "Name";
        }

        private void ItemListBox_Click(object sender, EventArgs e)
        {
            int i = itemListBox.SelectedIndex;

            // Send data to MainForm
            MainForm mainForm = new MainForm();
            mainForm.RemoveItemFromList(i);
        }

        private void ItemDeleteCloseButton_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
