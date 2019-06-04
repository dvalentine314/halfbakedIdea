using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorStrategy.Logic
{
    public class CatLogic : WEBAPIModels.Cat, IAnimalAction
    {
        public void Eat()
        {
            if (this.ThingsClawed != null)
            {
                Console.WriteLine("only eat the middle");
                //do other things cat specific
            }
        }
    }
}
