namespace hotel_management_app.Forms.Authenticate
{
    partial class AuthenticateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCloseForm = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnForgotPassword = new FontAwesome.Sharp.IconButton();
            this.btnRegisterPage = new FontAwesome.Sharp.IconButton();
            this.btnLoginPage = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnAuthenticateContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.BackColor = System.Drawing.Color.White;
            this.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseForm.ForeColor = System.Drawing.Color.Silver;
            this.btnCloseForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCloseForm.IconColor = System.Drawing.Color.Black;
            this.btnCloseForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseForm.Location = new System.Drawing.Point(1049, 1);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(50, 50);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "X";
            this.btnCloseForm.UseVisualStyleBackColor = false;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnForgotPassword, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterPage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnLoginPage, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(226, 676);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnForgotPassword
            // 
            this.btnForgotPassword.BackColor = System.Drawing.Color.White;
            this.btnForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForgotPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnForgotPassword.FlatAppearance.BorderSize = 0;
            this.btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.btnForgotPassword.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.btnForgotPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.btnForgotPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnForgotPassword.Location = new System.Drawing.Point(3, 455);
            this.btnForgotPassword.Name = "btnForgotPassword";
            this.btnForgotPassword.Padding = new System.Windows.Forms.Padding(0, 40, 0, 60);
            this.btnForgotPassword.Size = new System.Drawing.Size(220, 218);
            this.btnForgotPassword.TabIndex = 2;
            this.btnForgotPassword.Text = "Quên mật khẩu";
            this.btnForgotPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForgotPassword.UseVisualStyleBackColor = false;
            this.btnForgotPassword.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // btnRegisterPage
            // 
            this.btnRegisterPage.BackColor = System.Drawing.Color.White;
            this.btnRegisterPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegisterPage.FlatAppearance.BorderSize = 0;
            this.btnRegisterPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.btnRegisterPage.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnRegisterPage.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.btnRegisterPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegisterPage.IconSize = 60;
            this.btnRegisterPage.Location = new System.Drawing.Point(3, 226);
            this.btnRegisterPage.Name = "btnRegisterPage";
            this.btnRegisterPage.Padding = new System.Windows.Forms.Padding(0, 40, 0, 60);
            this.btnRegisterPage.Size = new System.Drawing.Size(220, 223);
            this.btnRegisterPage.TabIndex = 1;
            this.btnRegisterPage.Text = "Đăng Ký";
            this.btnRegisterPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegisterPage.UseVisualStyleBackColor = false;
            this.btnRegisterPage.Click += new System.EventHandler(this.btnRegisterPage_Click);
            // 
            // btnLoginPage
            // 
            this.btnLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.btnLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginPage.FlatAppearance.BorderSize = 0;
            this.btnLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginPage.ForeColor = System.Drawing.Color.White;
            this.btnLoginPage.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnLoginPage.IconColor = System.Drawing.Color.White;
            this.btnLoginPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginPage.IconSize = 60;
            this.btnLoginPage.Location = new System.Drawing.Point(3, 3);
            this.btnLoginPage.Name = "btnLoginPage";
            this.btnLoginPage.Padding = new System.Windows.Forms.Padding(0, 40, 0, 60);
            this.btnLoginPage.Size = new System.Drawing.Size(220, 217);
            this.btnLoginPage.TabIndex = 0;
            this.btnLoginPage.Text = "Đăng Nhập";
            this.btnLoginPage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLoginPage.UseVisualStyleBackColor = false;
            this.btnLoginPage.Click += new System.EventHandler(this.btnLoginPage_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.label1.Location = new System.Drawing.Point(296, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(747, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOTEL YY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnAuthenticateContainer
            // 
            this.pnAuthenticateContainer.Location = new System.Drawing.Point(244, 129);
            this.pnAuthenticateContainer.Name = "pnAuthenticateContainer";
            this.pnAuthenticateContainer.Size = new System.Drawing.Size(844, 500);
            this.pnAuthenticateContainer.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(244, 635);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(844, 50);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hotline: 0123456789";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.label2.Location = new System.Drawing.Point(425, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Website: api-hotelyy.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.label4.Location = new System.Drawing.Point(237, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 670);
            this.label4.TabIndex = 5;
            // 
            // AuthenticateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.pnAuthenticateContainer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCloseForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthenticateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthenticateForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthenticateForm_FormClosing);
            this.Load += new System.EventHandler(this.AuthenticateForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCloseForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnForgotPassword;
        private FontAwesome.Sharp.IconButton btnRegisterPage;
        private FontAwesome.Sharp.IconButton btnLoginPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnAuthenticateContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}