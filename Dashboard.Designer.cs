namespace Activity3_DeDios
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvproducts = new System.Windows.Forms.DataGridView();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.Refbutton = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.categorydropdown = new System.Windows.Forms.ComboBox();
            this.reorder = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.unitprice = new System.Windows.Forms.TextBox();
            this.productname = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.outofstock = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lowstock = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.instock = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalproducts = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LogoutBut = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imsdbDataSet1 = new Activity3_DeDios.imsdbDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imsdbDataSet = new Activity3_DeDios.imsdbDataSet();
            this.productsTableAdapter = new Activity3_DeDios.imsdbDataSetTableAdapters.ProductsTableAdapter();
            this.productsTableAdapter1 = new Activity3_DeDios.imsdbDataSet1TableAdapters.ProductsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.LogoutBut);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 908);
            this.panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(24, 82);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(493, 44);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Manage your inventory products";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dgvproducts);
            this.panel7.Controls.Add(this.searchbox);
            this.panel7.Controls.Add(this.textBox19);
            this.panel7.Controls.Add(this.Refbutton);
            this.panel7.Controls.Add(this.textBox18);
            this.panel7.Location = new System.Drawing.Point(24, 538);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1458, 349);
            this.panel7.TabIndex = 5;
            // 
            // dgvproducts
            // 
            this.dgvproducts.AllowUserToOrderColumns = true;
            this.dgvproducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducts.Location = new System.Drawing.Point(24, 63);
            this.dgvproducts.Margin = new System.Windows.Forms.Padding(4);
            this.dgvproducts.Name = "dgvproducts";
            this.dgvproducts.RowHeadersWidth = 51;
            this.dgvproducts.Size = new System.Drawing.Size(1408, 270);
            this.dgvproducts.TabIndex = 24;
            // 
            // searchbox
            // 
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.Location = new System.Drawing.Point(1048, 21);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(345, 30);
            this.searchbox.TabIndex = 23;
            // 
            // textBox19
            // 
            this.textBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox19.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.Location = new System.Drawing.Point(952, 23);
            this.textBox19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(89, 27);
            this.textBox19.TabIndex = 22;
            this.textBox19.Text = "Search";
            // 
            // Refbutton
            // 
            this.Refbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(196)))));
            this.Refbutton.Location = new System.Drawing.Point(268, 17);
            this.Refbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Refbutton.Name = "Refbutton";
            this.Refbutton.Size = new System.Drawing.Size(108, 33);
            this.Refbutton.TabIndex = 17;
            this.Refbutton.Text = "Refresh";
            this.Refbutton.UseVisualStyleBackColor = false;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(17, 18);
            this.textBox18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(229, 33);
            this.textBox18.TabIndex = 16;
            this.textBox18.Text = "Product List";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.categorydropdown);
            this.panel6.Controls.Add(this.reorder);
            this.panel6.Controls.Add(this.txtquantity);
            this.panel6.Controls.Add(this.unitprice);
            this.panel6.Controls.Add(this.productname);
            this.panel6.Controls.Add(this.description);
            this.panel6.Controls.Add(this.ClearButton);
            this.panel6.Controls.Add(this.DeleteButton);
            this.panel6.Controls.Add(this.UpdateButton);
            this.panel6.Controls.Add(this.AddButton);
            this.panel6.Controls.Add(this.textBox17);
            this.panel6.Controls.Add(this.textBox16);
            this.panel6.Controls.Add(this.textBox15);
            this.panel6.Controls.Add(this.textBox14);
            this.panel6.Controls.Add(this.Category);
            this.panel6.Controls.Add(this.textBox12);
            this.panel6.Location = new System.Drawing.Point(24, 293);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1458, 240);
            this.panel6.TabIndex = 4;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // categorydropdown
            // 
            this.categorydropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorydropdown.FormattingEnabled = true;
            this.categorydropdown.Items.AddRange(new object[] {
            "Men",
            "Female",
            "Unisex",
            "Summer",
            "Winter",
            "Fall"});
            this.categorydropdown.Location = new System.Drawing.Point(444, 57);
            this.categorydropdown.Margin = new System.Windows.Forms.Padding(4);
            this.categorydropdown.Name = "categorydropdown";
            this.categorydropdown.Size = new System.Drawing.Size(304, 37);
            this.categorydropdown.TabIndex = 27;
            // 
            // reorder
            // 
            this.reorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorder.Location = new System.Drawing.Point(831, 165);
            this.reorder.Margin = new System.Windows.Forms.Padding(4);
            this.reorder.Name = "reorder";
            this.reorder.Size = new System.Drawing.Size(304, 34);
            this.reorder.TabIndex = 26;
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(444, 165);
            this.txtquantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(304, 34);
            this.txtquantity.TabIndex = 25;
            // 
            // unitprice
            // 
            this.unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitprice.Location = new System.Drawing.Point(831, 69);
            this.unitprice.Margin = new System.Windows.Forms.Padding(4);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(304, 34);
            this.unitprice.TabIndex = 24;
            // 
            // productname
            // 
            this.productname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productname.Location = new System.Drawing.Point(17, 60);
            this.productname.Margin = new System.Windows.Forms.Padding(4);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(304, 34);
            this.productname.TabIndex = 23;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(15, 129);
            this.description.Margin = new System.Windows.Forms.Padding(4);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(393, 93);
            this.description.TabIndex = 22;
            this.description.Text = "";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Beige;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(1264, 176);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(168, 37);
            this.ClearButton.TabIndex = 21;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Firebrick;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(1265, 122);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(168, 37);
            this.DeleteButton.TabIndex = 20;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Aquamarine;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(1265, 70);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(168, 37);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.LawnGreen;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(1264, 17);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(168, 37);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add Product";
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(831, 132);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(229, 27);
            this.textBox17.TabIndex = 15;
            this.textBox17.Text = "Reorder Level";
            // 
            // textBox16
            // 
            this.textBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(444, 132);
            this.textBox16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(229, 27);
            this.textBox16.TabIndex = 14;
            this.textBox16.Text = "Quantity";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(17, 102);
            this.textBox15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(229, 27);
            this.textBox15.TabIndex = 13;
            this.textBox15.Text = "Description";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(831, 27);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(229, 27);
            this.textBox14.TabIndex = 12;
            this.textBox14.Text = "Unit Price";
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // Category
            // 
            this.Category.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.Category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Category.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.Location = new System.Drawing.Point(444, 27);
            this.Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Category.Multiline = true;
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(229, 27);
            this.Category.TabIndex = 11;
            this.Category.Text = "Category";
            // 
            // textBox12
            // 
            this.textBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.Location = new System.Drawing.Point(17, 27);
            this.textBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(229, 27);
            this.textBox12.TabIndex = 10;
            this.textBox12.Text = "Product Name";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.outofstock);
            this.panel5.Controls.Add(this.textBox7);
            this.panel5.Location = new System.Drawing.Point(1212, 144);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 144);
            this.panel5.TabIndex = 6;
            // 
            // outofstock
            // 
            this.outofstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.outofstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outofstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outofstock.Location = new System.Drawing.Point(123, 55);
            this.outofstock.Margin = new System.Windows.Forms.Padding(4);
            this.outofstock.Name = "outofstock";
            this.outofstock.Size = new System.Drawing.Size(68, 50);
            this.outofstock.TabIndex = 12;
            this.outofstock.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(189)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(40, 1);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(204, 44);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "Out of Stock";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(208)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lowstock);
            this.panel4.Controls.Add(this.textBox6);
            this.panel4.Location = new System.Drawing.Point(796, 144);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 144);
            this.panel4.TabIndex = 5;
            // 
            // lowstock
            // 
            this.lowstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(208)))));
            this.lowstock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lowstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowstock.Location = new System.Drawing.Point(115, 55);
            this.lowstock.Margin = new System.Windows.Forms.Padding(4);
            this.lowstock.Name = "lowstock";
            this.lowstock.Size = new System.Drawing.Size(68, 50);
            this.lowstock.TabIndex = 11;
            this.lowstock.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(208)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(59, 1);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(156, 44);
            this.textBox6.TabIndex = 10;
            this.textBox6.Text = "Low Stock";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(226)))), ((int)(((byte)(233)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.instock);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Location = new System.Drawing.Point(401, 146);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 141);
            this.panel3.TabIndex = 4;
            // 
            // instock
            // 
            this.instock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(226)))), ((int)(((byte)(233)))));
            this.instock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instock.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instock.Location = new System.Drawing.Point(120, 53);
            this.instock.Margin = new System.Windows.Forms.Padding(4);
            this.instock.Name = "instock";
            this.instock.Size = new System.Drawing.Size(68, 50);
            this.instock.TabIndex = 10;
            this.instock.Text = "0";
            this.instock.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(226)))), ((int)(((byte)(233)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(67, 2);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(135, 44);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "In Stock";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.totalproducts);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Location = new System.Drawing.Point(24, 146);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 141);
            this.panel2.TabIndex = 3;
            // 
            // totalproducts
            // 
            this.totalproducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.totalproducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalproducts.Location = new System.Drawing.Point(113, 53);
            this.totalproducts.Margin = new System.Windows.Forms.Padding(4);
            this.totalproducts.Name = "totalproducts";
            this.totalproducts.Size = new System.Drawing.Size(68, 50);
            this.totalproducts.TabIndex = 9;
            this.totalproducts.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(17, 2);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(229, 44);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "Total Products";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(24, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 44);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Product Management\r\n\r\n";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LogoutBut
            // 
            this.LogoutBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(196)))));
            this.LogoutBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBut.Location = new System.Drawing.Point(205, 7);
            this.LogoutBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBut.Name = "LogoutBut";
            this.LogoutBut.Size = new System.Drawing.Size(101, 38);
            this.LogoutBut.TabIndex = 1;
            this.LogoutBut.Text = "Logout";
            this.LogoutBut.UseVisualStyleBackColor = false;
            this.LogoutBut.Click += new System.EventHandler(this.LogoutBut_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(56, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "WELCOMEEE!!";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.imsdbDataSet1;
            // 
            // imsdbDataSet1
            // 
            this.imsdbDataSet1.DataSetName = "imsdbDataSet1";
            this.imsdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.imsdbDataSet;
            // 
            // imsdbDataSet
            // 
            this.imsdbDataSet.DataSetName = "imsdbDataSet";
            this.imsdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1533, 935);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducts)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imsdbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LogoutBut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox outofstock;
        private System.Windows.Forms.TextBox lowstock;
        private System.Windows.Forms.TextBox instock;
        private System.Windows.Forms.TextBox totalproducts;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button Refbutton;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.TextBox reorder;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.TextBox unitprice;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.ComboBox categorydropdown;
        private System.Windows.Forms.DataGridView dgvproducts;
        private imsdbDataSet imsdbDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private imsdbDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private imsdbDataSet1 imsdbDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private imsdbDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}