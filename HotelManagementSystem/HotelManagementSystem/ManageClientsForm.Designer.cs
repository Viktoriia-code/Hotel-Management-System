namespace HotelManagementSystem
{
    partial class ManageClientsForm
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.addClientBTN = new System.Windows.Forms.Button();
            this.editClientBTN = new System.Windows.Forms.Button();
            this.deleteClientBTN = new System.Windows.Forms.Button();
            this.emptyBTN = new System.Windows.Forms.Button();
            this.ClientIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiakkaiden hallinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puhelin:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTB.Location = new System.Drawing.Point(179, 174);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(195, 30);
            this.firstNameTB.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(425, 360);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTB.Location = new System.Drawing.Point(179, 220);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(195, 30);
            this.lastNameTB.TabIndex = 10;
            // 
            // countryTB
            // 
            this.countryTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTB.Location = new System.Drawing.Point(179, 266);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(195, 30);
            this.countryTB.TabIndex = 11;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(179, 312);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(195, 30);
            this.phoneTB.TabIndex = 12;
            // 
            // addClientBTN
            // 
            this.addClientBTN.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addClientBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBTN.Location = new System.Drawing.Point(36, 377);
            this.addClientBTN.Name = "addClientBTN";
            this.addClientBTN.Size = new System.Drawing.Size(110, 82);
            this.addClientBTN.TabIndex = 16;
            this.addClientBTN.Text = "Lisää uusi asiakas";
            this.addClientBTN.UseVisualStyleBackColor = false;
            this.addClientBTN.Click += new System.EventHandler(this.addClientBTN_Click);
            // 
            // editClientBTN
            // 
            this.editClientBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editClientBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editClientBTN.Location = new System.Drawing.Point(159, 377);
            this.editClientBTN.Name = "editClientBTN";
            this.editClientBTN.Size = new System.Drawing.Size(110, 38);
            this.editClientBTN.TabIndex = 17;
            this.editClientBTN.Text = "Muokkaa";
            this.editClientBTN.UseVisualStyleBackColor = false;
            this.editClientBTN.Click += new System.EventHandler(this.editClientBTN_Click);
            // 
            // deleteClientBTN
            // 
            this.deleteClientBTN.BackColor = System.Drawing.Color.LightCoral;
            this.deleteClientBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteClientBTN.Location = new System.Drawing.Point(283, 377);
            this.deleteClientBTN.Name = "deleteClientBTN";
            this.deleteClientBTN.Size = new System.Drawing.Size(110, 38);
            this.deleteClientBTN.TabIndex = 18;
            this.deleteClientBTN.Text = "Poista";
            this.deleteClientBTN.UseVisualStyleBackColor = false;
            this.deleteClientBTN.Click += new System.EventHandler(this.deleteClientBTN_Click);
            // 
            // emptyBTN
            // 
            this.emptyBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyBTN.Location = new System.Drawing.Point(283, 421);
            this.emptyBTN.Name = "emptyBTN";
            this.emptyBTN.Size = new System.Drawing.Size(110, 38);
            this.emptyBTN.TabIndex = 19;
            this.emptyBTN.Text = "Tyhennä";
            this.emptyBTN.UseVisualStyleBackColor = true;
            this.emptyBTN.Click += new System.EventHandler(this.emptyBTN_Click);
            // 
            // ClientIDTB
            // 
            this.ClientIDTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientIDTB.Location = new System.Drawing.Point(179, 106);
            this.ClientIDTB.Name = "ClientIDTB";
            this.ClientIDTB.ReadOnly = true;
            this.ClientIDTB.Size = new System.Drawing.Size(195, 30);
            this.ClientIDTB.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID:";
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 471);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClientIDTB);
            this.Controls.Add(this.emptyBTN);
            this.Controls.Add(this.deleteClientBTN);
            this.Controls.Add(this.editClientBTN);
            this.Controls.Add(this.addClientBTN);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageClientsForm";
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Button addClientBTN;
        private System.Windows.Forms.Button editClientBTN;
        private System.Windows.Forms.Button deleteClientBTN;
        private System.Windows.Forms.Button emptyBTN;
        private System.Windows.Forms.TextBox ClientIDTB;
        private System.Windows.Forms.Label label6;
    }
}