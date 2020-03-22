using System;

namespace Laborator1
{
    public delegate string myEvent(string str);

    public class EventProgram
    {
        event myEvent MyEvent;

        public EventProgram()
        {
            this.MyEvent += new myEvent(this.WelcomeUser);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        //public static void Main(string[] args)
        //{
        //    EventProgram obj1 = new EventProgram();
        //    string result = obj1.MyEvent("Alert");
        //    Console.WriteLine(result);
        //}
    }
}