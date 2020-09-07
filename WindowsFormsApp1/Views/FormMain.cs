using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using WindowsFormsApp1.Helpers;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class FormMain : Form
    {
        string URI = "http://localhost:8000/api/";
        public FormMain()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
            if(dataGridView1.DataSource == null)
            {
                GetAllProducts();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedTab == Products)
            {
                if (dataGridView1.DataSource == null)
                {
                    GetAllProducts();
                }
            }
            else if (tabControl1.SelectedTab == Categories)
            {
                if (dataGridView2.DataSource == null)
                {
                    GetAllCategories();
                }
            }
            else if (tabControl1.SelectedTab == Suppliers)
            {
                if (dataGridView3.DataSource == null)
                {
                    GetAllSuppliers();
                }
            }
            else if (tabControl1.SelectedTab == Employees)
            {
                if (dataGridView4.DataSource == null)
                {
                    GetAllEmployees();
                }
            }
            else if (tabControl1.SelectedTab == Orders)
            {
                if (dataGridView5.DataSource == null)
                {
                    GetAllOrders();
                }
            }
            else if (tabControl1.SelectedTab == OrderItems)
            {
                if (dataGridView6.DataSource == null)
                {
                    GetAllOrderItems();
                }
            }
        }

        private async void GetAllProducts()
        {
            try 
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "product"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<Product[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if(list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView1.DataSource = list;
                        }
                    }
                }
            }
            catch(HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);//e.ToString()
            }
        }

        private async void GetAllCategories()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "category"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<Category[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView2.DataSource = list;
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);
            }
        }

        private async void GetAllSuppliers()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "supplier"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<Supplier[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView3.DataSource = list;
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);
            }
        }

        private async void GetAllEmployees()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "employee"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<Employee[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView4.DataSource = list;
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);
            }
        }

        private async void GetAllOrders()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "order"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<Order[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView5.DataSource = list;
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);
            }
        }

        private async void GetAllOrderItems()
        {
            try
            {
                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(URI + "orderitem"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var list = JsonConvert.DeserializeObject<OrderItem[]>(await response.Content.ReadAsStringAsync()).ToList();
                        if (list.Count == 0)
                        {
                            MessageBox.Show("List is Empty", "Empty List");
                        }
                        else
                        {
                            dataGridView6.DataSource = list;
                        }
                    }
                }
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show("Message : " + e.Message, e.Message);
            }
        }
    }
}
