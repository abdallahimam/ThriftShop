namespace CPL_gui
{
	partial class Linq
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgvProduct = new System.Windows.Forms.DataGridView();
			this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productBrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbProductCategory = new System.Windows.Forms.TextBox();
			this.tbProductBrandName = new System.Windows.Forms.TextBox();
			this.tbProductPrice = new System.Windows.Forms.TextBox();
			this.tbProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbBrandName = new System.Windows.Forms.TextBox();
			this.dgvBrand = new System.Windows.Forms.DataGridView();
			this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numberOfProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAddProduct = new System.Windows.Forms.Button();
			this.btnRemoveProduct = new System.Windows.Forms.Button();
			this.btnAddBrand = new System.Windows.Forms.Button();
			this.btnRemoveBrand = new System.Windows.Forms.Button();
			this.btnFilterProducts = new System.Windows.Forms.Button();
			this.btnSortProducts = new System.Windows.Forms.Button();
			this.tbFilterInput = new System.Windows.Forms.TextBox();
			this.rbPrice = new System.Windows.Forms.RadioButton();
			this.rbName = new System.Windows.Forms.RadioButton();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.rbAscending = new System.Windows.Forms.RadioButton();
			this.rbDescending = new System.Windows.Forms.RadioButton();
			this.label9 = new System.Windows.Forms.Label();
			this.gbSortType = new System.Windows.Forms.GroupBox();
			this.gbSortDirection = new System.Windows.Forms.GroupBox();
			this.btnSordBrands = new System.Windows.Forms.Button();
			this.gbSortBrands = new System.Windows.Forms.GroupBox();
			this.rbSortBrandsNumber = new System.Windows.Forms.RadioButton();
			this.rbSortBrandsName = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbBrandDirectionDesc = new System.Windows.Forms.RadioButton();
			this.rbBrandDirectionAsc = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).BeginInit();
			this.gbSortType.SuspendLayout();
			this.gbSortDirection.SuspendLayout();
			this.gbSortBrands.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(180, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(718, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to thrift shop that manage the products of the shop";
			// 
			// dgvProduct
			// 
			this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productCategory,
            this.productPrice,
            this.productBrandName});
			this.dgvProduct.Location = new System.Drawing.Point(84, 224);
			this.dgvProduct.Name = "dgvProduct";
			this.dgvProduct.ReadOnly = true;
			this.dgvProduct.Size = new System.Drawing.Size(443, 150);
			this.dgvProduct.TabIndex = 1;
			// 
			// productName
			// 
			this.productName.HeaderText = "Name";
			this.productName.Name = "productName";
			this.productName.ReadOnly = true;
			// 
			// productCategory
			// 
			this.productCategory.HeaderText = "Category";
			this.productCategory.Name = "productCategory";
			this.productCategory.ReadOnly = true;
			// 
			// productPrice
			// 
			this.productPrice.HeaderText = "Price";
			this.productPrice.Name = "productPrice";
			this.productPrice.ReadOnly = true;
			// 
			// productBrandName
			// 
			this.productBrandName.HeaderText = "Brand Id";
			this.productBrandName.Name = "productBrandName";
			this.productBrandName.ReadOnly = true;
			// 
			// tbProductCategory
			// 
			this.tbProductCategory.Location = new System.Drawing.Point(368, 81);
			this.tbProductCategory.Name = "tbProductCategory";
			this.tbProductCategory.Size = new System.Drawing.Size(100, 20);
			this.tbProductCategory.TabIndex = 2;
			// 
			// tbProductBrandName
			// 
			this.tbProductBrandName.Location = new System.Drawing.Point(368, 122);
			this.tbProductBrandName.Name = "tbProductBrandName";
			this.tbProductBrandName.Size = new System.Drawing.Size(100, 20);
			this.tbProductBrandName.TabIndex = 3;
			// 
			// tbProductPrice
			// 
			this.tbProductPrice.Location = new System.Drawing.Point(151, 122);
			this.tbProductPrice.Name = "tbProductPrice";
			this.tbProductPrice.Size = new System.Drawing.Size(100, 20);
			this.tbProductPrice.TabIndex = 4;
			// 
			// tbProductName
			// 
			this.tbProductName.Location = new System.Drawing.Point(151, 81);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.Size = new System.Drawing.Size(100, 20);
			this.tbProductName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(81, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Price:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(289, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Category:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(289, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(39, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Brand:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(684, 108);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Brand Name:";
			// 
			// tbBrandName
			// 
			this.tbBrandName.Location = new System.Drawing.Point(773, 108);
			this.tbBrandName.Name = "tbBrandName";
			this.tbBrandName.Size = new System.Drawing.Size(116, 20);
			this.tbBrandName.TabIndex = 15;
			// 
			// dgvBrand
			// 
			this.dgvBrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBrand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandName,
            this.numberOfProducts});
			this.dgvBrand.Location = new System.Drawing.Point(651, 224);
			this.dgvBrand.Name = "dgvBrand";
			this.dgvBrand.ReadOnly = true;
			this.dgvBrand.Size = new System.Drawing.Size(273, 150);
			this.dgvBrand.TabIndex = 16;
			// 
			// brandName
			// 
			this.brandName.HeaderText = "Brand Name";
			this.brandName.Name = "brandName";
			this.brandName.ReadOnly = true;
			// 
			// numberOfProducts
			// 
			this.numberOfProducts.HeaderText = "Number of products";
			this.numberOfProducts.MinimumWidth = 130;
			this.numberOfProducts.Name = "numberOfProducts";
			this.numberOfProducts.ReadOnly = true;
			this.numberOfProducts.Width = 130;
			// 
			// btnAddProduct
			// 
			this.btnAddProduct.Location = new System.Drawing.Point(151, 175);
			this.btnAddProduct.Name = "btnAddProduct";
			this.btnAddProduct.Size = new System.Drawing.Size(100, 33);
			this.btnAddProduct.TabIndex = 17;
			this.btnAddProduct.Text = "Add Product";
			this.btnAddProduct.UseVisualStyleBackColor = true;
			this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
			// 
			// btnRemoveProduct
			// 
			this.btnRemoveProduct.Location = new System.Drawing.Point(368, 175);
			this.btnRemoveProduct.Name = "btnRemoveProduct";
			this.btnRemoveProduct.Size = new System.Drawing.Size(98, 33);
			this.btnRemoveProduct.TabIndex = 18;
			this.btnRemoveProduct.Text = "Remove Product";
			this.btnRemoveProduct.UseVisualStyleBackColor = true;
			this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
			// 
			// btnAddBrand
			// 
			this.btnAddBrand.Location = new System.Drawing.Point(687, 175);
			this.btnAddBrand.Name = "btnAddBrand";
			this.btnAddBrand.Size = new System.Drawing.Size(99, 33);
			this.btnAddBrand.TabIndex = 19;
			this.btnAddBrand.Text = "Add Brand";
			this.btnAddBrand.UseVisualStyleBackColor = true;
			this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
			// 
			// btnRemoveBrand
			// 
			this.btnRemoveBrand.Location = new System.Drawing.Point(792, 175);
			this.btnRemoveBrand.Name = "btnRemoveBrand";
			this.btnRemoveBrand.Size = new System.Drawing.Size(97, 33);
			this.btnRemoveBrand.TabIndex = 20;
			this.btnRemoveBrand.Text = "Remove Brand";
			this.btnRemoveBrand.UseVisualStyleBackColor = true;
			this.btnRemoveBrand.Click += new System.EventHandler(this.btnRemoveBrand_Click);
			// 
			// btnFilterProducts
			// 
			this.btnFilterProducts.Location = new System.Drawing.Point(136, 480);
			this.btnFilterProducts.Name = "btnFilterProducts";
			this.btnFilterProducts.Size = new System.Drawing.Size(94, 33);
			this.btnFilterProducts.TabIndex = 21;
			this.btnFilterProducts.Text = "Filter Products";
			this.btnFilterProducts.UseVisualStyleBackColor = true;
			this.btnFilterProducts.Click += new System.EventHandler(this.btnFilterProducts_Click);
			// 
			// btnSortProducts
			// 
			this.btnSortProducts.Location = new System.Drawing.Point(347, 480);
			this.btnSortProducts.Name = "btnSortProducts";
			this.btnSortProducts.Size = new System.Drawing.Size(180, 33);
			this.btnSortProducts.TabIndex = 22;
			this.btnSortProducts.Text = "Sort Products";
			this.btnSortProducts.UseVisualStyleBackColor = true;
			this.btnSortProducts.Click += new System.EventHandler(this.btnSortProducts_Click);
			// 
			// tbFilterInput
			// 
			this.tbFilterInput.Location = new System.Drawing.Point(136, 427);
			this.tbFilterInput.Name = "tbFilterInput";
			this.tbFilterInput.Size = new System.Drawing.Size(94, 20);
			this.tbFilterInput.TabIndex = 23;
			// 
			// rbPrice
			// 
			this.rbPrice.AutoSize = true;
			this.rbPrice.Location = new System.Drawing.Point(94, 15);
			this.rbPrice.Name = "rbPrice";
			this.rbPrice.Size = new System.Drawing.Size(48, 17);
			this.rbPrice.TabIndex = 24;
			this.rbPrice.Text = "Price";
			this.rbPrice.UseVisualStyleBackColor = true;
			// 
			// rbName
			// 
			this.rbName.AutoSize = true;
			this.rbName.Checked = true;
			this.rbName.Location = new System.Drawing.Point(6, 15);
			this.rbName.Name = "rbName";
			this.rbName.Size = new System.Drawing.Size(52, 17);
			this.rbName.TabIndex = 25;
			this.rbName.TabStop = true;
			this.rbName.Text = "Name";
			this.rbName.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(261, 395);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(58, 13);
			this.label6.TabIndex = 26;
			this.label6.Text = "Sort Type:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(261, 449);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Sort Direction:";
			// 
			// rbAscending
			// 
			this.rbAscending.AutoSize = true;
			this.rbAscending.Checked = true;
			this.rbAscending.Location = new System.Drawing.Point(6, 15);
			this.rbAscending.Name = "rbAscending";
			this.rbAscending.Size = new System.Drawing.Size(74, 17);
			this.rbAscending.TabIndex = 28;
			this.rbAscending.TabStop = true;
			this.rbAscending.Text = "Ascending";
			this.rbAscending.UseVisualStyleBackColor = true;
			// 
			// rbDescending
			// 
			this.rbDescending.AutoSize = true;
			this.rbDescending.Location = new System.Drawing.Point(94, 15);
			this.rbDescending.Name = "rbDescending";
			this.rbDescending.Size = new System.Drawing.Size(80, 17);
			this.rbDescending.TabIndex = 29;
			this.rbDescending.TabStop = true;
			this.rbDescending.Text = "Descending";
			this.rbDescending.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(81, 430);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(34, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Price:";
			// 
			// gbSortType
			// 
			this.gbSortType.Controls.Add(this.rbName);
			this.gbSortType.Controls.Add(this.rbPrice);
			this.gbSortType.Location = new System.Drawing.Point(347, 380);
			this.gbSortType.Name = "gbSortType";
			this.gbSortType.Size = new System.Drawing.Size(180, 44);
			this.gbSortType.TabIndex = 31;
			this.gbSortType.TabStop = false;
			// 
			// gbSortDirection
			// 
			this.gbSortDirection.Controls.Add(this.rbAscending);
			this.gbSortDirection.Controls.Add(this.rbDescending);
			this.gbSortDirection.Location = new System.Drawing.Point(347, 430);
			this.gbSortDirection.Name = "gbSortDirection";
			this.gbSortDirection.Size = new System.Drawing.Size(180, 44);
			this.gbSortDirection.TabIndex = 32;
			this.gbSortDirection.TabStop = false;
			// 
			// btnSordBrands
			// 
			this.btnSordBrands.Location = new System.Drawing.Point(725, 480);
			this.btnSordBrands.Name = "btnSordBrands";
			this.btnSordBrands.Size = new System.Drawing.Size(113, 33);
			this.btnSordBrands.TabIndex = 33;
			this.btnSordBrands.Text = "Sort Brands";
			this.btnSordBrands.UseVisualStyleBackColor = true;
			this.btnSordBrands.Click += new System.EventHandler(this.btnSordBrands_Click);
			// 
			// gbSortBrands
			// 
			this.gbSortBrands.Controls.Add(this.rbSortBrandsNumber);
			this.gbSortBrands.Controls.Add(this.rbSortBrandsName);
			this.gbSortBrands.Location = new System.Drawing.Point(719, 385);
			this.gbSortBrands.Name = "gbSortBrands";
			this.gbSortBrands.Size = new System.Drawing.Size(205, 37);
			this.gbSortBrands.TabIndex = 34;
			this.gbSortBrands.TabStop = false;
			// 
			// rbSortBrandsNumber
			// 
			this.rbSortBrandsNumber.AutoSize = true;
			this.rbSortBrandsNumber.Location = new System.Drawing.Point(85, 12);
			this.rbSortBrandsNumber.Name = "rbSortBrandsNumber";
			this.rbSortBrandsNumber.Size = new System.Drawing.Size(120, 17);
			this.rbSortBrandsNumber.TabIndex = 1;
			this.rbSortBrandsNumber.Text = "Number of products";
			this.rbSortBrandsNumber.UseVisualStyleBackColor = true;
			// 
			// rbSortBrandsName
			// 
			this.rbSortBrandsName.AutoSize = true;
			this.rbSortBrandsName.Checked = true;
			this.rbSortBrandsName.Location = new System.Drawing.Point(6, 12);
			this.rbSortBrandsName.Name = "rbSortBrandsName";
			this.rbSortBrandsName.Size = new System.Drawing.Size(52, 17);
			this.rbSortBrandsName.TabIndex = 0;
			this.rbSortBrandsName.TabStop = true;
			this.rbSortBrandsName.Text = "Name";
			this.rbSortBrandsName.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(648, 399);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(58, 13);
			this.label10.TabIndex = 35;
			this.label10.Text = "Sort Type:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(648, 449);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 13);
			this.label11.TabIndex = 36;
			this.label11.Text = "Direction:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbBrandDirectionDesc);
			this.groupBox1.Controls.Add(this.rbBrandDirectionAsc);
			this.groupBox1.Location = new System.Drawing.Point(719, 437);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(170, 37);
			this.groupBox1.TabIndex = 37;
			this.groupBox1.TabStop = false;
			// 
			// rbBrandDirectionDesc
			// 
			this.rbBrandDirectionDesc.AutoSize = true;
			this.rbBrandDirectionDesc.Location = new System.Drawing.Point(85, 12);
			this.rbBrandDirectionDesc.Name = "rbBrandDirectionDesc";
			this.rbBrandDirectionDesc.Size = new System.Drawing.Size(80, 17);
			this.rbBrandDirectionDesc.TabIndex = 1;
			this.rbBrandDirectionDesc.Text = "Descending";
			this.rbBrandDirectionDesc.UseVisualStyleBackColor = true;
			// 
			// rbBrandDirectionAsc
			// 
			this.rbBrandDirectionAsc.AutoSize = true;
			this.rbBrandDirectionAsc.Checked = true;
			this.rbBrandDirectionAsc.Location = new System.Drawing.Point(6, 12);
			this.rbBrandDirectionAsc.Name = "rbBrandDirectionAsc";
			this.rbBrandDirectionAsc.Size = new System.Drawing.Size(74, 17);
			this.rbBrandDirectionAsc.TabIndex = 0;
			this.rbBrandDirectionAsc.TabStop = true;
			this.rbBrandDirectionAsc.Text = "Ascending";
			this.rbBrandDirectionAsc.UseVisualStyleBackColor = true;
			// 
			// Linq
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1019, 525);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.gbSortBrands);
			this.Controls.Add(this.btnSordBrands);
			this.Controls.Add(this.gbSortDirection);
			this.Controls.Add(this.gbSortType);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbFilterInput);
			this.Controls.Add(this.btnSortProducts);
			this.Controls.Add(this.btnFilterProducts);
			this.Controls.Add(this.btnRemoveBrand);
			this.Controls.Add(this.btnAddBrand);
			this.Controls.Add(this.btnRemoveProduct);
			this.Controls.Add(this.btnAddProduct);
			this.Controls.Add(this.dgvBrand);
			this.Controls.Add(this.tbBrandName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbProductName);
			this.Controls.Add(this.tbProductPrice);
			this.Controls.Add(this.tbProductBrandName);
			this.Controls.Add(this.tbProductCategory);
			this.Controls.Add(this.dgvProduct);
			this.Controls.Add(this.label1);
			this.Name = "Linq";
			this.Text = "Linq";
			((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBrand)).EndInit();
			this.gbSortType.ResumeLayout(false);
			this.gbSortType.PerformLayout();
			this.gbSortDirection.ResumeLayout(false);
			this.gbSortDirection.PerformLayout();
			this.gbSortBrands.ResumeLayout(false);
			this.gbSortBrands.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvProduct;
		private System.Windows.Forms.TextBox tbProductCategory;
		private System.Windows.Forms.TextBox tbProductBrandName;
		private System.Windows.Forms.TextBox tbProductPrice;
		private System.Windows.Forms.TextBox tbProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbBrandName;
		private System.Windows.Forms.DataGridView dgvBrand;
		private System.Windows.Forms.Button btnAddProduct;
		private System.Windows.Forms.Button btnRemoveProduct;
		private System.Windows.Forms.Button btnAddBrand;
		private System.Windows.Forms.Button btnRemoveBrand;
		private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberOfProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn productName;
		private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn productBrandName;
		private System.Windows.Forms.Button btnFilterProducts;
		private System.Windows.Forms.Button btnSortProducts;
		private System.Windows.Forms.TextBox tbFilterInput;
		private System.Windows.Forms.RadioButton rbPrice;
		private System.Windows.Forms.RadioButton rbName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RadioButton rbAscending;
		private System.Windows.Forms.RadioButton rbDescending;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox gbSortType;
		private System.Windows.Forms.GroupBox gbSortDirection;
		private System.Windows.Forms.Button btnSordBrands;
		private System.Windows.Forms.GroupBox gbSortBrands;
		private System.Windows.Forms.RadioButton rbSortBrandsNumber;
		private System.Windows.Forms.RadioButton rbSortBrandsName;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rbBrandDirectionDesc;
		private System.Windows.Forms.RadioButton rbBrandDirectionAsc;
	}
}