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
			string query = "insert into ProductTbl(ProductName,ProductStock,ProductPrice,ProductCategory) values (@productName, @productStock, @productPrice, @productCategory)";
			var parameters = new DynamicParameters();
			parameters.Add("@productName", txtProductName.Text);
			parameters.Add("@productStock", txtProductStock.Text);
			parameters.Add("@productPrice", txtProductPrice.Text);
			parameters.Add("@productCategory", txtCategory.Text);

			await  connection.ExecuteAsync(query, parameters);
			MessageBox.Show("Yeni Kitap Ekleme İşlemi Başarılı");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private async void button1_Click(object sender, EventArgs e)
		{
			string query = "Select * From ProductTbl";
			var values = await connection.QueryAsync<ResultProductDto>(query);
			dataGridView1.DataSource = values;
		}


	}
}
