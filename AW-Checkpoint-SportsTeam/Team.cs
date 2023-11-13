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

        public void PrintTeam()
        {
            if (Players.Count < 1)
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
    }
}