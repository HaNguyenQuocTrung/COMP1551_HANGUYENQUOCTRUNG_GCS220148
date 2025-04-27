namespace COMP1551_HANGUYENQUOCTRUNG_FINAL
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtInputString = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblEncodedString = new System.Windows.Forms.Label();
            this.lblInputCodes = new System.Windows.Forms.Label();
            this.lblOutputCodes = new System.Windows.Forms.Label();
            this.lblSortedInput = new System.Windows.Forms.Label();
            this.lblInputString = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblInputHash = new System.Windows.Forms.Label();      // NEW
            this.lblEncodedHash = new System.Windows.Forms.Label();   // NEW
            this.SuspendLayout();
            // 
            // txtInputString
            // 
            this.txtInputString.Location = new System.Drawing.Point(12, 32);
            this.txtInputString.MaxLength = 40;
            this.txtInputString.Name = "txtInputString";
            this.txtInputString.Size = new System.Drawing.Size(260, 20);
            this.txtInputString.TabIndex = 0;
            this.txtInputString.PlaceholderText = "Enter a string (A-Z)";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(12, 84);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(260, 20);
            this.txtN.TabIndex = 1;
            this.txtN.PlaceholderText = "Enter integer N (-25 to 25)";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 110);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(260, 23);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblEncodedString
            // 
            this.lblEncodedString.AutoSize = true;
            this.lblEncodedString.Location = new System.Drawing.Point(12, 150);
            this.lblEncodedString.Name = "lblEncodedString";
            this.lblEncodedString.Text = "Encoded String: ";
            // 
            // lblInputCodes
            // 
            this.lblInputCodes.AutoSize = true;
            this.lblInputCodes.Location = new System.Drawing.Point(12, 170);
            this.lblInputCodes.Name = "lblInputCodes";
            this.lblInputCodes.Text = "ASCII Codes of Input: ";
            // 
            // lblOutputCodes
            // 
            this.lblOutputCodes.AutoSize = true;
            this.lblOutputCodes.Location = new System.Drawing.Point(12, 190);
            this.lblOutputCodes.Name = "lblOutputCodes";
            this.lblOutputCodes.Text = "ASCII Codes of Output: ";
            // 
            // lblSortedInput
            // 
            this.lblSortedInput.AutoSize = true;
            this.lblSortedInput.Location = new System.Drawing.Point(12, 210);
            this.lblSortedInput.Name = "lblSortedInput";
            this.lblSortedInput.Text = "Sorted Input: ";
            // 
            // lblInputString
            // 
            this.lblInputString.AutoSize = true;
            this.lblInputString.Location = new System.Drawing.Point(12, 16);
            this.lblInputString.Name = "lblInputString";
            this.lblInputString.Text = "Input String:";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 68);
            this.lblN.Name = "lblN";
            this.lblN.Text = "N (Shift Value):";
            // 
            // lblInputHash
            // 
            this.lblInputHash.AutoSize = true;
            this.lblInputHash.Location = new System.Drawing.Point(12, 230);
            this.lblInputHash.Name = "lblInputHash";
            this.lblInputHash.Text = "Input Hash:";
            //
            // lblEncodedHash
            //
            this.lblEncodedHash.AutoSize = true;
            this.lblEncodedHash.Location = new System.Drawing.Point(12, 250);
            this.lblEncodedHash.Name = "lblEncodedHash";
            this.lblEncodedHash.Text = "Encoded Hash:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 280);
            this.Controls.Add(this.lblEncodedHash);   // NEW
            this.Controls.Add(this.lblInputHash);      // NEW
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblInputString);
            this.Controls.Add(this.lblSortedInput);
            this.Controls.Add(this.lblOutputCodes);
            this.Controls.Add(this.lblInputCodes);
            this.Controls.Add(this.lblEncodedString);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtInputString);
            this.Name = "Form1";
            this.Text = "String Processing Application";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtInputString;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblEncodedString;
        private System.Windows.Forms.Label lblInputCodes;
        private System.Windows.Forms.Label lblOutputCodes;
        private System.Windows.Forms.Label lblSortedInput;
        private System.Windows.Forms.Label lblInputString;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblInputHash;     // NEW
        private System.Windows.Forms.Label lblEncodedHash;  // NEW
    }
}
