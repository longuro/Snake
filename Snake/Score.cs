using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    public class Score
    {
		public int score;
		public Score(int score)
		{
			this.score = score;
		}
		public void ScoreUp()
		{
			score += 1;
		}

		public int GetScore()
        {
			return score;
        }
		public void ScoreInGame()
		{

			int xOffset = 0;
			int yOffset = 25;
			Console.SetCursorPosition(xOffset, yOffset);
			WriteText("Score: " + score, xOffset, yOffset);

		}

		public void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}
	}
}
