namespace FeeCalculatorUI
{
    partial class SimpleCalc
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
            this.txtSurcharge = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTicketTotal = new System.Windows.Forms.TextBox();
            this.txtServiceFee = new System.Windows.Forms.TextBox();
            this.lblArResult = new System.Windows.Forms.Label();
            this.btnCalculateAR = new System.Windows.Forms.Button();
            this.btnEditFormula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSurcharge
            // 
            this.txtSurcharge.Location = new System.Drawing.Point(37, 46);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(100, 20);
            this.txtSurcharge.TabIndex = 0;
            this.txtSurcharge.TextChanged += new System.EventHandler(this.txtSurcharge_change);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(143, 43);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Fee\r\n";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Surcharge";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(325, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Total Fee: $0.00";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ticket Total";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Service Fee";
            // 
            // txtTicketTotal
            // 
            this.txtTicketTotal.Location = new System.Drawing.Point(37, 106);
            this.txtTicketTotal.Name = "txtTicketTotal";
            this.txtTicketTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTicketTotal.TabIndex = 6;
            this.txtTicketTotal.TextChanged += new System.EventHandler(this.txtTicketTotal_TextChanged);
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.Location = new System.Drawing.Point(37, 148);
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.Size = new System.Drawing.Size(100, 20);
            this.txtServiceFee.TabIndex = 7;
            this.txtServiceFee.TextChanged += new System.EventHandler(this.txtServiceFee_TextChanged);
            // 
            // lblArResult
            // 
            this.lblArResult.AutoSize = true;
            this.lblArResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblArResult.Location = new System.Drawing.Point(325, 180);
            this.lblArResult.Name = "lblArResult";
            this.lblArResult.Size = new System.Drawing.Size(82, 17);
            this.lblArResult.TabIndex = 8;
            this.lblArResult.Text = "AR amount:";
            this.lblArResult.Click += new System.EventHandler(this.lblArResult_Click);
            // 
            // btnCalculateAR
            // 
            this.btnCalculateAR.Location = new System.Drawing.Point(37, 175);
            this.btnCalculateAR.Name = "btnCalculateAR";
            this.btnCalculateAR.Size = new System.Drawing.Size(130, 23);
            this.btnCalculateAR.TabIndex = 9;
            this.btnCalculateAR.Text = "Calculate AR amount";
            this.btnCalculateAR.UseVisualStyleBackColor = true;
            this.btnCalculateAR.Click += new System.EventHandler(this.btnCalculateAR_Click);
            // 
            // btnEditFormula
            // 
            this.btnEditFormula.Location = new System.Drawing.Point(476, 12);
            this.btnEditFormula.Name = "btnEditFormula";
            this.btnEditFormula.Size = new System.Drawing.Size(121, 23);
            this.btnEditFormula.TabIndex = 10;
            this.btnEditFormula.Text = "Admin: Edit Formula";
            this.btnEditFormula.UseVisualStyleBackColor = true;
            this.btnEditFormula.Click += new System.EventHandler(this.btnEditFormula_Click);
            // 
            // SimpleCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 227);
            this.Controls.Add(this.btnEditFormula);
            this.Controls.Add(this.btnCalculateAR);
            this.Controls.Add(this.lblArResult);
            this.Controls.Add(this.txtServiceFee);
            this.Controls.Add(this.txtTicketTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtSurcharge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimpleCalc";
            this.Text = "Barkota Fee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSurcharge;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTicketTotal;
        private System.Windows.Forms.TextBox txtServiceFee;
        private System.Windows.Forms.Label lblArResult;
        private System.Windows.Forms.Button btnCalculateAR;
        private System.Windows.Forms.Button btnEditFormula;
    }
}

