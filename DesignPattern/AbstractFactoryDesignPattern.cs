using System;
namespace DesignPattern
{
    public interface IPizza
    {
        string GetDescription();
        int GetCost();
    }
    public class AbstractFactoryDesignPattern
    {
        public AbstractFactoryDesignPattern()
        {
        }
    }
    public class PlainPizza : IPizza
    {
        public int GetCost()
        {
            return 4;
        }

        public string GetDescription()
        {
            return "Thin dough";
        }
    }
    //Decorator class

    public class ToppingDecorator : IPizza
    {
        protected IPizza temp;

        public ToppingDecorator(IPizza pizza)
        {
            this.temp = pizza;
        }
        public int GetCost()
        {
            return temp.GetCost();
        }

        public string GetDescription()
        {
            return temp.GetDescription();
        }
    }

    public class Mozzerela : ToppingDecorator
    {
        public Mozzerela(IPizza pizza) : base(pizza)
        {
        }

        public  new int  GetCost()
        {
            return temp.GetCost()+ 2 ;
        }

        public  new string GetDescription()
        {
            return temp.GetDescription()+"Mozzarella";
        }
    }




}

