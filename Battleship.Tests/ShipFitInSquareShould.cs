using NUnit.Framework;

namespace Battleship.Tests
{
    public class ShipFitInSquareShould
    {
        //[TestCase(1, 1, "B2")]
        //[TestCase(2, 1, "B2")]
        //[TestCase(2, 2, "C2")]
        //public void ReturnFalse_WhenXAndYIsOutOfSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsFalse(ship.FitsInSquare(squareHeight, squareWidth));
        //}

        //[TestCase(1, 1, "A1")]
        //[TestCase(2, 2, "B2")]
        //[TestCase(2, 2, "A2")]
        //[TestCase(2, 2, "B1")]
        //public void ReturnTrue_WhenXAndYInSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsTrue(ship.FitsInSquare(squareHeight, squareWidth));
        //}

        //[TestCase(1, 1, "A1x2")]
        //[TestCase(2, 2, "B2x3")]
        //[TestCase(2, 1, "A2x2")]
        //[TestCase(1, 2, "B2x2")]
        //public void ReturnFalse_WhenLengthIsOutOfSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsFalse(ship.FitsInSquare(squareHeight, squareWidth));
        //}

        //[TestCase(1, 1, "A1")]
        //[TestCase(2, 2, "A1x2")]
        //public void ReturnTrue_WhenLengthIsInSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsTrue(ship.FitsInSquare(squareHeight, squareWidth));
        //}

        //[TestCase(2, 1, "A1x3|")]
        //[TestCase(2, 1, "A1x2-")]
        //[TestCase(1, 2, "A1x2|")]
        //[TestCase(1, 2, "A1x3-")]
        //public void ReturnsFalse_WhenDirectionLeadingOutOfSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsFalse(ship.FitsInSquare(squareHeight, squareWidth));
        //}

        //[TestCase(2, 1, "A1x2|")]
        //[TestCase(1, 2, "A1x2-")]
        //public void ReturnsTrue_WhenDirectionKeepsInSquare(byte squareHeight, byte squareWidth, string shipNotation)
        //{
        //    var ship = Ship.Parse(shipNotation);

        //    Assert.IsTrue(ship.FitsInSquare(squareHeight, squareWidth));
        //}
    }
}