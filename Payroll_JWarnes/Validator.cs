using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_JWarnes
{
    class Validator
    {
        //this method is used to check if a textbox contains a decimal appropriate value
        public static bool isDecimal(TextBox textBox)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }

   
}
