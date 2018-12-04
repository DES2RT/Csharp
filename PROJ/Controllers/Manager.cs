using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INT422TestOne.Models;
using AutoMapper;

namespace INT422TestOne.Controllers
{
    public class Manager
    {
        private DataContext ds = new DataContext();

        // TEAMS
        //get all teams
        public TeamBase GetAllTeams()
        {
            var fetchedObjects = ds.Teams.OrderBy(nm => nm.Name);
            return Mapper.Map<TeamBase>(fetchedObjects);
        }

        //get team list
        public IEnumerable<TeamList> GetAllTeamsList()
        {
            var fetchedObjects = ds.Teams.OrderBy(nm => nm.Name);
            return Mapper.Map<IEnumerable<TeamList>>(fetchedObjects);
        }

        //get team by id
        public TeamBase GetTeamById(int? id)
        {
            if(!id.HasValue)
            {
                return null;
            }
            else
            {
                var fetchedObject = ds.Teams.Include("Players").SingleOrDefault(a => a.Id == id.Value);
                return (fetchedObject == null)
                    ? null : Mapper.Map<TeamBase>(fetchedObject);
            }
        }

        //get team with players
        public TeamBaseWithPlayers GetTeamByIdWithPlayers(int? id)
        {
            if(!id.HasValue)
            {
                return null;
            }
            var fetchedObjects = ds.Teams.Include("Players").SingleOrDefault(a => a.Id == id);
            return (fetchedObjects == null) 
                ? null : Mapper.Map<TeamBaseWithPlayers>(fetchedObjects);
        }

        //add new team
        public TeamBase AddTeam(TeamAdd newItem)
        {
            var team = ds.Teams.Find(newItem.Id);

            var addedItem = ds.Teams.Add(Mapper.Map<Team>(newItem));
            ds.SaveChanges();
            return (addedItem == null) ? null : Mapper.Map<TeamBase>(addedItem);
        }

        //edit team
        public TeamBase EditTeam(TeamEdit newItem)
        {
            var fetchedObject = ds.Teams.Include("Players").SingleOrDefault(i => i.Id == newItem.Id);
            if(fetchedObject == null)
            {
                return null;
            }
            else
            {
                ds.Entry(fetchedObject).CurrentValues.SetValues(newItem);
                ds.SaveChanges();

                return Mapper.Map<TeamBase>(fetchedObject);
            }
        }
//===============================================================//

        // PLAYERS
        //get all players
        //get player list
        //get player by id
        //add new player
        //edit player

    }
}