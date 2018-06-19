using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThriftShopContext;


namespace CPL_gui
{
	public partial class Linq : Form
	{
		private bool statusOfFilterOrSort = false;

		public Linq()
		{
			InitializeComponent();
			var db = new ThriftShopContext.ThriftShopDataContext();
			ShowProducts(db.Products);
			IQueryable<Brand> result = from brand in db.Brands
												orderby brand.Products.Count()
												select brand;
			ShowBrands(result);
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			String name = tbProductName.Text;
			String category = tbProductCategory.Text;
			String brandName = tbProductBrandName.Text;
			String price = tbProductPrice.Text;
			if (!(name == "" || category == "" || brandName == "" || price == ""))
			{
				var db = new ThriftShopContext.ThriftShopDataContext();
				if (!CheckProductId(name))
				{
					if (CheckBrandId(brandName))
					{
						if (statusOfFilterOrSort)
						{
							ShowProducts(db.Products);
							statusOfFilterOrSort = false;
						}
						var brand = db.Brands.First(p => p.BrandName == brandName);
						double parsePrice = double.Parse(price);
						Product product = new ThriftShopContext.Product();
						product.ProductName = name;
						product.ProductCategory = category;
						product.ProductPrice = parsePrice;
						product.Brand = brand;
						db.Products.InsertOnSubmit(product);
						db.SubmitChanges();
						dgvProduct.Rows.Add(name, category, price, brandName);
						IQueryable<Brand> result = from brandI in db.Brands
															orderby brandI.Products.Count()
															select brandI;
						ShowBrands(result);
						tbProductBrandName.Clear();
						tbProductCategory.Clear();
						tbProductName.Clear();
						tbProductPrice.Clear();
					}
					else
					{
						tbProductBrandName.Text = "Brand Not Exist";
						tbProductBrandName.ForeColor = Color.Red;
					}
				}
				else
				{
					tbProductName.Text = "Product is already exist";
					tbProductName.ForeColor = Color.Red;
				}
			}
		}

		private void btnAddBrand_Click(object sender, EventArgs e)
		{
			String Name = tbBrandName.Text;
			if (Name != "")
			{
				if (!CheckBrandId(Name))
				{
					var db = new ThriftShopContext.ThriftShopDataContext();
					Brand brand = new ThriftShopContext.Brand();
					brand.BrandName = Name;
					db.Brands.InsertOnSubmit(brand);
					db.SubmitChanges();
					dgvBrand.Rows.Add(Name, "0");
				}
				else
				{
					tbBrandName.Text = "Brand is already exist";
					tbBrandName.ForeColor = Color.Red;
				}
			}
		}

		private void btnRemoveProduct_Click(object sender, EventArgs e)
		{
			int currentRow = dgvProduct.CurrentRow.Index;
			DataGridViewRow row = dgvProduct.CurrentRow;
			if (row != null)
			{
				if (row.Cells["productName"].Value != null)
				{
					String productName = row.Cells["productName"].Value.ToString();
					var db = new ThriftShopContext.ThriftShopDataContext();
					db.Products.DeleteOnSubmit(db.Products.Where(p => p.ProductName == productName).First());
					db.SubmitChanges();
					dgvProduct.Rows.RemoveAt(currentRow);
					IQueryable<Brand> result = from brand in db.Brands
														orderby brand.Products.Count()
														select brand;
					ShowBrands(result);
				}
			}
		}

		private void btnRemoveBrand_Click(object sender, EventArgs e)
		{
			int currentRow = dgvBrand.CurrentRow.Index;
			DataGridViewRow row = dgvBrand.CurrentRow;
			if (row != null)
			{
				if (row.Cells["brandName"].Value != null)
				{
					String brandName = row.Cells["brandName"].Value.ToString();
					var db = new ThriftShopContext.ThriftShopDataContext();
					db.Products.DeleteAllOnSubmit(db.Products.Where(p => p.Brand.BrandName == brandName));
					db.SubmitChanges();
					db.Brands.DeleteOnSubmit(db.Brands.Where(p => p.BrandName == brandName).First());
					db.SubmitChanges();
					dgvBrand.Rows.RemoveAt(currentRow);
					ShowProducts(db.Products);
				}
			}
		}

		private void btnFilterProducts_Click(object sender, EventArgs e)
		{
			double price;
			price = double.Parse(tbFilterInput.Text.ToString());
			var db = new ThriftShopContext.ThriftShopDataContext();
			var result = db.Products.Where<Product>(p => p.ProductPrice <= price);
			/*
			var result = from p in db.Products
							 where p.ProductPrice <= price
							 select p;
			*/
			ShowProducts(result);
			statusOfFilterOrSort = true;
			tbFilterInput.Clear();
		}

		private void btnSortProducts_Click(object sender, EventArgs e)
		{
			var db = new ThriftShopContext.ThriftShopDataContext();
			IQueryable<Product> result = null;
			if (rbName.Checked && rbAscending.Checked)
			{
				result = db.Products.OrderBy(p => p.ProductName);
			}
			else if (rbName.Checked && rbDescending.Checked)
			{
				result = db.Products.OrderByDescending(p => p.ProductName);
			}
			else if (rbPrice.Checked && rbAscending.Checked)
			{
				result = db.Products.OrderBy(p => p.ProductPrice);
			}
			else if (rbPrice.Checked && rbDescending.Checked)
			{
				result = db.Products.OrderByDescending(p => p.ProductPrice);
			}
			else
			{
				return;
			}
			ShowProducts(result);
		}

		private void btnSordBrands_Click(object sender, EventArgs e)
		{
			var db = new ThriftShopContext.ThriftShopDataContext();
			IQueryable<Brand> result = null;
			if (rbSortBrandsName.Checked && rbBrandDirectionAsc.Checked)
			{
				result = from brand in db.Brands
							orderby brand.BrandName ascending
							select brand;
			}
			else if (rbSortBrandsNumber.Checked && rbBrandDirectionAsc.Checked)
			{
				result = from brand in db.Brands
							orderby brand.Products.Count() ascending
							select brand;
			}
			else if (rbSortBrandsName.Checked && rbBrandDirectionDesc.Checked)
			{
				result = from brand in db.Brands
							orderby brand.BrandName descending
							select brand;
			}
			else if (rbSortBrandsNumber.Checked && rbBrandDirectionDesc.Checked)
			{
				result = from brand in db.Brands
							orderby brand.Products.Count() descending
							select brand;
			}
			else
			{
				return;
			}
			ShowBrands(result);
		}

		private void ShowBrands(IQueryable<Brand> result)
		{
			dgvBrand.Rows.Clear();
			foreach (Brand instance in result)
			{
				dgvBrand.Rows.Add(instance.BrandName, instance.Products.Count());
			}
		}

		private void ShowProducts(IQueryable<Product> products)
		{
			dgvProduct.Rows.Clear();
			foreach (Product item in products)
			{
				dgvProduct.Rows.Add(item.ProductName, item.ProductCategory, item.ProductPrice, item.Brand.BrandName);
			}
		}

		private bool CheckBrandId(String Name)
		{
			var db = new ThriftShopContext.ThriftShopDataContext();
			int result = db.Brands.Count(p => p.BrandName == Name);
			if (result == 0)
			{
				return false;
			}
			return true;
		}

		private bool CheckProductId(String Id)
		{
			var db = new ThriftShopContext.ThriftShopDataContext();
			int result = db.Products.Count(p => p.ProductName == Id);
			if (result == 0)
			{
				return false;
			}
			return true;
		}
	}
}

