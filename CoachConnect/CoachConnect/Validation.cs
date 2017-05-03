using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachConnect
{
    public class Validation
    {

        public bool ValidateTextBox(string tb)
        {
            if (string.IsNullOrEmpty(tb) || !tb.Trim().All(char.IsLetter)) return false;
            else return true;
        }

        public bool ValidateEmail(string tb)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(tb);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ValidatePhone(string tb)
        {
            if (tb.Length == 10) return true;
            else return false;
        }

        public bool ValidateComboBox(int selectedIndex)
        {
            if (selectedIndex == -1) return false;
            else return true;
        }

        public string CleanString(string dirty)
        {
            string clean = "";
            clean = dirty.Trim();
            if (clean.Length > 1) return char.ToUpper(clean[0]) + clean.Substring(1).ToLower();
            else return clean.ToUpper();
            
        }

        public string CleanNumber(string dirty)
        {
            string clean = "";
            foreach (char num in dirty)
            {
                if (char.IsDigit(num)) clean += num.ToString();
            }
            return clean;
        }
        public string FormatPhone(string phone)
        {
            string formatPhone = "";
            return formatPhone = ("(" + phone.Substring(0, 3) + ")" + phone.Substring(3, 3) + "-" + phone.Substring(6, 4));
        }
    }
}
