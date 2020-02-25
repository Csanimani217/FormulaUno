using Forma1.MyExceptions;
using Forma1.Repository;
using Forma1.service;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.Controller
{
    /// <summary>
    /// Controlller réteg kapcsolatot teremt a GUi és a service réteg között
    /// feladata a bemenő adatok vizsgálata
    /// feladata a megjelenítendő adatok átalakítása a GUI számára
    /// feladata a programozónak szánt hibaüzenetek jeleníti meg
    /// </summary>
    class F1Controller
    {
        TeamService teamService;

        public F1Controller()
        {
            teamService = new TeamService();
        }

        public void addTeamofF1(string teamName)
        {
            try
            {
                teamService.addTeam(teamName);
            }
            catch(TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                if (!teamService.IsExsist(teamNameToDelete))
                {
                    throw new ControllerException(teamNameToDelete + "csapat nem letezik, nem lehet törölni");
                    teamservice.deleteTeam(teamNameToDelete);

                }
                    
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
            }
        }

        public List<string> getTeamNames()
        {
            try
            {
                List<Team> teams = teamService.getTeams();
                return TeamListToTeamNameList(teams);
            }
            catch (TeamServiceException tse)
            {
                Debug.WriteLine(tse.Message);
                List<string> teamNames = new List<string>();
                return teamNames;
            }
        }

        private List<string> TeamListToTeamNameList(List<Team> teams)
        {
            List<string> teamNames = new List<string>();
            foreach (Team t in teams)
            {
                teamNames.Add(t.getTeamName());
               
            }
            return teamNames;
        }
    }
}
