﻿namespace EgitimKampi601
{
	partial class FrmCustomer
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
			this.btnGetByCustomerId = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCustomerUpdate = new System.Windows.Forms.Button();
			this.btnCustomerDelete = new System.Windows.Forms.Button();
			this.btnCustomerAdd = new System.Windows.Forms.Button();
			this.btnCustomerList = new System.Windows.Forms.Button();
			this.txtCustomerCity = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCustomerSurname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCustomerId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetByCustomerId
			// 
			this.btnGetByCustomerId.BackColor = System.Drawing.Color.LightSalmon;
			this.btnGetByCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetByCustomerId.Location = new System.Drawing.Point(150, 264);
			this.btnGetByCustomerId.Name = "btnGetByCustomerId";
			this.btnGetByCustomerId.Size = new System.Drawing.Size(100, 23);
			this.btnGetByCustomerId.TabIndex = 35;
			this.btnGetByCustomerId.Text = "ID\'ye gore Getir";
			this.btnGetByCustomerId.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(256, 31);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(557, 374);
			this.dataGridView1.TabIndex = 34;
			// 
			// btnCustomerUpdate
			// 
			this.btnCustomerUpdate.BackColor = System.Drawing.Color.LightSalmon;
			this.btnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerUpdate.Location = new System.Drawing.Point(150, 235);
			this.btnCustomerUpdate.Name = "btnCustomerUpdate";
			this.btnCustomerUpdate.Size = new System.Drawing.Size(100, 23);
			this.btnCustomerUpdate.TabIndex = 33;
			this.btnCustomerUpdate.Text = "Güncelle";
			this.btnCustomerUpdate.UseVisualStyleBackColor = false;
			this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
			// 
			// btnCustomerDelete
			// 
			this.btnCustomerDelete.BackColor = System.Drawing.Color.LightSalmon;
			this.btnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerDelete.Location = new System.Drawing.Point(150, 206);
			this.btnCustomerDelete.Name = "btnCustomerDelete";
			this.btnCustomerDelete.Size = new System.Drawing.Size(100, 23);
			this.btnCustomerDelete.TabIndex = 32;
			this.btnCustomerDelete.Text = "Sil";
			this.btnCustomerDelete.UseVisualStyleBackColor = false;
			this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
			// 
			// btnCustomerAdd
			// 
			this.btnCustomerAdd.BackColor = System.Drawing.Color.LightSalmon;
			this.btnCustomerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerAdd.Location = new System.Drawing.Point(150, 175);
			this.btnCustomerAdd.Name = "btnCustomerAdd";
			this.btnCustomerAdd.Size = new System.Drawing.Size(100, 23);
			this.btnCustomerAdd.TabIndex = 31;
			this.btnCustomerAdd.Text = "Ekle";
			this.btnCustomerAdd.UseVisualStyleBackColor = false;
			this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
			// 
			// btnCustomerList
			// 
			this.btnCustomerList.BackColor = System.Drawing.Color.LightSalmon;
			this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCustomerList.Location = new System.Drawing.Point(150, 146);
			this.btnCustomerList.Name = "btnCustomerList";
			this.btnCustomerList.Size = new System.Drawing.Size(100, 23);
			this.btnCustomerList.TabIndex = 30;
			this.btnCustomerList.Text = "Listele";
			this.btnCustomerList.UseVisualStyleBackColor = false;
			this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
			// 
			// txtCustomerCity
			// 
			this.txtCustomerCity.Location = new System.Drawing.Point(150, 109);
			this.txtCustomerCity.Name = "txtCustomerCity";
			this.txtCustomerCity.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerCity.TabIndex = 25;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(73, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 13);
			this.label3.TabIndex = 24;
			this.label3.Text = "Müşteri Şehir:";
			// 
			// txtCustomerSurname
			// 
			this.txtCustomerSurname.Location = new System.Drawing.Point(150, 83);
			this.txtCustomerSurname.Name = "txtCustomerSurname";
			this.txtCustomerSurname.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerSurname.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(65, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Müşteri Soyadı:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(150, 57);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerName.TabIndex = 21;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "Müşteri Adı:";
			// 
			// txtCustomerId
			// 
			this.txtCustomerId.Location = new System.Drawing.Point(150, 31);
			this.txtCustomerId.Name = "txtCustomerId";
			this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
			this.txtCustomerId.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(88, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 18;
			this.label1.Text = "Müşteri Id:";
			// 
			// FrmCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(881, 452);
			this.Controls.Add(this.btnGetByCustomerId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCustomerUpdate);
			this.Controls.Add(this.btnCustomerDelete);
			this.Controls.Add(this.btnCustomerAdd);
			this.Controls.Add(this.btnCustomerList);
			this.Controls.Add(this.txtCustomerCity);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCustomerSurname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCustomerId);
			this.Controls.Add(this.label1);
			this.Name = "FrmCustomer";
			this.Text = "FrmCustomer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetByCustomerId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCustomerUpdate;
		private System.Windows.Forms.Button btnCustomerDelete;
		private System.Windows.Forms.Button btnCustomerAdd;
		private System.Windows.Forms.Button btnCustomerList;
		private System.Windows.Forms.TextBox txtCustomerCity;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCustomerSurname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCustomerId;
		private System.Windows.Forms.Label label1;
	}
}