namespace FeeCalculatorUI
{
    partial class AdminFormulaForm
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
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblFixed = new System.Windows.Forms.Label();
            this.txtFixed = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(16, 21);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(120, 15);
            this.lblOffset.TabIndex = 0;
            this.lblOffset.Text = "Surcharge Offset (+X):";
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(185, 18);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(120, 23);
            this.txtOffset.TabIndex = 1;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(16, 56);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(114, 15);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Percentage Rate (*Y):";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(185, 53);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 23);
            this.txtRate.TabIndex = 3;
            // 
            // lblFixed
            // 
            this.lblFixed.AutoSize = true;
            this.lblFixed.Location = new System.Drawing.Point(16, 91);
            this.lblFixed.Name = "lblFixed";
            this.lblFixed.Size = new System.Drawing.Size(80, 15);
            this.lblFixed.TabIndex = 4;
            this.lblFixed.Text = "Fixed Fee (+Z):";
            // 
            // txtFixed
            // 
            this.txtFixed.Location = new System.Drawing.Point(185, 88);
            this.txtFixed.Name = "txtFixed";
            this.txtFixed.Size = new System.Drawing.Size(120, 23);
            this.txtFixed.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(149, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(230, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AdminFormulaForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 176);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFixed);
            this.Controls.Add(this.lblFixed);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lblOffset);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminFormulaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Admin - Edit Fee Formula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblFixed;
        private System.Windows.Forms.TextBox txtFixed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
