using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> jsonData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Invoice Maker";
        }

        private void button_addItem_Click(object sender, EventArgs e)
        {
            // Get values from input controls
            string item = textBox_Item.Text;
            int quantity = (int)numericUpDown_Qty.Value; // Cast to int
            decimal price = numericUpDown_Price.Value; // Cast to decimal
            decimal total = quantity * price;

            // Assuming you have a DataGridView named dataGridView1
            // Create a new row and populate it
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = item });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = quantity });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = price });
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = total });

            // Add the row to the DataGridView
            dataGridView1.Rows.Add(newRow);
            UpdatedTotal();
        }

        private void button_removeItem_Click(object sender, EventArgs e)
        {
            // Assuming your DataGridView is named dataGridView1
            if (dataGridView1.SelectedCells.Count > 0)
            {
                // Get the selected cell's row index
                int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                // Remove the entire row
                dataGridView1.Rows.RemoveAt(rowIndex);
            }
            else
            {
                // Inform the user that no cell is selected
                MessageBox.Show("Please select a cell in the row to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Preview_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_Client.Text) && !string.IsNullOrEmpty(textBox_Employee.Text))
            {
                string HTMLTemplated = Properties.Resources.Index;
                Bitmap Image = Properties.Resources.shop_Logo;
                string base64ImageRepresentation = string.Empty;
                // Convert the image to a byte array
                using (MemoryStream m = new MemoryStream())
                {
                    Image.Save(m, Image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 string
                    base64ImageRepresentation = Convert.ToBase64String(imageBytes);
                }
                HTMLTemplated = HTMLTemplated.Replace("@Client", textBox_Client.Text);
                HTMLTemplated = HTMLTemplated.Replace("@Employee", textBox_Employee.Text);
                HTMLTemplated = HTMLTemplated.Replace("@BASE64", base64ImageRepresentation);
                HTMLTemplated = HTMLTemplated.Replace("@Date", DateTime.Now.ToString("yyyy-MM-dd"));
                HTMLTemplated = HTMLTemplated.Replace("@Date", DateTime.Now.ToString("yyyy-MM-dd"));

                var (folio, invoice) = JsonReader($"Logs-{DateTime.Now.Year}.json");

                folio.ToString();
                invoice.ToString();

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    filas += "<tr>";
                    filas += "<td>" + row.Cells["Description_Grid"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Quantity_Grid"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["PricePerUnit_Grid"].Value.ToString() + "</td>";
                    filas += "<td>" + row.Cells["Total_Grid"].Value.ToString() + "</td>";
                    filas += "</tr>";
                    total += decimal.Parse(row.Cells["Total_Grid"].Value.ToString());
                }
                HTMLTemplated = HTMLTemplated.Replace("@Filas", filas);
                HTMLTemplated = HTMLTemplated.Replace("@TOTAL_Item", total.ToString());


                // Specify the path to save the HTML file
                string filePath = Path.Combine(Path.GetTempPath(), "invoice.html");

                // Write the HTML content to the file
                File.WriteAllText(filePath, HTMLTemplated);

                // Open the HTML file in the default web browser
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            else
            {
                MessageBox.Show("The client and employee are empty", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Saved_Click(object sender, EventArgs e)
        {

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            JsonFolio();
        }

        private void JsonFolio()
        {
            string fileName = $"Logs-{DateTime.Now.Year}.json";

            if (!File.Exists(fileName))
            {
                // Initialize the dictionary for the first entry
                Dictionary<string, string> jsonData = new Dictionary<string, string>();

                // Increment folio
                int currentFolio = 1;
                string folio = currentFolio.ToString();

                // Generate invoice-date (e.g., 2024-001)
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string invoiceDate = $"{currentDate}-{currentFolio:D3}";

                // Add to the dictionary
                jsonData[folio] = invoiceDate;

                // Save the data to the JSON file
                string json = JsonConvert.SerializeObject(jsonData);
                File.WriteAllText(fileName, json);
            }
            else
            {
                // Load existing data from the JSON file
                string existingJson = File.ReadAllText(fileName);
                Dictionary<string, string> jsonData = JsonConvert.DeserializeObject<Dictionary<string, string>>(existingJson);

                // Increment folio
                int currentFolio = jsonData.Count + 1;
                string folio = currentFolio.ToString();

                // Generate invoice-date (e.g., 2024-001)
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                string invoiceDate = $"{currentDate}-{currentFolio:D3}";

                // Add to the dictionary
                jsonData[folio] = invoiceDate;

                // Save the updated data back to the JSON file
                string updatedJson = JsonConvert.SerializeObject(jsonData);
                File.WriteAllText(fileName, updatedJson);
            }
        }

        private (string folio, string invoice) JsonReader(string fileName)
        {
            string folio = string.Empty;
            string invoice = string.Empty;

            if (File.Exists(fileName))
            {
                string existingJson = File.ReadAllText(fileName);
                Dictionary<string, string> jsonData = JsonConvert.DeserializeObject<Dictionary<string, string>>(existingJson);

                foreach (var entry in jsonData)
                {
                    folio = entry.Key;
                    invoice = entry.Value;
                }
            }
            else
            {
                JsonFolio();
            }

            // Increment folio and invoice
            int incrementedFolio = int.Parse(folio) + 1;
            string incrementedInvoice = $"{DateTime.Now:yyyy-MM-dd}-{incrementedFolio:D3}";

            return (incrementedFolio.ToString(), incrementedInvoice);
        }

        private decimal UpdatedTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += decimal.Parse(row.Cells["Total_Grid"].Value.ToString());
            }
            return total;
        }
    }
}
