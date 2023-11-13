using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW_Checkpoint_SportsTeam.UnitTesting
{
    internal class StarTesting
    {
        [Test]
        public void Equals_CompareStarPlayer_ReturnTrue()
        {
            //Arrange
            Team myTeam = new("R'lyeh");
            myTeam.Players.Add(new Star(1, "Elder One", "Ph'nglui mglw'nafh Cthulhu R'lyeh wgah'nagl fhtagn"));
            bool expected = true;

            //Act
            bool actual = myTeam.Players[0] is Star;

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
