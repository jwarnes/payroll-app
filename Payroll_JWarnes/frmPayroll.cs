﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Payroll_JWarnes
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private string generateWageReport()
        {
                //this method performs all the necessary calculations, and then returns a formatted string containing the results
                //this string can then be 

                //perform all the calculations
                decimal gross = Convert.ToDecimal(this.txtHoursWorked.Text) * Convert.ToDecimal(this.txtRate.Text);
                decimal stateTaxWithholding = gross * (Convert.ToDecimal(this.txtStateTax.Text) / 100);
                decimal fedTaxWithholding = gross * (Convert.ToDecimal(this.txtFedTax.Text) / 100);
                decimal ficaWithholding = gross * (Convert.ToDecimal(this.txtFica.Text) / 100);
                decimal miscDeductions = Convert.ToDecimal(this.txtMisc.Text);

                decimal net = gross - stateTaxWithholding - fedTaxWithholding - ficaWithholding - miscDeductions;

                //generate and return the report string
                string wageReport = "Gross Pay: " + gross.ToString("c");
                wageReport += "\r\nNet Pay: " + net.ToString("c");
                wageReport += "\r\n\r\nState Tax Withholding: " + stateTaxWithholding.ToString("c");
                wageReport += "\r\nFederal Tax Withholding: " + fedTaxWithholding.ToString("c");
                wageReport += "\r\nFICA Withholding: " + ficaWithholding.ToString("c");
                wageReport += "\r\nMisc. Deductions: " + miscDeductions.ToString("c");

                return wageReport;
 
        }

        private void displayReport(string report)
        {
            this.lblReport.Text = report;
            this.lblReport.TextAlign = ContentAlignment.MiddleRight;
        }

        private bool validate()
        {
            string errorMessage = "";

            if (!Validator.isDecimal(this.txtHoursWorked))
                errorMessage = "Hours worked must be a number.\n";
            if (!Validator.isDecimal(this.txtRate))
                errorMessage += "Hourly rate must be a number.\n";
            if (!Validator.isDecimal(this.txtStateTax))
                errorMessage += "State tax must be a number.\n";
            if (!Validator.isDecimal(this.txtFedTax))
                errorMessage += "Federal tax must be a number.\n";
            if (!Validator.isDecimal(this.txtFica))
                errorMessage += "Federal tax must be a number.\n";
            if (!Validator.isDecimal(this.txtMisc))
                errorMessage += "Misc. Deductions must be a number.";

            if (errorMessage == "")
                return true;
            else
            {
                MessageBox.Show(errorMessage, "You did something wrong!");
                return false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //run validation method, and if all the data is valid generate the report
            if (this.validate())
            {
                this.displayReport(this.generateWageReport());
                this.btnSave.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //reset the report label back to default
            this.lblReport.Text = "Please complete the fields.";
            this.lblReport.TextAlign = ContentAlignment.MiddleCenter;

            //clear all the fields
            this.txtHoursWorked.Text = this.txtRate.Text = this.txtStateTax.Text =
                this.txtFedTax.Text = this.txtFica.Text = this.txtMisc.Text = "";
            
            //disable save button
            this.btnSave.Enabled = false;

            //give focus to the first control
            this.txtHoursWorked.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //open a save dialog if the user clicks the btnSave control
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Payroll Report";
            save.Filter = "Text Files|*.txt";
            save.ShowDialog();

            if(save.FileName != "")
            {
                //convert the contents of lblReport to a byte array
                byte[] report = new UTF8Encoding(true).GetBytes("Payroll Report\r\n----------------\r\n\r\n" + this.lblReport.Text);

                //open a filestream and write the report to the file
                FileStream saveStream = (FileStream)save.OpenFile();
                saveStream.Write(report, 0, report.Length);
                saveStream.Close();
                
            }
        }
    }
}
