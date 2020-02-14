using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Modell
{
    /// <summary>
    /// A versenyző osztály
    /// </summary>
    class Racer
    {
        /// <summary>
        /// A versenyző osztály adattagjai.
        /// </summary>
        private string name;
        private int age;
        private int salery;


        /// <summary>
        /// Üres konstruktor lehtetlen adatokkal.
        /// </summary>
        public Racer()
        {
            name = string.Empty;
            age = -1;
            salery = -1;
        }


        /// <summary>
        /// Teljes konstruktor.
        /// </summary>
        /// <param name="name"> Versenyző neve</param>
        /// <param name="age"> Vers. kora</param>
        /// <param name="salery"> vers. fizetése</param>
        public Racer(string name, int age, int salery)
        {
            this.name = name;
            this.age = age;
            this.salery = salery;
        }


        /// <summary>
        /// versenyző nevének megadása.
        /// </summary>
        /// <param name="name">A versenyző neve</param>
        public void setName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// versenyző korának megadása.
        /// </summary>
        /// <param name="age">A versenyző kora</param>
        public void setAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// versenyző fizetésének megadása.
        /// </summary>
        /// <param name="salery">A versenyző fizetése</param>
        public void setSalery(int salery)
        {
            this.salery = salery;
        }

        /// <summary>
        /// A versenyző nevét adja vissza.
        /// </summary>
        /// <returns>A versenyző neve</returns>
        public string getName ()
        {
            return name;
        }
        /// <summary>
        /// A versenyző korát adja vissza.
        /// </summary>
        /// <returns>A versenyző kora</returns>
        public int getAge()
        {
            return age;
        }
        /// <summary>
        /// A versenyző fizetését adja vissza.
        /// </summary>
        /// <returns>A versenyző fizetése</returns>
        public int getSalery()
        {
            return salery;
        }
    }
}
