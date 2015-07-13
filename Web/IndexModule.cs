using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Nancy;
using Nancy.ModelBinding;
using Web.Models;

namespace Web
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get["/"] = _ =>
            {
                var model = new IndexModel() {Message = "Welcome the time is: " + DateTime.Now};
                return View[model];
            };

            Get["/teams"] = _ =>
            {
                var teamModel = new TeamsModel()
                {
                    TeamNames = new []{ "eagles", "chargers"},
                    Teams = new [] { new Team() {Name ="Eagles"}, new Team(){ Name = "Chargers" }}
                };
                return View[teamModel];
            };

            Get["/error/throw"] = _ =>
            {
                return new ErrorModel() { Message = "This was a route set up to demonstrate an error."} ;
            };

            Post["/teams"] = _ =>
            {
                var model = this.Bind<TeamsModel>();
                var teamList = this.Bind<IList<Team>>();
                model.Teams = teamList.ToArray();
                return model;
            };

            Get["/team/{teamName}/players"] = _ =>
            {
                return new []{ new Player() { Name="Randal Cunningham", Position = "QB"}};
            };

            Get["/something"] = _ =>
            {
                return null;
            };
        }
    }

    
}