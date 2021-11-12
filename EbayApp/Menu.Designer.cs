
namespace EbayApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_prods = new System.Windows.Forms.Button();
            this.btn_sells = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.btn_prods);
            this.panel_menu.Controls.Add(this.btn_sells);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 689);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(56, 195);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(94, 29);
            this.btn_prods.TabIndex = 0;
            this.btn_prods.Text = "Products";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // btn_sells
            // 
            this.btn_sells.Location = new System.Drawing.Point(56, 124);
            this.btn_sells.Name = "btn_sells";
            this.btn_sells.Size = new System.Drawing.Size(94, 29);
            this.btn_sells.TabIndex = 0;
            this.btn_sells.Text = "Sells";
            this.btn_sells.UseVisualStyleBackColor = true;
            this.btn_sells.Click += new System.EventHandler(this.btn_sells_Click);
            // 
            // main_panel
            // 
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(250, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(1010, 689);
            this.main_panel.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 689);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panel_menu);
            this.Name = "Menu";
            this.Text = "Form1";
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button btn_prods;
        private System.Windows.Forms.Button btn_sells;
        private System.Windows.Forms.Panel main_panel;
    }
}

