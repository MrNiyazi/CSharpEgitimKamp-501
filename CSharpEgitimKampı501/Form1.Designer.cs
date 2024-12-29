namespace CSharpEgitimKampı501
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtProductId = new System.Windows.Forms.TextBox();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.txtProductStock = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.lblTotalProductCunt = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblMaxProductName = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblDistinctCategoryCount = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(259, 24);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(737, 366);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Urun Id";
			// 
			// txtProductId
			// 
			this.txtProductId.Location = new System.Drawing.Point(87, 24);
			this.txtProductId.Name = "txtProductId";
			this.txtProductId.Size = new System.Drawing.Size(134, 22);
			this.txtProductId.TabIndex = 3;
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(87, 56);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(134, 22);
			this.txtProductName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ürün Adı";
			// 
			// txtProductPrice
			// 
			this.txtProductPrice.Location = new System.Drawing.Point(87, 97);
			this.txtProductPrice.Name = "txtProductPrice";
			this.txtProductPrice.Size = new System.Drawing.Size(134, 22);
			this.txtProductPrice.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Fiyat";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(23, 209);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(198, 40);
			this.button1.TabIndex = 8;
			this.button1.Text = "Listele";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtProductStock
			// 
			this.txtProductStock.Location = new System.Drawing.Point(87, 135);
			this.txtProductStock.Name = "txtProductStock";
			this.txtProductStock.Size = new System.Drawing.Size(134, 22);
			this.txtProductStock.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 9;
			this.label4.Text = "Stok";
			// 
			// txtCategory
			// 
			this.txtCategory.Location = new System.Drawing.Point(87, 170);
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.Size = new System.Drawing.Size(134, 22);
			this.txtCategory.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 16);
			this.label5.TabIndex = 11;
			this.label5.Text = "Kategori";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(23, 255);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(198, 40);
			this.button2.TabIndex = 13;
			this.button2.Text = "Ekle";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(23, 301);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(198, 40);
			this.btnDelete.TabIndex = 14;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(23, 347);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(198, 40);
			this.btnUpdate.TabIndex = 15;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// lblTotalProductCunt
			// 
			this.lblTotalProductCunt.AutoSize = true;
			this.lblTotalProductCunt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTotalProductCunt.Location = new System.Drawing.Point(8, 460);
			this.lblTotalProductCunt.Name = "lblTotalProductCunt";
			this.lblTotalProductCunt.Size = new System.Drawing.Size(294, 32);
			this.lblTotalProductCunt.TabIndex = 16;
			this.lblTotalProductCunt.Text = "Toplam Kitap Sayısı:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(308, 460);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 32);
			this.label7.TabIndex = 17;
			this.label7.Text = "0";
			// 
			// lblMaxProductName
			// 
			this.lblMaxProductName.AutoSize = true;
			this.lblMaxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMaxProductName.Location = new System.Drawing.Point(271, 509);
			this.lblMaxProductName.Name = "lblMaxProductName";
			this.lblMaxProductName.Size = new System.Drawing.Size(31, 32);
			this.lblMaxProductName.TabIndex = 19;
			this.lblMaxProductName.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(12, 509);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(234, 32);
			this.label8.TabIndex = 18;
			this.label8.Text = "En Pahalı Kitap:";
			// 
			// lblDistinctCategoryCount
			// 
			this.lblDistinctCategoryCount.AutoSize = true;
			this.lblDistinctCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblDistinctCategoryCount.Location = new System.Drawing.Point(312, 571);
			this.lblDistinctCategoryCount.Name = "lblDistinctCategoryCount";
			this.lblDistinctCategoryCount.Size = new System.Drawing.Size(31, 32);
			this.lblDistinctCategoryCount.TabIndex = 21;
			this.lblDistinctCategoryCount.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(12, 571);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(308, 32);
			this.label9.TabIndex = 20;
			this.label9.Text = "Kategori Kitap Sayısı:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(1008, 820);
			this.Controls.Add(this.lblDistinctCategoryCount);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lblMaxProductName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblTotalProductCunt);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtCategory);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtProductStock);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtProductPrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtProductName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProductId);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProductId;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtProductStock;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCategory;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label lblTotalProductCunt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblMaxProductName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblDistinctCategoryCount;
		private System.Windows.Forms.Label label9;
	}
}

