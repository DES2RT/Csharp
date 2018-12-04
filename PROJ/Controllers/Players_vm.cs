using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INT422TestOne.Controllers
{
        public class PlayerBase : PlayerAdd
        {
        }
        
        public class PlayerAdd
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int PenaltyMinutes { get; set; }
            public int GoalsScored { get; set; }
            public TeamBase TeamId { get; set; }

        }

        public class PlayerAddForm
        {
            public string Name { get; set; }
            public int PenaltyMinutes { get; set; }
            public int GoalsScored { get; set; }
            public SelectList Teams { get; set; }
        }

        public class PlayerList
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string TeamName { get; set; }
            public string PlayerAndTeam
            {
                get
                {
                    return string.Format("{0} - {1}", this.Name, this.TeamName);
                }
            }
        }

        public class PlayerEdit
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int PenaltyMinutes { get; set; }
            public int GoalsScored { get; set; }
            public TeamBase TeamId { get; set; }
        }

        public class PlayerEditForm
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int PenaltyMinutes { get; set; }
            public int GoalsScored { get; set; }
            public SelectList Teams { get; set; }

        }
    
}