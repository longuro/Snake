using System;
using System.Threading;

namespace Snake
{
    public class Game
    {
        public Game()
        {
            Console.SetWindowSize(100, 30);
            Walls walls = new Walls(80, 25);
            walls.Draw();
            Point p = new Point(4, 5, 'x');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80, 25, 'o');
            Point food = foodCreator.CreateFood();
            food.Draw();
            Params settings = new Params();
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.PlayBackground();
            Score count = new Score(0);
            count.ScoreInGame();
            Sounds soundEat = new Sounds(settings.GetResourceFolder());
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    count.ScoreUp();
                    count.ScoreInGame();
                    soundEat.PlayEat();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Button(key.Key);
                }
            }
            new GameOverSnake();
            sound.PlayEnd();
            Thread.Sleep(5000);
            new EndScore(count.GetScore(), settings.GetResourceFolder());
        }
    }
}