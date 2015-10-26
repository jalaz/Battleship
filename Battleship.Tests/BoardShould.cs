using System;
using NUnit.Framework;

namespace Battleship.Tests
{
    //Types of boats: 
    // single-funnel : PatrolBoat
    // two-funnel : Cruiser
    // three-funnel : Battleship
    // four-funnel : Aircraft carrier
    public class BoardShould
    {
        //private Board board;

        //[SetUp]
        //public void Setup()
        //{
        //    board = new Board();
        //}

        //[Test]
        //public void AcceptSingleFunnelShip()
        //{
        //    board.Add(new PatrolBoat(1, 1));

        //    var shipsOnBoard = board.GetAll();

        //    Assert.AreEqual(1, shipsOnBoard.Count);
        //}

        //[Test]
        //public void ThrowShipsOverlapException_WhenShipsOverlap()
        //{
        //    board.Add(new PatrolBoat(1, 1));

        //    Assert.Throws<ShipOverlapException>(() =>
        //    {
        //        board.Add(new PatrolBoat(1, 1));
        //    }, message: "Ship A1x1- overlaps with A1x1-");
        //}

        //[TestCase(11, 1, Direction.Horizontal)]
        //[TestCase(9, 1, Direction.Horizontal)]
        //[TestCase(1, 11, Direction.Horizontal)]
        //[TestCase(1, 9, Direction.Vertiacal)]
        //public void ThrowsArgumentOutOfRangeException_WhenShipIsOutOfBoard(byte x, byte y, Direction direction)
        //{
        //    Assert.Throws<ArgumentOutOfRangeException>(() =>
        //    {
        //        board.Add(new Submarine(x, y, direction));
        //    });
        //}

        //[TestCase("A1")]
        //[TestCase("B2x3|")]
        //public void AddAcceptStringNotation(string ship)
        //{
        //    board.Add(ship);

        //    Assert.AreEqual(1, board.GetAll().Count);
        //}

        //[TestCase("not a ship")]
        //public void AddThrowNotAShipWhenWrongNotationPassed(string ship)
        //{
        //    Assert.Throws<NotAShipException>(() =>
        //    {
        //        board.Add(ship);
        //    });
        //}

        //[TestCase("There is not sufficient count of ships. We need: PatrolBoat (4), Cruiser (3), Submarine (2), AircraftCarrier (1)")]
        //[TestCase("There is not sufficient count of ships. We need: PatrolBoat (3), Cruiser (3), Submarine (2), AircraftCarrier (1)", "A1")]
        //[TestCase("There is not sufficient count of ships. We need: PatrolBoat (4), Cruiser (2), Submarine (2), AircraftCarrier (1)", "A1x2")]
        //[TestCase("There is not sufficient count of ships. We need: PatrolBoat (4), Cruiser (3), Submarine (1), AircraftCarrier (1)", "A1x3")]
        //[TestCase("There is not sufficient count of ships. We need: PatrolBoat (4), Cruiser (3), Submarine (1)", "A1x4")]
        //public void ThrowBoardIsNotReadyWithoutAllShips_DuringValidation(string message, params string[] ships)
        //{
        //    foreach (var ship in ships)
        //    {
        //        board.Add(ship);
        //    }

        //    Assert.Throws<BoardIsNotReadyException>(() =>
        //    {
        //        board.Validate();
        //    }, message);
        //}

        //[TestCase("A1x4-", "C3x3-", "G1x3|", "C6x2|", "I3x2-", "G6x2-", "A3", "A6", "I1", "I8")]
        //public void AcceptSuccessfulSetup(params string[] ships)
        //{
        //    foreach (var ship in ships)
        //    {
        //        board.Add(ship);
        //    }

        //    board.Validate();
        //}
    }
}