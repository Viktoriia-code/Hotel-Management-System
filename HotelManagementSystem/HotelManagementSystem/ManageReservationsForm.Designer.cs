namespace HotelManagementSystem
{
    partial class ManageReservationsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookingNumberTB = new System.Windows.Forms.TextBox();
            this.reservationDataGridView = new System.Windows.Forms.DataGridView();
            this.clientNumTB = new System.Windows.Forms.TextBox();
            this.emptyBTN = new System.Windows.Forms.Button();
            this.removeBookingBTN = new System.Windows.Forms.Button();
            this.editBookingBTN = new System.Windows.Forms.Button();
            this.addBookingBTN = new System.Windows.Forms.Button();
            this.dateInTP = new System.Windows.Forms.DateTimePicker();
            this.dateOutTP = new System.Windows.Forms.DateTimePicker();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.roomNumberCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 92);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varausten hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Varaus nro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Asiakas nro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huonetyyppi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Huoneen nro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Sisään:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ulos:";
            // 
            // bookingNumberTB
            // 
            this.bookingNumberTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookingNumberTB.Location = new System.Drawing.Point(183, 113);
            this.bookingNumberTB.Name = "bookingNumberTB";
            this.bookingNumberTB.Size = new System.Drawing.Size(195, 30);
            this.bookingNumberTB.TabIndex = 9;
            // 
            // reservationDataGridView
            // 
            this.reservationDataGridView.AllowUserToAddRows = false;
            this.reservationDataGridView.AllowUserToDeleteRows = false;
            this.reservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationDataGridView.Location = new System.Drawing.Point(411, 101);
            this.reservationDataGridView.Name = "reservationDataGridView";
            this.reservationDataGridView.Size = new System.Drawing.Size(425, 360);
            this.reservationDataGridView.TabIndex = 10;
            this.reservationDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationDataGridView_CellClick);
            // 
            // clientNumTB
            // 
            this.clientNumTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientNumTB.Location = new System.Drawing.Point(183, 149);
            this.clientNumTB.Name = "clientNumTB";
            this.clientNumTB.Size = new System.Drawing.Size(195, 30);
            this.clientNumTB.TabIndex = 11;
            // 
            // emptyBTN
            // 
            this.emptyBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyBTN.Location = new System.Drawing.Point(279, 412);
            this.emptyBTN.Name = "emptyBTN";
            this.emptyBTN.Size = new System.Drawing.Size(110, 38);
            this.emptyBTN.TabIndex = 23;
            this.emptyBTN.Text = "Tyhennä";
            this.emptyBTN.UseVisualStyleBackColor = true;
            this.emptyBTN.Click += new System.EventHandler(this.emptyBTN_Click);
            // 
            // removeBookingBTN
            // 
            this.removeBookingBTN.BackColor = System.Drawing.Color.LightCoral;
            this.removeBookingBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookingBTN.Location = new System.Drawing.Point(279, 368);
            this.removeBookingBTN.Name = "removeBookingBTN";
            this.removeBookingBTN.Size = new System.Drawing.Size(110, 38);
            this.removeBookingBTN.TabIndex = 22;
            this.removeBookingBTN.Text = "Poista";
            this.removeBookingBTN.UseVisualStyleBackColor = false;
            this.removeBookingBTN.Click += new System.EventHandler(this.removeBookingBTN_Click);
            // 
            // editBookingBTN
            // 
            this.editBookingBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editBookingBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBookingBTN.Location = new System.Drawing.Point(155, 368);
            this.editBookingBTN.Name = "editBookingBTN";
            this.editBookingBTN.Size = new System.Drawing.Size(110, 38);
            this.editBookingBTN.TabIndex = 21;
            this.editBookingBTN.Text = "Muokkaa";
            this.editBookingBTN.UseVisualStyleBackColor = false;
            this.editBookingBTN.Click += new System.EventHandler(this.editBookingBTN_Click);
            // 
            // addBookingBTN
            // 
            this.addBookingBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addBookingBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookingBTN.Location = new System.Drawing.Point(32, 368);
            this.addBookingBTN.Name = "addBookingBTN";
            this.addBookingBTN.Size = new System.Drawing.Size(110, 82);
            this.addBookingBTN.TabIndex = 20;
            this.addBookingBTN.Text = "Lisää uusi varaus";
            this.addBookingBTN.UseVisualStyleBackColor = false;
            this.addBookingBTN.Click += new System.EventHandler(this.addBookingBTN_Click);
            // 
            // dateInTP
            // 
            this.dateInTP.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateInTP.CustomFormat = "dd/MM/yyyy";
            this.dateInTP.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateInTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInTP.Location = new System.Drawing.Point(183, 278);
            this.dateInTP.Name = "dateInTP";
            this.dateInTP.Size = new System.Drawing.Size(195, 30);
            this.dateInTP.TabIndex = 24;
            // 
            // dateOutTP
            // 
            this.dateOutTP.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOutTP.CustomFormat = "dd/MM/yyyy";
            this.dateOutTP.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateOutTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOutTP.Location = new System.Drawing.Point(183, 319);
            this.dateOutTP.Name = "dateOutTP";
            this.dateOutTP.Size = new System.Drawing.Size(195, 30);
            this.dateOutTP.TabIndex = 25;
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeCB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Location = new System.Drawing.Point(183, 192);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(195, 31);
            this.roomTypeCB.TabIndex = 29;
            this.roomTypeCB.SelectedIndexChanged += new System.EventHandler(this.roomTypeCB_SelectedIndexChanged);
            // 
            // roomNumberCB
            // 
            this.roomNumberCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomNumberCB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomNumberCB.FormattingEnabled = true;
            this.roomNumberCB.Location = new System.Drawing.Point(183, 234);
            this.roomNumberCB.Name = "roomNumberCB";
            this.roomNumberCB.Size = new System.Drawing.Size(195, 31);
            this.roomNumberCB.TabIndex = 30;
            // 
            // ManageReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 471);
            this.Controls.Add(this.roomNumberCB);
            this.Controls.Add(this.roomTypeCB);
            this.Controls.Add(this.dateOutTP);
            this.Controls.Add(this.dateInTP);
            this.Controls.Add(this.emptyBTN);
            this.Controls.Add(this.removeBookingBTN);
            this.Controls.Add(this.editBookingBTN);
            this.Controls.Add(this.addBookingBTN);
            this.Controls.Add(this.clientNumTB);
            this.Controls.Add(this.reservationDataGridView);
            this.Controls.Add(this.bookingNumberTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageReservationsForm";
            this.Text = "ManageReservationsForm";
            this.Load += new System.EventHandler(this.ManageReservationsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservationDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookingNumberTB;
        private System.Windows.Forms.DataGridView reservationDataGridView;
        private System.Windows.Forms.TextBox clientNumTB;
        private System.Windows.Forms.Button emptyBTN;
        private System.Windows.Forms.Button removeBookingBTN;
        private System.Windows.Forms.Button editBookingBTN;
        private System.Windows.Forms.Button addBookingBTN;
        private System.Windows.Forms.DateTimePicker dateInTP;
        private System.Windows.Forms.DateTimePicker dateOutTP;
        private System.Windows.Forms.ComboBox roomTypeCB;
        private System.Windows.Forms.ComboBox roomNumberCB;
    }
}