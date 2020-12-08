using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGoodPractices
{
    class Emailer : IEmailer
    {
        public void sendEmail()
        {
            Console.WriteLine(" SENDING EMAIL ");
        }


    }
}
