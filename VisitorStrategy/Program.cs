using System;
using VisitorStrategy.WEBAPIModels;
using VisitorStrategy.Translation;

namespace VisitorStrategy
{
    class Program
    {
        /**
         Rules and restrictions:
            Models cannot have functions because they are exposed to outside systems

        */
        static void Main(string[] args)
        {

            Animal firstRequest = new Cat { ThingsClawed = "sofa"};
            //pretend this is an incoming restful request to a controller. probably using webapi
            fakeController(firstRequest);

            Animal secondRequest = new Dog { ThingsSmelled = "bush" };
            //pretend this is an incoming restful request to a controller. probably using webapi
            fakeController(secondRequest);
        }

        public static void fakeController(Animal animal)
        {

            var animalWithLogic = Translation.AnimalTranslation.Translate(animal);

            animalWithLogic.Eat();
        }


    }
}
