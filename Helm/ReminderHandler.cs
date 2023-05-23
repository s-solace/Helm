using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helm
{

    

    internal class ReminderHandler
    {

        private DateTime dt;
        bool hasTime;

        public ReminderHandler(DateTime d, bool b)
        {
            hasTime = b;
            dt = d;
        }


    }
}
