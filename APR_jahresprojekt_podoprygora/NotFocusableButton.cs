using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APR_jahresprojekt_podoprygora
{
    internal class NotFocusableButton : Button
    {
        public bool CanFocus
        {
            get { return false; }
        }
    }
}
