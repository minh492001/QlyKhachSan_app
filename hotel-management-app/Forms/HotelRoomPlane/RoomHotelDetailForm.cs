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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace hotel_management_app.Forms.HotelRoomPlane
{
    public partial class RoomHotelDetailForm : Form
    {
        private readonly HotelRoomPlanDto _model;
        private readonly HttpClient _client = new HttpClient();
        public RoomHotelDetailForm(HotelRoomPlanDto hotelRoomModel)
        {
            InitializeComponent();
            _model = hotelRoomModel;
            setUpData();

            _client.BaseAddress = new Uri(SystemConfig.BaseApi);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // set auth
            var token = Properties.Settings.Default.token;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        void setUpData()
        {
            lbNoRoom.Text = _model.noRoom;
            lbMaThue.Text = _model.id.ToString();
            lbUsername.Text = Properties.Settings.Default.name;
            lbCreatedDate.Text = _model.reservationTime.ToString("HH:mm dd/MM/yyyy");
            setStatus(_model.roomStatus);

            lbCheckIn.Text = _model.checkinTime.ToString("dd/MM/yyyy");
            lbCheckInTime.Text = _model.checkinTime.ToString("HH:mm");
            lbCheckOut.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbCheckOutTime.Text = DateTime.Now.ToString("HH:mm");
            setRoomType(_model.roomType);

            txtName.Text = _model.customerName;
            txtCCCD.Text = _model.citizenIdentification;
            txtNumberphone.Text = _model.numberPhone;
            cbBookType.SelectedIndex = 0;

            if (_model.roomStatus == 0)
            {
                lbCheckIn.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lbCheckInTime.Text = DateTime.Now.ToString("HH:mm");
                lbCreatedDate.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            }

            // payment info
            lbPrice.Text = String.Format("{0:n0}", _model.price);
        }

        void setStatus(int roomStatus)
        {
            if (roomStatus == 0)
            {
                btnStatus.BackColor = Color.FromArgb(93, 163, 92);
                btnStatus.Text = "Phòng trống";

                btnPrint.Visible = false;
            }
            else if (roomStatus == 1)
            {
                btnStatus.BackColor = Color.FromArgb(241, 97, 33);
                btnStatus.Text = "Đang ở";
                btnSubmit.Text = "Thanh toán";
                btnSubmit.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
                txtName.Enabled = false;
                txtCCCD.Enabled = false;

                btnPrint.Visible = false;
            }
            else if (roomStatus == 2)
            {
                btnStatus.BackColor = Color.FromArgb(255, 151, 114);
                btnStatus.Text = "Đặt trước";
                btnSubmit.Text = "Nhận phòng";
                txtName.Enabled = false;
                txtNumberphone.Enabled = false;

                btnPrint.Visible = false;
            }
            else
            {
                btnStatus.BackColor = Color.FromArgb(251, 162, 0);
                btnStatus.Text = "Trả phòng";
                btnSubmit.Text = "Dọn phòng";
                btnSubmit.IconChar = FontAwesome.Sharp.IconChar.Broom;
            }

            if(roomStatus != 0) 
            {
                // hide booktype
                cbBookType.Hide();
                lbBookType.Hide();

                if(roomStatus != 2)
                {
                    var totalHours = (int)(DateTime.Now - _model.checkinTime).TotalHours + 1;
                    var totalPrice = 200000.0;
                    if (totalHours > 2)
                    {
                        totalPrice += (totalHours - 2) * 20000;
                    }

                    if (_model.roomType == 1)
                    {
                        totalPrice *= 1.5;
                    }
                    else if (_model.roomType == 2)
                    {
                        totalPrice *= 2.5;
                    }
                    lbTotalPrice.Text = String.Format("{0:n0}", totalPrice);
                    lbSum.Text = String.Format("{0:n0}", totalPrice);
                }
                else if(roomStatus != 3)
                {
                    var totalHours = (int)(_model.checkoutTime - _model.checkinTime).TotalHours + 1;
                    var totalPrice = 200000.0;
                    if (totalHours > 2)
                    {
                        totalPrice += (totalHours - 2) * 20000;
                    }

                    if (_model.roomType == 1)
                    {
                        totalPrice *= 1.5;
                    }
                    else if (_model.roomType == 2)
                    {
                        totalPrice *= 2.5;
                    }
                    lbTotalPrice.Text = String.Format("{0:n0}", totalPrice);
                    lbSum.Text = String.Format("{0:n0}", totalPrice);
                }
            }
        }

        void setRoomType(int roomType)
        {
            if (roomType == 0)
            {
                lbRoomType.Text = "Phòng đơn";
            }
            else if (roomType == 1)
            {
                lbRoomType.Text = "Phòng đôi";
            }
            else
            {
                lbRoomType.Text = "Phòng VIP";
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void iconButton4_ClickAsync(object sender, EventArgs e)
        {
            var customername = txtName.Text;
            var cccd = txtCCCD.Text;
            var numberPhone = txtNumberphone.Text;

            if (_model.roomStatus == 0)
            {
                if (cbBookType.SelectedIndex == 0)
                {
                    if (string.IsNullOrEmpty(customername) || string.IsNullOrEmpty(cccd))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                        return;
                    }
                    var rentRoomRequest = new
                    {
                        hotelRoomId = _model.id,
                        name = customername,
                        citizenIdentification = cccd
                    };

                    var byteContent = Ultility.GetByteArrayContentFromObject(rentRoomRequest);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = await _client.PostAsync("api/Booking/RentRoom", byteContent);
                    response.EnsureSuccessStatusCode();

                    dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                    if (jsonRes.code == "Oke")
                    {
                        MessageBox.Show("Cho thuê phòng thành công");
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == typeof(HotelRoomPlanForm).Name)
                            {
                                (item as HotelRoomPlanForm).SetTable();
                            }
                        }
                        this.Close();
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(customername) || string.IsNullOrEmpty(numberPhone))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                        return;
                    }

                    var bookRoomRequest = new
                    {
                        hotelRoomId = _model.id,
                        name = customername,
                        numberPhone = numberPhone
                    };

                    var byteContent = Ultility.GetByteArrayContentFromObject(bookRoomRequest);
                    byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    HttpResponseMessage response = await _client.PostAsync("api/Booking/BookRoom", byteContent);
                    response.EnsureSuccessStatusCode();

                    dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                    if (jsonRes.code == "Oke")
                    {
                        MessageBox.Show("Đặt phòng thành công");
                        foreach (Form item in Application.OpenForms)
                        {
                            if (item.Name == typeof(HotelRoomPlanForm).Name)
                            {
                                (item as HotelRoomPlanForm).SetTable();
                            }
                        }
                        this.Close();
                    }
                }
            }
            else if (_model.roomStatus == 1)
            {
                var checkOutRequest = new
                {
                    bookingId = _model.bookingId,
                };

                var byteContent = Ultility.GetByteArrayContentFromObject(checkOutRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PostAsync("api/Booking/CheckOut", byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Trả phòng thành công");
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == typeof(HotelRoomPlanForm).Name)
                        {
                            (item as HotelRoomPlanForm).SetTable();
                        }
                    }

                    _model.roomStatus = 3;
                    _model.checkoutTime = DateTime.Now;
                    setUpData();
                    btnPrint.Visible = true;
                }
            }
            else if(_model.roomStatus == 2)
            {
                if (string.IsNullOrEmpty(cccd))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khách hàng");
                    return;
                }

                var checkInRequest = new
                {
                    bookingId = _model.bookingId,
                    citizenIdentification = cccd
                };

                var byteContent = Ultility.GetByteArrayContentFromObject(checkInRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PutAsync("api/Booking/CheckIn", byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Nhận phòng thành công");
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == typeof(HotelRoomPlanForm).Name)
                        {
                            (item as HotelRoomPlanForm).SetTable();
                        }
                    }
                    this.Close();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Chắc chắn", "Bạn chắc muốn dọn phòng?", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.No)
                {
                    return;
                }
                var cleanRoomRequest = new
                {
                    hotelRoomId = _model.id,
                };

                var byteContent = Ultility.GetByteArrayContentFromObject(cleanRoomRequest);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                HttpResponseMessage response = await _client.PutAsync("api/Booking/CleanRoom", byteContent);
                response.EnsureSuccessStatusCode();

                dynamic jsonRes = JObject.Parse(await response.Content.ReadAsStringAsync());
                if (jsonRes.code == "Oke")
                {
                    MessageBox.Show("Dọn phòng thành công");
                    foreach (Form item in Application.OpenForms)
                    {
                        if (item.Name == typeof(HotelRoomPlanForm).Name)
                        {
                            (item as HotelRoomPlanForm).SetTable();
                        }
                    }
                    this.Close();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
