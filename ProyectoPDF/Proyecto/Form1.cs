using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
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
            decimal totla = UpdatedTotal();
            label_PriceTotal.Text = "$" + totla.ToString();
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
            InvoiceView();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            JsonFolio();
            InvoiceSaved();
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

        private void InvoiceView()
        {
            string HTMLTemplated = Properties.Resources.Index;

            if (!string.IsNullOrEmpty(textBox_Client.Text) && !string.IsNullOrEmpty(textBox_Employee.Text))
            {
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
                string filePath = Path.Combine(Path.GetTempPath(), "Invoice.html");

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

        private void InvoiceSaved()
        {
            string HTMLTemplated = Properties.Resources.Saved;
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("{0}.pdf", DateTime.Now.ToString("ddMMyyyyHHmmss"));
            savefile.Filter = "PDF files (*.pdf)|*.pdf";
            savefile.Title = "Save PDF File";

            if (!string.IsNullOrEmpty(textBox_Client.Text))
            {
                HTMLTemplated = HTMLTemplated.Replace("@Client", textBox_Client.Text);
                HTMLTemplated = HTMLTemplated.Replace("@Employee", textBox_Employee.Text);
                HTMLTemplated = HTMLTemplated.Replace("@Date", DateTime.Now.ToString("yyyy-MM-dd"));

                var (folio, invoice) = JsonReader($"Logs-{DateTime.Now.Year}.json");

                HTMLTemplated = HTMLTemplated.Replace("@Folio", folio.ToString());
                HTMLTemplated = HTMLTemplated.Replace("@Invoice", invoice.ToString());

                string filas = string.Empty;
                decimal total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Description_Grid"].Value != null &&
                        row.Cells["Quantity_Grid"].Value != null &&
                        row.Cells["PricePerUnit_Grid"].Value != null &&
                        row.Cells["Total_Grid"].Value != null)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.Cells["Description_Grid"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Quantity_Grid"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["PricePerUnit_Grid"].Value.ToString() + "</td>";
                        filas += "<td>" + row.Cells["Total_Grid"].Value.ToString() + "</td>";
                        filas += "</tr>";
                        total += decimal.Parse(row.Cells["Total_Grid"].Value.ToString());
                    }
                }
                HTMLTemplated = HTMLTemplated.Replace("@Filas", filas);
                HTMLTemplated = HTMLTemplated.Replace("@TOTAL_Item", total.ToString());

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                        {
                            // Create a new document and define it as PDF
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            if (writer == null)
                            {
                                throw new NullReferenceException("PdfWriter instance is null.");
                            }

                            pdfDoc.Open();

                            // Add the image to the document
                            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.shop, System.Drawing.Imaging.ImageFormat.Png);
                            img.ScaleToFit(60, 60);
                            img.Alignment = iTextSharp.text.Image.UNDERLYING;
                            img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                            pdfDoc.Add(img);

                            // Add the HTML content to the document
                            using (StringReader sr = new StringReader(HTMLTemplated))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                        }

                        MessageBox.Show("PDF saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No client", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
