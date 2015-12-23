namespace BarCodeGen
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnBarcodeGen = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // btnBarcodeGen
            // 
            this.btnBarcodeGen.Location = new System.Drawing.Point(77, 105);
            this.btnBarcodeGen.Name = "btnBarcodeGen";
            this.btnBarcodeGen.Size = new System.Drawing.Size(113, 47);
            this.btnBarcodeGen.TabIndex = 0;
            this.btnBarcodeGen.Text = "Generate Barcode";
            this.btnBarcodeGen.UseVisualStyleBackColor = true;
            this.btnBarcodeGen.Click += new System.EventHandler(this.btnBarcodeGen_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnBarcodeGen);
            this.Name = "Main";
            this.Text = "Barcode Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarcodeGen;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

