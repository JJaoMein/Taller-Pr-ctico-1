using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter
{
    class Player
    {
        private const int MAX_CRITTERS = 3;
        private const int MIN_CRITTERS = 1;


        public Critter myCritter;
        private List<Critter> myCritters;

        public void AddCritter(Critter newCritter)
        {
            if (myCritters.Count > MIN_CRITTERS && myCritters.Count < MAX_CRITTERS)
            {
                if (newCritter is Critter)
                {
                    Critter enemyCritter = newCritter as Critter;
                    
                    if (enemyCritter != myCritter)
                    {
                        myCritters.Add(enemyCritter);
                    }

                }
            }
        }


        public void RevomeCritter(Critter targetCritter)
        {
            if (myCritters.Count > 0)
            {
                targetCritter = myCritter;

                if (targetCritter.HP <= 0)
                {
                    myCritters.Remove(targetCritter);
                }
            }
        }
    }
}
