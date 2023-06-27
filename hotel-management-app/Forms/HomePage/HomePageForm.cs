using hotel_management_app.Forms.CustomerManagement;
using hotel_management_app.Forms.HotelRoom;
using hotel_management_app.Forms.HotelRoomManagement;
using hotel_management_app.Forms.UserManagememt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_app.Forms.HomePage
{
    public partial class HomePageForm : Form
    {
        private HotelRoomPlanForm _hotelRoomPlanForm;
        private UserManagementForm _userManagementForm;
        private HotelRoomManagementForm _hotelRoomManagementForm;
        private CustomerManagementForm _customerManagementForm;
        private List<Form> _formList;

        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            lbNameAdmin.Text = "Xin chào, " + Properties.Settings.Default.name;
            formsInitial();
            _hotelRoomPlanForm.Show();
            _formList.Add(_hotelRoomPlanForm);
        }

        private void formsInitial()
        {
            _formList = new List<Form>();
            _hotelRoomPlanForm = new HotelRoomPlanForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnMainView.Controls.Add(_hotelRoomPlanForm);

            _userManagementForm = new UserManagementForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnMainView.Controls.Add(_userManagementForm);

            _hotelRoomManagementForm = new HotelRoomManagementForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnMainView.Controls.Add(_hotelRoomManagementForm);

            _customerManagementForm = new CustomerManagementForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnMainView.Controls.Add(_customerManagementForm);
        }

        private void btnRoomPlan_Click(object sender, EventArgs e)
        {
            _hotelRoomPlanForm.SetTable();
            _formList[0].Hide();
            _formList = new List<Form>();
            _formList.Add(_hotelRoomPlanForm);
            _hotelRoomPlanForm.Show();
            lbLocation.Text = "Sơ đồ phòng";
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            _formList[0].Hide();
            _formList = new List<Form>();
            _formList.Add(_userManagementForm);
            _userManagementForm.Show();
            lbLocation.Text = "Quản lý nhân viên";
        }

        private void btnHotelRoomManagement_Click(object sender, EventArgs e)
        {
            _formList[0].Hide();
            _formList = new List<Form>();
            _formList.Add(_hotelRoomManagementForm);
            _hotelRoomManagementForm.Show();
            lbLocation.Text = "Quản lý phòng";
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            _formList[0].Hide();
            _formList = new List<Form>();
            _formList.Add(_customerManagementForm);
            _customerManagementForm.Show();
            lbLocation.Text = "Quản lý khách hàng";
        }
    }
}
