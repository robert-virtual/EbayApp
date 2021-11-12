
namespace EbayApp.Views.Prompts
{
    partial class AddCategory
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
            this.dgv_cats = new System.Windows.Forms.DataGridView();
            this.txt_new_category = new System.Windows.Forms.TextBox();
            this.btn_save_cat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cats
            // 
            this.dgv_cats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cats.Location = new System.Drawing.Point(22, 33);
            this.dgv_cats.Name = "dgv_cats";
            this.dgv_cats.RowHeadersWidth = 51;
            this.dgv_cats.RowTemplate.Height = 29;
            this.dgv_cats.Size = new System.Drawing.Size(660, 431);
            this.dgv_cats.TabIndex = 0;
            // 
            // txt_new_category
            // 
            this.txt_new_category.Location = new System.Drawing.Point(741, 64);
            this.txt_new_category.Name = "txt_new_category";
            this.txt_new_category.PlaceholderText = "Category Name";
            this.txt_new_category.Size = new System.Drawing.Size(208, 27);
            this.txt_new_category.TabIndex = 1;
            // 
            // btn_save_cat
            // 
            this.btn_save_cat.Location = new System.Drawing.Point(854, 98);
            this.btn_save_cat.Name = "btn_save_cat";
            this.btn_save_cat.Size = new System.Drawing.Size(94, 29);
            this.btn_save_cat.TabIndex = 2;
            this.btn_save_cat.Text = "Save";
            this.btn_save_cat.UseVisualStyleBackColor = true;
            this.btn_save_cat.Click += new System.EventHandler(this.btn_save_cat_Click);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 504);
            this.Controls.Add(this.btn_save_cat);
            this.Controls.Add(this.txt_new_category);
            this.Controls.Add(this.dgv_cats);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cats;
        private System.Windows.Forms.TextBox txt_new_category;
        private System.Windows.Forms.Button btn_save_cat;
    }
}