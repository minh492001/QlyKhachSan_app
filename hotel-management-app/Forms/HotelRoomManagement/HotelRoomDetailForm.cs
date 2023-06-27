using hotel_management_app.Common;
using hotel_management_app.Forms.HotelRoom;
using hotel_management_app.Models;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_app.Forms.HotelRoomManagement
{
    public partial class HotelRoomDetailForm : Form
    {
        private readonly HotelRoomModel _model;
        private readonly HttpClient _client = new HttpClient();
        public HotelRoomDetailForm(HotelRoomModel hotelRoomModel)
        {
            InitializeComponent();
            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set auth
            var token = Properties.Settings.Default.token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            _model = hotelRoomModel;
            this.setUpData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setUpData()
        {
            if(_model.id == 0)
            {
                //set title
                lbTitle.Text = "Thêm mới thông tin phòng";
                btnSubmit.Text = "Thêm mới";
            }

            //set data
            txtId.Text = _model.id.ToString();
            txtId.Enabled = false;
            txtArea.Text = _model.area.ToString();
            txtNoRoom.Text = _model.noRoom.ToString();
            txtSize.Text = _model.size.ToString();
            txtFloor.Text = _model.floor.ToString();
            cbRoomType.SelectedIndex = _model.roomType;
            txtNumberBed.Text = _model.numberBed.ToString();
            txtPrice.Text = _model.price.ToString();
            txtOption.Text = _model.option.ToString();
            txtDescription.Text = _model.description;
            txtCreatedDate.Text = _model.createdDate.ToString("dd/MM/yyyy HH:mm");
            txtCreatedDate.Enabled = false;
            txtUpdatedDate.Text = _model.updatedDate.ToString("dd/MM/yyyy HH:mm");
            txtUpdatedDate.Enabled = false;
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var area = txtArea.Text;
            var noRoom = txtNoRoom.Text;
            var size = txtSize.Text;
            var floor = txtFloor.Text;
            var roomType = cbRoomType.SelectedIndex;
            var numberBed = txtNumberBed.Text;
            var price = txtPrice.Text;
            var option = txtOption.Text;
            var description = txtDescription.Text;

            if (string.IsNullOrEmpty(area) || string.IsNullOrEmpty(noRoom) || string.IsNullOrEmpty(size) || string.IsNullOrEmpty(floor) || string.IsNullOrEmpty(numberBed) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            if (_model.id != 0)
            {
                var updateRequest = new
                {
                    noRoom = noRoom,
                    floor = int.Parse(floor),
                    roomType = roomType,
                    numberBed = int.Parse(numberBed),
                    area = int.Parse(area),
                    size = size,
                    price = double.Parse(price),
                    option = option,
                    description = description
                };

                var byteContent = Ultility.GetByteArrayContentFromObject(updateRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PutAsync("api/HotelRoomManagement/Update?id="+_model.id, byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Cập nhật thành công");
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == typeof(HotelRoomManagementForm).Name)
                        {
                            (item as HotelRoomManagementForm).setDataUser();
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show((string)jsonRes.des);
                }
            }
            else
            {
                var storeRequest = new
                {
                    noRoom = noRoom,
                    floor = int.Parse(floor),
                    roomType = roomType,
                    numberBed = int.Parse(numberBed),
                    area = int.Parse(area),
                    size = size,
                    price = double.Parse(price),
                    option = option,
                    description = description
                };

                var byteContent = Ultility.GetByteArrayContentFromObject(storeRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PostAsync("api/HotelRoomManagement/Store", byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Thêm mới thành công");
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == typeof(HotelRoomManagementForm).Name)
                        {
                            (item as HotelRoomManagementForm).setDataUser();
                        }
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show((string)jsonRes.des);
                }
            }
        }
    }
}
