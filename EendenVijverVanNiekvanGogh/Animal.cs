using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanNiekvanGogh
{
    abstract class Animal
    {
        public Animal(string name, Gender geslacht, Pond home)
        {
            this.Name = name;
            this.Geslacht = geslacht;
            this.Home = home;
        }

        public Gender Geslacht { get; private set; }
        public string Name { get; private set; }
        public Pond Home { get; internal set; }

        public override string ToString()
        {
            return this.Name + " the " + this.GetType().Name;
        }
    }
}
