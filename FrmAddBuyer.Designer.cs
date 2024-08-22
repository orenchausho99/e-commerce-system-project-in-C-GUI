namespace FinalProject_orengal_part5_GUI
{
    partial class FrmAddBuyer
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
            this.btnGo_Buyer = new System.Windows.Forms.Button();
            this.addressNumlbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.passlbl = new System.Windows.Forms.Label();
            this.userNamelbl = new System.Windows.Forms.Label();
            this.statelbl = new System.Windows.Forms.Label();
            this.streetNamelbl = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtAddressNum = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo_Buyer
            // 
            this.btnGo_Buyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGo_Buyer.Location = new System.Drawing.Point(279, 323);
            this.btnGo_Buyer.Name = "btnGo_Buyer";
            this.btnGo_Buyer.Size = new System.Drawing.Size(204, 55);
            this.btnGo_Buyer.TabIndex = 25;
            this.btnGo_Buyer.Text = "Add buyer";
            this.btnGo_Buyer.UseVisualStyleBackColor = true;
            this.btnGo_Buyer.Click += new System.EventHandler(this.btnGo_Buyer_Click);
            // 
            // addressNumlbl
            // 
            this.addressNumlbl.AutoSize = true;
            this.addressNumlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.addressNumlbl.Location = new System.Drawing.Point(191, 190);
            this.addressNumlbl.Name = "addressNumlbl";
            this.addressNumlbl.Size = new System.Drawing.Size(102, 15);
            this.addressNumlbl.TabIndex = 24;
            this.addressNumlbl.Text = "Number address:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(318, 272);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(134, 20);
            this.txtPassword.TabIndex = 23;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passlbl.Location = new System.Drawing.Point(191, 273);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(64, 15);
            this.passlbl.TabIndex = 22;
            this.passlbl.Text = "Password:";
            // 
            // userNamelbl
            // 
            this.userNamelbl.AutoSize = true;
            this.userNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNamelbl.Location = new System.Drawing.Point(191, 231);
            this.userNamelbl.Name = "userNamelbl";
            this.userNamelbl.Size = new System.Drawing.Size(68, 15);
            this.userNamelbl.TabIndex = 21;
            this.userNamelbl.Text = "Username:";
            this.userNamelbl.Click += new System.EventHandler(this.userNamelbl_Click);
            // 
            // statelbl
            // 
            this.statelbl.AutoSize = true;
            this.statelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statelbl.Location = new System.Drawing.Point(191, 71);
            this.statelbl.Name = "statelbl";
            this.statelbl.Size = new System.Drawing.Size(38, 15);
            this.statelbl.TabIndex = 20;
            this.statelbl.Text = "State:";
            // 
            // streetNamelbl
            // 
            this.streetNamelbl.AutoSize = true;
            this.streetNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.streetNamelbl.Location = new System.Drawing.Point(191, 150);
            this.streetNamelbl.Name = "streetNamelbl";
            this.streetNamelbl.Size = new System.Drawing.Size(42, 15);
            this.streetNamelbl.TabIndex = 19;
            this.streetNamelbl.Text = "Street:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(318, 230);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 20);
            this.txtUserName.TabIndex = 18;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtAddressNum
            // 
            this.txtAddressNum.Location = new System.Drawing.Point(318, 189);
            this.txtAddressNum.Name = "txtAddressNum";
            this.txtAddressNum.Size = new System.Drawing.Size(134, 20);
            this.txtAddressNum.TabIndex = 17;
            this.txtAddressNum.TextChanged += new System.EventHandler(this.txtAddressNum_TextChanged);
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(318, 149);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(134, 20);
            this.txtStreetName.TabIndex = 16;
            this.txtStreetName.TextChanged += new System.EventHandler(this.txtStreetName_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(318, 109);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(134, 20);
            this.txtCity.TabIndex = 15;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(318, 70);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(134, 20);
            this.txtState.TabIndex = 14;
            this.txtState.TextChanged += new System.EventHandler(this.txtState_TextChanged);
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.citylbl.Location = new System.Drawing.Point(191, 110);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(29, 15);
            this.citylbl.TabIndex = 13;
            this.citylbl.Text = "City:";
            this.citylbl.Click += new System.EventHandler(this.citylbl_Click);
            // 
            // FrmAddBuyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGo_Buyer);
            this.Controls.Add(this.addressNumlbl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userNamelbl);
            this.Controls.Add(this.statelbl);
            this.Controls.Add(this.streetNamelbl);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAddressNum);
            this.Controls.Add(this.txtStreetName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.citylbl);
            this.Name = "FrmAddBuyer";
            this.Text = "FrmAddBuyer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo_Buyer;
        private System.Windows.Forms.Label addressNumlbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.Label userNamelbl;
        private System.Windows.Forms.Label statelbl;
        private System.Windows.Forms.Label streetNamelbl;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtAddressNum;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label citylbl;
    }
}