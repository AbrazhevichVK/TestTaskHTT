namespace TestTaskHTT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelCatalog = new System.Windows.Forms.Label();
            this.labelSections = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.panelFormArea = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 38);
            this.panel2.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(375, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Main menu ";
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(98)))), ((int)(((byte)(172)))));
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.labelCategories);
            this.panelMenu.Controls.Add(this.labelProducts);
            this.panelMenu.Controls.Add(this.labelCatalog);
            this.panelMenu.Controls.Add(this.labelSections);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 38);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(272, 643);
            this.panelMenu.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(10, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.BackColor = System.Drawing.Color.Transparent;
            this.labelProducts.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProducts.ForeColor = System.Drawing.Color.White;
            this.labelProducts.Location = new System.Drawing.Point(70, 72);
            this.labelProducts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(74, 22);
            this.labelProducts.TabIndex = 6;
            this.labelProducts.Text = "Products";
            this.labelProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelProducts_MouseClick);
            this.labelProducts.MouseLeave += new System.EventHandler(this.labelProducts_MouseLeave);
            this.labelProducts.MouseHover += new System.EventHandler(this.labelProducts_MouseHover);
            // 
            // labelCatalog
            // 
            this.labelCatalog.AutoSize = true;
            this.labelCatalog.BackColor = System.Drawing.Color.Transparent;
            this.labelCatalog.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCatalog.ForeColor = System.Drawing.Color.White;
            this.labelCatalog.Location = new System.Drawing.Point(70, 43);
            this.labelCatalog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCatalog.Name = "labelCatalog";
            this.labelCatalog.Size = new System.Drawing.Size(66, 22);
            this.labelCatalog.TabIndex = 5;
            this.labelCatalog.Text = "Catalog";
            this.labelCatalog.Click += new System.EventHandler(this.labelCatalog_Click);
            this.labelCatalog.MouseLeave += new System.EventHandler(this.labelCatalog_MouseLeave);
            this.labelCatalog.MouseHover += new System.EventHandler(this.labelCatalog_MouseHover);
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.BackColor = System.Drawing.Color.Transparent;
            this.labelSections.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSections.ForeColor = System.Drawing.Color.White;
            this.labelSections.Location = new System.Drawing.Point(37, 7);
            this.labelSections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(87, 27);
            this.labelSections.TabIndex = 0;
            this.labelSections.Text = "Sections";
            // 
            // labelCategories
            // 
            this.labelCategories.AutoSize = true;
            this.labelCategories.BackColor = System.Drawing.Color.Transparent;
            this.labelCategories.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategories.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCategories.Location = new System.Drawing.Point(70, 101);
            this.labelCategories.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(88, 22);
            this.labelCategories.TabIndex = 7;
            this.labelCategories.Text = "Categories";
            this.labelCategories.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelCategories_MouseClick);
            this.labelCategories.MouseLeave += new System.EventHandler(this.labelCategories_MouseLeave);
            this.labelCategories.MouseHover += new System.EventHandler(this.labelCategories_MouseHover);
            // 
            // panelFormArea
            // 
            this.panelFormArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormArea.Location = new System.Drawing.Point(277, 43);
            this.panelFormArea.Name = "panelFormArea";
            this.panelFormArea.Size = new System.Drawing.Size(920, 632);
            this.panelFormArea.TabIndex = 4;
            // 
            // TestTaskHTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 681);
            this.Controls.Add(this.panelFormArea);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel2);
            this.Name = "TestTaskHTT";
            this.ShowIcon = false;
            this.Text = "TestTaskHTT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestTaskHTT_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelCatalog;
        private System.Windows.Forms.Label labelSections;
        private System.Windows.Forms.Panel panelFormArea;
    }
}

