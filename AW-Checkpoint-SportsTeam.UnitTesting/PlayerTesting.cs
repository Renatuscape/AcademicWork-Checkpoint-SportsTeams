using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_Checkpoint_SportsTeam.UnitTesting
{
    public class PlayerTesting
    {
        [TestCase(0, 6)]
        [TestCase(2, 3)]
        [TestCase(5, 4)]
        public void Equals_ComparePlayerObjects_ReturnTrue(int indexA, int indexB)
        {
            //Arrange
            Team myTeam = new("Arkham Lacrosse Juniors");
            myTeam.CreateDummyTeam();
            var playerA = myTeam.Players[indexA];
            var playerB = myTeam.Players[indexB];


            //Act

            //Assert
            Assert.That(playerA, Is.EqualTo(playerB));
        }
    }
}
