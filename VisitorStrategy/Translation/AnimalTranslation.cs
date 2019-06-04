using System;
using System.Collections.Generic;
using System.Text;
using VisitorStrategy.Logic;
using VisitorStrategy.WEBAPIModels;

namespace VisitorStrategy.Translation
{
    public static class AnimalTranslation
    {

        internal static IAnimalAction Translate(Animal animal)
        {
            var cat = animal as Cat;
            var dog = animal as Dog;
            if (cat != null)
            {
                return Translate(cat);
            }
            else if(dog!=null)
            {
                return Translate(dog);
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

        public static CatLogic Translate(Cat cat)
        {
            return new CatLogic
            {
                ThingsClawed = cat.ThingsClawed,
                Legs = cat.Legs
            };
        }

        public static DogLogic Translate(Dog dog)
        {
            return new DogLogic
            {
                ThingsSmelled = dog.ThingsSmelled,
                Legs = dog.Legs
            };
        }
    }
}
