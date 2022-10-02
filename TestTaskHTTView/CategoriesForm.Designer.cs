namespace TestTaskHTT
{
    partial class CategoriesForm
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
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createCategoryTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Location = new System.Drawing.Point(13, 46);
            this.dataGridViewCategories.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCategories.MultiSelect = false;
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.RowHeadersWidth = 51;
            this.dataGridViewCategories.Size = new System.Drawing.Size(873, 338);
            this.dataGridViewCategories.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categories";
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCategory.Location = new System.Drawing.Point(605, 14);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(170, 27);
            this.buttonAddCategory.TabIndex = 7;
            this.buttonAddCategory.Text = "Add new category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter category name:";
            // 
            // createCategoryTextBox
            // 
            this.createCategoryTextBox.Location = new System.Drawing.Point(413, 17);
            this.createCategoryTextBox.Name = "createCategoryTextBox";
            this.createCategoryTextBox.Size = new System.Drawing.Size(176, 23);
            this.createCategoryTextBox.TabIndex = 9;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 397);
            this.Controls.Add(this.createCategoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCategories);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CategoriesForm";
            this.ShowIcon = false;
            this.Text = "Categories - Sections";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox createCategoryTextBox;
    }
}