namespace WindowsFormsApp1.Views
{
    partial class FormProduct
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
            this.btn_getAllProducts = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_updateProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_getById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_getAllProducts
            // 
            this.btn_getAllProducts.Location = new System.Drawing.Point(12, 12);
            this.btn_getAllProducts.Name = "btn_getAllProducts";
            this.btn_getAllProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_getAllProducts.TabIndex = 0;
            this.btn_getAllProducts.Text = "button1";
            this.btn_getAllProducts.UseVisualStyleBackColor = true;
            this.btn_getAllProducts.Click += new System.EventHandler(this.btn_getAllProducts_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(336, 12);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(452, 23);
            this.btn_addProduct.TabIndex = 1;
            this.btn_addProduct.Text = "button2";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_updateProduct
            // 
            this.btn_updateProduct.Location = new System.Drawing.Point(174, 12);
            this.btn_updateProduct.Name = "btn_updateProduct";
            this.btn_updateProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_updateProduct.TabIndex = 1;
            this.btn_updateProduct.Text = "button2";
            this.btn_updateProduct.UseVisualStyleBackColor = true;
            this.btn_updateProduct.Click += new System.EventHandler(this.btn_updateProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(255, 12);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteProduct.TabIndex = 2;
            this.btn_deleteProduct.Text = "button4";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 397);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(470, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 397);
            this.textBox1.TabIndex = 4;
            // 
            // btn_getById
            // 
            this.btn_getById.Location = new System.Drawing.Point(93, 12);
            this.btn_getById.Name = "btn_getById";
            this.btn_getById.Size = new System.Drawing.Size(75, 23);
            this.btn_getById.TabIndex = 5;
            this.btn_getById.Text = "button4";
            this.btn_getById.UseVisualStyleBackColor = true;
            this.btn_getById.Click += new System.EventHandler(this.btn_getById_Click);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_getById);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_updateProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.btn_getAllProducts);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_getAllProducts;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_updateProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_getById;
    }
}