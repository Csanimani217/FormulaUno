﻿using Forma1.MyExceptions;
using Forma1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.service
{
    /// <summary>
    /// a service réteg feladata az üzleti logika megvalósítása
    /// kapcsolatot teremt a controller és repository réteg között
    /// </summary>
    class TeamService
    {
        F1 f1Repository;

        public TeamService ()
        {
            f1Repository = new F1();
        }

        public void addTeam(String teamName)
        {
            try
            {
                Team t = new Team(teamName);
                f1Repository.add(t);
            }
            catch(F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }

        public List<Team> getTeams()
        {
            try
            {
                return f1Repository.getTeams();
            }
            catch (F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }
        public void deleteTeam(string teamNameToDelete)
        {
            try
            {
                int numberOfTeamRacers = f1Repository.getNumberOfRacers(teamNameToDelete);
                if(numberOfTeamRacers > 0)
                {
                    throw new TeamServiceException(teamNameToDelete + "nem lehet torolni");
                }
                else
                {
                    f1Repository.delete(teamNameToDelete);
                }
            }
            catch(F1Exception f1e)
            {
                throw new TeamServiceException(f1e.Message);
            }
        }
        public bool IsExsist(string teamNameToDelete)
        {
            try 
	        {	        
		        if (f1Repository.Isexsist(teamNameToDelete))
                {
                    return true;
                }
                else
	            {
                    return false;
	            }
	        }
	        catch (Exception)
	        {
                throw;
	        }
        }
    }
}
