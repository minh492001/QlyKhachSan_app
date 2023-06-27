using hotel_management_app.Common;
using hotel_management_app.Forms.HotelRoomPlane;
using hotel_management_app.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace hotel_management_app.Forms.HotelRoomManagement
{
    public partial class HotelRoomManagementForm : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<HotelRoomModel> _hotelRoomModelList = new List<HotelRoomModel>();
        public HotelRoomManagementForm()
        {
            InitializeComponent();
        }

        private void HotelRoomManagementForm_Load(object sender, EventArgs e)
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
            dgvHotelRoom.ReadOnly = true;
        }

        /// <summary>
        /// Set data user dgv
        /// </summary>
        public void setDataUser()
        {
            // call api
            HttpResponseMessage response = _client.GetAsync("api/HotelRoomManagement/Get?limit=10&page=1").GetAwaiter().GetResult();
            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                dynamic json = JsonConvert.DeserializeObject(content);
                _hotelRoomModelList = JsonConvert.DeserializeObject<List<HotelRoomModel>>(json.data.data.ToString());

                lbTotalUser.Text = "Tổng: " + json.data.total.ToString() + " Phòng";
            }

            dgvHotelRoom.Rows.Clear();
            dgvHotelRoom.Refresh();
            foreach (var hotelRoom in _hotelRoomModelList)
            {
                dgvHotelRoom.Rows.Add(new object[] { hotelRoom.id, hotelRoom.noRoom, hotelRoom.floor, getRoomType(hotelRoom.roomType), hotelRoom.numberBed, hotelRoom.area + " m2", hotelRoom.size, string.Format("{0:n0}",hotelRoom.price), "Chi tiết", "Xóa" });
            }
        }

        /// <summary>
        /// get room type
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        public string getRoomType(int roomType)
        {
            if (roomType == 0)
            {
                return "Phòng đơn";
            }
            else if (roomType == 1)
            {
                return "Phòng đôi";
            }
            else
            {
                return "Phòng VIP";
            }
        }

        private async void dgvHotelRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHotelRoom.Columns[e.ColumnIndex].Name == "Detail")
            {
                var hotelRoomModel = _hotelRoomModelList.Where(row => row.id == (int)dgvHotelRoom.CurrentRow.Cells[0].Value).FirstOrDefault();
                var hotelRoomDetailForm = new HotelRoomDetailForm(hotelRoomModel);
                hotelRoomDetailForm.ShowDialog();
            }
            else if (dgvHotelRoom.Columns[e.ColumnIndex].Name == "Delete")
            {
                DialogResult dialogResult = MessageBox.Show("Chắc chắn", "Bạn chắc muốn xoá?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                HttpResponseMessage response = await _client.DeleteAsync("api/HotelRoomManagement/Delete?id=" + (int)dgvHotelRoom.CurrentRow.Cells[0].Value);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Xoá thành công!");
                    setDataUser();
                }
                else
                {
                    MessageBox.Show((string)jsonRes.des);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var hotelRoomModel = new HotelRoomModel();
            var hotelRoomDetailForm = new HotelRoomDetailForm(hotelRoomModel);
            hotelRoomDetailForm.ShowDialog();
        }
    }
}
