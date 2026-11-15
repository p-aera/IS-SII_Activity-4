using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Activity3_DeDios
{
    public partial class Dashboard : Form
    {
        private int selectedProductId = 0;
        public Dashboard()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
            UpdateButton.Click += UpdateButton_Click;
            DeleteButton.Click += DeleteButton_Click;
            ClearButton.Click += ClearButton_Click;
            //Refbutton.Click += Refbutton_Click;

            categorydropdown.DropDownStyle = ComboBoxStyle.DropDownList;

            //searchbox.TextChanged += Searchbox_TextChanged;
            dgvproducts.CellClick += Dgvproducts_CellClick;

            LoadProducts();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                int total = 0;
                int inStock = 0;
                int lowStock = 0;
                int outOfStock = 0;

                using (OleDbConnection con = database.GetDbConnection())
                {
                    con.Open();
                    // Just grab the raw data, let C# do the math
                    string query = "SELECT Quantity, ReorderLevel FROM Products WHERE ProductName IS NOT NULL";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                total++;

                                // Safely get the numbers, defaulting to 0 if they are NULL in Access
                                int qty = reader["Quantity"] != DBNull.Value ? Convert.ToInt32(reader["Quantity"]) : 0;
                                int reorder = reader["ReorderLevel"] != DBNull.Value ? Convert.ToInt32(reader["ReorderLevel"]) : 0;

                                // Do the logic in C#
                                if (qty == 0)
                                {
                                    outOfStock++;
                                }
                                else if (qty <= reorder)
                                {
                                    lowStock++;
                                }
                                else
                                {
                                    inStock++;
                                }
                            }
                        }
                    }
                }

                // Update the UI
                totalproducts.Text = total.ToString();
                instock.Text = inStock.ToString();
                lowstock.Text = lowStock.ToString();
                outofstock.Text = outOfStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Statistic Error: " + ex.Message);
            }
        }

        private bool ValidateProduct()
        {
            if (string.IsNullOrWhiteSpace(productname.Text))
            {
                MessageBox.Show("Please enter a product name.");
                productname.Focus();
                return false;
            }
            if (categorydropdown.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                categorydropdown.Focus();
                return false;
            }
            decimal price;
            if (!decimal.TryParse(unitprice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                unitprice.Focus();
                return false;
            }
            int quantity;
            if (!int.TryParse(txtquantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                txtquantity.Focus();
                return false;
            }
            int reorderLevel;
            if (!int.TryParse(reorder.Text, out reorderLevel) || reorderLevel < 0)
            {
                MessageBox.Show("Please enter a valid reorder level.");
                reorder.Focus();
                return false;
            }
            return true;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                return;
            }

            try
            {
                using (OleDbConnection con = database.GetDbConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO Products (ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, CreatedAt) VALUES (?, ?, ?, ?, ?, ?, Now)";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = productname.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = categorydropdown.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarChar).Value = description.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(unitprice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtquantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(reorder.Text);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearField();
                LoadProducts();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding products: " + ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return; 
            }

            if (!ValidateProduct())
                return;

            try
            {
                using (OleDbConnection con = database.GetDbConnection())
                {
                    con.Open();
                    string query = @"UPDATE Products SET ProductName=?, Category=?, Description=?, UnitPrice=?, Quantity=?, ReorderLevel=? WHERE ProductID=?";
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = productname.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarChar).Value = categorydropdown.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarChar).Value = description.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(unitprice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtquantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(reorder.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearField();
                LoadProducts();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating product: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection con = database.GetDbConnection())
                    {
                        con.Open();
                        string query = @"DELETE FROM Products WHERE ProductID=?";
                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductId;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearField();
                    LoadProducts();
                    LoadDashboardStats();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }

        private void Dgvproducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvproducts.Rows[e.RowIndex];
                selectedProductId = Convert.ToInt32(row.Cells["ProductID"].Value);
                productname.Text = row.Cells["ProductName"].Value.ToString();
                categorydropdown.Text = row.Cells["Category"].Value.ToString();
                description.Text = row.Cells["Description"].Value.ToString();
                unitprice.Text = row.Cells["UnitPrice"].Value.ToString();
                txtquantity.Text = row.Cells["Quantity"].Value.ToString();
                reorder.Text = row.Cells["ReorderLevel"].Value.ToString();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            productname.Clear();
            categorydropdown.SelectedIndex = -1;
            description.Clear();
            unitprice.Clear();
            txtquantity.Clear();
            reorder.Clear();

            selectedProductId = 0;

            dgvproducts.ClearSelection();
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection con = database.GetDbConnection())
                {
                    con.Open();
                    string query = @"SELECT * FROM Products ORDER BY ProductID DESC";
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvproducts.DataSource = null;
                        dgvproducts.AutoGenerateColumns = true;
                        dgvproducts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load products: " + ex.Message);
            }
        }

        private void LogoutBut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Fill(this.imsdbDataSet1.Products);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}