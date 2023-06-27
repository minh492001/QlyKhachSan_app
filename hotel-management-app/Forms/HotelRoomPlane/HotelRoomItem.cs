using hotel_management_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using FontAwesome.Sharp;
using hotel_management_app.Forms.HotelRoomPlane;

namespace hotel_management_app.Forms.HotelRoom
{
    public partial class HotelRoomItem : UserControl
    {
        private readonly HotelRoomPlanDto _model;
        public HotelRoomItem(HotelRoomPlanDto hotelRoomModel)
        {
            InitializeComponent();
            _model = hotelRoomModel;
            setData();
        }

        public void setData()
        {
            lbNoRoom.Text = _model.noRoom;
            lbRoomType.Text = getRoomType(_model.roomType);
            lbRoomStatus.Text = getRoomStatus(_model.roomStatus);
        }

        /// <summary>
        /// get Room type
        /// </summary>
        /// <param name="roomType"></param>
        /// <returns></returns>
        public string getRoomType(int roomType)
        {
            if(roomType == 0)
            {
                return "Phòng đơn";
            }
            else if(roomType == 1)
            {
                return "Phòng đôi";
            }
            else 
            {
                return "Phòng VIP";
            }
        }

        /// <summary>
        /// Set Room Status
        /// </summary>
        /// <param name="roomStatus"></param>
        /// <returns></returns>
        public string getRoomStatus(int roomStatus)
        {
            if(roomStatus == 0)
            {
                pnContainer.BackColor = Color.FromArgb(93, 163, 92);
                icStatus.BackColor = Color.FromArgb(93, 163, 92);
                var labelTime = new Label
                {
                    Location = new System.Drawing.Point(0, 0),
                    Size = new System.Drawing.Size(pnWork.Width, 29),
                    Text = DateTime.Now.ToString("HH:mm"),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    AutoSize = false,
                    Font = new Font("Microsoft Sans Serif", 15, System.Drawing.FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                };
                pnWork.Controls.Add(labelTime);

                var labelDate = new Label
                {
                    Location = new System.Drawing.Point(0, 29),
                    Size = new System.Drawing.Size(pnWork.Width, 20),
                    Text = DateTime.Now.ToString("dd/MM/yyyy"),
                    Anchor = AnchorStyles.Left | AnchorStyles.Right,
                    AutoSize = false,
                    Font = new Font("Microsoft Sans Serif", 10),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.TopCenter,
                };
                pnWork.Controls.Add(labelDate);

                return "Phòng trống";
            }
            else if(roomStatus == 1)
            {
                pnContainer.BackColor = Color.FromArgb(241, 97, 33);
                icStatus.BackColor = Color.FromArgb(241, 97, 33);

                setValueRoom();

                return "Đang ở";
            }
            else if (roomStatus == 2)
            {
                pnContainer.BackColor = Color.FromArgb(255, 151, 114);
                icStatus.BackColor = Color.FromArgb(255, 151, 114);

                setValueRoom();

                return "Đặt trước";
            }
            else 
            {
                pnContainer.BackColor = Color.FromArgb(251, 162, 0);
                icStatus.BackColor = Color.FromArgb(251, 162, 0);

                setValueRoom();

                return "Trả phòng";
            }
        }

        private void setValueRoom()
        {
            // Total price
            var labelTotal = new Label
            {
                Location = new System.Drawing.Point(0, pnWork.Height - 40),
                Size = new System.Drawing.Size(100, 20),
                Text = "Tổng tiền",
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnWork.Controls.Add(labelTotal);

            var totalPrice = 150000.0;
            if(_model.roomStatus == 1)
            {
                var totalHours = (int)(DateTime.Now - _model.checkinTime).TotalHours + 1;
                if(totalHours > 2)
                {
                    totalPrice += (totalHours - 2) * 20000;
                }
            }
            var valueTotal = new Label
            {
                Location = new System.Drawing.Point(0, pnWork.Height - 20),
                Size = new System.Drawing.Size(100, 20),
                Text = (totalPrice/1000).ToString() + "k",
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnWork.Controls.Add(valueTotal);

            // Reserve
            var labelReserve = new Label
            {
                Location = new System.Drawing.Point(pnWork.Width - 90, pnWork.Height - 40),
                Size = new System.Drawing.Size(90, 20),
                Text = "Đặt trước",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnWork.Controls.Add(labelReserve);
            var valueReserve = new Label
            {
                Location = new System.Drawing.Point(pnWork.Width - 90, pnWork.Height - 20),
                Size = new System.Drawing.Size(90, 20),
                Text = "0K",
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
            };
            pnWork.Controls.Add(valueReserve);

            // time book
            var TimeFromText = _model.reservationTime.ToString("dd/MM HH:mm");
            if(_model.status == 1)
            {
                TimeFromText = _model.checkinTime.ToString("dd/MM HH:mm");
            }
            var TimeFrom = new Label
            {
                Location = new System.Drawing.Point(0, pnWork.Height - 60),
                Size = new System.Drawing.Size(100, 20),
                Text = TimeFromText,
                Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Top,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleRight,
            };
            pnWork.Controls.Add(TimeFrom);

            var TimeTo = new Label
            {
                Location = new System.Drawing.Point(pnWork.Width - 100, pnWork.Height - 60),
                Size = new System.Drawing.Size(100, 20),
                Text = DateTime.Now.ToString("dd/MM HH:mm"),
                Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                Font = new Font("Microsoft Sans Serif", 10),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
            };
            pnWork.Controls.Add(TimeTo);

            var btnIcon = new IconButton
            {
                Location = new System.Drawing.Point(pnWork.Width / 2 - 12, 0),
                Size = new System.Drawing.Size(24, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                AutoSize = false,
                IconChar = IconChar.Clock,
                IconSize = 48,
                ImageAlign = ContentAlignment.MiddleCenter,
                IconColor = Color.White,
                FlatStyle = FlatStyle.Flat,
            };
            btnIcon.FlatAppearance.BorderSize = 0;
            pnWork.Controls.Add(btnIcon);
        }

        private void pnContainer_Click(object sender, EventArgs e)
        {
            var roomHotelDetailForm = new RoomHotelDetailForm(_model);
            roomHotelDetailForm.ShowDialog();
        }

        private void pnWork_Click(object sender, EventArgs e)
        {
            var roomHotelDetailForm = new RoomHotelDetailForm(_model);
            roomHotelDetailForm.ShowDialog();
        }
    }
}
