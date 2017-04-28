using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachConnect
{
    class Validation
    {

        public bool validateTextBox(String tb)
        {
            if (String.IsNullOrEmpty(tb) || !tb.All(char.IsLetter))return false;
            else return true;
        }

        public String CleanString(String dirty)
        {
            String clean = "";
            return clean;
        }
    }
}
