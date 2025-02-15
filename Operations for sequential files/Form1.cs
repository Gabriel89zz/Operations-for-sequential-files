namespace Operations_for_sequential_files
{
    public partial class Form1 : Form
    {
        private string salesFile = "sales.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegisterSale_Click(object sender, EventArgs e)
        {
            try
            {
                string product = txtProduct.Text.Trim();
                int quantity = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);

                if (string.IsNullOrEmpty(product) || quantity <= 0 || price <= 0)
                {
                    MessageBox.Show("Please enter valid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal total = quantity * price;
                string saleLine = $"{product},{quantity},{price},{total}";

                using (StreamWriter writer = new StreamWriter(salesFile, true))
                {
                    writer.WriteLine(saleLine);
                }

                ClearFields();
                MessageBox.Show("Sale registered successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadSales_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the RichTextBox before loading sales
                rtbSales.Clear();

                // Check if the file exists
                if (!File.Exists(salesFile))
                {
                    MessageBox.Show("No sales recorded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Read all lines from the file
                using (StreamReader reader = new StreamReader(salesFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split the line into its components
                        string[] data = line.Split(',');

                        string product = data[0];
                        int quantity = int.Parse(data[1]);
                        decimal price = decimal.Parse(data[2]);
                        decimal total = decimal.Parse(data[3]);

                        // Display the information in the RichTextBox
                        rtbSales.AppendText($"Product: {product}, Quantity: {quantity}, Price: {price:C}, Total: {total:C}\n");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                string productToDelete = txtProduct.Text.Trim();

                if (string.IsNullOrEmpty(productToDelete))
                {
                    MessageBox.Show("Please enter the product name to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var lines = File.ReadAllLines(salesFile).ToList();
                var updatedLines = lines.Where(line => !line.StartsWith(productToDelete)).ToList();

                File.WriteAllLines(salesFile, updatedLines);

                MessageBox.Show("Sale deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtProduct.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();
        }

        private void btnSearchSale_Click(object sender, EventArgs e)
        {
            try
            {
                string productToSearch = txtProduct.Text.Trim();

                if (string.IsNullOrEmpty(productToSearch))
                {
                    MessageBox.Show("Please enter the product name to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                rtbSales.Clear();

                var lines = File.ReadAllLines(salesFile);
                bool found = false;

                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data[0].Equals(productToSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        rtbSales.AppendText($"Product: {data[0]}, Quantity: {data[1]}, Price: {data[2]}$, Total: {data[3]}$\n");
                        found = true;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
