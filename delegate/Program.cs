using System;

namespace delegate1
{
    class Program
{
        private static void HelloMessage() 
        {
            Console.WriteLine("Hello");
        }
        private static void ByeMessage()
        {
            Console.WriteLine("Bye");
        }
        private static void WorkMessage(DayOfWeek day)
        {
            Console.WriteLine("Work "+ day);
        }
        delegate void MyFirstDelegate();
        delegate void MySecondDelegate(DayOfWeek day);
        static void Main(string[] args)
    {
            MyFirstDelegate del;
            MySecondDelegate del2;
            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                del = HelloMessage;
                del();
            }
            if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                del = ByeMessage;
                del();
            }
            if((DateTime.Now.DayOfWeek != DayOfWeek.Monday) & (DateTime.Now.DayOfWeek != DayOfWeek.Sunday))
            {
                del2 = WorkMessage;
                del2(DateTime.Now.DayOfWeek);
            }
              
            
    }
}
}

