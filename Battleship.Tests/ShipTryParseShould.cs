using NUnit.Framework;

namespace Battleship.Tests
{
    public class ShipTryParseShould
    {
        //[TestCase("not a ship", false)]
        //[TestCase("A1", true)]
        //[TestCase("A1x1", true)]
        //[TestCase("A1x1-", true)]
        //[TestCase("A1x1|", true)]
        //public void CanParse(string notation, bool canParse)
        //{
        //    Ship pos;

        //    var result = Ship.TryParse(notation, out pos);

        //    Assert.AreEqual(canParse, result);
        //}

        //[TestCase("A1", 1u, 1u, 1u, Direction.Horizontal)]
        //[TestCase("A2x2", 1u, 2u, 2u, Direction.Horizontal)]
        //[TestCase("A2x2-", 1u, 2u, 2u, Direction.Horizontal)]
        //[TestCase("A2x2|", 1u, 2u, 2u, Direction.Vertiacal)]
        //public void ParseNotation(string notation, uint expectedX, uint expectedY, uint expectedLength, Direction expectedDirection)
        //{
        //    Ship position;
        //    Ship.TryParse(notation, out position);

        //    Assert.AreEqual(expectedX, position.X);
        //    Assert.AreEqual(expectedY, position.Y);
        //    Assert.AreEqual(expectedLength, position.Length);
        //    Assert.AreEqual(expectedDirection, position.Direction);
        //}
    }
}