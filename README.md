# Battleship

*Hometask #4 for Kottans.NET courses*

** Logic for setting up a board with ships

Instructions:

- Fork or copy the contents of this repository to the folder with your hometasks
- Open Battleship.sln in VS 2015. You will see one project with the name Battleship.Tests there.
- Create one more project for the implementation.
- Execute the following until all the tests pass:

   - Uncomment test
   - Do all that is necessary to build the project
   - Make the test to pass
   - Refactor if needed

It is recommended to fulfil the tests suits in the order:

   - ShipEqualsShould
   - ShipParseShould
   - ShipTryParseShould
   - ShipFitInSquareShould
   - ShipIntersectsWithShould
   - BoardShould

####Ship notation

``A1x2|``

``A1`` - coordinates (first square on the board)

``x2`` - size of the ship (fill two squares)

``|`` - positioning (vertical)

Have fun :)
