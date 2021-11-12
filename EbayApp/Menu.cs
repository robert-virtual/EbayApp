using EbayApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EbayApp
{
    public partial class Menu : Form
    {
        List<UserControl> pages = new List<UserControl>();
        public Menu()
        {
            InitializeComponent();
            var prodsView = new ProdsView();
            var sellsView = new SellsView();

            pages.Add(sellsView); // 0
            pages.Add(prodsView); // 1
            main_panel.Controls.Add(pages[1]);
        }

       

        private void btn_sells_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(pages[0]);
        }

        private void btn_prods_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();
            main_panel.Controls.Add(pages[1]);
        }
    }
}
