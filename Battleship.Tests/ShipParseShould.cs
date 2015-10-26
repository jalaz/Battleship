using System;
using NUnit.Framework;

namespace Battleship.Tests
{
    public class ShipParseShould
    {
        //[TestCase("A1", 1u, 1u, 1u, Direction.Horizontal)]
        //[TestCase("A2x2", 1u, 2u, 2u, Direction.Horizontal)]
        //[TestCase("A2x2-", 1u, 2u, 2u, Direction.Horizontal)]
        //[TestCase("A2x2|", 1u, 2u, 2u, Direction.Vertiacal)]
        //public void ParseNotation(string notation, uint expectedX, uint expectedY, uint expectedLength, Direction expectedDirection)
        //{
        //    var position = Ship.Parse(notation);

        //    Assert.AreEqual(expectedX, position.X);
        //    Assert.AreEqual(expectedY, position.Y);
        //    Assert.AreEqual(expectedLength, position.Length);
        //    Assert.AreEqual(expectedDirection, position.Direction);
        //}

        //[TestCase("not a ship")]
        //[TestCase("M1")]
        //[TestCase("A11")]
        //[TestCase("A1x5")]
        //public void ThrowsNotAShipException_WhenIsNotNotation(string notAShip)
        //{
        //    Assert.Throws<NotAShipException>(() =>
        //    {
        //        Ship.Parse(notAShip);
        //    });
        //}

        //[TestCase("A1", typeof(PatrolBoat))]
        //[TestCase("A1x2", typeof(Cruiser))]
        //[TestCase("A1x3", typeof(Submarine))]
        //[TestCase("A1x4", typeof(AircraftCarrier))]
        //public void CreateCorrectTypeOfShipBasedOnItsSize(string ship, Type expectedType)
        //{
        //    Assert.IsInstanceOf(expectedType, Ship.Parse(ship));
        //}
    }
}