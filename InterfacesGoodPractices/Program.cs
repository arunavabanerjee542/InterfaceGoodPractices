using InterfacesGoodPractices.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InterfacesGoodPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailer e = MyFactory.getEmailer();
            ITextMessage t = MyFactory.getTextMessage();

            MyFactory.showReflection();


            e.sendEmail();
            t.sendText();


        }
    }
}
