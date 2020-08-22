using System;

namespace DesignPattern
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SingletonDesinPattern singleton1 = SingletonDesinPattern.GetInstance();
            SingletonDesinPattern singleton = SingletonDesinPattern.GetInstance();
            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton.GetHashCode());

            Console.WriteLine("=============FactoryDesignPattern Pattern");
            INotification notification = new FactoryDesignPattern().getObject("SMS");
            INotification notification1 = new FactoryDesignPattern().getObject("EMAIL");
            notification.notifyUser();
            notification1.notifyUser();

            Console.WriteLine("=============ProtoType Design======");
            Sheep marrin = new Sheep();

            CloneFactory cloneMaker = new CloneFactory();

            Sheep cloneSheep = (Sheep)cloneMaker.GetClone(marrin);

            Console.WriteLine("HashCode of marrin:" + marrin.GetHashCode() + "\nHashCode Of sheepClone:" + cloneSheep.GetHashCode());

            Console.WriteLine("=============Decorator Design======");

            IPizza makePizza = new Mozzerela(new PlainPizza());

            Console.WriteLine("Discription:"+makePizza.GetDescription());
            Console.WriteLine("Cost:" + makePizza.GetCost());

        }
    }
}
