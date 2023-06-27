namespace hotel_management_app.Forms.HotelRoom
{
    partial class HotelRoomItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnContainer = new System.Windows.Forms.Panel();
            this.pnWork = new System.Windows.Forms.Panel();
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.icStatus = new FontAwesome.Sharp.IconButton();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbNoRoom = new System.Windows.Forms.Label();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.pnContainer.Controls.Add(this.pnWork);
            this.pnContainer.Controls.Add(this.lbRoomStatus);
            this.pnContainer.Controls.Add(this.icStatus);
            this.pnContainer.Controls.Add(this.lbRoomType);
            this.pnContainer.Controls.Add(this.lbNoRoom);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(251, 135);
            this.pnContainer.TabIndex = 0;
            this.pnContainer.Click += new System.EventHandler(this.pnContainer_Click);
            // 
            // pnWork
            // 
            this.pnWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnWork.Location = new System.Drawing.Point(7, 62);
            this.pnWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnWork.Name = "pnWork";
            this.pnWork.Size = new System.Drawing.Size(240, 70);
            this.pnWork.TabIndex = 4;
            this.pnWork.Click += new System.EventHandler(this.pnWork_Click);
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRoomStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomStatus.ForeColor = System.Drawing.Color.White;
            this.lbRoomStatus.Location = new System.Drawing.Point(116, 39);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(132, 20);
            this.lbRoomStatus.TabIndex = 3;
            this.lbRoomStatus.Text = "Phòng trống";
            this.lbRoomStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // icStatus
            // 
            this.icStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(163)))), ((int)(((byte)(92)))));
            this.icStatus.FlatAppearance.BorderSize = 0;
            this.icStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icStatus.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.icStatus.IconColor = System.Drawing.Color.White;
            this.icStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icStatus.Location = new System.Drawing.Point(172, 14);
            this.icStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icStatus.Name = "icStatus";
            this.icStatus.Size = new System.Drawing.Size(75, 23);
            this.icStatus.TabIndex = 2;
            this.icStatus.UseVisualStyleBackColor = false;
            // 
            // lbRoomType
            // 
            this.lbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomType.ForeColor = System.Drawing.Color.White;
            this.lbRoomType.Location = new System.Drawing.Point(3, 39);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(119, 20);
            this.lbRoomType.TabIndex = 1;
            this.lbRoomType.Text = "Phòng đơn";
            this.lbRoomType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbNoRoom
            // 
            this.lbNoRoom.AutoSize = true;
            this.lbNoRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoRoom.ForeColor = System.Drawing.Color.White;
            this.lbNoRoom.Location = new System.Drawing.Point(20, 10);
            this.lbNoRoom.Name = "lbNoRoom";
            this.lbNoRoom.Size = new System.Drawing.Size(55, 29);
            this.lbNoRoom.TabIndex = 0;
            this.lbNoRoom.Text = "201";
            // 
            // HotelRoomItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(251, 135);
            this.Name = "HotelRoomItem";
            this.Size = new System.Drawing.Size(251, 135);
            this.pnContainer.ResumeLayout(false);
            this.pnContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainer;
        private FontAwesome.Sharp.IconButton icStatus;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label lbNoRoom;
        private System.Windows.Forms.Label lbRoomStatus;
        private System.Windows.Forms.Panel pnWork;
    }
}
