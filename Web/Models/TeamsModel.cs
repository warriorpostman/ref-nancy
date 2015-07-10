using System.Collections;
using System.Collections.Generic;

namespace Web.Models
{
    public class TeamsModel
    {
        public string[] TeamNames { get; set; }
        public Team[] Teams { get; set; }
    }

    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}