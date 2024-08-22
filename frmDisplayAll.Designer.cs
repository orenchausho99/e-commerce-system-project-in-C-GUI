namespace FinalProject_orengal_part5_GUI
{
    partial class frmDisplayAll
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
            this.txtBoxPrintAll = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxPrintAll
            // 
            this.txtBoxPrintAll.Location = new System.Drawing.Point(12, 12);
            this.txtBoxPrintAll.Multiline = true;
            this.txtBoxPrintAll.Name = "txtBoxPrintAll";
            this.txtBoxPrintAll.Size = new System.Drawing.Size(776, 426);
            this.txtBoxPrintAll.TabIndex = 0;
            this.txtBoxPrintAll.TextChanged += new System.EventHandler(this.txtBoxPrintAll_TextChanged);
            // 
            // frmDisplayAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxPrintAll);
            this.Name = "frmDisplayAll";
            this.Text = "frmDisplayAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPrintAll;
    }
}