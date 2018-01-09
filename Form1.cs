using Microsoft.VisualBasic.FileIO;
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

        //clears the import, add and price textboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearButton.Text = String.Empty;
            itemNametextBox.Text = String.Empty;
            itemPriceTextBox.Text = String.Empty;
        }

        //adds the item information such as item name, item category and item price in the first datagridview
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
                    MessageBox.Show("ERROR! Please enter valid information.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Please enter valid information.");
            }
        }

        //removes the selected row of data in the first datagridview
        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedRow = addItemDataGridView.CurrentRow.Index;
            if (selectedRow >= 0)
            {
                addItemDataGridView.Rows.RemoveAt(selectedRow);
            }
        }

        //browses CSV file dialog box for importing 
        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            //Adding filter to list CSV file
            dialog.Filter = "Files(*.txt, *.csv)|*.txt;*.csv|All Files (*.*) |*.*";

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                importFileTextBox.Text = dialog.FileName;
                string val = importFileTextBox.Text;
                
            }
        }

        //imports CSV file and displays in the first datagridview
        private void importButton_Click(object sender, EventArgs e)
        {
            {
                int j = 0;
                String filepath = importFileTextBox.Text;
                try
                {

                    if (importFileTextBox.Text != "" && importFileTextBox.Text != null)
                    {
                        TextFieldParser csvreader = new TextFieldParser(filepath);
                        csvreader.SetDelimiters(new string[] 
                        { 
                            ","
                        });
                        csvreader.HasFieldsEnclosedInQuotes = true;
                        csvreader.ReadFields();

                        while (!csvreader.EndOfData)
                        {
                            string[] fielddata = csvreader.ReadFields();
                            addItemDataGridView.Rows.Add();

                            for (int i = 0; i < fielddata.Length; i++)
                            {
                                addItemDataGridView.Rows[j].Cells[i].Value = fielddata[i];
                            }
                            Console.WriteLine("");
                            j += 1;
                        }
                       
                        MessageBox.Show("File imported successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Enter the .csv file");
                    }

                }
                catch
                {
                    MessageBox.Show("Please import .csv file.");
                }
            }
          
        }

        //displays selected row from the first datagridview in the textboxes of "Billing Details"
        private void addItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = addItemDataGridView.Rows[index];
            itemNameBillingTextBox.Text = selectedRow.Cells[0].Value.ToString();
            itemCategoryBillingTextBox.Text = selectedRow.Cells[1].Value.ToString();
        }

        //adds the billing information in the second datagridview according to the quantity entered
        private void addToSalesButton_Click(object sender, EventArgs e)
        {
            string billingItem = itemNameBillingTextBox.Text;
            string billingCategory = itemCategoryBillingTextBox.Text;

            try
            {

                int billingQuantity = Convert.ToInt32(quantityBillingTextBox.Text);
                if (billingItem != null && billingItem != "" && billingCategory != null && billingQuantity > 0)
                {
                    for (int i = 1; i <= billingQuantity; i++)
                    {
                        int count = billingDataGridView.Rows.Add();
                        billingDataGridView.Rows[count].Cells[0].Value = billingItem;
                        billingDataGridView.Rows[count].Cells[1].Value = billingCategory;
                        billingDataGridView.Rows[count].Cells[2].Value = billingQuantity;
                        billingDataGridView.Rows[count].Selected = true;
                    }
                    MessageBox.Show("Item has been added!");
                    

                }
                else
                {
                    MessageBox.Show("ERROR! Please enter valid information.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR! Please enter valid information.");
            }
        }

        

    }
}


       


    

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         