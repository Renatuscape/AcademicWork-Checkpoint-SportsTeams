namespace AW_Checkpoint_SportsTeam
{
    public class Player
    {
        public string Name { get; private set; } = string.Empty;
        public int Number { get; set; }

        public Player(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public override string ToString()
        {
            return $"#{Number} {Name}";
        }

        public bool Equals (Player other)
        {
            return other is Player;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Player other)
            {
                return Equals(other);
            }

            else
            {
                return false;
            }

        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}