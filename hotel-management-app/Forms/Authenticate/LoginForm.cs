using hotel_management_app.Common;
using hotel_management_app.Forms.HomePage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hotel_management_app.Forms.Authenticate
{
    public partial class LoginForm : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private Thread th;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Button login click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin đăng nhập?", "HotelYY", MessageBoxButtons.OK);
                    return;
                }
                var loginRequest = new
                {
                    username = username,
                    password = password
                };
                var byteContent = Ultility.GetByteArrayContentFromObject(loginRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PostAsync("api/UserAuthenticate/UserLogin", byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if(jsonRes.code == "Oke")
                {
                    var token = (string)jsonRes.data.token;
                    Properties.Settings.Default.token = token;

                    var role = (string)jsonRes.data.role;
                    Properties.Settings.Default.role = role;

                    var name = (string)jsonRes.data.user.name;
                    Properties.Settings.Default.name = name;

                    Properties.Settings.Default.Save();
                    //HomePageForm homePageForm = new HomePageForm();
                    //homePageForm.Show();

                    // hidden authenticate form
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == "AuthenticateForm")
                        {
                            item.Close();
                            th = new Thread(openHomePageForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                        }
                    }
                }
                else
                {
                    MessageBox.Show((string)jsonRes.des, "HotelYY", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Open HomePage form
        /// </summary>
        /// <param name="obj"></param>
        public void openHomePageForm(object obj)
        {
            Application.Run(new HomePageForm());
        }

        private void cbDisplayPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDisplayPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
