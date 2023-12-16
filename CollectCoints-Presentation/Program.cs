using CollectCoins_Library;



Console.WriteLine(Menus.GameName());
Console.WriteLine(Menus.GameStart());
Board board = new Board();
Console.WriteLine(board.Draw());

Console.WriteLine(Menus.MainMenu(3));
