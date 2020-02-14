using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    /// <summary>
    /// a F1 nyilvántartó osztály
    /// </summary>
    class F1
    {
        /// <summary>
        /// F1 csapatok
        /// </summary>
        List<Team> teams;

        public F1()
        {
            teams = new List<Team>();
        }

        public void add(string name)
        {
            Team t = new Team(name);
            teams.Add(t);
            //eddig új
        }
    }
}
