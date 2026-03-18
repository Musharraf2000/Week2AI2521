using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class CursedArtifact:StoryArtifact
    {
        private int cursedStacks;

        public CursedArtifact():base()
        {
            cursedStacks = 2;
        }

        public void TriggerCurse()
        {
            if (cursedStacks > 0)
            {
                cursedStacks--;
                TakeDamage(25);
            }
            else if (cursedStacks == 0)
            {
                TakeDamage(60);
            }
            Console.WriteLine("Current Cursed Stacks : "+cursedStacks);
        }
    }
}
