namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ChampionshipContext())
            {
                var teams = context.Teams;

                Console.Write("ID".PadRight(6));
                Console.Write("TeamName".PadRight(20));
                Console.Write("TeamCity".PadRight(20));
                Console.Write("Wins".PadRight(10));
                Console.Write("Losses".PadRight(10));
                Console.Write("Draws".PadRight(10));
                Console.Write("Scored goals".PadRight(20));
                Console.Write("Conceded goals".PadRight(20));
                Console.WriteLine("\n");

                foreach (var team in teams)
                {
                    Console.Write(team.ID.ToString().PadRight(6));
                    Console.Write(team.TeamName.PadRight(20));
                    Console.Write(team.TeamCity.PadRight(20));
                    Console.Write(team.Wins.ToString().PadRight(10));
                    Console.Write(team.Losses.ToString().PadRight(10));
                    Console.Write(team.Draws.ToString().PadRight(10));
                    Console.Write(team.ScoredGoals.ToString().PadRight(20));
                    Console.Write(team.ConcededGoals.ToString().PadRight(20));
                    Console.WriteLine();
                }
            }
        }
    }
}