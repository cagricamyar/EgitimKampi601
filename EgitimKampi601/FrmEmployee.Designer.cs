﻿namespace EgitimKampi601
{
	partial class FrmEmployee
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtEmployeePrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.LightSalmon;
			this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetById.Location = new System.Drawing.Point(37, 286);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(175, 23);
			this.btnGetById.TabIndex = 49;
			this.btnGetById.Text = "ID\'ye gore Getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(217, 38);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(557, 374);
			this.dataGridView1.TabIndex = 48;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.LightSalmon;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(37, 257);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(175, 23);
			this.btnUpdate.TabIndex = 47;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.LightSalmon;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(37, 228);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(175, 23);
			this.btnDelete.TabIndex = 46;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.LightSalmon;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(37, 197);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(175, 23);
			this.btnCreate.TabIndex = 45;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.LightSalmon;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(37, 168);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(175, 23);
			this.btnList.TabIndex = 44;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtEmployeePrice
			// 
			this.txtEmployeePrice.Location = new System.Drawing.Point(111, 116);
			this.txtEmployeePrice.Name = "txtEmployeePrice";
			this.txtEmployeePrice.Size = new System.Drawing.Size(100, 20);
			this.txtEmployeePrice.TabIndex = 43;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 13);
			this.label3.TabIndex = 42;
			this.label3.Text = "Personel Maaş:";
			// 
			// txtEmployeeSurname
			// 
			this.txtEmployeeSurname.Location = new System.Drawing.Point(111, 90);
			this.txtEmployeeSurname.Name = "txtEmployeeSurname";
			this.txtEmployeeSurname.Size = new System.Drawing.Size(100, 20);
			this.txtEmployeeSurname.TabIndex = 41;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 40;
			this.label4.Text = "Personel Soyadı:";
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(111, 64);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
			this.txtEmployeeName.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 38;
			this.label2.Text = "Personel Adı:";
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.Location = new System.Drawing.Point(111, 38);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
			this.txtEmployeeId.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 36;
			this.label1.Text = "Personel Id:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(34, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 13);
			this.label5.TabIndex = 50;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(34, 149);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 51;
			this.label6.Text = "Departman:";
			// 
			// cmbEmployeeDepartment
			// 
			this.cmbEmployeeDepartment.FormattingEnabled = true;
			this.cmbEmployeeDepartment.Location = new System.Drawing.Point(111, 141);
			this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
			this.cmbEmployeeDepartment.Size = new System.Drawing.Size(100, 21);
			this.cmbEmployeeDepartment.TabIndex = 52;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cmbEmployeeDepartment);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtEmployeePrice);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmployeeSurname);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmployeeId);
			this.Controls.Add(this.label1);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtEmployeePrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmployeeSurname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmployeeId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
	}
}