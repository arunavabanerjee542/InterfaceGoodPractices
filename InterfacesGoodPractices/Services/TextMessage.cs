using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGoodPractices
{
    class TextMessage : ITextMessage
    {
        public void sendText()
        {
            Console.WriteLine(" Text message is Going ");
        }

    }
}
