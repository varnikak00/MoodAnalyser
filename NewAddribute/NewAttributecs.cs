using System;
using System.Collections.Generic;
using System.Text;

namespace NewAttribute
{
    class Attribute
    { 
        Private string title;

            Private string discription;
        public NewAddribute(string t,sting d)
        {
            title = t;
            discription = d
        }
        /// <summary>
        /// Attributes the display.
        /// </summary>
        /// <param name="classType">Type of the class.</param>
        /// <returns></returns>
        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);
            MethodInfo[] methods = classType.GetMethods();        
        for(int i = 0; i < methods.GetLength (0); i++)
            {
                object[] attributeArrray = methods[i].GetCustomAttribute(true);
                foreach (Attribute item in attributeArrray)
                {
                    if (item is NewAttribute);

                    {
                        NewAddribute attributeobject = (NewAttribute)item;
                        Console.WriteLine("{0}-{1},{2}")MethodO(i)
                    }
                }

            }
        }
    }
}
