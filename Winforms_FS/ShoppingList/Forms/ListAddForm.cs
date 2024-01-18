using ShoppingListApp.Models;
using ShoppingListApp.Validators;

namespace ShoppingListApp.Forms
{
    public partial class ListAddForm : Form
    {
        private int _listId;

        public ListAddForm(int newId)
        {
            InitializeComponent();
            _listId = newId;
        }

        private void SaveListButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate all input fields
                var listName = InputValidator.ValidateName(listNameValue.Text);

                // No exceptions, add item to current shopping list
                var list = new ShoppingList()
                {
                    Id = _listId,
                    Name = listName,
                    Items = new List<ShoppingListItem>()
                };

                // Add data to MainForm
                MainForm mainForm = new MainForm();
                mainForm.AddNewList(list);

                // Close the form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured when saving the list: " + ex);
            }
        }
    }
}