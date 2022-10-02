namespace TestTaskHTT
{
    partial class CatalogForm
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
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(13, 46);
            this.dataGridViewCatalog.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCatalog.MultiSelect = false;
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowHeadersWidth = 51;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(873, 338);
            this.dataGridViewCatalog.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Catalog";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(716, 8);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(170, 27);
            this.buttonRefresh.TabIndex = 8;
            this.buttonRefresh.Text = "Refresh catalog";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // CatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 397);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCatalog);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CatalogForm";
            this.ShowIcon = false;
            this.Text = "Catalog - Sections";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
    }
}