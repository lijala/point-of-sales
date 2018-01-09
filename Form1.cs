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
        private double price;

        public Form1()
        {
            InitializeComponent();
            
        }

        //clears the import, add and price textboxes
        private void clearButton_Click(object sender, EventArgs e)
        {
            importFileTextBox.Text = String.Empty;
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
                try
                {
                    addItemDataGridView.Rows.Add();
                    if (importFileTextBox.Text != null && importFileTextBox.Text != "")
                    {
                        TextFieldParser csvceader = new TextFieldParser(importFileTextBox.Text);
                        csvceader.SetDelimiters(new string[] { "," });
                        while (!csvceader.EndOfData)
                        {
                            int rowIndex = FindEmptyRow();

                            string[] rowdata = csvceader.ReadFields();
                            addItemDataGridView.Rows.Add();
                            //loop till the column numbers in rowdata which is a single row imported from csv and then add those data to corresponding columns in datagridview
                            for (int i = 0; i < rowdata.Length; i++)
                            {
                                addItemDataGridView.Rows[rowIndex].Cells[i].Value = (Object)rowdata[i];
                            }
                        }
                        MessageBox.Show("Successfully Imported.");
                    }

                    else MessageBox.Show("File location not specified.", "No Filepath selected", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }

             }             
         }


        //displays selected row from the first datagridview in the textboxes of "Billing Details"
        private void addItemDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = addItemDataGridView.Rows[index];
            itemNameBillingTextBox.Text = selectedRow.Cells[ItemColumn.Index].Value.ToString();
            itemCategoryBillingTextBox.Text = selectedRow.Cells[CategoryColumn.Index].Value.ToString();
            price = Convert.ToDouble(selectedRow.Cells[PriceColumn.Index].Value);
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
                        billingDataGridView.Rows[count].Cells[2].Value = price;
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
            finally
            {
                DisplayChart();
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            if (sortByPriceRadioButton.Checked == true)
            {
                SortByPrice();
            }
            if (sortByNameRadioButton.Checked == true)
            {
                SortByName();
            }
        }




        //finds empty row to add
        public int FindEmptyRow()
        {
            int rows = addItemDataGridView.RowCount;
            int columns = addItemDataGridView.ColumnCount;
            int EmptyRow = 0;
            int EmptyColumn = 0;
            bool flag = false;
            do
            {
                string value = (string)addItemDataGridView.Rows[EmptyRow].Cells[EmptyColumn].Value;
                if (value != null && value.Length != 0)
                {
                    EmptyRow++;
                }
                else {
                    flag = true;
                }
            } while (!flag && EmptyRow < rows);
            return EmptyRow;
        }

     
        public void SortByName() {
            List<string> names = new List<string>();

            //getting every item names from table and storing it in a list
            foreach (DataGridViewRow row in addItemDataGridView.Rows){
                string name = Convert.ToString(row.Cells[ItemColumn.Index].Value);
                names.Add(name);
            }

            //sorting the names list from above
            for (int i = 0; i < names.Count - 1; i++)
            {
                for (int j = 1; j < names.Count - 1; j++)
                {
                    if (names[j - 1].CompareTo(names[j]) > 0)
                    {
                        string temp = names[j - 1];
                        names[j - 1] = names[j];
                        names[j] = temp;

                        List<object> row0 = new List<object>();
                        List<object> row1 = new List<object>();

                        for (int m = 0; m < addItemDataGridView.ColumnCount; m++)
                        {
                            object item0 = addItemDataGridView.Rows[j - 1].Cells[m].Value;
                            object item1 = addItemDataGridView.Rows[j].Cells[m].Value;
                            row0.Add(item0);
                            row1.Add(item1);
                            addItemDataGridView.Rows[j - 1].Cells[m].Value = row1[m];
                            addItemDataGridView.Rows[j].Cells[m].Value = row0[m];
                        }
                    }
                }
            }


        }

        public void SortByPrice() {

            List<double> prices = new List<double>();

            //getting every item prices from table and storing it in a list
            foreach (DataGridViewRow row in addItemDataGridView.Rows)
            {
                double price = Convert.ToDouble(row.Cells[PriceColumn.Index].Value);
                prices.Add(price);
            }

            for (int i = 0; i < prices.Count - 1; i++)
            {
                for (int j = 1; j < prices.Count - 1; j++)
                {
                    if (prices[j] < prices[j-1])
                    {
                        double temp = prices[j - 1];
                        prices[j - 1] = prices[j];
                        prices[j] = temp;

                        List<object> row0 = new List<object>();
                        List<object> row1 = new List<object>();

                        for (int m = 0; m < addItemDataGridView.ColumnCount; m++)
                        {
                            object item0 = addItemDataGridView.Rows[j - 1].Cells[m].Value;
                            object item1 = addItemDataGridView.Rows[j].Cells[m].Value;
                            row0.Add(item0);
                            row1.Add(item1);
                            addItemDataGridView.Rows[j - 1].Cells[m].Value = row1[m];
                            addItemDataGridView.Rows[j].Cells[m].Value = row0[m];
                        }
                    }
                }
            }
        }

        public void DisplayChart() {
            ReportChart.Series["BillingSeries"].Points.Clear();


            double Breakfast;
            double Snacks;
            double ColdDrinks;
            double HotDrinks;
            double Dessert;

            List<double> BreakfastList = new List<double>();
            List<double> SnacksList = new List<double>();
            List<double> ColdDrinksList = new List<double>();
            List<double> HotDrinksList = new List<double>();
            List<double> DessertList = new List<double>();
           
            foreach (DataGridViewRow row in billingDataGridView.Rows)
            {
                string category = Convert.ToString(row.Cells[SoldCategoryColumn.Index].Value);
                if (category.Equals("Breakfast"))
                {
                    double price = Convert.ToDouble(row.Cells[2].Value);
                    BreakfastList.Add(price);
                }

                else if (category.Equals("Snacks"))
                {
                    double price = Convert.ToDouble(row.Cells[SoldPriceColumn.Index].Value);
                    SnacksList.Add(price);
                }

                else if (category.Equals("Cold Drinks"))
                {
                    double price = Convert.ToDouble(row.Cells[SoldPriceColumn.Index].Value);
                    ColdDrinksList.Add(price);
                }

                else if (category.Equals("Hot Drinks"))
                {
                    double price = Convert.ToDouble(row.Cells[SoldPriceColumn.Index].Value);
                    HotDrinksList.Add(price);
                }

                else if (category.Equals("Dessert"))
                {
                    double price = Convert.ToDouble(row.Cells[SoldPriceColumn.Index].Value);
                    DessertList.Add(price);
                }
            }

            Breakfast = GetSalesPrice(BreakfastList);
            Snacks = GetSalesPrice(SnacksList);
            ColdDrinks = GetSalesPrice(ColdDrinksList);
            HotDrinks = GetSalesPrice(HotDrinksList);
            Dessert = GetSalesPrice(DessertList);


            AddToChart(0, Breakfast, "Breakfast", Color.Red);
            AddToChart(1, Snacks, "Snacks", Color.Yellow);     
            AddToChart(2, ColdDrinks, "Cold Drinks", Color.Green);
            AddToChart(3, HotDrinks, "Hot Drinks", Color.LightSkyBlue);
            AddToChart(4, Dessert, "Desert", Color.Purple);
        
        }

        public void AddToChart(int points, double totalSales, String category, Color color)
        {
            Console.WriteLine(totalSales);
            ReportChart.Series["BillingSeries"].Points.Add(totalSales);
            ReportChart.Series["BillingSeries"].Points[points].Color = color;
            ReportChart.Series["BillingSeries"].Points[points].LegendText = category;
            ReportChart.Series["BillingSeries"].Points[points].Label = Convert.ToString(totalSales);
        }
       //i'll run the code see if you can find the error okay
        public double GetSalesPrice(List<double> salesList) {
            double sales = 0;
            foreach (double price in salesList) {
                sales = sales + price;
            }
            return sales;
        }

        private void clearBillingButton_Click(object sender, EventArgs e)
        {
            itemNameBillingTextBox.Text = String.Empty;
            itemCategoryBillingTextBox.Text = String.Empty;
            quantityBillingTextBox.Text = String.Empty;
        }

        private void removeBillingButton_Click(object sender, EventArgs e)
        {
            int selectedRow = billingDataGridView.CurrentRow.Index;
            if (selectedRow >= 0)
            {
                billingDataGridView.Rows.RemoveAt(selectedRow);
            }
        }
    }
}


       


    

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         