using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//  7.3.	You will need add: using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace CChavezCustomExceptionsDemo_
{

    //  7.1.	Add a class to your project:
    internal class SocialSecurityNumber
    {
        //  7.2.	This code uses a regex to validate that a social security
        //          number has been set into the SSN property.
        private string ssn;

        public string SSN
        {
            get { return ssn; }
            set
            {

                //  This is Regex for Social secuirty number
                //  these can be looked up online look for Regex or Regular Expresions
                //  https://regex101.com/
                //  This is the pattern intake looking for
                //  3 digets a "-" 2 digits another "-" and then a final 3 digits
                //  string pattern = @"^\d{3}-\d{2}-\d{4}$";
                // This is a better one that has exceptions around SSSN numbers
                // it cant let it start with "9 and any 2 numbers", 666, or 000 in the first 3 characters ?!666|000|9\\d{2})
                //  it won't let the center numbers be 00
                // it also won't let the last 4 numbers be 0000 (?!0{4})\\d{4}
                string pattern = "^(?!666|000|9\\d{2})\\d{3}-(?!00)\\d{2}-(?!0{4})\\d{4}$";
                if (Regex.IsMatch(value, pattern))
                {
                    ssn = value;
                }
                else
                {
                    //throw new Exception();
                    //  7.9.In the SocialSecurityNumber class change the throw statement to:
                    //throw new ArgumentException("Not a valid Social Social Security Number");
                    //  8.6.Change the throw statement in your SocialSecurityClass to:
                    throw new SSNFormatException();

                }
            }
        }
    }

}
