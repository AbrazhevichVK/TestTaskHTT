namespace TestTaskHTTView
{
    partial class AddProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productFactoryTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.categoryIdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter product name:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(12, 36);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(176, 23);
            this.productNameTextBox.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 229);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(113, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 15);
            this.labelResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Factory name:";
            // 
            // productFactoryTextBox
            // 
            this.productFactoryTextBox.Location = new System.Drawing.Point(12, 99);
            this.productFactoryTextBox.Name = "productFactoryTextBox";
            this.productFactoryTextBox.Size = new System.Drawing.Size(176, 23);
            this.productFactoryTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter category id:";
            // 
            // categoryIdTextBox
            // 
            this.categoryIdTextBox.Location = new System.Drawing.Point(12, 165);
            this.categoryIdTextBox.Name = "categoryIdTextBox";
            this.categoryIdTextBox.Size = new System.Drawing.Size(176, 23);
            this.categoryIdTextBox.TabIndex = 7;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 296);
            this.Controls.Add(this.categoryIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productFactoryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddProductForm";
            this.ShowIcon = false;
            this.Text = "Creating a new product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productFactoryTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox categoryIdTextBox;
    }
}