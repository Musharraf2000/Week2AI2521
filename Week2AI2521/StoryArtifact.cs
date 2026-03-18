using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week2AI2521
{
    internal class StoryArtifact
    {
        private int integrty;

        public StoryArtifact()
        {
           integrty = 100;
        }

        public int CurrentIntegrity { get { return integrty; } }

        public void TakeDamage(int amount)
        {
            if(integrty - amount <= 0)
            {
                integrty = 0;
            }
            else
            {
                integrty -= amount;
            }
            Console.WriteLine($"The artifact took {amount} damage. Current integrity: {CurrentIntegrity}");
        }
    }
}
