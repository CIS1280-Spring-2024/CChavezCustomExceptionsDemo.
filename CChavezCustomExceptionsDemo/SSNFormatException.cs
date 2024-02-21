using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CChavezCustomExceptionsDemo_
{
    //  8.3.	Notice the highlighted section above. To create a user-defined Exception you use
    //  inheritance. In this case our SSNFormatException is going to inherit from the Exception
    //  class. This means that SSNFormatException will have all the properties and methods
    //  that Exception has plus whatever we define in the SSNFormatException class.
    class SSNFormatException : Exception
    {
        // Constructor
        public SSNFormatException() : base("Not a valid Social Social Security Number.")
        {
        }
        public SSNFormatException(string message) : base (message)
        {

        }
    }
    //  8.4.	In this case we just define a parameterless constructor that calls the base
    //  class single parameter constructor(hence the keyword base) to set a default message.
    //  8.5.	Note, if you override a class you get properties and methods but not the base
    //  class constructors. You have to define those in your base class (more information on this is in Chapter 4 of your book).

}
