using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_management_app.Forms.Authenticate
{
    public partial class AuthenticateForm : Form
    {
        private int _formIndex;
        private LoginForm _loginForm;
        private RegisterForm _registerForm;
        private ForgotPasswordForm _forgotPasswordForm;

        public AuthenticateForm()
        {
            InitializeComponent();
        }

        private void AuthenticateForm_Load(object sender, EventArgs e)
        {
            _formIndex = 0;

            _loginForm = new LoginForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnAuthenticateContainer.Controls.Add(_loginForm);
            _registerForm = new RegisterForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnAuthenticateContainer.Controls.Add(_registerForm);
            _forgotPasswordForm = new ForgotPasswordForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pnAuthenticateContainer.Controls.Add(_forgotPasswordForm);

            _loginForm.Show();
        }

        private void AuthenticateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn đóng ứng dụng?", "HotelYY",MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            if(_formIndex == 0)
            {
                return;
            }
            _formIndex = 0;

            // set color button
            this.setColorButtonPage(0);

            // close other form
            _forgotPasswordForm.Hide();
            _registerForm.Hide();

            // open form
            _loginForm.Show();
        }

        private void btnRegisterPage_Click(object sender, EventArgs e)
        {
            if (_formIndex == 1)
            {
                return;
            }
            _formIndex = 1;
         
            // set color button
            this.setColorButtonPage(1);

            // close other form
            _loginForm.Hide();
            _forgotPasswordForm.Hide();

            // open form
            _registerForm.Show();

        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            if (_formIndex == 2)
            {
                return;
            }
            _formIndex = 2;
            
            // set color button
            this.setColorButtonPage(2);

            // close other form
            _loginForm.Hide();
            _registerForm.Hide();

            // open form
            _forgotPasswordForm.Show();
        }

        /// <summary>
        /// Set color form
        /// </summary>
        /// <param name="butonIndex"></param>
        public void setColorButtonPage(int butonIndex)
        {
            
            if (butonIndex == 0)
            {
                btnLoginPage.ForeColor = Color.FromArgb(255, 255, 255);
                btnLoginPage.IconColor = Color.FromArgb(255, 255, 255);
                btnLoginPage.BackColor = Color.FromArgb(29, 115, 191);

                btnRegisterPage.ForeColor = Color.FromArgb(29, 115, 191);
                btnRegisterPage.IconColor = Color.FromArgb(29, 115, 191);
                btnRegisterPage.BackColor = Color.FromArgb(255, 255, 255);

                btnForgotPassword.ForeColor = Color.FromArgb(29, 115, 191);
                btnForgotPassword.IconColor = Color.FromArgb(29, 115, 191);
                btnForgotPassword.BackColor = Color.FromArgb(255, 255, 255);
            }
            else if (butonIndex == 1)
            {
                btnLoginPage.ForeColor = Color.FromArgb(29, 115, 191);
                btnLoginPage.IconColor = Color.FromArgb(29, 115, 191);
                btnLoginPage.BackColor = Color.FromArgb(255, 255, 255);

                btnRegisterPage.ForeColor = Color.FromArgb(255, 255, 255);
                btnRegisterPage.IconColor = Color.FromArgb(255, 255, 255);
                btnRegisterPage.BackColor = Color.FromArgb(29, 115, 191);

                btnForgotPassword.ForeColor = Color.FromArgb(29, 115, 191);
                btnForgotPassword.IconColor = Color.FromArgb(29, 115, 191);
                btnForgotPassword.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                btnLoginPage.ForeColor = Color.FromArgb(29, 115, 191);
                btnLoginPage.IconColor = Color.FromArgb(29, 115, 191);
                btnLoginPage.BackColor = Color.FromArgb(255, 255, 255);

                btnRegisterPage.ForeColor = Color.FromArgb(29, 115, 191);
                btnRegisterPage.IconColor = Color.FromArgb(29, 115, 191);
                btnRegisterPage.BackColor = Color.FromArgb(255, 255, 255);

                btnForgotPassword.ForeColor = Color.FromArgb(255, 255, 255);
                btnForgotPassword.IconColor = Color.FromArgb(255, 255, 255);
                btnForgotPassword.BackColor = Color.FromArgb(29, 115, 191);
            }
        }
    }
}
