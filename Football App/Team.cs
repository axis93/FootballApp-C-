using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_App
{
    class Team
    {
        private List<Player> squad = new List<Player>();

        private string Name;
        private int points;
        private int games;
        private int win;
        private int draws;
        private int loss;
        private int diffrenceScored;// to be confirmed

        public string name { get; set; }
        public int Points { get; set; }
        public int Games { get; set; }
        public int Win { get; set; }
        public int Draws { get; set; }
        public int Loss { get; set; }
        public int DiffrenceScored { get; set; }

        public Team() { }
        private void show(Team team)
        {
            string print = "";
            print = "" + team.Name.ToString() + " " + team.Points.ToString() + " " + team.Games.ToString() + " "
               + team.Win.ToString() + " " + team.Draws.ToString() + " " + team.Loss.ToString() + " " + team.DiffrenceScored.ToString();
        }

        public void addPlayer(Player player)
        {
            squad.Add(player);
        }

        public void orderByName()
        {
            for (int i = 1; i < squad.Count; i++)
            {
                string temp = squad[i].LastName;
                if(squad[i] > )
            }
        }
    }
}
