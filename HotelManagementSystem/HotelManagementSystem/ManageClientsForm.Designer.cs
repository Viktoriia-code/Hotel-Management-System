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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.countryTB = new System.Windows.Forms.TextBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.userLoginTB = new System.Windows.Forms.TextBox();
            this.userPasswordTB = new System.Windows.Forms.TextBox();
            this.addClientBTN = new System.Windows.Forms.Button();
            this.changeBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.emptyBTN = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(113, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Etunimi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sukunimi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Puhelin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Käyttäjätunnus:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salasana:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTB.Location = new System.Drawing.Point(200, 110);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(195, 30);
            this.firstNameTB.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(425, 360);
            this.dataGridView1.TabIndex = 9;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTB.Location = new System.Drawing.Point(200, 147);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(195, 30);
            this.lastNameTB.TabIndex = 10;
            // 
            // countryTB
            // 
            this.countryTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryTB.Location = new System.Drawing.Point(200, 183);
            this.countryTB.Name = "countryTB";
            this.countryTB.Size = new System.Drawing.Size(195, 30);
            this.countryTB.TabIndex = 11;
            // 
            // phoneTB
            // 
            this.phoneTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTB.Location = new System.Drawing.Point(200, 219);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(195, 30);
            this.phoneTB.TabIndex = 12;
            // 
            // userLoginTB
            // 
            this.userLoginTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLoginTB.Location = new System.Drawing.Point(200, 291);
            this.userLoginTB.Name = "userLoginTB";
            this.userLoginTB.Size = new System.Drawing.Size(195, 30);
            this.userLoginTB.TabIndex = 14;
            // 
            // userPasswordTB
            // 
            this.userPasswordTB.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userPasswordTB.Location = new System.Drawing.Point(200, 327);
            this.userPasswordTB.Name = "userPasswordTB";
            this.userPasswordTB.Size = new System.Drawing.Size(195, 30);
            this.userPasswordTB.TabIndex = 15;
            // 
            // addClientBTN
            // 
            this.addClientBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBTN.Location = new System.Drawing.Point(36, 377);
            this.addClientBTN.Name = "addClientBTN";
            this.addClientBTN.Size = new System.Drawing.Size(110, 82);
            this.addClientBTN.TabIndex = 16;
            this.addClientBTN.Text = "Lisää uusi asiakas";
            this.addClientBTN.UseVisualStyleBackColor = true;
            this.addClientBTN.Click += new System.EventHandler(this.addClientBTN_Click);
            // 
            // changeBTN
            // 
            this.changeBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBTN.Location = new System.Drawing.Point(159, 377);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(110, 38);
            this.changeBTN.TabIndex = 17;
            this.changeBTN.Text = "Muokkaa";
            this.changeBTN.UseVisualStyleBackColor = true;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBTN.Location = new System.Drawing.Point(283, 377);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(110, 38);
            this.deleteBTN.TabIndex = 18;
            this.deleteBTN.Text = "Poista";
            this.deleteBTN.UseVisualStyleBackColor = true;
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
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 471);
            this.Controls.Add(this.emptyBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.addClientBTN);
            this.Controls.Add(this.userPasswordTB);
            this.Controls.Add(this.userLoginTB);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.countryTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ManageClientsForm";
            this.Text = "ManageClientsForm";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox countryTB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.TextBox userLoginTB;
        private System.Windows.Forms.TextBox userPasswordTB;
        private System.Windows.Forms.Button addClientBTN;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button emptyBTN;
    }
}