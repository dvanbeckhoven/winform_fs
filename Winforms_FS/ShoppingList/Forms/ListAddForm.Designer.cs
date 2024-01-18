namespace ShoppingListApp.Forms
{
    partial class ListAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListAddForm));
            saveListButton = new Button();
            listNameLabel = new Label();
            listNameValue = new TextBox();
            listHeaderLabel = new Label();
            SuspendLayout();
            // 
            // saveListButton
            // 
            saveListButton.BackColor = Color.ForestGreen;
            saveListButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveListButton.ForeColor = Color.White;
            saveListButton.Image = (Image)resources.GetObject("saveListButton.Image");
            saveListButton.ImageAlign = ContentAlignment.MiddleLeft;
            saveListButton.Location = new Point(157, 117);
            saveListButton.Name = "saveListButton";
            saveListButton.Padding = new Padding(4, 0, 0, 0);
            saveListButton.Size = new Size(150, 40);
            saveListButton.TabIndex = 19;
            saveListButton.Text = "Save List";
            saveListButton.TextAlign = ContentAlignment.MiddleLeft;
            saveListButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            saveListButton.UseVisualStyleBackColor = false;
            saveListButton.Click += SaveListButton_Click;
            // 
            // listNameLabel
            // 
            listNameLabel.AutoSize = true;
            listNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listNameLabel.ForeColor = Color.ForestGreen;
            listNameLabel.Location = new Point(12, 59);
            listNameLabel.Name = "listNameLabel";
            listNameLabel.Size = new Size(70, 30);
            listNameLabel.TabIndex = 13;
            listNameLabel.Text = "Name";
            // 
            // listNameValue
            // 
            listNameValue.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listNameValue.Location = new Point(157, 59);
            listNameValue.Name = "listNameValue";
            listNameValue.Size = new Size(250, 35);
            listNameValue.TabIndex = 12;
            // 
            // listHeaderLabel
            // 
            listHeaderLabel.AutoSize = true;
            listHeaderLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listHeaderLabel.ForeColor = Color.Indigo;
            listHeaderLabel.Location = new Point(12, 9);
            listHeaderLabel.Name = "listHeaderLabel";
            listHeaderLabel.Size = new Size(131, 30);
            listHeaderLabel.TabIndex = 11;
            listHeaderLabel.Text = "Add new list";
            // 
            // ListAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 194);
            Controls.Add(saveListButton);
            Controls.Add(listNameLabel);
            Controls.Add(listNameValue);
            Controls.Add(listHeaderLabel);
            Name = "ListAddForm";
            Text = "Add New List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveListButton;
        private Label listNameLabel;
        private TextBox listNameValue;
        private Label listHeaderLabel;
    }
}