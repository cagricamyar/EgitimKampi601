using EgitimKampi601.Entities;
using EgitimKampi601.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKampi601
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		CustomerOperations customerOperations = new CustomerOperations();
		private void btnCustomerCreate_Click(object sender, EventArgs e)
		{
			var customer = new Customer()
			{
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
				CustomerCity = txtCustomerCity.Text,
				CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text),
			};

			customerOperations.AddCustomer(customer);
			MessageBox.Show("Musteri Ekleme Basarili", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnCustomerList_Click(object sender, EventArgs e)
		{
			List<Customer> customerList = customerOperations.GetAllCustomer();
			dataGridView1.DataSource = customerList;
		}

		private void btnCustomerDelete_Click(object sender, EventArgs e)
		{
			string customerId = txtCustomerId.Text;
			customerOperations.DeleteCustomer(customerId);
			MessageBox.Show("Musteri Basariyla Silindi");
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			string customerId = txtCustomerId.Text;
			var updatedCustomer = new Customer
			{
				CustomerId = customerId,
				CustomerName = txtCustomerName.Text,
				CustomerSurname = txtCustomerSurname.Text,
				CustomerBalance = decimal.Parse(txtCustomerBalance.Text),
				CustomerCity = txtCustomerCity.Text,
				CustomerShoppingCount = int.Parse(txtCustomerShoppingCount.Text)
			};
			customerOperations.UpdateCustomer(updatedCustomer);
			MessageBox.Show("Musteri Basariyla Guncellendi");
		}

		private void btnGetByCustomerId_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;
			Customer customers = customerOperations.GetCustomerById(id);
			dataGridView1.DataSource = new List<Customer>
			{
				customers
			};
		}
	}
}
