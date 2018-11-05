using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanNiekvanGogh
{
    class Stork : Animal
    {

        public Stork(string name, Gender gender, Pond home) : base(name, gender, home)
        {

        }

        public void EatFrog(Frog frog)
        {
            frog.Home.Inhabitants.Remove(frog);
        }
    }
}
