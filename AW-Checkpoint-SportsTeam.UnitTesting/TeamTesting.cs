namespace AW_Checkpoint_SportsTeam.UnitTesting
{
    public class TeamTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(7, 7)]
        [TestCase(3, 3)]
        [TestCase(1, 1)]
        public void ListPlayers_AddPlayers_ReturnCorrectNumberOfPlayers(int toAdd, int expected)
        {
            //Arrange
            Team testTeam = new("The Iron Betatesters");
            //Act
            for (int i = 0; i < toAdd; i++)
            {
                testTeam.Players.Add(new(i, ""));
            }

            //Assert
            Assert.That(testTeam.Players.Count == expected);
        }

        [TestCase(7, 7)]
        [TestCase(0, 7)]
        [TestCase(1, 1)]
        public void PrintTeam_AddPlayers_ReturnAddedPlayersOrGeneratePlaceholders(int toAdd, int expected)
        {
            //Arrange
            Team testTeam = new("The Iron Betatesters");
            //Act
            for (int i = 0; i < toAdd; i++)
            {
                testTeam.Players.Add(new(i+1, ""));
            }
            testTeam.PrintTeam();

            //Assert
            Assert.That(testTeam.Players.Count == expected);
        }
    }
}