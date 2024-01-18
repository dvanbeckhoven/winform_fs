using ShoppingListApp.Models;

namespace ShoppingListApp.Forms
{
    public partial class ListSelectForm : Form
    {
        private static List<ShoppingList>? _shoppingLists;

        public ListSelectForm(List<ShoppingList> shoppingLists)
        {
            _shoppingLists = shoppingLists;
            InitializeComponent();
        }

        private void ListSelectForm_Load(object sender, EventArgs e)
        {
            listListBox.DataSource = _shoppingLists;
            listListBox.DisplayMember = "Name";
            listListBox.ValueMember = "Name";
        }        

        private void OpenListButton_Click(object sender, EventArgs e)
        {
            int i = listListBox.SelectedIndex;

            // Send data to MainForm
            MainForm mainForm = new MainForm();
            mainForm.LoadSelectedList(i);

            // Close the form
            this.Close();
        }
    }
}
