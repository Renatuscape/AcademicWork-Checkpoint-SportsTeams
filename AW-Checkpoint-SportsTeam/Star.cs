namespace AW_Checkpoint_SportsTeam
{
    public class Star : Player
    {
        public string Description { get; set; }
        public Star(int number, string name, string description) : base(number, name)
        {
            Description = description;
        }
        public override string ToString()
        {
            return $"#{Number} {Name}, a star player! {Description}";
        }
    }


}