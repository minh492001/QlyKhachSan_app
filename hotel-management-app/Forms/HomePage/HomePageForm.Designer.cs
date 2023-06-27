namespace hotel_management_app.Forms.HomePage
{
    partial class HomePageForm
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbNameAdmin = new System.Windows.Forms.Label();
            this.ovalPictureBox2 = new hotel_management_app.Controls.OvalPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMainView = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnUserManagement = new FontAwesome.Sharp.IconButton();
            this.btnCustomerManagement = new FontAwesome.Sharp.IconButton();
            this.btnHotelRoomManagement = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnRoomPlan = new FontAwesome.Sharp.IconButton();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(115)))), ((int)(((byte)(191)))));
            this.pnHeader.Controls.Add(this.lbLocation);
            this.pnHeader.Controls.Add(this.lbNameAdmin);
            this.pnHeader.Controls.Add(this.ovalPictureBox2);
            this.pnHeader.Controls.Add(this.panel3);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1368, 90);
            this.pnHeader.TabIndex = 0;
            // 
            // lbLocation
            // 
            this.lbLocation.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.ForeColor = System.Drawing.Color.White;
            this.lbLocation.Location = new System.Drawing.Point(256, 12);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(330, 66);
            this.lbLocation.TabIndex = 3;
            this.lbLocation.Text = "Sơ đồ phòng";
            this.lbLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNameAdmin
            // 
            this.lbNameAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNameAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAdmin.ForeColor = System.Drawing.Color.White;
            this.lbNameAdmin.Location = new System.Drawing.Point(1043, 32);
            this.lbNameAdmin.Name = "lbNameAdmin";
            this.lbNameAdmin.Size = new System.Drawing.Size(236, 23);
            this.lbNameAdmin.TabIndex = 0;
            this.lbNameAdmin.Text = "Xin chào, Administrator";
            this.lbNameAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ovalPictureBox2
            // 
            this.ovalPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ovalPictureBox2.BackColor = System.Drawing.Color.White;
            this.ovalPictureBox2.Location = new System.Drawing.Point(1285, 12);
            this.ovalPictureBox2.Name = "ovalPictureBox2";
            this.ovalPictureBox2.Size = new System.Drawing.Size(71, 66);
            this.ovalPictureBox2.TabIndex = 2;
            this.ovalPictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 90);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(191)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel YY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMainView
            // 
            this.pnMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMainView.BackColor = System.Drawing.Color.White;
            this.pnMainView.Location = new System.Drawing.Point(256, 96);
            this.pnMainView.Name = "pnMainView";
            this.pnMainView.Size = new System.Drawing.Size(1100, 700);
            this.pnMainView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 718);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnUserManagement, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnCustomerManagement, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnHotelRoomManagement, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.iconButton4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.iconButton3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iconButton2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.iconButton1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnRoomPlan, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnUserManagement.IconColor = System.Drawing.Color.White;
            this.btnUserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserManagement.IconSize = 30;
            this.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.Location = new System.Drawing.Point(3, 311);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(0, 0, 47, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(244, 38);
            this.btnUserManagement.TabIndex = 7;
            this.btnUserManagement.Text = "Quản lý nhân viên";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnCustomerManagement
            // 
            this.btnCustomerManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnCustomerManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomerManagement.FlatAppearance.BorderSize = 0;
            this.btnCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCustomerManagement.ForeColor = System.Drawing.Color.White;
            this.btnCustomerManagement.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnCustomerManagement.IconColor = System.Drawing.Color.White;
            this.btnCustomerManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomerManagement.IconSize = 30;
            this.btnCustomerManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerManagement.Location = new System.Drawing.Point(3, 267);
            this.btnCustomerManagement.Name = "btnCustomerManagement";
            this.btnCustomerManagement.Padding = new System.Windows.Forms.Padding(0, 0, 33, 0);
            this.btnCustomerManagement.Size = new System.Drawing.Size(244, 38);
            this.btnCustomerManagement.TabIndex = 6;
            this.btnCustomerManagement.Text = "Quản lý khách hàng";
            this.btnCustomerManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomerManagement.UseVisualStyleBackColor = false;
            this.btnCustomerManagement.Click += new System.EventHandler(this.btnCustomerManagement_Click);
            // 
            // btnHotelRoomManagement
            // 
            this.btnHotelRoomManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnHotelRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHotelRoomManagement.FlatAppearance.BorderSize = 0;
            this.btnHotelRoomManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotelRoomManagement.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnHotelRoomManagement.ForeColor = System.Drawing.Color.White;
            this.btnHotelRoomManagement.IconChar = FontAwesome.Sharp.IconChar.Buromobelexperte;
            this.btnHotelRoomManagement.IconColor = System.Drawing.Color.White;
            this.btnHotelRoomManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHotelRoomManagement.IconSize = 30;
            this.btnHotelRoomManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotelRoomManagement.Location = new System.Drawing.Point(3, 223);
            this.btnHotelRoomManagement.Name = "btnHotelRoomManagement";
            this.btnHotelRoomManagement.Padding = new System.Windows.Forms.Padding(0, 0, 76, 0);
            this.btnHotelRoomManagement.Size = new System.Drawing.Size(244, 38);
            this.btnHotelRoomManagement.TabIndex = 5;
            this.btnHotelRoomManagement.Text = "Quản lý phòng";
            this.btnHotelRoomManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHotelRoomManagement.UseVisualStyleBackColor = false;
            this.btnHotelRoomManagement.Click += new System.EventHandler(this.btnHotelRoomManagement_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(3, 179);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(0, 0, 60, 0);
            this.iconButton4.Size = new System.Drawing.Size(244, 38);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.Text = "Quản lý hoá đơn";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(3, 135);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 0, 117, 0);
            this.iconButton3.Size = new System.Drawing.Size(244, 38);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Thống kê";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(3, 91);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.iconButton2.Size = new System.Drawing.Size(244, 38);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "Danh sách thuê phòng";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 47);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(0, 0, 116, 0);
            this.iconButton1.Size = new System.Drawing.Size(244, 38);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Thu ngân";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnRoomPlan
            // 
            this.btnRoomPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.btnRoomPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoomPlan.FlatAppearance.BorderSize = 0;
            this.btnRoomPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoomPlan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomPlan.ForeColor = System.Drawing.Color.White;
            this.btnRoomPlan.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.btnRoomPlan.IconColor = System.Drawing.Color.White;
            this.btnRoomPlan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoomPlan.IconSize = 30;
            this.btnRoomPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoomPlan.Location = new System.Drawing.Point(3, 3);
            this.btnRoomPlan.Name = "btnRoomPlan";
            this.btnRoomPlan.Padding = new System.Windows.Forms.Padding(0, 0, 91, 0);
            this.btnRoomPlan.Size = new System.Drawing.Size(244, 38);
            this.btnRoomPlan.TabIndex = 0;
            this.btnRoomPlan.Text = "Sơ đồ phòng";
            this.btnRoomPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoomPlan.UseVisualStyleBackColor = false;
            this.btnRoomPlan.Click += new System.EventHandler(this.btnRoomPlan_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1368, 808);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnMainView);
            this.Controls.Add(this.pnHeader);
            this.MinimumSize = new System.Drawing.Size(1386, 855);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel YY";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovalPictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnMainView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Controls.OvalPictureBox ovalPictureBox2;
        private System.Windows.Forms.Label lbNameAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton btnRoomPlan;
        private FontAwesome.Sharp.IconButton btnUserManagement;
        private FontAwesome.Sharp.IconButton btnCustomerManagement;
        private FontAwesome.Sharp.IconButton btnHotelRoomManagement;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbLocation;
    }
}