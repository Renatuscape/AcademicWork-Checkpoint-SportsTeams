namespace AW_Checkpoint_SportsTeam
{
    public class Team
    {
        public string Name { get; private set; } = string.Empty;
        public List<Player> Players { get; set; } = new();

        public Team(string name)
        {
            Name = name;
        }

        public void CreateDummyTeam()
        {
            Players = new() {
                new (1, "Henry Armitage"),
                new (2, "Randolph Carter"),
                new (3, "Obed Marsh"),
                new (4, "John Raymond Legrasse"),
                new (5, "Walter Gilman"),
                new (6, "William Dyer"),
                new Star(7, "Abdul Alhazred", "Used to be an author, now he plays sportsball!"),
            };
        }

        public void PrintTeam()
        {
            if (Players.Count < 1)
            {
                CreateDummyTeam();
            }

            Console.WriteLine($"\t*** {Name} ***\n");
            foreach (var player in Players)
            {
                Console.WriteLine($"\t{player}");
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        //Brukte de siste 40 min på å finne ut hvordan jeg skulle bruke operator overload og rakk ikke legge til testing
        public static Team operator +(Team team, Player player)
        {
            team.Players.Add(player);

            return team;
        }
    }
}