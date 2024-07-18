using System;
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
            string client = textBox_Item.Text;
            int quantity = (int)numericUpDown_Qty.Value; // Cast to int
            decimal price = numericUpDown_Price.Value; // Cast to decimal
            decimal total = quantity * price;

            // Assuming you have a DataGridView named dataGridView1
            // Create a new row and populate it
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell { Value = client });
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

    }
}
