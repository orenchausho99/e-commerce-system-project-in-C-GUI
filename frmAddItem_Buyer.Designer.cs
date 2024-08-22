namespace FinalProject_orengal_part5_GUI
{
    partial class frmAddItem_Buyer
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
            this.comboSeller = new System.Windows.Forms.ComboBox();
            this.sellerNamelbl = new System.Windows.Forms.Label();
            this.comboProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo_AddItem = new System.Windows.Forms.Button();
            this.comboBuyer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSeller
            // 
            this.comboSeller.FormattingEnabled = true;
            this.comboSeller.Location = new System.Drawing.Point(321, 108);
            this.comboSeller.Name = "comboSeller";
            this.comboSeller.Size = new System.Drawing.Size(134, 21);
            this.comboSeller.TabIndex = 34;
            this.comboSeller.SelectedIndexChanged += new System.EventHandler(this.comboSeller_SelectedIndexChanged);
            // 
            // sellerNamelbl
            // 
            this.sellerNamelbl.AutoSize = true;
            this.sellerNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.sellerNamelbl.Location = new System.Drawing.Point(211, 109);
            this.sellerNamelbl.Name = "sellerNamelbl";
            this.sellerNamelbl.Size = new System.Drawing.Size(77, 15);
            this.sellerNamelbl.TabIndex = 33;
            this.sellerNamelbl.Text = "Seller name:";
            this.sellerNamelbl.Click += new System.EventHandler(this.sellerNamelbl_Click);
            // 
            // comboProduct
            // 
            this.comboProduct.FormattingEnabled = true;
            this.comboProduct.Location = new System.Drawing.Point(321, 146);
            this.comboProduct.Name = "comboProduct";
            this.comboProduct.Size = new System.Drawing.Size(134, 21);
            this.comboProduct.TabIndex = 36;
            this.comboProduct.SelectedIndexChanged += new System.EventHandler(this.comboProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(211, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Product name:";
            // 
            // btnGo_AddItem
            // 
            this.btnGo_AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGo_AddItem.Location = new System.Drawing.Point(285, 244);
            this.btnGo_AddItem.Name = "btnGo_AddItem";
            this.btnGo_AddItem.Size = new System.Drawing.Size(204, 55);
            this.btnGo_AddItem.TabIndex = 37;
            this.btnGo_AddItem.Text = "Add product ";
            this.btnGo_AddItem.UseVisualStyleBackColor = true;
            this.btnGo_AddItem.Click += new System.EventHandler(this.btnGo_AddItem_Click);
            // 
            // comboBuyer
            // 
            this.comboBuyer.FormattingEnabled = true;
            this.comboBuyer.Location = new System.Drawing.Point(321, 189);
            this.comboBuyer.Name = "comboBuyer";
            this.comboBuyer.Size = new System.Drawing.Size(134, 21);
            this.comboBuyer.TabIndex = 39;
            this.comboBuyer.SelectedIndexChanged += new System.EventHandler(this.comboBuyer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(211, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Buyer name:";
            // 
            // frmAddItem_Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBuyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGo_AddItem);
            this.Controls.Add(this.comboProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSeller);
            this.Controls.Add(this.sellerNamelbl);
            this.Name = "frmAddItem_Buyer";
            this.Text = "frmAddItem_Buyer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSeller;
        private System.Windows.Forms.Label sellerNamelbl;
        private System.Windows.Forms.ComboBox comboProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo_AddItem;
        private System.Windows.Forms.ComboBox comboBuyer;
        private System.Windows.Forms.Label label2;
    }
}