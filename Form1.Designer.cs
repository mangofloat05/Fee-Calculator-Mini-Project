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
            this.txtSurcharge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurcharge.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSurcharge.Location = new System.Drawing.Point(36, 56);
            this.txtSurcharge.Name = "txtSurcharge";
            this.txtSurcharge.Size = new System.Drawing.Size(220, 25);
            this.txtSurcharge.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btnCalculate.FlatAppearance.BorderSize = 0;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(36, 91);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 34);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Fee";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surcharge";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 9F);
            this.lblResult.Location = new System.Drawing.Point(287, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Padding = new System.Windows.Forms.Padding(8);
            this.lblResult.Size = new System.Drawing.Size(300, 130);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Fee breakdown will appear here.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ticket Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(34, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Payment Service Fee";
            // 
            // txtTicketTotal
            // 
            this.txtTicketTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTicketTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTicketTotal.Location = new System.Drawing.Point(36, 166);
            this.txtTicketTotal.Name = "txtTicketTotal";
            this.txtTicketTotal.Size = new System.Drawing.Size(220, 25);
            this.txtTicketTotal.TabIndex = 6;
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServiceFee.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServiceFee.Location = new System.Drawing.Point(36, 221);
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.Size = new System.Drawing.Size(220, 25);
            this.txtServiceFee.TabIndex = 7;
            // 
            // lblArResult
            // 
            this.lblArResult.BackColor = System.Drawing.Color.White;
            this.lblArResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblArResult.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblArResult.Location = new System.Drawing.Point(287, 180);
            this.lblArResult.Name = "lblArResult";
            this.lblArResult.Padding = new System.Windows.Forms.Padding(8);
            this.lblArResult.Size = new System.Drawing.Size(300, 66);
            this.lblArResult.TabIndex = 8;
            this.lblArResult.Text = "AR Amount: ₱0.00";
            // 
            // btnCalculateAR
            // 
            this.btnCalculateAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCalculateAR.FlatAppearance.BorderSize = 0;
            this.btnCalculateAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateAR.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculateAR.ForeColor = System.Drawing.Color.White;
            this.btnCalculateAR.Location = new System.Drawing.Point(36, 258);
            this.btnCalculateAR.Name = "btnCalculateAR";
            this.btnCalculateAR.Size = new System.Drawing.Size(220, 34);
            this.btnCalculateAR.TabIndex = 9;
            this.btnCalculateAR.Text = "Calculate AR amount";
            this.btnCalculateAR.UseVisualStyleBackColor = false;
            this.btnCalculateAR.Click += new System.EventHandler(this.btnCalculateAR_Click);
            // 
            // btnEditFormula
            // 
            this.btnEditFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnEditFormula.FlatAppearance.BorderSize = 0;
            this.btnEditFormula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFormula.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnEditFormula.ForeColor = System.Drawing.Color.White;
            this.btnEditFormula.Location = new System.Drawing.Point(461, 8);
            this.btnEditFormula.Name = "btnEditFormula";
            this.btnEditFormula.Size = new System.Drawing.Size(126, 24);
            this.btnEditFormula.TabIndex = 10;
            this.btnEditFormula.Text = "Admin: Edit Formula";
            this.btnEditFormula.UseVisualStyleBackColor = false;
            this.btnEditFormula.Visible = false;
            this.btnEditFormula.Click += new System.EventHandler(this.btnEditFormula_Click);
            // 
            // SimpleCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(624, 314);
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
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SimpleCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barkota Fee Calculator";
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

