using System;

namespace Laborator1
{
    public class Problema1
    {
        public static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.MyEvent += c_MyEvent;

            Console.WriteLine("Apasa 'a' pentru a numara");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        public static void c_MyEvent(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Environment.Exit(0);
        }
    }

    public class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                OnMyEvent(EventArgs.Empty);
            }
        }

        protected virtual void OnMyEvent(EventArgs e)
        {
            EventHandler handler = MyEvent;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler MyEvent;
    }
}