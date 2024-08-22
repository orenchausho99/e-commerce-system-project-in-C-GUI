namespace FinalProject_orengal_part5_GUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddSeller = new System.Windows.Forms.Button();
            this.btnAddBuyer = new System.Windows.Forms.Button();
            this.btnProductSeller = new System.Windows.Forms.Button();
            this.btnProductBuyer = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(356, 70);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select an option:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAddSeller
            // 
            this.btnAddSeller.Location = new System.Drawing.Point(332, 112);
            this.btnAddSeller.Name = "btnAddSeller";
            this.btnAddSeller.Size = new System.Drawing.Size(154, 23);
            this.btnAddSeller.TabIndex = 6;
            this.btnAddSeller.Text = "Add seller";
            this.btnAddSeller.UseCompatibleTextRendering = true;
            this.btnAddSeller.UseVisualStyleBackColor = true;
            this.btnAddSeller.Click += new System.EventHandler(this.btmAddSeller_Click);
            // 
            // btnAddBuyer
            // 
            this.btnAddBuyer.Location = new System.Drawing.Point(332, 153);
            this.btnAddBuyer.Name = "btnAddBuyer";
            this.btnAddBuyer.Size = new System.Drawing.Size(154, 23);
            this.btnAddBuyer.TabIndex = 7;
            this.btnAddBuyer.Text = "Add buyer";
            this.btnAddBuyer.UseVisualStyleBackColor = true;
            this.btnAddBuyer.Click += new System.EventHandler(this.btnAddBuyer_Click);
            // 
            // btnProductSeller
            // 
            this.btnProductSeller.Location = new System.Drawing.Point(332, 195);
            this.btnProductSeller.Name = "btnProductSeller";
            this.btnProductSeller.Size = new System.Drawing.Size(154, 23);
            this.btnProductSeller.TabIndex = 8;
            this.btnProductSeller.Text = "Add an item to seller";
            this.btnProductSeller.UseVisualStyleBackColor = true;
            this.btnProductSeller.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProductBuyer
            // 
            this.btnProductBuyer.Location = new System.Drawing.Point(332, 237);
            this.btnProductBuyer.Name = "btnProductBuyer";
            this.btnProductBuyer.Size = new System.Drawing.Size(154, 23);
            this.btnProductBuyer.TabIndex = 9;
            this.btnProductBuyer.Text = "Add an item to buyer";
            this.btnProductBuyer.UseVisualStyleBackColor = true;
            this.btnProductBuyer.Click += new System.EventHandler(this.btnProductBuyer_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(332, 278);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(154, 23);
            this.btnDisplayAll.TabIndex = 10;
            this.btnDisplayAll.Text = "Display all data";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisplayAll);
            this.Controls.Add(this.btnProductBuyer);
            this.Controls.Add(this.btnProductSeller);
            this.Controls.Add(this.btnAddBuyer);
            this.Controls.Add(this.btnAddSeller);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddSeller;
        private System.Windows.Forms.Button btnAddBuyer;
        private System.Windows.Forms.Button btnProductSeller;
        private System.Windows.Forms.Button btnProductBuyer;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Label label1;
    }
}

