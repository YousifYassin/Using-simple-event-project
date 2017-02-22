using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    public delegate void myEventHandler(string value);

    class EventPublisher
    {
        private string theval;
        public event myEventHandler changedValue;
        public string Val
        {
            set
            {
                this.theval = value;
                this.changedValue(theval);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventPublisher obj = new EventPublisher();
            obj.changedValue += changedValue;
            string str;
            do
            {
                Console.WriteLine("Enter the value");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));
            Console.WriteLine("Goodbye!");
        }
        static void changedValue(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
    }
}
