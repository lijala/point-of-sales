namespace LijalaShrestha_ADCoursework_L3C3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.billingRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.addItemsRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.mainRectangleShape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.addItemLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNametextBox = new System.Windows.Forms.TextBox();
            this.itemCategoryLabel = new System.Windows.Forms.Label();
            this.itemCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.itemPriceLabel = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addItemDataGridView = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importFileLabel = new System.Windows.Forms.Label();
            this.importFileTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.billingLabel = new System.Windows.Forms.Label();
            this.itemNameBillingLabel = new System.Windows.Forms.Label();
            this.itemNameBillingTextBox = new System.Windows.Forms.TextBox();
            this.itemCategoryBillingLabel = new System.Windows.Forms.Label();
            this.quantityBillingLabel = new System.Windows.Forms.Label();
            this.quantityBillingTextBox = new System.Windows.Forms.TextBox();
            this.addToSalesButton = new System.Windows.Forms.Button();
            this.billingDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.sortByPriceRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByLabel = new System.Windows.Forms.Label();
            this.reportChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.itemCategoryBillingTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.addItemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).BeginInit();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.billingRectangleShape,
            this.addItemsRectangleShape,
            this.mainRectangleShape});
            this.shapeContainer1.Size = new System.Drawing.Size(1025, 504);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 7;
            this.lineShape1.X2 = 353;
            this.lineShape1.Y1 = 205;
            this.lineShape1.Y2 = 205;
            // 
            // billingRectangleShape
            // 
            this.billingRectangleShape.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billingRectangleShape.Location = new System.Drawing.Point(354, 6);
            this.billingRectangleShape.Name = "billingRectangleShape";
            this.billingRectangleShape.Size = new System.Drawing.Size(345, 493);
            // 
            // addItemsRectangleShape
            // 
            this.addItemsRectangleShape.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addItemsRectangleShape.Location = new System.Drawing.Point(7, 6);
            this.addItemsRectangleShape.Name = "addItemsRectangleShape";
            this.addItemsRectangleShape.Size = new System.Drawing.Size(347, 493);
            // 
            // mainRectangleShape
            // 
            this.mainRectangleShape.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainRectangleShape.Location = new System.Drawing.Point(7, 6);
            this.mainRectangleShape.Name = "mainRectangleShape";
            this.mainRectangleShape.Size = new System.Drawing.Size(1013, 493);
            // 
            // addItemLabel
            // 
            this.addItemLabel.AutoSize = true;
            this.addItemLabel.Location = new System.Drawing.Point(30, 75);
            this.addItemLabel.Name = "addItemLabel";
            this.addItemLabel.Size = new System.Drawing.Size(66, 13);
            this.addItemLabel.TabIndex = 2;
            this.addItemLabel.Text = "ADD ITEMS";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(30, 102);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 3;
            this.itemNameLabel.Text = "Item Name:\r\n";
            // 
            // itemNametextBox
            // 
            this.itemNametextBox.Location = new System.Drawing.Point(110, 95);
            this.itemNametextBox.Name = "itemNametextBox";
            this.itemNametextBox.Size = new System.Drawing.Size(209, 20);
            this.itemNametextBox.TabIndex = 4;
            // 
            // itemCategoryLabel
            // 
            this.itemCategoryLabel.AutoSize = true;
            this.itemCategoryLabel.Location = new System.Drawing.Point(29, 129);
            this.itemCategoryLabel.Name = "itemCategoryLabel";
            this.itemCategoryLabel.Size = new System.Drawing.Size(75, 13);
            this.itemCategoryLabel.TabIndex = 5;
            this.itemCategoryLabel.Text = "Item Category:";
            // 
            // itemCategoryComboBox
            // 
            this.itemCategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itemCategoryComboBox.FormattingEnabled = true;
            this.itemCategoryComboBox.Items.AddRange(new object[] {
            "Breakfast",
            "Snacks",
            "Cold Drinks",
            "Hot Drinks",
            "Dessert"});
            this.itemCategoryComboBox.Location = new System.Drawing.Point(110, 121);
            this.itemCategoryComboBox.Name = "itemCategoryComboBox";
            this.itemCategoryComboBox.Size = new System.Drawing.Size(209, 21);
            this.itemCategoryComboBox.TabIndex = 6;
            // 
            // itemPriceLabel
            // 
            this.itemPriceLabel.AutoSize = true;
            this.itemPriceLabel.Location = new System.Drawing.Point(29, 155);
            this.itemPriceLabel.Name = "itemPriceLabel";
            this.itemPriceLabel.Size = new System.Drawing.Size(57, 13);
            this.itemPriceLabel.TabIndex = 7;
            this.itemPriceLabel.Text = "Item Price:";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(110, 148);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(209, 20);
            this.itemPriceTextBox.TabIndex = 8;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.SystemColors.Control;
            this.removeButton.Location = new System.Drawing.Point(110, 174);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 23);
            this.removeButton.TabIndex = 9;
            this.removeButton.Text = "REMOVE";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.Control;
            this.addButton.Location = new System.Drawing.Point(225, 174);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addItemDataGridView
            // 
            this.addItemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Category,
            this.Price});
            this.addItemDataGridView.Location = new System.Drawing.Point(11, 242);
            this.addItemDataGridView.Name = "addItemDataGridView";
            this.addItemDataGridView.Size = new System.Drawing.Size(339, 250);
            this.addItemDataGridView.TabIndex = 11;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // importFileLabel
            // 
            this.importFileLabel.AutoSize = true;
            this.importFileLabel.Location = new System.Drawing.Point(29, 22);
            this.importFileLabel.Name = "importFileLabel";
            this.importFileLabel.Size = new System.Drawing.Size(74, 13);
            this.importFileLabel.TabIndex = 12;
            this.importFileLabel.Text = "IMPORT FILE";
            // 
            // importFileTextBox
            // 
            this.importFileTextBox.Location = new System.Drawing.Point(110, 15);
            this.importFileTextBox.Name = "importFileTextBox";
            this.importFileTextBox.Size = new System.Drawing.Size(209, 20);
            this.importFileTextBox.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(110, 42);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(68, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.SystemColors.Control;
            this.importButton.Location = new System.Drawing.Point(253, 42);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(66, 23);
            this.importButton.TabIndex = 16;
            this.importButton.Text = "IMPORT";
            this.importButton.UseVisualStyleBackColor = false;
            // 
            // billingLabel
            // 
            this.billingLabel.AutoSize = true;
            this.billingLabel.Location = new System.Drawing.Point(489, 19);
            this.billingLabel.Name = "billingLabel";
            this.billingLabel.Size = new System.Drawing.Size(96, 13);
            this.billingLabel.TabIndex = 17;
            this.billingLabel.Text = "BILLING DETAILS";
            // 
            // itemNameBillingLabel
            // 
            this.itemNameBillingLabel.AutoSize = true;
            this.itemNameBillingLabel.Location = new System.Drawing.Point(384, 59);
            this.itemNameBillingLabel.Name = "itemNameBillingLabel";
            this.itemNameBillingLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameBillingLabel.TabIndex = 18;
            this.itemNameBillingLabel.Text = "Item Name:";
            // 
            // itemNameBillingTextBox
            // 
            this.itemNameBillingTextBox.Location = new System.Drawing.Point(465, 52);
            this.itemNameBillingTextBox.Name = "itemNameBillingTextBox";
            this.itemNameBillingTextBox.Size = new System.Drawing.Size(150, 20);
            this.itemNameBillingTextBox.TabIndex = 19;
            // 
            // itemCategoryBillingLabel
            // 
            this.itemCategoryBillingLabel.AutoSize = true;
            this.itemCategoryBillingLabel.Location = new System.Drawing.Point(384, 103);
            this.itemCategoryBillingLabel.Name = "itemCategoryBillingLabel";
            this.itemCategoryBillingLabel.Size = new System.Drawing.Size(75, 13);
            this.itemCategoryBillingLabel.TabIndex = 20;
            this.itemCategoryBillingLabel.Text = "Item Category:";
            // 
            // quantityBillingLabel
            // 
            this.quantityBillingLabel.AutoSize = true;
            this.quantityBillingLabel.Location = new System.Drawing.Point(384, 149);
            this.quantityBillingLabel.Name = "quantityBillingLabel";
            this.quantityBillingLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityBillingLabel.TabIndex = 22;
            this.quantityBillingLabel.Text = "Quantity:";
            // 
            // quantityBillingTextBox
            // 
            this.quantityBillingTextBox.Location = new System.Drawing.Point(465, 142);
            this.quantityBillingTextBox.Name = "quantityBillingTextBox";
            this.quantityBillingTextBox.Size = new System.Drawing.Size(150, 20);
            this.quantityBillingTextBox.TabIndex = 23;
            // 
            // addToSalesButton
            // 
            this.addToSalesButton.BackColor = System.Drawing.SystemColors.Control;
            this.addToSalesButton.Location = new System.Drawing.Point(521, 189);
            this.addToSalesButton.Name = "addToSalesButton";
            this.addToSalesButton.Size = new System.Drawing.Size(94, 23);
            this.addToSalesButton.TabIndex = 24;
            this.addToSalesButton.Text = "ADD TO SALES";
            this.addToSalesButton.UseVisualStyleBackColor = false;
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.billingDataGridView.Location = new System.Drawing.Point(359, 242);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.Size = new System.Drawing.Size(336, 250);
            this.billingDataGridView.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sale Item";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Location = new System.Drawing.Point(840, 19);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(52, 13);
            this.reportLabel.TabIndex = 26;
            this.reportLabel.Text = "REPORT";
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.Control;
            this.browseButton.Location = new System.Drawing.Point(184, 42);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(63, 23);
            this.browseButton.TabIndex = 27;
            this.browseButton.Text = "BROWSE";
            this.browseButton.UseVisualStyleBackColor = false;
            // 
            // sortByPriceRadioButton
            // 
            this.sortByPriceRadioButton.AutoSize = true;
            this.sortByPriceRadioButton.Location = new System.Drawing.Point(110, 215);
            this.sortByPriceRadioButton.Name = "sortByPriceRadioButton";
            this.sortByPriceRadioButton.Size = new System.Drawing.Size(57, 17);
            this.sortByPriceRadioButton.TabIndex = 28;
            this.sortByPriceRadioButton.TabStop = true;
            this.sortByPriceRadioButton.Text = "PRICE";
            this.sortByPriceRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByNameRadioButton
            // 
            this.sortByNameRadioButton.AutoSize = true;
            this.sortByNameRadioButton.Location = new System.Drawing.Point(225, 215);
            this.sortByNameRadioButton.Name = "sortByNameRadioButton";
            this.sortByNameRadioButton.Size = new System.Drawing.Size(56, 17);
            this.sortByNameRadioButton.TabIndex = 29;
            this.sortByNameRadioButton.TabStop = true;
            this.sortByNameRadioButton.Text = "NAME";
            this.sortByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByLabel
            // 
            this.sortByLabel.AutoSize = true;
            this.sortByLabel.Location = new System.Drawing.Point(30, 219);
            this.sortByLabel.Name = "sortByLabel";
            this.sortByLabel.Size = new System.Drawing.Size(54, 13);
            this.sortByLabel.TabIndex = 30;
            this.sortByLabel.Text = "SORT BY";
            // 
            // reportChart
            // 
            chartArea2.Name = "ChartArea1";
            this.reportChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.reportChart.Legends.Add(legend2);
            this.reportChart.Location = new System.Drawing.Point(707, 52);
            this.reportChart.Name = "reportChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.reportChart.Series.Add(series2);
            this.reportChart.Size = new System.Drawing.Size(307, 440);
            this.reportChart.TabIndex = 31;
            this.reportChart.Text = "Report";
            // 
            // itemCategoryBillingTextBox
            // 
            this.itemCategoryBillingTextBox.Location = new System.Drawing.Point(465, 96);
            this.itemCategoryBillingTextBox.Name = "itemCategoryBillingTextBox";
            this.itemCategoryBillingTextBox.ReadOnly = true;
            this.itemCategoryBillingTextBox.Size = new System.Drawing.Size(150, 20);
            this.itemCategoryBillingTextBox.TabIndex = 32;
            this.itemCategoryBillingTextBox.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1025, 504);
            this.Controls.Add(this.itemCategoryBillingTextBox);
            this.Controls.Add(this.reportChart);
            this.Controls.Add(this.sortByLabel);
            this.Controls.Add(this.sortByNameRadioButton);
            this.Controls.Add(this.sortByPriceRadioButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.billingDataGridView);
            this.Controls.Add(this.addToSalesButton);
            this.Controls.Add(this.quantityBillingTextBox);
            this.Controls.Add(this.quantityBillingLabel);
            this.Controls.Add(this.itemCategoryBillingLabel);
            this.Controls.Add(this.itemNameBillingTextBox);
            this.Controls.Add(this.itemNameBillingLabel);
            this.Controls.Add(this.billingLabel);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.importFileTextBox);
            this.Controls.Add(this.importFileLabel);
            this.Controls.Add(this.addItemDataGridView);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.itemPriceLabel);
            this.Controls.Add(this.itemCategoryComboBox);
            this.Controls.Add(this.itemCategoryLabel);
            this.Controls.Add(this.itemNametextBox);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.addItemLabel);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RESTAURANT POINT-OF-SALE SYSTEM";
            ((System.ComponentModel.ISupportInitialize)(this.addItemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape mainRectangleShape;
        private System.Windows.Forms.Label addItemLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape addItemsRectangleShape;
        private System.Windows.Forms.TextBox itemNametextBox;
        private System.Windows.Forms.Label itemCategoryLabel;
        private System.Windows.Forms.ComboBox itemCategoryComboBox;
        private System.Windows.Forms.Label itemPriceLabel;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView addItemDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Label importFileLabel;
        private System.Windows.Forms.TextBox importFileTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Label billingLabel;
        private System.Windows.Forms.Label itemNameBillingLabel;
        private System.Windows.Forms.TextBox itemNameBillingTextBox;
        private System.Windows.Forms.Label itemCategoryBillingLabel;
        private System.Windows.Forms.Label quantityBillingLabel;
        private System.Windows.Forms.TextBox quantityBillingTextBox;
        private System.Windows.Forms.Button addToSalesButton;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape billingRectangleShape;
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.Button browseButton;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.RadioButton sortByPriceRadioButton;
        private System.Windows.Forms.RadioButton sortByNameRadioButton;
        private System.Windows.Forms.Label sortByLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart reportChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox itemCategoryBillingTextBox;
    }
}

