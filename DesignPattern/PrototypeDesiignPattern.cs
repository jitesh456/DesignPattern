using System;
namespace DesignPattern
{
    public interface IAnimal : ICloneable
    {

         IAnimal MakeCopy();


    }

    class Sheep : IAnimal
    {

        public object Clone()
        {
            object clone = MemberwiseClone();
            return clone;
        }

        public IAnimal MakeCopy()
            {
                Sheep sheep= null;
                try
                {
                    sheep = (Sheep)this.Clone();
                }
                catch (NotSupportedException e)
                {
                    Console.WriteLine(e.Message);
                }
                return sheep;
            }
    }

    public class CloneFactory
    {

        public IAnimal GetClone(IAnimal sample)
        {
            return sample.MakeCopy();
        }

    }
}
