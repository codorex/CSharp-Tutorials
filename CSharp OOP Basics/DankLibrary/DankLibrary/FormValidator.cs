using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DankLibrary
{
    public static class FormValidator
    {
        public static bool ValidateTextField(Control field)
        {
            bool isNotValid = String.IsNullOrEmpty(field.Text);
            if (isNotValid)
            {
                field.BackColor = Color.Red;
            }

            return !isNotValid;
        }

        public static bool ValidateNumericField(Control field)
        {
            bool isNotValid = Int32.TryParse(field.Text, out int result);
            if (isNotValid)
            {
                field.BackColor = Color.Red;
            }

            return !isNotValid;
        }
    }
}
