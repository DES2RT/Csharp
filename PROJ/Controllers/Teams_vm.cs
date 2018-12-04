using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INT422TestOne.Controllers
{
    public class TeamBase : TeamAdd
    {
    }

    public class TeamBaseWithPlayers : TeamBase
    {
        public IEnumerable<PlayerBase> Players { get; set; }
    }

    public class TeamAdd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public SelectList Players { get; set; }
    }

    public class TeamAddForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public SelectList Players { get; set; }
    }

    public class TeamList
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class TeamEdit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public SelectList Players { get; set; }
    }

    public class TeamEditForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesWon { get; set; }
        public SelectList Players { get; set; }
    }
}