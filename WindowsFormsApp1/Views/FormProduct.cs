using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Helpers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class FormProduct : Form
    {
        string URI = "http://localhost:8000/api/product";

        public FormProduct()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void btn_getAllProducts_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void btn_updateProduct_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private async void GetAllProducts()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI))
            {
                if (response.IsSuccessStatusCode)
                {
                    dataGridView1.DataSource = JsonConvert.DeserializeObject<Product[]>(await response.Content.ReadAsStringAsync()).ToList();
                    textBox1.Text = await response.Content.ReadAsStringAsync();
                }
            }
        }

        private async void AddProduct()
        {
            Product p = new Product();
            p.Name = "Rolex";
            //p.Category = "Watch";
            p.Price = 98979836878;

            var serializedProduct = JsonConvert.SerializeObject(p);
            HttpContent content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsync(URI, content))
            {
                textBox1.Text = await response.Content.ReadAsStringAsync();
            }
            GetAllProducts(); // if error dont do this
        }


        private async void UpdateProduct()
        {
            Product p = new Product();
            p.Id = 5;
            p.Name = "Rolex";
            //p.Category = "Watch";
            p.Price = 140000; //changed the price

            var serializedProduct = JsonConvert.SerializeObject(p);
            var content = new StringContent(serializedProduct, Encoding.UTF8, "application/json");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsync(String.Format("{0}/{1}", URI, p.Id), content))
            {
                textBox1.Text = await response.Content.ReadAsStringAsync();
            }
            GetAllProducts();
        }


        private async void DeleteProduct()
        {
            Product p = new Product();
            p.Id = 7;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.DeleteAsync(String.Format("{0}/{1}", URI, p.Id)))
            {
                textBox1.Text = await response.Content.ReadAsStringAsync();
            }
            GetAllProducts();
        }

        private async void btn_getById_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Id = 5;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(String.Format("{0}/{1}", URI, p.Id)))
            {
                if (response.IsSuccessStatusCode)
                {
                    textBox1.Text = await response.Content.ReadAsStringAsync();
                }
            }
        }
    }
}
