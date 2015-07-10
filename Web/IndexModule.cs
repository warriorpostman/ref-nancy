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

            Post["/teams"] = _ =>
            {
                var model = this.Bind<TeamsModel>();
                var teamList = this.Bind<IList<Team>>();
                model.Teams = teamList.ToArray();
                return model;
            };

            Get["/something"] = _ =>
            {
                return null;
            };
        }
    }

   
}