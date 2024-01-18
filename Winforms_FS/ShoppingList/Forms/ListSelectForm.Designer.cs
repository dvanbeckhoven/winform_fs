namespace ShoppingListApp.Forms
{
    partial class ListSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSelectForm));
            selectListLabel = new Label();
            listListBox = new ListBox();
            listSelectButton = new Button();
            SuspendLayout();
            // 
            // selectListLabel
            // 
            selectListLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            selectListLabel.AutoSize = true;
            selectListLabel.Cursor = Cursors.No;
            selectListLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectListLabel.ForeColor = Color.Indigo;
            selectListLabel.Location = new Point(12, 5);
            selectListLabel.Name = "selectListLabel";
            selectListLabel.Size = new Size(107, 30);
            selectListLabel.TabIndex = 5;
            selectListLabel.Text = "Select List";
            // 
            // listListBox
            // 
            listListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listListBox.FormattingEnabled = true;
            listListBox.ItemHeight = 21;
            listListBox.Location = new Point(12, 48);
            listListBox.Name = "listListBox";
            listListBox.Size = new Size(425, 319);
            listListBox.TabIndex = 4;
            // 
            // listSelectButton
            // 
            listSelectButton.BackColor = Color.ForestGreen;
            listSelectButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listSelectButton.ForeColor = Color.White;
            listSelectButton.Image = (Image)resources.GetObject("listSelectButton.Image");
            listSelectButton.ImageAlign = ContentAlignment.MiddleLeft;
            listSelectButton.Location = new Point(12, 382);
            listSelectButton.Name = "listSelectButton";
            listSelectButton.Padding = new Padding(4, 0, 0, 0);
            listSelectButton.Size = new Size(150, 40);
            listSelectButton.TabIndex = 20;
            listSelectButton.Text = "Open List";
            listSelectButton.TextAlign = ContentAlignment.MiddleLeft;
            listSelectButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            listSelectButton.UseVisualStyleBackColor = false;
            listSelectButton.Click += OpenListButton_Click;
            // 
            // ListSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(461, 445);
            Controls.Add(listSelectButton);
            Controls.Add(selectListLabel);
            Controls.Add(listListBox);
            Name = "ListSelectForm";
            Text = "Select List to Open";
            Load += ListSelectForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        
        private Label selectListLabel;
        private ListBox listListBox;
        private Button listSelectButton;
    }
}