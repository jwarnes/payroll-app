namespace Payroll_JWarnes
{
    partial class frmPayroll
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMisc = new System.Windows.Forms.TextBox();
            this.txtFica = new System.Windows.Forms.TextBox();
            this.txtFedTax = new System.Windows.Forms.TextBox();
            this.txtStateTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtHoursWorked);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(244, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wages Earned";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(147, 53);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(73, 22);
            this.txtRate.TabIndex = 3;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(147, 20);
            this.txtHoursWorked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(73, 22);
            this.txtHoursWorked.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly &Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Hours Worked";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMisc);
            this.groupBox2.Controls.Add(this.txtFica);
            this.groupBox2.Controls.Add(this.txtFedTax);
            this.groupBox2.Controls.Add(this.txtStateTax);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(16, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(244, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Withholdings";
            // 
            // txtMisc
            // 
            this.txtMisc.Location = new System.Drawing.Point(147, 116);
            this.txtMisc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMisc.Name = "txtMisc";
            this.txtMisc.Size = new System.Drawing.Size(73, 22);
            this.txtMisc.TabIndex = 7;
            // 
            // txtFica
            // 
            this.txtFica.Location = new System.Drawing.Point(147, 85);
            this.txtFica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFica.Name = "txtFica";
            this.txtFica.Size = new System.Drawing.Size(73, 22);
            this.txtFica.TabIndex = 5;
            // 
            // txtFedTax
            // 
            this.txtFedTax.Location = new System.Drawing.Point(147, 54);
            this.txtFedTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFedTax.Name = "txtFedTax";
            this.txtFedTax.Size = new System.Drawing.Size(73, 22);
            this.txtFedTax.TabIndex = 3;
            // 
            // txtStateTax
            // 
            this.txtStateTax.Location = new System.Drawing.Point(147, 23);
            this.txtStateTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStateTax.Name = "txtStateTax";
            this.txtStateTax.Size = new System.Drawing.Size(73, 22);
            this.txtStateTax.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "&Misc. Deductions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "F&ICA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "&Fed. Income Tax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "&State Income Tax";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblReport);
            this.groupBox3.Location = new System.Drawing.Point(268, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(251, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wage Breakdown";
            // 
            // lblReport
            // 
            this.lblReport.Location = new System.Drawing.Point(8, 25);
            this.lblReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReport.MaximumSize = new System.Drawing.Size(400, 369);
            this.lblReport.MinimumSize = new System.Drawing.Size(13, 12);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(235, 154);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Please complete the fields.";
            this.lblReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(288, 213);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 249);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 4;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(396, 249);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File|*.txt";
            this.saveFileDialog1.Title = "Save Payroll Report";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(396, 213);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Sa&ve to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmPayroll
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(532, 292);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmPayroll";
            this.Text = "Payroll Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtMisc;
        private System.Windows.Forms.TextBox txtFica;
        private System.Windows.Forms.TextBox txtFedTax;
        private System.Windows.Forms.TextBox txtStateTax;




    }
}

