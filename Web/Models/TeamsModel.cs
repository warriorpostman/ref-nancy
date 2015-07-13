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

    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    public class ErrorModel
    {
        public string Message { get; set; }
    }
}