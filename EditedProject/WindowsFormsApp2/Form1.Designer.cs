namespace WindowsFormsApp2
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
            this.BTN = new System.Windows.Forms.Button();
            this.TxtBinary = new System.Windows.Forms.TextBox();
            this.LabBinary = new System.Windows.Forms.Label();
            this.LabOctal = new System.Windows.Forms.Label();
            this.TxtOctal = new System.Windows.Forms.TextBox();
            this.LabHexa = new System.Windows.Forms.Label();
            this.TxtHexa = new System.Windows.Forms.TextBox();
            this.LabDici = new System.Windows.Forms.Label();
            this.TxtDecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN
            // 
            this.BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN.Location = new System.Drawing.Point(285, 452);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(256, 51);
            this.BTN.TabIndex = 0;
            this.BTN.Text = "Done";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // TxtBinary
            // 
            this.TxtBinary.Location = new System.Drawing.Point(339, 82);
            this.TxtBinary.Multiline = true;
            this.TxtBinary.Name = "TxtBinary";
            this.TxtBinary.Size = new System.Drawing.Size(333, 42);
            this.TxtBinary.TabIndex = 1;
            // 
            // LabBinary
            // 
            this.LabBinary.AutoSize = true;
            this.LabBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabBinary.Location = new System.Drawing.Point(169, 86);
            this.LabBinary.Name = "LabBinary";
            this.LabBinary.Size = new System.Drawing.Size(116, 38);
            this.LabBinary.TabIndex = 2;
            this.LabBinary.Text = "Binary";
            // 
            // LabOctal
            // 
            this.LabOctal.AutoSize = true;
            this.LabOctal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabOctal.Location = new System.Drawing.Point(169, 176);
            this.LabOctal.Name = "LabOctal";
            this.LabOctal.Size = new System.Drawing.Size(99, 38);
            this.LabOctal.TabIndex = 4;
            this.LabOctal.Text = "Octal";
            // 
            // TxtOctal
            // 
            this.TxtOctal.Location = new System.Drawing.Point(339, 172);
            this.TxtOctal.Multiline = true;
            this.TxtOctal.Name = "TxtOctal";
            this.TxtOctal.Size = new System.Drawing.Size(333, 43);
            this.TxtOctal.TabIndex = 3;
            // 
            // LabHexa
            // 
            this.LabHexa.AutoSize = true;
            this.LabHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHexa.Location = new System.Drawing.Point(169, 263);
            this.LabHexa.Name = "LabHexa";
            this.LabHexa.Size = new System.Drawing.Size(98, 38);
            this.LabHexa.TabIndex = 6;
            this.LabHexa.Text = "Hexa";
            // 
            // TxtHexa
            // 
            this.TxtHexa.Location = new System.Drawing.Point(339, 259);
            this.TxtHexa.Multiline = true;
            this.TxtHexa.Name = "TxtHexa";
            this.TxtHexa.Size = new System.Drawing.Size(333, 43);
            this.TxtHexa.TabIndex = 5;
            // 
            // LabDici
            // 
            this.LabDici.AutoSize = true;
            this.LabDici.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabDici.Location = new System.Drawing.Point(169, 350);
            this.LabDici.Name = "LabDici";
            this.LabDici.Size = new System.Drawing.Size(142, 38);
            this.LabDici.TabIndex = 8;
            this.LabDici.Text = "Decimal";
            // 
            // TxtDecimal
            // 
            this.TxtDecimal.Location = new System.Drawing.Point(339, 346);
            this.TxtDecimal.Multiline = true;
            this.TxtDecimal.Name = "TxtDecimal";
            this.TxtDecimal.Size = new System.Drawing.Size(333, 43);
            this.TxtDecimal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 573);
            this.Controls.Add(this.LabDici);
            this.Controls.Add(this.TxtDecimal);
            this.Controls.Add(this.LabHexa);
            this.Controls.Add(this.TxtHexa);
            this.Controls.Add(this.LabOctal);
            this.Controls.Add(this.TxtOctal);
            this.Controls.Add(this.LabBinary);
            this.Controls.Add(this.TxtBinary);
            this.Controls.Add(this.BTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN;
        private System.Windows.Forms.TextBox TxtBinary;
        private System.Windows.Forms.Label LabBinary;
        private System.Windows.Forms.Label LabOctal;
        private System.Windows.Forms.TextBox TxtOctal;
        private System.Windows.Forms.Label LabHexa;
        private System.Windows.Forms.TextBox TxtHexa;
        private System.Windows.Forms.Label LabDici;
        private System.Windows.Forms.TextBox TxtDecimal;
    }
}

