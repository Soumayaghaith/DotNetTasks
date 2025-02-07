using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4
{
    internal class BaseClass
    {
        #region Methods
        virtual public void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
        #endregion
    }
}
