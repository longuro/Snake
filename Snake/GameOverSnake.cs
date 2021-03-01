using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Security.Cryptography.X509Certificates;

namespace Snake
{
	public class GameOverSnake
	{
		public GameOverSnake()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			WriteText("		     GAME OVER         ", xOffset + 1, yOffset++);
			WriteText("============================", xOffset, yOffset++);
			Params settings = new Params();
			Sounds sound2 = new Sounds(settings.GetResourceFolder());
			sound2.PlayEnd();
		}
		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}