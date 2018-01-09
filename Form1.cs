using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LijalaShrestha_ADCoursework_L3C3
{
    public partial class Form1 : Form
    {
        private bool status = false;
        private int row = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearButton.Text = String.Empty;
            itemNametextBox.Text = String.Empty;
            itemPriceTextBox.Text = String.Empty;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string itemName = itemNametextBox.Text;
            string itemCategory = itemCategoryComboBox.Text;
            
            try
            {

                double itemPrice = Convert.ToDouble(itemPriceTextBox.Text);
                if (itemName != null && itemName != "" && itemCategory != null && itemPrice > 0)
                {
                    addItemDataGridView.Rows.Add();
                    addItemDataGridView.Rows[this.row].Cells[0].Value = itemName;
                    addItemDataGridView.Rows[this.row].Cells[1].Value = itemCategory;
                    addItemDataGridView.Rows[this.row].Cells[2].Value = itemPrice;
                    addItemDataGridView.Rows[this.row].Selected = true;

                    MessageBox.Show("Item has been added!");
                    row++;
                    
                }
                else
                {
                    MessageBox.Show("ERROR!");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedRow = addItemDataGridView.CurrentRow.Index;
            if (selectedRow >= 0)
            {
                addItemDataGridView.Rows.RemoveAt(selectedRow);
            }
        }


    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         