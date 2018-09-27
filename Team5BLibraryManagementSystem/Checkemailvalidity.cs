using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Team5BLibraryManagementSystem
{
    public class Checkemailvalidity
    {
        //Check name validity
        public bool IsValidName(string strIn)
        {
            if (strIn.Any(char.IsSymbol) || strIn.Any(char.IsDigit))
            {
                MessageBox.Show("Name cannot contains special characters and digits!","Warning",MessageBoxButtons.OK);
                return false;
            }

            else
            {
                return true;
            }           
        }

        //Check phone validity
        public bool IsValidPhone(string strIn)
        {
            if (strIn.Any(char.IsDigit))
            {              
                return true;
            }

            else
            {
                MessageBox.Show("Phone number can contain only digits!", "Warning", MessageBoxButtons.OK);
                return false;
            }
        }

        //Check email validity
        bool invalid = false;
        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;
          
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
            {               
                return false;               
            }
                
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
          
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
