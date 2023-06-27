using hotel_management_app.Common;
using hotel_management_app.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_app.Forms.CustomerManagement
{
    public partial class CustomerManagementForm : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<CustomerModel> _customerModelList = new List<CustomerModel>();

        public CustomerManagementForm()
        {
            InitializeComponent();
        }

        private void CustomerManagementForm_Load(object sender, EventArgs e)
        {
            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set auth
            var token = Properties.Settings.Default.token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            DGVInitial();
            setDataCustomer();
        }

        /// <summary>
        /// DGV initial
        /// </summary>
        private void DGVInitial()
        {
            dgvCustomer.ReadOnly = true;
        }

        private void setDataCustomer()
        {
            // call api
            HttpResponseMessage response = _client.GetAsync("api/CustomerManagement/Get?limit=10&page=1&name=" + txtName.Text).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                dynamic json = JsonConvert.DeserializeObject(content);
                _customerModelList = JsonConvert.DeserializeObject<List<CustomerModel>>(json.data.data.ToString());

                lbTotal.Text = "Tổng: " + json.data.total.ToString() + " Khách hàng";
            }

            dgvCustomer.Rows.Clear();
            dgvCustomer.Refresh();
            foreach (var customerModel in _customerModelList)
            {
                dgvCustomer.Rows.Add(new object[] { customerModel.id, customerModel.name, customerModel.citizenIdentification, customerModel.dateOfBirth != null ? customerModel.dateOfBirth.Value.ToString("dd-MM-yyyy") : "NULL", customerModel.numberPhone, GetCustomerType(customerModel.customerType), "-------" });
            }
        }

        /// <summary>
        /// get customer type
        /// </summary>
        /// <param name="customerType"></param>
        /// <returns></returns>
        private string GetCustomerType(int customerType)
        {
            if(customerType == 2)
            {
                return "Khách VIP";
            }
            else if (customerType == 1)
            {
                return "Khách quen";
            }
            else
            {
                return "Khách mới";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setDataCustomer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            setDataCustomer();
        }
    }
}
