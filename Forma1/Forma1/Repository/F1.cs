using Forma1.MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Repository
{
    /// <summary>
    /// a F1 nyilvántartó osztály
    /// szolgáltatást níújt service rétegnek.
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
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba, a lista nincs példányosítva!");
            }
            else
            {
                Team t = new Team(name);
                teams.Add(t);
                //Innentől GIT-en
            }
        }

        public void add(Team t)
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba, a lista nincs példányosítva!");
            }
            else
            {
                teams.Add(t);
            }
            
        }

        public List<Team> getTeams()
        {
            if (teams == null)
            {
                throw new F1Exception("Végzetes hiba, a team lista nincs példányosítva!");
            }
            else
            {
                return teams;
            }
        }
        
        public bool IsExsist(string teamNameTodelete)
        {
            if (teams == null)
            {
                throw new F1Exception("végzetes hiba, team lista nem jó");
            }
            else
	        {
             foreach (Team t in teams)
             {
               if (t.getTeamName() == teamName)
               {
                 return true;
               }
             }
             return false;
	        {

	        }
	        }
            }
    }
}
