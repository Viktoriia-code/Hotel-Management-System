namespace HotelManagementSystem
{
    partial class ManageRoomsForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roomPhoneTB = new System.Windows.Forms.TextBox();
            this.roomNumberTB = new System.Windows.Forms.TextBox();
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotFreeRoomRadioBTN = new System.Windows.Forms.RadioButton();
            this.FreeRoomRadioBTN = new System.Windows.Forms.RadioButton();
            this.clearRoomBTN = new System.Windows.Forms.Button();
            this.deleteRoomBTN = new System.Windows.Forms.Button();
            this.editRoomBTN = new System.Windows.Forms.Button();
            this.addRoomBTN = new System.Windows.Forms.Button();
            this.roomTypeCB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 92);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huoneiden hallinta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vapaa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Puhelin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Huonetyyppi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Huoneen nro:";
            // 
            // roomPhoneTB
            // 
            this.roomPhoneTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomPhoneTB.Location = new System.Drawing.Point(173, 184);
            this.roomPhoneTB.Name = "roomPhoneTB";
            this.roomPhoneTB.Size = new System.Drawing.Size(195, 30);
            this.roomPhoneTB.TabIndex = 16;
            // 
            // roomNumberTB
            // 
            this.roomNumberTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomNumberTB.Location = new System.Drawing.Point(173, 111);
            this.roomNumberTB.Name = "roomNumberTB";
            this.roomNumberTB.Size = new System.Drawing.Size(195, 30);
            this.roomNumberTB.TabIndex = 14;
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Location = new System.Drawing.Point(409, 101);
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.Size = new System.Drawing.Size(425, 360);
            this.roomDataGridView.TabIndex = 18;
            this.roomDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomDataGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NotFreeRoomRadioBTN);
            this.panel2.Controls.Add(this.FreeRoomRadioBTN);
            this.panel2.Location = new System.Drawing.Point(173, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 50);
            this.panel2.TabIndex = 19;
            // 
            // NotFreeRoomRadioBTN
            // 
            this.NotFreeRoomRadioBTN.AutoSize = true;
            this.NotFreeRoomRadioBTN.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotFreeRoomRadioBTN.ForeColor = System.Drawing.Color.Red;
            this.NotFreeRoomRadioBTN.Location = new System.Drawing.Point(130, 11);
            this.NotFreeRoomRadioBTN.Name = "NotFreeRoomRadioBTN";
            this.NotFreeRoomRadioBTN.Size = new System.Drawing.Size(42, 27);
            this.NotFreeRoomRadioBTN.TabIndex = 1;
            this.NotFreeRoomRadioBTN.TabStop = true;
            this.NotFreeRoomRadioBTN.Text = "EI";
            this.NotFreeRoomRadioBTN.UseVisualStyleBackColor = true;
            // 
            // FreeRoomRadioBTN
            // 
            this.FreeRoomRadioBTN.AutoSize = true;
            this.FreeRoomRadioBTN.Checked = true;
            this.FreeRoomRadioBTN.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreeRoomRadioBTN.ForeColor = System.Drawing.Color.Green;
            this.FreeRoomRadioBTN.Location = new System.Drawing.Point(30, 11);
            this.FreeRoomRadioBTN.Name = "FreeRoomRadioBTN";
            this.FreeRoomRadioBTN.Size = new System.Drawing.Size(79, 27);
            this.FreeRoomRadioBTN.TabIndex = 0;
            this.FreeRoomRadioBTN.TabStop = true;
            this.FreeRoomRadioBTN.Text = "KYLLÄ";
            this.FreeRoomRadioBTN.UseVisualStyleBackColor = true;
            // 
            // clearRoomBTN
            // 
            this.clearRoomBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearRoomBTN.Location = new System.Drawing.Point(270, 368);
            this.clearRoomBTN.Name = "clearRoomBTN";
            this.clearRoomBTN.Size = new System.Drawing.Size(110, 38);
            this.clearRoomBTN.TabIndex = 27;
            this.clearRoomBTN.Text = "Tyhennä";
            this.clearRoomBTN.UseVisualStyleBackColor = true;
            this.clearRoomBTN.Click += new System.EventHandler(this.clearRoomBTN_Click);
            // 
            // deleteRoomBTN
            // 
            this.deleteRoomBTN.BackColor = System.Drawing.Color.LightCoral;
            this.deleteRoomBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoomBTN.Location = new System.Drawing.Point(270, 324);
            this.deleteRoomBTN.Name = "deleteRoomBTN";
            this.deleteRoomBTN.Size = new System.Drawing.Size(110, 38);
            this.deleteRoomBTN.TabIndex = 26;
            this.deleteRoomBTN.Text = "Poista";
            this.deleteRoomBTN.UseVisualStyleBackColor = false;
            this.deleteRoomBTN.Click += new System.EventHandler(this.deleteRoomBTN_Click);
            // 
            // editRoomBTN
            // 
            this.editRoomBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editRoomBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomBTN.Location = new System.Drawing.Point(146, 324);
            this.editRoomBTN.Name = "editRoomBTN";
            this.editRoomBTN.Size = new System.Drawing.Size(110, 38);
            this.editRoomBTN.TabIndex = 25;
            this.editRoomBTN.Text = "Muokkaa";
            this.editRoomBTN.UseVisualStyleBackColor = false;
            this.editRoomBTN.Click += new System.EventHandler(this.editRoomBTN_Click);
            // 
            // addRoomBTN
            // 
            this.addRoomBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addRoomBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBTN.Location = new System.Drawing.Point(23, 324);
            this.addRoomBTN.Name = "addRoomBTN";
            this.addRoomBTN.Size = new System.Drawing.Size(110, 82);
            this.addRoomBTN.TabIndex = 24;
            this.addRoomBTN.Text = "Lisää uusi huone";
            this.addRoomBTN.UseVisualStyleBackColor = false;
            this.addRoomBTN.Click += new System.EventHandler(this.addRoomBTN_Click);
            // 
            // roomTypeCB
            // 
            this.roomTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomTypeCB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomTypeCB.FormattingEnabled = true;
            this.roomTypeCB.Location = new System.Drawing.Point(173, 147);
            this.roomTypeCB.Name = "roomTypeCB";
            this.roomTypeCB.Size = new System.Drawing.Size(195, 31);
            this.roomTypeCB.TabIndex = 28;
            // 
            // ManageRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 471);
            this.Controls.Add(this.roomTypeCB);
            this.Controls.Add(this.clearRoomBTN);
            this.Controls.Add(this.deleteRoomBTN);
            this.Controls.Add(this.editRoomBTN);
            this.Controls.Add(this.addRoomBTN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roomDataGridView);
            this.Controls.Add(this.roomPhoneTB);
            this.Controls.Add(this.roomNumberTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageRoomsForm";
            this.Text = "ManageRoomsForm";
            this.Load += new System.EventHandler(this.ManageRoomsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomPhoneTB;
        private System.Windows.Forms.TextBox roomNumberTB;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton NotFreeRoomRadioBTN;
        private System.Windows.Forms.RadioButton FreeRoomRadioBTN;
        private System.Windows.Forms.Button clearRoomBTN;
        private System.Windows.Forms.Button deleteRoomBTN;
        private System.Windows.Forms.Button editRoomBTN;
        private System.Windows.Forms.Button addRoomBTN;
        private System.Windows.Forms.ComboBox roomTypeCB;
    }
}