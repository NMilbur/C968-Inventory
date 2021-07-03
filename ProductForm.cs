using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NMilburn_InventoryApp
{
    public partial class ProductForm : Form
    {
        private BindingList<Part> productParts = new BindingList<Part>();

        //Part DataGridView Binding
        public static BindingSource allPartsBindingSource = new BindingSource();
        public static BindingList<Part> allPartsBindingList = new BindingList<Part>(Inventory.AllParts);

        //Product DataGridView Binding
        public static BindingSource productPartsBindingSource = new BindingSource();
        //public static BindingList<Product> productsBindingList = new BindingList<Product>(Inventory.Products);

        public ProductForm()
        {
            InitializeComponent();
            productFormLabel.Text = "Add Product";
        }

        public ProductForm(Product product)
        {
            InitializeComponent();
            productFormLabel.Text = "Modify Product";
            loadProductForm(product);
        }

        public void loadProductForm(Product product)
        {
            productIDInput.Text = product.ProductID.ToString();
            productNameInput.Text = product.Name;
            productInventoryInput.Text = product.InStock.ToString();
            productPriceInput.Text = product.Price.ToString();
            maxInput.Text = product.Max.ToString();
            minInput.Text = product.Min.ToString();
            
            for (int i = 0; i < product.AssociatedParts.Count; i++)
            {
                productParts.Add(product.AssociatedParts[i]);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

            // Part DataGridView
            allPartsBindingSource.DataSource = allPartsBindingList;
            allPartsDataView.DataSource = allPartsBindingSource;

            allPartsDataView.Columns["PartID"].HeaderText = "Part ID";
            allPartsDataView.Columns["InStock"].HeaderText = "Inventory";
            
            
            // Product Parts DataGridView
            
            productPartsBindingSource.DataSource = productParts;
            productPartsDataView.DataSource = productPartsBindingSource;

            productPartsDataView.Columns["PartID"].HeaderText = "Part ID";
            productPartsDataView.Columns["InStock"].HeaderText = "Inventory";
          
        }

        private void addBtn_Click(object sender, EventArgs e) {
            try
            {
                DataGridViewRow selectedRow = allPartsDataView.SelectedRows[0];
                Part selectedPart = Inventory.lookupPart(Convert.ToInt32(selectedRow.Cells["PartID"].Value));

                productParts.Add(selectedPart);
                productPartsBindingSource.ResetBindings(false);
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


        private void deleteBtn_Click(object sender, EventArgs e) {
            try
            {
                var confirmation = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Deletion", MessageBoxButtons.YesNo);

                bool deleteConfirmed = (confirmation == DialogResult.Yes);

                if (deleteConfirmed)
                {
                    DataGridViewRow selectedRow = productPartsDataView.SelectedRows[0];
                    Part selectedPart = Inventory.lookupPart(Convert.ToInt32(selectedRow.Cells["PartID"].Value));

                    productParts.Remove(selectedPart);
                    productPartsBindingSource.ResetBindings(false);
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

        private void saveBtn_Click(object sender, EventArgs e) {
            bool allowSubmit = true;
            int testInt;
            decimal testDec;

            if (!int.TryParse(productInventoryInput.Text, out testInt) ||
                !decimal.TryParse(productPriceInput.Text, out testDec) ||
                !int.TryParse(maxInput.Text, out testInt) ||
                !int.TryParse(minInput.Text, out testInt)) {
                MessageBox.Show("Invalid input, check error next to fields if applicable");
                allowSubmit = false;
            }

            else if (Convert.ToInt32(maxInput.Text) < Convert.ToInt32(minInput.Text)) {
                MessageBox.Show("Max field should be more than the Min field");
                allowSubmit = false;
            }

            else if (Convert.ToInt32(productInventoryInput.Text) < Convert.ToInt32(minInput.Text) ||
                Convert.ToInt32(productInventoryInput.Text) > Convert.ToInt32(maxInput.Text)) {
                MessageBox.Show("Inventory Field must be between the values in the Min and Max fields.");
                allowSubmit = false;
            }

            if (allowSubmit)
            {
                if (String.IsNullOrWhiteSpace(productIDInput.Text))
                {
                    Inventory.ProductIncrement += 1;

                    Product product = new Product(
                        Inventory.ProductIncrement,
                        productNameInput.Text,
                        Convert.ToDecimal(productPriceInput.Text),
                        Convert.ToInt32(productInventoryInput.Text),
                        Convert.ToInt32(maxInput.Text),
                        Convert.ToInt32(minInput.Text)
                    );

                    Inventory.addProduct(product);

                    for (int i = 0; i < productParts.Count; i++)
                    {
                         product.addAssociatedPart(productParts[i]);
                    }
                }
                else {
                    Product product = new Product(
                        productNameInput.Text,
                        Convert.ToDecimal(productPriceInput.Text),
                        Convert.ToInt32(productInventoryInput.Text),
                        Convert.ToInt32(maxInput.Text),
                        Convert.ToInt32(minInput.Text)
                    );

                    Inventory.updateProduct(Convert.ToInt32(productIDInput.Text), product);
                    Product existingProduct = Inventory.lookupProduct(Convert.ToInt32(productIDInput.Text));

                    for (int i = 0; i < existingProduct.AssociatedParts.Count; i++)
                    {
                        if (!productParts.Contains(existingProduct.AssociatedParts[i]))
                        {
                            existingProduct.removeAssociatedPart(existingProduct.AssociatedParts[i].PartID);
                        }
                    }

                    for (int i = 0; i < productParts.Count; i++) {
                        if (!existingProduct.AssociatedParts.Contains(productParts[i])) {
                            existingProduct.addAssociatedPart(productParts[i]);
                        }
                    }
                }

                allPartsDataView.DataSource = null;
                productPartsDataView.DataSource = null;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            allPartsDataView.DataSource = null;
            productPartsDataView.DataSource = null;
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e) {
            allPartsDataView.ClearSelection();
            //partsDataGridView.DefaultCellStyle.SelectionBackColor = Color.Yellow;

            if (searchInput.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(searchInput.Text.ToUpper()))
                    {
                        allPartsDataView.Rows[i].Selected = true;
                    }
                    else
                    {
                        allPartsDataView.Rows[i].Selected = false;
                    }
                }
            }
        }

        private void productInventoryInput_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            try
            {
                int x = Int32.Parse(productInventoryInput.Text);
                errorProvider1.SetError(productInventoryInput, "");

            }
            catch (Exception ex) {
                errorProvider1.SetError(productInventoryInput, "Not an integer");
            }
        }

        private void productPriceInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                decimal x = Decimal.Parse(productPriceInput.Text);
                errorProvider1.SetError(productPriceInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(productPriceInput, "Not a decimal");
            }
        }

        private void maxInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(maxInput.Text);
                errorProvider1.SetError(maxInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(maxInput, "Not an integer");
            }
        }

        private void minInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                int x = Int32.Parse(minInput.Text);
                errorProvider1.SetError(minInput, "");

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(minInput, "Not an integer");
            }
        }
    }
}
