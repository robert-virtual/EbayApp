using EbayApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EbayApp.Views.Prompts
{
    public partial class AddCategory : Form
    {

        public AddCategory()
        {
            InitializeComponent();
            LoadCats();
        }
        void LoadCats()
        {
            Category cat = new Category();
            dgv_cats.DataSource = null;
            dgv_cats.DataSource = cat.GetAll();
        }
        private void btn_save_cat_Click(object sender, EventArgs e)
        {
            Category cat = new Category() 
            {
                Name = txt_new_category.Text.Trim()
            };
            cat.Save(cat);
            LoadCats();
        }
    }
}
