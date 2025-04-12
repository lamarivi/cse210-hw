using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------Welcome to Goal Setting Quest App-----------------");
        GoalManager goalManager = new();
        goalManager.Start();
    }
}