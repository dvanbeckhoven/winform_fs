namespace ShoppingListApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            shoppingListItemsView = new DataGridView();
            mainNameLabel = new Label();
            totalLabel = new Label();
            priceTotalBox = new TextBox();
            selectListButton = new Button();
            newListButton = new Button();
            saveListButton = new Button();
            clearListButton = new Button();
            addItemButton = new Button();
            removeItemButton = new Button();
            euroSignLabel = new Label();
            sortingDropdown = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)shoppingListItemsView).BeginInit();
            SuspendLayout();
            // 
            // shoppingListItemsView
            // 
            shoppingListItemsView.AllowUserToAddRows = false;
            shoppingListItemsView.AllowUserToDeleteRows = false;
            shoppingListItemsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            shoppingListItemsView.BackgroundColor = SystemColors.Window;
            shoppingListItemsView.BorderStyle = BorderStyle.Fixed3D;
            shoppingListItemsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            shoppingListItemsView.Location = new Point(12, 52);
            shoppingListItemsView.Name = "shoppingListItemsView";
            shoppingListItemsView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            shoppingListItemsView.Size = new Size(535, 499);
            shoppingListItemsView.TabIndex = 0;
            // 
            // mainNameLabel
            // 
            mainNameLabel.AutoSize = true;
            mainNameLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainNameLabel.ForeColor = Color.Indigo;
            mainNameLabel.Location = new Point(12, 9);
            mainNameLabel.Name = "mainNameLabel";
            mainNameLabel.Size = new Size(144, 30);
            mainNameLabel.TabIndex = 1;
            mainNameLabel.Text = "Shopping list";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.ForeColor = Color.Indigo;
            totalLabel.Location = new Point(12, 566);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(113, 30);
            totalLabel.TabIndex = 2;
            totalLabel.Text = "Total price";
            // 
            // priceTotalBox
            // 
            priceTotalBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            priceTotalBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            priceTotalBox.Location = new Point(336, 566);
            priceTotalBox.Name = "priceTotalBox";
            priceTotalBox.PlaceholderText = "0.00";
            priceTotalBox.ReadOnly = true;
            priceTotalBox.Size = new Size(211, 35);
            priceTotalBox.TabIndex = 3;
            priceTotalBox.TextAlign = HorizontalAlignment.Right;
            priceTotalBox.Click += PriceTotalBox_Click;
            // 
            // selectListButton
            // 
            selectListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectListButton.BackColor = Color.ForestGreen;
            selectListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectListButton.ForeColor = Color.White;
            selectListButton.Image = (Image)resources.GetObject("selectListButton.Image");
            selectListButton.ImageAlign = ContentAlignment.MiddleLeft;
            selectListButton.Location = new Point(752, 52);
            selectListButton.Name = "selectListButton";
            selectListButton.Padding = new Padding(4, 0, 0, 0);
            selectListButton.Size = new Size(180, 40);
            selectListButton.TabIndex = 4;
            selectListButton.Text = "Select List";
            selectListButton.TextAlign = ContentAlignment.MiddleLeft;
            selectListButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectListButton.UseVisualStyleBackColor = false;
            selectListButton.Click += SelectListButton_Click;
            // 
            // newListButton
            // 
            newListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            newListButton.BackColor = Color.ForestGreen;
            newListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newListButton.ForeColor = Color.White;
            newListButton.Image = (Image)resources.GetObject("newListButton.Image");
            newListButton.ImageAlign = ContentAlignment.MiddleLeft;
            newListButton.Location = new Point(752, 107);
            newListButton.Name = "newListButton";
            newListButton.Padding = new Padding(4, 0, 0, 0);
            newListButton.Size = new Size(180, 40);
            newListButton.TabIndex = 5;
            newListButton.Text = "New List";
            newListButton.TextAlign = ContentAlignment.MiddleLeft;
            newListButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newListButton.UseVisualStyleBackColor = false;
            newListButton.Click += NewListButton_Click;
            // 
            // saveListButton
            // 
            saveListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            saveListButton.BackColor = Color.ForestGreen;
            saveListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveListButton.ForeColor = Color.White;
            saveListButton.Image = (Image)resources.GetObject("saveListButton.Image");
            saveListButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveListButton.Location = new Point(752, 162);
            saveListButton.Name = "saveListButton";
            saveListButton.Padding = new Padding(4, 0, 0, 0);
            saveListButton.Size = new Size(180, 40);
            saveListButton.TabIndex = 6;
            saveListButton.Text = "Save List";
            saveListButton.TextAlign = ContentAlignment.MiddleLeft;
            saveListButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveListButton.UseVisualStyleBackColor = false;
            // 
            // clearListButton
            // 
            clearListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            clearListButton.BackColor = Color.ForestGreen;
            clearListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearListButton.ForeColor = Color.White;
            clearListButton.Image = (Image)resources.GetObject("clearListButton.Image");
            clearListButton.ImageAlign = ContentAlignment.MiddleLeft;
            clearListButton.Location = new Point(752, 219);
            clearListButton.Name = "clearListButton";
            clearListButton.Padding = new Padding(4, 0, 0, 0);
            clearListButton.Size = new Size(180, 40);
            clearListButton.TabIndex = 7;
            clearListButton.Text = "Clear List";
            clearListButton.TextAlign = ContentAlignment.MiddleLeft;
            clearListButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            clearListButton.UseVisualStyleBackColor = false;
            clearListButton.Click += ClearListButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            addItemButton.BackColor = Color.Indigo;
            addItemButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemButton.ForeColor = Color.White;
            addItemButton.Image = (Image)resources.GetObject("addItemButton.Image");
            addItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            addItemButton.Location = new Point(562, 52);
            addItemButton.Name = "addItemButton";
            addItemButton.Padding = new Padding(4, 0, 0, 0);
            addItemButton.Size = new Size(180, 40);
            addItemButton.TabIndex = 8;
            addItemButton.Text = "Add Item";
            addItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += AddItemButton_Click;
            // 
            // removeItemButton
            // 
            removeItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            removeItemButton.BackColor = Color.Indigo;
            removeItemButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            removeItemButton.ForeColor = Color.White;
            removeItemButton.Image = (Image)resources.GetObject("removeItemButton.Image");
            removeItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            removeItemButton.Location = new Point(562, 107);
            removeItemButton.Name = "removeItemButton";
            removeItemButton.Padding = new Padding(4, 0, 0, 0);
            removeItemButton.Size = new Size(180, 40);
            removeItemButton.TabIndex = 9;
            removeItemButton.Text = "Remove Item";
            removeItemButton.TextAlign = ContentAlignment.MiddleLeft;
            removeItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            removeItemButton.UseVisualStyleBackColor = false;
            removeItemButton.Click += DeleteItemButton_Click;
            // 
            // euroSignLabel
            // 
            euroSignLabel.AutoSize = true;
            euroSignLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            euroSignLabel.Location = new Point(305, 569);
            euroSignLabel.Name = "euroSignLabel";
            euroSignLabel.Size = new Size(25, 30);
            euroSignLabel.TabIndex = 10;
            euroSignLabel.Text = "€";
            // 
            // sortingDropdown
            // 
            sortingDropdown.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortingDropdown.FormattingEnabled = true;
            sortingDropdown.Items.AddRange(new object[] { "A -> Z", "Z -> A", "0 -> 100", "100 -> 0" });
            sortingDropdown.Location = new Point(365, 10);
            sortingDropdown.Name = "sortingDropdown";
            sortingDropdown.Size = new Size(182, 33);
            sortingDropdown.TabIndex = 11;
            sortingDropdown.SelectedIndexChanged += SortingDropdown_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 640);
            Controls.Add(sortingDropdown);
            Controls.Add(euroSignLabel);
            Controls.Add(removeItemButton);
            Controls.Add(addItemButton);
            Controls.Add(clearListButton);
            Controls.Add(saveListButton);
            Controls.Add(newListButton);
            Controls.Add(selectListButton);
            Controls.Add(priceTotalBox);
            Controls.Add(totalLabel);
            Controls.Add(mainNameLabel);
            Controls.Add(shoppingListItemsView);
            Name = "MainForm";
            Text = "My Shopping List";
            Activated += MainForm_Activated;
            Load += MainFormLoad;
            ((System.ComponentModel.ISupportInitialize)shoppingListItemsView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView shoppingListItemsView;
        private Label mainNameLabel;
        private Label totalLabel;
        private TextBox priceTotalBox;
        private Button selectListButton;
        private Button newListButton;
        private Button saveListButton;
        private Button clearListButton;
        private Button addItemButton;
        private Button removeItemButton;
        private Label euroSignLabel;
        private ComboBox sortingDropdown;
    }
}
