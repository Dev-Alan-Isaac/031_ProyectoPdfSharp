using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Form1 : Form
    {
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
                HTMLTemplated = HTMLTemplated.Replace("@Date", DateTime.Now.ToString());

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

        }

        private int JsonFolio()
        {

            return 0;
        }
    }
}
