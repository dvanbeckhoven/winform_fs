namespace ShoppingListApp.Forms
{
    partial class itemDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemDeleteForm));
            itemListBox = new ListBox();
            itemDeleteLabel = new Label();
            itemDeleteHintLabel = new Label();
            itemDeleteCloseButton = new Button();
            SuspendLayout();
            // 
            // itemListBox
            // 
            itemListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemListBox.FormattingEnabled = true;
            itemListBox.ItemHeight = 21;
            itemListBox.Location = new Point(14, 90);
            itemListBox.Name = "itemListBox";
            itemListBox.Size = new Size(425, 319);
            itemListBox.TabIndex = 0;
            itemListBox.Click += ItemListBox_Click;
            // 
            // itemDeleteLabel
            // 
            itemDeleteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemDeleteLabel.AutoSize = true;
            itemDeleteLabel.Cursor = Cursors.No;
            itemDeleteLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDeleteLabel.ForeColor = Color.Indigo;
            itemDeleteLabel.Location = new Point(14, 16);
            itemDeleteLabel.Name = "itemDeleteLabel";
            itemDeleteLabel.Size = new Size(139, 30);
            itemDeleteLabel.TabIndex = 1;
            itemDeleteLabel.Text = "Remove item";
            // 
            // itemDeleteHintLabel
            // 
            itemDeleteHintLabel.AutoSize = true;
            itemDeleteHintLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDeleteHintLabel.Location = new Point(14, 55);
            itemDeleteHintLabel.Name = "itemDeleteHintLabel";
            itemDeleteHintLabel.Size = new Size(175, 21);
            itemDeleteHintLabel.TabIndex = 2;
            itemDeleteHintLabel.Text = "Click on item to delete";
            // 
            // itemDeleteCloseButton
            // 
            itemDeleteCloseButton.BackColor = Color.ForestGreen;
            itemDeleteCloseButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemDeleteCloseButton.ForeColor = Color.White;
            itemDeleteCloseButton.Image = (Image)resources.GetObject("itemDeleteCloseButton.Image");
            itemDeleteCloseButton.Location = new Point(12, 421);
            itemDeleteCloseButton.Name = "itemDeleteCloseButton";
            itemDeleteCloseButton.Padding = new Padding(4, 0, 0, 0);
            itemDeleteCloseButton.Size = new Size(160, 47);
            itemDeleteCloseButton.TabIndex = 3;
            itemDeleteCloseButton.Text = "Close Form";
            itemDeleteCloseButton.TextAlign = ContentAlignment.MiddleLeft;
            itemDeleteCloseButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            itemDeleteCloseButton.UseVisualStyleBackColor = false;
            itemDeleteCloseButton.Click += ItemDeleteCloseButton_Click;
            // 
            // itemDeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 480);
            Controls.Add(itemDeleteCloseButton);
            Controls.Add(itemDeleteHintLabel);
            Controls.Add(itemDeleteLabel);
            Controls.Add(itemListBox);
            Name = "itemDeleteForm";
            Text = "Delete Item from List";
            Load += ItemDeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox itemListBox;
        private Label itemDeleteLabel;
        private Label itemDeleteHintLabel;
        private Button itemDeleteCloseButton;
    }
}