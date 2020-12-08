using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesGoodPractices.Factory
{
    static class MyFactory
    {
       static public IEmailer getEmailer()
        {
            return new Emailer();
        }

       static public ITextMessage getTextMessage()
        {
            return new TextMessage();
        }

        static public  void showReflection()
        {
            // Now Lets try this using reflection

            // Load the current assembly
            Assembly currentassembly = Assembly.GetExecutingAssembly();

            // Load the type of class
            Type type = currentassembly.GetType("InterfacesGoodPractices.Emailer");

            // create instance
            object instance = Activator.CreateInstance(type);

            // know the method
            MethodInfo method = type.GetMethod("sendEmail");

            Console.WriteLine(" This Message appears through Reflection ");

            method.Invoke(instance, null);
        }


    }
}
