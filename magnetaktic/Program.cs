using System;
try
{
    Console.WriteLine("Starting...");
    using var game = new magnetaktic.Game1();
    Console.WriteLine("Game created...");
    game.Run();
    Console.WriteLine("Game exited normally.");
}
catch (Exception ex)
{
    Console.WriteLine("CRASH: " + ex.ToString());
    Console.ReadLine(); // keeps the window open
}