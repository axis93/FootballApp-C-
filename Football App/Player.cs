using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_App
{
    public class Player : IStats    {
        private string firstName;
        private string lastName;
        private string name;
        private string role;
        private int presence;
        private int goals;
        private int assist;
        private int yellow_cards;
        private int red_cards;
        private int gamePlayed;

        public Player()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Presence { get; set; }
        public int Goals { get; set; }
        public int Assits { get; set; }
        public int Yellow_cards { get; set; }
        public int Red_cards { get; set; }    
        public int GamePlayed { get; set; }


    }
}
