
namespace EbayApp.Views
{
    partial class ProdsView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_category = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.n_price = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_cats = new System.Windows.Forms.ComboBox();
            this.txt_prod_name = new System.Windows.Forms.TextBox();
            this.dgv_prods = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_category
            // 
            this.btn_add_category.Location = new System.Drawing.Point(1030, 275);
            this.btn_add_category.Name = "btn_add_category";
            this.btn_add_category.Size = new System.Drawing.Size(140, 29);
            this.btn_add_category.TabIndex = 12;
            this.btn_add_category.Text = "Add Category";
            this.btn_add_category.UseVisualStyleBackColor = true;
            this.btn_add_category.Click += new System.EventHandler(this.btn_add_category_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(1030, 414);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(140, 29);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // n_price
            // 
            this.n_price.Location = new System.Drawing.Point(979, 353);
            this.n_price.Name = "n_price";
            this.n_price.Size = new System.Drawing.Size(191, 27);
            this.n_price.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // cb_cats
            // 
            this.cb_cats.FormattingEnabled = true;
            this.cb_cats.Location = new System.Drawing.Point(979, 241);
            this.cb_cats.Name = "cb_cats";
            this.cb_cats.Size = new System.Drawing.Size(191, 28);
            this.cb_cats.TabIndex = 8;
            // 
            // txt_prod_name
            // 
            this.txt_prod_name.Location = new System.Drawing.Point(979, 186);
            this.txt_prod_name.Name = "txt_prod_name";
            this.txt_prod_name.PlaceholderText = "Product Name";
            this.txt_prod_name.Size = new System.Drawing.Size(191, 27);
            this.txt_prod_name.TabIndex = 7;
            // 
            // dgv_prods
            // 
            this.dgv_prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prods.Location = new System.Drawing.Point(59, 186);
            this.dgv_prods.Name = "dgv_prods";
            this.dgv_prods.RowHeadersWidth = 51;
            this.dgv_prods.RowTemplate.Height = 29;
            this.dgv_prods.Size = new System.Drawing.Size(830, 390);
            this.dgv_prods.TabIndex = 6;
            // 
            // ProdsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_add_category);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.n_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_cats);
            this.Controls.Add(this.txt_prod_name);
            this.Controls.Add(this.dgv_prods);
            this.Name = "ProdsView";
            this.Size = new System.Drawing.Size(1228, 763);
            ((System.ComponentModel.ISupportInitialize)(this.n_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_category;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NumericUpDown n_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_cats;
        private System.Windows.Forms.TextBox txt_prod_name;
        private System.Windows.Forms.DataGridView dgv_prods;
    }
}
