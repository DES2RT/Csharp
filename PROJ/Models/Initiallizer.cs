using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace INT422TestOne.Models
{
    public class Initiallizer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            DataContext ds = new DataContext();

            Team ML = new Team();
            ML.Name = "Leafs";
            ML.GamesPlayed = 10;
            ML.GamesWon = 7;

            ds.Teams.Add(ML);

            Team MC = new Team();
            MC.Name = "Canadiens";
            MC.GamesPlayed = 10;
            MC.GamesWon = 6;

            ds.Teams.Add(MC);

            Player pl = new Player();
            pl.Name = "Jones";
            pl.PenaltyMinutes = 17;
            pl.GoalsScored = 1;
            pl.Team = ML;
            ds.Players.Add(pl);
            pl = null;

            pl = new Player();
            pl.Name = "Smith";
            pl.PenaltyMinutes = 1;
            pl.GoalsScored = 4;
            pl.Team = ML;
            ds.Players.Add(pl);
            pl = null;

            pl = new Player();
            pl.Name = "Frenchy";
            pl.PenaltyMinutes = 4;
            pl.GoalsScored = 2;
            pl.Team = ML;
            ds.Players.Add(pl);
            pl = null;

            pl = new Player();
            pl.Name = "Lane";
            pl.PenaltyMinutes = 2;
            pl.GoalsScored = 4;
            pl.Team = MC;
            ds.Players.Add(pl);
            pl = null;

            pl = new Player();
            pl.Name = "Brown";
            pl.PenaltyMinutes = 4;
            pl.GoalsScored = 2;
            pl.Team = MC;
            ds.Players.Add(pl);
            pl = null;

            pl = new Player();
            pl.Name = "Knight";
            pl.PenaltyMinutes = 6;
            pl.GoalsScored = 1;
            pl.Team = MC;
            ds.Players.Add(pl);

            ds.SaveChanges();

        }
    }
}