using CSharpEgitimKampi501.Dtos;
using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampı501
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection connection = new SqlConnection("Server=BERAT\\SQLEXPRESS; initial Catalog=EgitimKampi501Db; integrated security=true");


		private async void button2_Click(object sender, EventArgs e)
		{
			string query = "insert into ProductTbl(ProductName,ProductStock,ProductPrice,PrductCategory) values (@productName, @productStock, @productPrice, @prductCategory)";
			var parameters = new DynamicParameters();
			parameters.Add("@productName", txtProductName.Text);
			parameters.Add("@productStock", txtProductStock.Text);
			parameters.Add("@productPrice", txtProductPrice.Text);
			parameters.Add("@prductCategory", txtCategory.Text);

			await  connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Yeni Kitap Ekleme İşlemi Başarılı");
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			string query = "Select Count(*) From ProductTbl";
			var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query);
			label7.Text = productTotalCount.ToString();

			string query2 = "Select ProductName From ProductTbl Where ProductPrice=(Select Max(ProductPrice) From ProductTbl)";
			var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
			lblMaxProductName.Text = maxPriceProductName.ToString();

			string query3 = "Select Count(Distinct(ProductCategory)) From ProductTbl";
			var disctincProductCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
			lblDistinctCategoryCount.Text = disctincProductCount.ToString();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			string query = "Select * From ProductTbl";
			var values = await connection.QueryAsync<ResultProductDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnDelete_Click(object sender, EventArgs e)
		{
			string query = "Delete From ProductTbl Where ProductId=@productId";
			var parameters = new DynamicParameters();
			parameters.Add("@productId", txtProductId.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Kitap Silme İşlemi Başarılı");
		}

		private async void btnUpdate_Click(object sender, EventArgs e)
		{
			string query = "Update ProductTbl Set ProductName=@productName,productPrice=@productPrice,ProductStock=@productStock, ProductCategory=@productCategory where ProductId=@productId";
			var parameters = new DynamicParameters();
			parameters.Add("@productName", txtProductName.Text);
			parameters.Add("@productStock", txtProductStock.Text);
			parameters.Add("@productPrice", txtProductPrice.Text);
			parameters.Add("@productCategory", txtCategory.Text);
			parameters.Add("@productId", txtProductId.Text);
			await connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Kitap Güncelleme İşlemi Başarılı Bir Şekilde Yapıldı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
