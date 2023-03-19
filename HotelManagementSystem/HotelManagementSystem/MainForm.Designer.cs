namespace HotelManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.ManageClientsBTN = new System.Windows.Forms.Button();
            this.ManageBookingBTN = new System.Windows.Forms.Button();
            this.ManageRoomsBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa Hotellisovellukseen!\r\nValitse, mitä haluat tehdä.";
            // 
            // ManageClientsBTN
            // 
            this.ManageClientsBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.ManageClientsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageClientsBTN.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageClientsBTN.ForeColor = System.Drawing.Color.White;
            this.ManageClientsBTN.Location = new System.Drawing.Point(29, 93);
            this.ManageClientsBTN.Name = "ManageClientsBTN";
            this.ManageClientsBTN.Size = new System.Drawing.Size(329, 42);
            this.ManageClientsBTN.TabIndex = 1;
            this.ManageClientsBTN.Text = "Hallitse asiakkaita";
            this.ManageClientsBTN.UseVisualStyleBackColor = false;
            this.ManageClientsBTN.Click += new System.EventHandler(this.ManageClientsBTN_Click);
            // 
            // ManageBookingBTN
            // 
            this.ManageBookingBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ManageBookingBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageBookingBTN.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageBookingBTN.ForeColor = System.Drawing.Color.White;
            this.ManageBookingBTN.Location = new System.Drawing.Point(29, 148);
            this.ManageBookingBTN.Name = "ManageBookingBTN";
            this.ManageBookingBTN.Size = new System.Drawing.Size(329, 42);
            this.ManageBookingBTN.TabIndex = 2;
            this.ManageBookingBTN.Text = "Hallitse varauksia";
            this.ManageBookingBTN.UseVisualStyleBackColor = false;
            this.ManageBookingBTN.Click += new System.EventHandler(this.ManageBookingBTN_Click);
            // 
            // ManageRoomsBTN
            // 
            this.ManageRoomsBTN.BackColor = System.Drawing.Color.IndianRed;
            this.ManageRoomsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageRoomsBTN.Font = new System.Drawing.Font("Ebrima", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRoomsBTN.ForeColor = System.Drawing.Color.White;
            this.ManageRoomsBTN.Location = new System.Drawing.Point(30, 205);
            this.ManageRoomsBTN.Name = "ManageRoomsBTN";
            this.ManageRoomsBTN.Size = new System.Drawing.Size(329, 42);
            this.ManageRoomsBTN.TabIndex = 3;
            this.ManageRoomsBTN.Text = "Hallitse huoneita";
            this.ManageRoomsBTN.UseVisualStyleBackColor = false;
            this.ManageRoomsBTN.Click += new System.EventHandler(this.ManageRoomsBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.ManageRoomsBTN);
            this.Controls.Add(this.ManageBookingBTN);
            this.Controls.Add(this.ManageClientsBTN);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Pääikkuna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageClientsBTN;
        private System.Windows.Forms.Button ManageBookingBTN;
        private System.Windows.Forms.Button ManageRoomsBTN;
    }
}