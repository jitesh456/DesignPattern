using System;
namespace DesignPattern
{
    public class SingletonDesinPattern
    {
        private static SingletonDesinPattern Singleton=new SingletonDesinPattern();
        private SingletonDesinPattern()
        {
        }

        public static SingletonDesinPattern GetInstance()
        {
            return Singleton;   
        }

        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
