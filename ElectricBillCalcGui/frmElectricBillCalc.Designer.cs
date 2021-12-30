
namespace ElectricBillCalcGui
{
    partial class frmElectricBillCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElectricBillCalc));
            this.lblNumCust = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNumCustomer = new System.Windows.Forms.Label();
            this.lblKwhUsed = new System.Windows.Forms.Label();
            this.lblAvgBillAmt = new System.Windows.Forms.Label();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.lblAllCustomers = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCust
            // 
            this.lblNumCust.AutoSize = true;
            this.lblNumCust.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNumCust.Location = new System.Drawing.Point(462, 221);
            this.lblNumCust.Name = "lblNumCust";
            this.lblNumCust.Size = new System.Drawing.Size(253, 27);
            this.lblNumCust.TabIndex = 1;
            this.lblNumCust.Text = "Number of Customers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.label1.Location = new System.Drawing.Point(479, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Usage (kWh)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(470, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average Bill Amount";
            // 
            // lblNumCustomer
            // 
            this.lblNumCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumCustomer.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblNumCustomer.Location = new System.Drawing.Point(462, 264);
            this.lblNumCustomer.Name = "lblNumCustomer";
            this.lblNumCustomer.Size = new System.Drawing.Size(249, 39);
            this.lblNumCustomer.TabIndex = 4;
            this.lblNumCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKwhUsed
            // 
            this.lblKwhUsed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKwhUsed.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKwhUsed.ForeColor = System.Drawing.Color.Black;
            this.lblKwhUsed.Location = new System.Drawing.Point(462, 389);
            this.lblKwhUsed.Name = "lblKwhUsed";
            this.lblKwhUsed.Size = new System.Drawing.Size(249, 39);
            this.lblKwhUsed.TabIndex = 5;
            this.lblKwhUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvgBillAmt
            // 
            this.lblAvgBillAmt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgBillAmt.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvgBillAmt.ForeColor = System.Drawing.Color.Black;
            this.lblAvgBillAmt.Location = new System.Drawing.Point(462, 536);
            this.lblAvgBillAmt.Name = "lblAvgBillAmt";
            this.lblAvgBillAmt.Size = new System.Drawing.Size(249, 39);
            this.lblAvgBillAmt.TabIndex = 6;
            this.lblAvgBillAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCust
            // 
            this.btnAddCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.btnAddCust.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCust.ForeColor = System.Drawing.Color.Black;
            this.btnAddCust.Location = new System.Drawing.Point(462, 631);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(253, 70);
            this.btnAddCust.TabIndex = 7;
            this.btnAddCust.Text = "&Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = false;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // lblAllCustomers
            // 
            this.lblAllCustomers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllCustomers.FormattingEnabled = true;
            this.lblAllCustomers.ItemHeight = 23;
            this.lblAllCustomers.Location = new System.Drawing.Point(12, 221);
            this.lblAllCustomers.Name = "lblAllCustomers";
            this.lblAllCustomers.Size = new System.Drawing.Size(407, 602);
            this.lblAllCustomers.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(462, 753);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(253, 70);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(764, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmElectricBillCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(757, 835);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAllCustomers);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.lblAvgBillAmt);
            this.Controls.Add(this.lblKwhUsed);
            this.Controls.Add(this.lblNumCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumCust);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(212)))), ((int)(((byte)(202)))));
            this.Name = "frmElectricBillCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electric Bill Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumCustomer;
        private System.Windows.Forms.Label lblKwhUsed;
        private System.Windows.Forms.Label lblAvgBillAmt;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.ListBox lblAllCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

