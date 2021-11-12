using EbayApp.Controllers;
using EbayApp.Models;
using EbayApp.Views.Prompts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EbayApp.Views
{
    public partial class ProdsView : UserControl
    {
        Product Prod = new Product();
        List<Product> Products = new List<Product>();
        public ProdsView()
        {
            InitializeComponent();
            LoadProds();
            LoadCats();
        }
        void LoadProds()
        {
            
            Products = Prod.IncludeCats();
            LoadDGV(Products);
        }
        void LoadDGV(List<Product> prods)
        {
            dgv_prods.DataSource = null;
            dgv_prods.DataSource = prods;
        }
        void LoadCats()
        {
            var cat = new Category();
            cb_cats.DataSource = cat.GetAll();
            cb_cats.DisplayMember = "Name";
            cb_cats.ValueMember  = "CategoryId";
        }
        private void btn_add_category_Click(object sender, EventArgs e)
        {
            var addcat = new AddCategory();
            addcat.ShowDialog();
            // actualizar
            LoadCats();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var prod = new Product() 
            {
                Name = txt_prod_name.Text.Trim(),
                CategoryFk = cb_cats.SelectedValue.GetHashCode(),
                Price = n_price.Value
            };
            prod.Save(prod);
            LoadProds();
        }
    }
}
