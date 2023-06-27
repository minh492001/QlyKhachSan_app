using FontAwesome.Sharp;
using hotel_management_app.Common;
using hotel_management_app.Models;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_app.Forms.HotelRoom
{
    public partial class HotelRoomPlanForm : Form
    {
        private readonly HttpClient _client = new HttpClient();
        private List<HotelRoomPlanDto> _hotelRoomModelList = new List<HotelRoomPlanDto>();

        public HotelRoomPlanForm()
        {
            InitializeComponent();
        }

        private void HotelRoomPlanForm_Load(object sender, EventArgs e)
        {
            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set auth
            var token = Properties.Settings.Default.token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            //
            cbFloor.SelectedIndex = 0;
            cbFloor.Height = 32;

            SetTable();
        }

        public void SetTable()
        {
            try
            {
                // call api
                HttpResponseMessage response = _client.GetAsync("api/HotelRoom/GetRoomHotelPlan?limit=16&page=1").GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    dynamic json = JsonConvert.DeserializeObject(content);
                    _hotelRoomModelList = JsonConvert.DeserializeObject<List<HotelRoomPlanDto>>(json.data.data.ToString());
                }

                // reset table
                tbHotelRoom.Controls.Clear();
                lbNumberVancant.Text = "0";
                lbNumberStaying.Text = "0";
                lbNumberReserve.Text = "0";
                lbNumberCheckout.Text = "0";

                // set data for table
                foreach (var hotelRoomModel in _hotelRoomModelList)
                {
                    var hotelItem = new HotelRoomItem(hotelRoomModel) { Dock = DockStyle.Fill };
                    tbHotelRoom.Controls.Add(hotelItem);
                }

                lbNumberVancant.Text = _hotelRoomModelList.Where(row => row.roomStatus == 0).Count().ToString();
                lbNumberStaying.Text = _hotelRoomModelList.Where(row => row.roomStatus == 1).Count().ToString();
                lbNumberReserve.Text = _hotelRoomModelList.Where(row => row.roomStatus == 2).Count().ToString();
                lbNumberCheckout.Text = _hotelRoomModelList.Where(row => row.roomStatus == 3).Count().ToString();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
