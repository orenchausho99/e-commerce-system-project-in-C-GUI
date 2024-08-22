namespace FinalProject_orengal_part5_GUI
{
    partial class frmAddItem_Seller
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
            this.btnGo_AddItem = new System.Windows.Forms.Button();
            this.categorylbl = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.comboSeller = new System.Windows.Forms.ComboBox();
            this.cboxSpecialPackage = new System.Windows.Forms.CheckBox();
            this.radKids = new System.Windows.Forms.RadioButton();
            this.radElectronics = new System.Windows.Forms.RadioButton();
            this.radOffice = new System.Windows.Forms.RadioButton();
            this.radClothing = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGo_AddItem
            // 
            this.btnGo_AddItem.Location = new System.Drawing.Point(265, 371);
            this.btnGo_AddItem.Name = "btnGo_AddItem";
            this.btnGo_AddItem.Size = new System.Drawing.Size(204, 55);
            this.btnGo_AddItem.TabIndex = 25;
            this.btnGo_AddItem.Text = "Add item ";
            this.btnGo_AddItem.UseVisualStyleBackColor = true;
            this.btnGo_AddItem.Click += new System.EventHandler(this.btnGo_AddItem_Click);
            // 
            // categorylbl
            // 
            this.categorylbl.AutoSize = true;
            this.categorylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.categorylbl.Location = new System.Drawing.Point(186, 134);
            this.categorylbl.Name = "categorylbl";
            this.categorylbl.Size = new System.Drawing.Size(111, 15);
            this.categorylbl.TabIndex = 19;
            this.categorylbl.Text = "Choose a category:";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Location = new System.Drawing.Point(304, 82);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(134, 20);
            this.txtProductPrice.TabIndex = 15;
            this.txtProductPrice.TextChanged += new System.EventHandler(this.txtProductPrice_TextChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(304, 43);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(134, 20);
            this.txtProductName.TabIndex = 14;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // comboSeller
            // 
            this.comboSeller.FormattingEnabled = true;
            this.comboSeller.Location = new System.Drawing.Point(304, 313);
            this.comboSeller.Name = "comboSeller";
            this.comboSeller.Size = new System.Drawing.Size(134, 21);
            this.comboSeller.TabIndex = 32;
            this.comboSeller.SelectedIndexChanged += new System.EventHandler(this.comboSeller_SelectedIndexChanged);
            // 
            // cboxSpecialPackage
            // 
            this.cboxSpecialPackage.AutoSize = true;
            this.cboxSpecialPackage.Location = new System.Drawing.Point(326, 261);
            this.cboxSpecialPackage.Name = "cboxSpecialPackage";
            this.cboxSpecialPackage.Size = new System.Drawing.Size(117, 17);
            this.cboxSpecialPackage.TabIndex = 35;
            this.cboxSpecialPackage.Text = "Special packaging:";
            this.cboxSpecialPackage.UseVisualStyleBackColor = true;
            this.cboxSpecialPackage.CheckedChanged += new System.EventHandler(this.cboxSpecialPackage_CheckedChanged);
            // 
            // radKids
            // 
            this.radKids.AutoSize = true;
            this.radKids.Location = new System.Drawing.Point(339, 137);
            this.radKids.Name = "radKids";
            this.radKids.Size = new System.Drawing.Size(44, 17);
            this.radKids.TabIndex = 26;
            this.radKids.TabStop = true;
            this.radKids.Text = "kids";
            this.radKids.UseVisualStyleBackColor = true;
            this.radKids.CheckedChanged += new System.EventHandler(this.radKids_CheckedChanged);
            // 
            // radElectronics
            // 
            this.radElectronics.AutoSize = true;
            this.radElectronics.Location = new System.Drawing.Point(339, 160);
            this.radElectronics.Name = "radElectronics";
            this.radElectronics.Size = new System.Drawing.Size(76, 17);
            this.radElectronics.TabIndex = 27;
            this.radElectronics.TabStop = true;
            this.radElectronics.Text = "electronics";
            this.radElectronics.UseVisualStyleBackColor = true;
            this.radElectronics.CheckedChanged += new System.EventHandler(this.radElectronics_CheckedChanged);
            // 
            // radOffice
            // 
            this.radOffice.AutoSize = true;
            this.radOffice.Location = new System.Drawing.Point(339, 183);
            this.radOffice.Name = "radOffice";
            this.radOffice.Size = new System.Drawing.Size(51, 17);
            this.radOffice.TabIndex = 28;
            this.radOffice.TabStop = true;
            this.radOffice.Text = "office";
            this.radOffice.UseVisualStyleBackColor = true;
            this.radOffice.CheckedChanged += new System.EventHandler(this.radOffice_CheckedChanged);
            // 
            // radClothing
            // 
            this.radClothing.AutoSize = true;
            this.radClothing.Location = new System.Drawing.Point(339, 206);
            this.radClothing.Name = "radClothing";
            this.radClothing.Size = new System.Drawing.Size(62, 17);
            this.radClothing.TabIndex = 29;
            this.radClothing.TabStop = true;
            this.radClothing.Text = "clothing";
            this.radClothing.UseVisualStyleBackColor = true;
            this.radClothing.CheckedChanged += new System.EventHandler(this.radClothing_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(186, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Product price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(186, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Product name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(186, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Seller name:";
            // 
            // frmAddItem_Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radOffice);
            this.Controls.Add(this.radClothing);
            this.Controls.Add(this.radElectronics);
            this.Controls.Add(this.radKids);
            this.Controls.Add(this.cboxSpecialPackage);
            this.Controls.Add(this.comboSeller);
            this.Controls.Add(this.btnGo_AddItem);
            this.Controls.Add(this.categorylbl);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Name = "frmAddItem_Seller";
            this.Text = "frmAddItem_Seller";
            this.Load += new System.EventHandler(this.frmAddItem_Seller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo_AddItem;
        private System.Windows.Forms.Label categorylbl;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox comboSeller;
        private System.Windows.Forms.CheckBox cboxSpecialPackage;
        private System.Windows.Forms.RadioButton radKids;
        private System.Windows.Forms.RadioButton radElectronics;
        private System.Windows.Forms.RadioButton radOffice;
        private System.Windows.Forms.RadioButton radClothing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}