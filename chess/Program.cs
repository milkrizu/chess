using Pawn.Core;

//реализация метода move

Console.WriteLine("Chess!");
Figure f = new Figure(1, 4);

Pawn1 pawn = new Pawn1(2, 3);
Console.WriteLine(pawn.Move(2, 3));

king king = new king(4, 5);
Console.WriteLine(king.Move(4, 5));

Rook rook = new Rook(6, 7);
Console.WriteLine(rook.Move(6, 7));

Queen queen = new Queen(1, 1);
Console.WriteLine(queen.Move(1, 1));

Horse horse = new Horse(7, 8);
Console.WriteLine(horse.Move(7, 8));

Elephant elephant = new Elephant(2, 5);
Console.WriteLine(elephant.Move(2, 5));

