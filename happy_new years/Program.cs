using System;
using System.Threading;

class Program
{
	static void Main()
	{
		Console.Title = "🎉 Happy New Year! 🎉";
		Console.Clear();

		string message = "Happy New Year!";
		string[] colors = Enum.GetNames(typeof(ConsoleColor));
		Random random = new Random();

		// Firework animation
		for (int i = 0; i < 30; i++)
		{
			Console.SetCursorPosition(
				random.Next(0, Console.WindowWidth),
				random.Next(0, Console.WindowHeight));

			Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[random.Next(colors.Length)]);
			Console.Write("*");
			Thread.Sleep(50);
		}

		Console.Clear();

		Console.SetCursorPosition(Console.WindowWidth / 2 - message.Length / 2, Console.WindowHeight / 2);
		foreach (char c in message)
		{
			Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[random.Next(colors.Length)]);
			Console.Write(c);
			Thread.Sleep(150);
		}

		Console.ResetColor();

		// Adding some decorative borders
		Console.SetCursorPosition(0, 0);
		Console.ForegroundColor = ConsoleColor.Yellow;
		for (int i = 0; i < Console.WindowWidth; i++)
			Console.Write("=");

		Console.SetCursorPosition(0, Console.WindowHeight - 1);
		for (int i = 0; i < Console.WindowWidth; i++)
			Console.Write("=");

		Console.ResetColor();

		Console.SetCursorPosition(0, Console.WindowHeight - 2);
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("\nPress any key to exit...");

		Console.ResetColor();
		Console.ReadKey();
	}
}
