namespace ShoppingList.Forms
{
    partial class ItemAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemAddForm));
            itemHeaderLabel = new Label();
            itemNameValue = new TextBox();
            itemNameLabel = new Label();
            itemDescriptionLabel = new Label();
            itemDescriptionValue = new TextBox();
            itemPriceLabel = new Label();
            itemPriceValue = new TextBox();
            itemQtyLabel = new Label();
            saveItemButton = new Button();
            itemQtyValue = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)itemQtyValue).BeginInit();
            SuspendLayout();
            // 
            // itemHeaderLabel
            // 
            itemHeaderLabel.AutoSize = true;
            itemHeaderLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemHeaderLabel.ForeColor = Color.Indigo;
            itemHeaderLabel.Location = new Point(14, 16);
            itemHeaderLabel.Name = "itemHeaderLabel";
            itemHeaderLabel.Size = new Size(111, 30);
            itemHeaderLabel.TabIndex = 0;
            itemHeaderLabel.Text = "Add items";
            // 
            // itemNameValue
            // 
            itemNameValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameValue.Location = new Point(159, 66);
            itemNameValue.Name = "itemNameValue";
            itemNameValue.Size = new Size(250, 35);
            itemNameValue.TabIndex = 1;
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemNameLabel.ForeColor = Color.ForestGreen;
            itemNameLabel.Location = new Point(14, 66);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(70, 30);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Name";
            // 
            // itemDescriptionLabel
            // 
            itemDescriptionLabel.AutoSize = true;
            itemDescriptionLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDescriptionLabel.ForeColor = Color.ForestGreen;
            itemDescriptionLabel.Location = new Point(14, 116);
            itemDescriptionLabel.Name = "itemDescriptionLabel";
            itemDescriptionLabel.Size = new Size(122, 30);
            itemDescriptionLabel.TabIndex = 4;
            itemDescriptionLabel.Text = "Description";
            itemDescriptionLabel.UseWaitCursor = true;
            // 
            // itemDescriptionValue
            // 
            itemDescriptionValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDescriptionValue.Location = new Point(159, 116);
            itemDescriptionValue.Multiline = true;
            itemDescriptionValue.Name = "itemDescriptionValue";
            itemDescriptionValue.Size = new Size(609, 96);
            itemDescriptionValue.TabIndex = 3;
            // 
            // itemPriceLabel
            // 
            itemPriceLabel.AutoSize = true;
            itemPriceLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPriceLabel.ForeColor = Color.ForestGreen;
            itemPriceLabel.Location = new Point(14, 229);
            itemPriceLabel.Name = "itemPriceLabel";
            itemPriceLabel.Size = new Size(59, 30);
            itemPriceLabel.TabIndex = 6;
            itemPriceLabel.Text = "Price";
            // 
            // itemPriceValue
            // 
            itemPriceValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemPriceValue.Location = new Point(159, 229);
            itemPriceValue.Name = "itemPriceValue";
            itemPriceValue.PlaceholderText = "0.00";
            itemPriceValue.Size = new Size(149, 35);
            itemPriceValue.TabIndex = 5;
            itemPriceValue.TextAlign = HorizontalAlignment.Right;
            // 
            // itemQtyLabel
            // 
            itemQtyLabel.AutoSize = true;
            itemQtyLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemQtyLabel.ForeColor = Color.ForestGreen;
            itemQtyLabel.Location = new Point(14, 283);
            itemQtyLabel.Name = "itemQtyLabel";
            itemQtyLabel.Size = new Size(96, 30);
            itemQtyLabel.TabIndex = 8;
            itemQtyLabel.Text = "Quantity";
            // 
            // saveItemButton
            // 
            saveItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveItemButton.BackColor = Color.ForestGreen;
            saveItemButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveItemButton.ForeColor = Color.White;
            saveItemButton.Image = (Image)resources.GetObject("saveItemButton.Image");
            saveItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveItemButton.Location = new Point(158, 342);
            saveItemButton.Name = "saveItemButton";
            saveItemButton.Padding = new Padding(4, 0, 0, 0);
            saveItemButton.Size = new Size(150, 40);
            saveItemButton.TabIndex = 9;
            saveItemButton.Text = "Save Item";
            saveItemButton.TextAlign = ContentAlignment.MiddleLeft;
            saveItemButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveItemButton.UseVisualStyleBackColor = false;
            saveItemButton.Click += saveItemButton_Click;
            // 
            // itemQtyValue
            // 
            itemQtyValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemQtyValue.Location = new Point(159, 281);
            itemQtyValue.Name = "itemQtyValue";
            itemQtyValue.RightToLeft = RightToLeft.No;
            itemQtyValue.Size = new Size(149, 35);
            itemQtyValue.TabIndex = 10;
            itemQtyValue.TextAlign = HorizontalAlignment.Right;
            itemQtyValue.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(itemQtyValue);
            Controls.Add(saveItemButton);
            Controls.Add(itemQtyLabel);
            Controls.Add(itemPriceLabel);
            Controls.Add(itemPriceValue);
            Controls.Add(itemDescriptionLabel);
            Controls.Add(itemDescriptionValue);
            Controls.Add(itemNameLabel);
            Controls.Add(itemNameValue);
            Controls.Add(itemHeaderLabel);
            Name = "ItemForm";
            Text = "Manage Shopping List Items";            
            ((System.ComponentModel.ISupportInitialize)itemQtyValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemHeaderLabel;
        private TextBox itemNameValue;
        private Label itemNameLabel;
        private Label itemDescriptionLabel;
        private TextBox itemDescriptionValue;
        private Label itemPriceLabel;
        private TextBox itemPriceValue;
        private Label itemQtyLabel;
        private Button saveItemButton;
        private NumericUpDown itemQtyValue;
    }
}