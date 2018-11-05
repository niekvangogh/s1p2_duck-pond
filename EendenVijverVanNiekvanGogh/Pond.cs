using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EendenVijverVanNiekvanGogh
{
    class Pond
    {

        public Pond()
        {
            this.Inhabitants = new List<Animal>();

            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                var gender = random.NextDouble() < .50 ? Gender.MAN : Gender.WOMAN;
                var name = this.Names[random.Next(this.Names.Count)];
                this.Inhabitants.Add(new Duck(name, gender, this));
            }

            for (int i = 0; i < 10; i++)
            {
                var gender = random.NextDouble() < .50 ? Gender.MAN : Gender.WOMAN;
                var name = this.Names[random.Next(this.Names.Count)];
                this.Inhabitants.Add(new Frog(name, gender, this));
            }

            this.Inhabitants.Add(new Stork(
                this.Names[random.Next(this.Names.Count)],
                random.NextDouble() < .50 ? Gender.MAN : Gender.WOMAN,
                this)
            );
        }

        public List<Animal> Inhabitants { get; set; }
        public List<string> Names
        {
            get
            {
                return new List<string>() {
                    "Niek", "Robin", "Yip", "Jan", "Danny", "Thomas", "Jake", "Paul", "Donald",
                    "Tammi", "Gia", "Basil", "Lance", "Janey", "Jennifer",
                    "Joya", "Edna", "Janine", "Una", "Beau", "Jared", "Hoa", "Tiera",
                    "Darby", "Samatha", "Lanny", "Dell", "Cecille"
                };
            }
        }
    }
}
