namespace ShoppingList
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
            Items = new DataGridView();
            MainNameLabel = new Label();
            TotalLabel = new Label();
            PriceTotalBox = new TextBox();
            SelectListButton = new Button();
            NewListButton = new Button();
            SaveListButton = new Button();
            ClearListButton = new Button();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Items).BeginInit();
            SuspendLayout();
            // 
            // Items
            // 
            Items.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Items.BackgroundColor = SystemColors.Window;
            Items.BorderStyle = BorderStyle.Fixed3D;
            Items.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Items.Location = new Point(12, 52);
            Items.Name = "Items";
            Items.Size = new Size(535, 499);
            Items.TabIndex = 0;
            // 
            // MainNameLabel
            // 
            MainNameLabel.AutoSize = true;
            MainNameLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MainNameLabel.ForeColor = Color.Indigo;
            MainNameLabel.Location = new Point(12, 9);
            MainNameLabel.Name = "MainNameLabel";
            MainNameLabel.Size = new Size(144, 30);
            MainNameLabel.TabIndex = 1;
            MainNameLabel.Text = "Shopping list";
            MainNameLabel.Click += label1_Click;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalLabel.ForeColor = Color.Indigo;
            TotalLabel.Location = new Point(12, 566);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(113, 30);
            TotalLabel.TabIndex = 2;
            TotalLabel.Text = "Total price";
            // 
            // PriceTotalBox
            // 
            PriceTotalBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriceTotalBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceTotalBox.Location = new Point(336, 566);
            PriceTotalBox.Name = "PriceTotalBox";
            PriceTotalBox.ReadOnly = true;
            PriceTotalBox.Size = new Size(211, 35);
            PriceTotalBox.TabIndex = 3;
            PriceTotalBox.TextAlign = HorizontalAlignment.Right;
            // 
            // SelectListButton
            // 
            SelectListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SelectListButton.BackColor = Color.ForestGreen;
            SelectListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectListButton.ForeColor = Color.White;
            SelectListButton.Location = new Point(752, 52);
            SelectListButton.Name = "SelectListButton";
            SelectListButton.Size = new Size(150, 40);
            SelectListButton.TabIndex = 4;
            SelectListButton.Text = "Select List";
            SelectListButton.UseVisualStyleBackColor = false;
            // 
            // NewListButton
            // 
            NewListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NewListButton.BackColor = Color.ForestGreen;
            NewListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewListButton.ForeColor = Color.White;
            NewListButton.Location = new Point(752, 107);
            NewListButton.Name = "NewListButton";
            NewListButton.Size = new Size(150, 40);
            NewListButton.TabIndex = 5;
            NewListButton.Text = "New List";
            NewListButton.UseVisualStyleBackColor = false;
            // 
            // SaveListButton
            // 
            SaveListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SaveListButton.BackColor = Color.ForestGreen;
            SaveListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveListButton.ForeColor = Color.White;
            SaveListButton.Location = new Point(752, 162);
            SaveListButton.Name = "SaveListButton";
            SaveListButton.Size = new Size(150, 40);
            SaveListButton.TabIndex = 6;
            SaveListButton.Text = "Save List";
            SaveListButton.UseVisualStyleBackColor = false;
            // 
            // ClearListButton
            // 
            ClearListButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ClearListButton.BackColor = Color.ForestGreen;
            ClearListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearListButton.ForeColor = Color.White;
            ClearListButton.Location = new Point(752, 219);
            ClearListButton.Name = "ClearListButton";
            ClearListButton.Size = new Size(150, 40);
            ClearListButton.TabIndex = 7;
            ClearListButton.Text = "Clear List";
            ClearListButton.UseVisualStyleBackColor = false;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.BackColor = Color.Indigo;
            AddItemButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddItemButton.ForeColor = Color.White;
            AddItemButton.Image = (Image)resources.GetObject("AddItemButton.Image");
            AddItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            AddItemButton.Location = new Point(562, 52);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Padding = new Padding(4, 0, 0, 0);
            AddItemButton.Size = new Size(180, 40);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add Item";
            AddItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddItemButton.UseVisualStyleBackColor = false;
            AddItemButton.Click += button1_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.BackColor = Color.Indigo;
            RemoveItemButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveItemButton.ForeColor = Color.White;
            RemoveItemButton.Image = (Image)resources.GetObject("RemoveItemButton.Image");
            RemoveItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            RemoveItemButton.Location = new Point(562, 107);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Padding = new Padding(4, 0, 0, 0);
            RemoveItemButton.Size = new Size(180, 40);
            RemoveItemButton.TabIndex = 9;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.TextAlign = ContentAlignment.MiddleLeft;
            RemoveItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RemoveItemButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 640);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(ClearListButton);
            Controls.Add(SaveListButton);
            Controls.Add(NewListButton);
            Controls.Add(SelectListButton);
            Controls.Add(PriceTotalBox);
            Controls.Add(TotalLabel);
            Controls.Add(MainNameLabel);
            Controls.Add(Items);
            Name = "MainForm";
            Text = "ShoppingList";
            Load += MainFormLoad;
            ((System.ComponentModel.ISupportInitialize)Items).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Items;
        private Label MainNameLabel;
        private Label TotalLabel;
        private TextBox PriceTotalBox;
        private Button SelectListButton;
        private Button NewListButton;
        private Button SaveListButton;
        private Button ClearListButton;
        private Button AddItemButton;
        private Button RemoveItemButton;
    }
}
