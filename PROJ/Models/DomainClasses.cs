using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INT422TestOne.Models
{
    public class Team
    {
        public Team()
        {
            this.Players = new List<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public List<Player> Players { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PenaltyMinutes { get; set; }
        public int GoalsScored { get; set; }
        public Team Team { get; set; }
    }
}