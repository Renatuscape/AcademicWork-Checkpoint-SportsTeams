namespace AW_Checkpoint_SportsTeam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://github.com/Renatuscape/AcademicWork-Checkpoint-SportsTeams

            Team myTeam = new("The Miskatonics");

            myTeam = myTeam + new Player(8, "Rod Usher");
            myTeam.PrintTeam();
        }
    }
}