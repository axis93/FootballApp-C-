using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_App
{
    public class League
    {
        private string name;
        private int numbOfTeams;
        private List<Team> teams;

        bool found = false;
        private string getTeam(string name)
        { 
            
            string team ="";
            
            foreach(Team t in teams)
            {
                 if(name != t.name)
                {

                    found = false;
                    return team;
                }
                else
                {
                    found = true;
                    team = t.name;
                    return team;
                   
                }
            }
            
        }
    }
}
