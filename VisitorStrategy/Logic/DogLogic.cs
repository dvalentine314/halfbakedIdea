using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorStrategy.Logic
{
    public class DogLogic : WEBAPIModels.Dog, IAnimalAction
    {
        public void Eat()
        {
            Console.WriteLine("eat fast");
            //do other things dog specific
        }
    }
}
