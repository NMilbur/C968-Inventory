using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMilburn_InventoryApp
{
    public partial class InventoryManagementMain : Form
    {
        //Part DataGridView Binding
        public static BindingSource partsBindingSource = new BindingSource();
        public static BindingList<Part> partsBindingList = new BindingList<Part>(Inventory.AllParts);

        //Product DataGridView Binding
        public static BindingSource productsBindingSource = new BindingSource();
        public static BindingList<Product> productsBindingList = new BindingList<Product>(Inventory.Products);

        
        public InventoryManagementMain()
        {
            InitializeComponent();
            Inventory.PartIncrement = 0;
            Inventory.ProductIncrement = 0;
        }

        private void InventoryManagementMain_Load(object sender, EventArgs e) {
            Inventory.addPart(new Inhouse(1, "Test 1", 3, 15, 5, 1, 1));
            Inventory.addPart(new Inhouse(2, "Test 2", 5, 15, 6, 1, 1));
            Inventory.addPart(new Inhouse(3, "Test 3", 7, 15, 9, 1, 1));


            // Part DataGridView
            partsBindingSource.DataSource = partsBindingList;
            partsDataGridView.DataSource = partsBindingSource;

            partsDataGridView.Columns["PartID"].HeaderText = "Part ID";
            partsDataGridView.Columns["InStock"].HeaderText = "Inventory";

            // Product DataGridView
            productsBindingSource.DataSource = productsBindingList;
            productDataGridView.DataSource = productsBindingSource;

            productDataGridView.Columns["ProductID"].HeaderText = "Product ID";
            productDataGridView.Columns["InStock"].HeaderText = "Inventory";

            //Debug.WriteLine(Inventory.AllParts.Count);
            //Debug.WriteLine("Here");
        }

        private void partAddBtn_Click(object sender, EventArgs e) {
            this.Hide();
            PartForm partForm = new PartForm();
            partForm.ShowDialog();
            this.Show();
            partsBindingSource.ResetBindings(false);
        }

        private void partModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
                Part selectedPart = Inventory.lookupPart(Convert.ToInt32(selectedRow.Cells["PartID"].Value));

                PartForm editForm = new PartForm(selectedPart);
                editForm.ShowDialog();
                this.Show();
                partsBindingSource.ResetBindings(false);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No valid row was selected");
                return;
            }
            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("No row was selected");
                return;
            }
        }

        private void partDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var confirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Deletion", MessageBoxButtons.YesNo);

                bool deleteConfirmed = (confirmation == DialogResult.Yes);

                if (deleteConfirmed)
                {
                    DataGridViewRow selectedRow = partsDataGridView.SelectedRows[0];
                    Part selectedPart = Inventory.lookupPart(Convert.ToInt32(selectedRow.Cells["PartID"].Value));
                    Inventory.deletePart(selectedPart.PartID);
                    partsBindingSource.ResetBindings(false);
                }
            
            } catch(NullReferenceException)
            {
                MessageBox.Show("No valid row was selected");
            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("No row was selected");
            }
            
        }

        private void productAddBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            this.Show();
            productsBindingSource.ResetBindings(false);
        }

        private void productModifyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = productDataGridView.SelectedRows[0];
                Product selectedProduct = Inventory.lookupProduct(Convert.ToInt32(selectedRow.Cells["ProductID"].Value));

                ProductForm editForm = new ProductForm(selectedProduct);
                editForm.ShowDialog();
                this.Show();
                productsBindingSource.ResetBindings(false);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No valid row was selected");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No row was selected");
                return;
            }
        }

        private void productDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = productDataGridView.SelectedRows[0];
                Product selectedProduct = Inventory.lookupProduct(Convert.ToInt32(selectedRow.Cells["ProductID"].Value));

                bool allowDelete = true;

                if (selectedProduct.AssociatedParts.Count > 0) {
                    MessageBox.Show("This product has parts associated with it and cannot be deleted.");
                    allowDelete = false;
                }

                if (allowDelete)
                {
                    var confirmation = MessageBox.Show("Are you sure you want to delete this product?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo);

                    bool deleteConfirmed = (confirmation == DialogResult.Yes);

                    if (deleteConfirmed)
                    {

                        Inventory.removeProduct(selectedProduct.ProductID);
                        productsBindingSource.ResetBindings(false);
                    }
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No valid row was selected");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No row was selected");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void partSearchBtn_Click(object sender, EventArgs e) {
            partsDataGridView.ClearSelection();
            //partsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            if (partSearchInput.Text != "") {
                for (int i = 0; i < Inventory.AllParts.Count; i++) {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(partSearchInput.Text.ToUpper())) {
                        partsDataGridView.Rows[i].Selected = true;
                    } else
                    {
                        partsDataGridView.Rows[i].Selected = false;
                    }
                }
            }
        }

        private void productSearchBtn_Click(object sender, EventArgs e)
        {
            productDataGridView.ClearSelection();
            //partsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            if (productSearchInput.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(productSearchInput.Text.ToUpper()))
                    {
                        productDataGridView.Rows[i].Selected = true;
                    }
                    else
                    {
                        productDataGridView.Rows[i].Selected = false;
                    }
                }
            }
        }
    }
}
