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

namespace hotel_management_app.Forms.UserManagememt
{
    public partial class UserManagementForm : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<UserModel> _userModelList = new List<UserModel>();

        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set auth
            var token = Properties.Settings.Default.token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            DGVInitial();
            setDataUser();
        }

        /// <summary>
        /// DGV initial
        /// </summary>
        private void DGVInitial()
        {
            dgvUser.ReadOnly = true;
        }

        /// <summary>
        /// Set data user dgv
        /// </summary>
        private void setDataUser()
        {
            // call api
            HttpResponseMessage response = _client.GetAsync("api/UserManagement/Get?limit=10&page=1&name=" + txtName.Text + "&email=" + txtEmail.Text).GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                dynamic json = JsonConvert.DeserializeObject(content);
                _userModelList = JsonConvert.DeserializeObject<List<UserModel>>(json.data.data.ToString());

                lbTotalUser.Text = "Tổng: "+ json.data.total.ToString() + " Nhân viên";
            }

            dgvUser.Rows.Clear();
            dgvUser.Refresh();
            foreach(var user in _userModelList)
            {
                dgvUser.Rows.Add(new object[] {user.id, user.name, user.citizenIdentification, user.dateOfBirth.ToString("dd-MM-yyyy"), user.address, user.numberPhone, user.email, user.role, "-------"});
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            setDataUser();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            setDataUser();
        }
    }
}
