using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Programi
    {
        static void Main(string[] args)
        {

            int points=0;
            Console.WriteLine("1,2,3-LEVEL");
            string vastus = Console.ReadLine();
            Console.Clear();
            if (vastus=="1")
            {
                Console.WriteLine("      Level: " + vastus);
                Console.WriteLine("      Points: " + points);
                Console.SetWindowSize(80, 25);
                Console.WriteLine(" ");
                Walls walls = new Walls(80, 25);
                walls.Draw();
                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../Song.mp3");
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();
                FoodCreator foodCreator = new FoodCreator(78, 24, '*');
                Point food = foodCreator.CreateFood();
                Console.ForegroundColor = ConsoleColor.Red;
                food.Draw();

                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        break;
                    }
                    if (snake.Eat(food))
                    {
                        points++;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("      Points: " + points); 
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        snake.Move();

                    }
                    Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleKey(key.Key);
                    }
                }
            }
            else if (vastus=="2")
            {
                Console.WriteLine("      Level: " + vastus);
                Console.WriteLine("      Points: " + points);
                Console.SetWindowSize(50, 25);
                Walls walls = new Walls(50, 25);
                walls.Draw();
                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../miraz.mp3");
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(49, 24, '*');
                Point food = foodCreator.CreateFood();
                Console.ForegroundColor = ConsoleColor.Red;
                food.Draw();
                obstacles obstaclesCreator = new obstacles(50, 25, '+');
                Point obstacles = obstaclesCreator.CreateObstacles();
                obstacles.Draw();


                while (true)
                {
                    if (walls.IsHit(snake) || snake.IsHitTail())
                    {
                        break;
                    }
                    if (snake.Eat(obstacles))
                    {
                        break;
                    }
                    if (snake.Eat(food))
                    {
                        points++;
                        Console.SetCursorPosition(0, 1);
                        Console.WriteLine("      Points: " + points);
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        snake.Move();
                    }
                    Thread.Sleep(70);
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey();
                        snake.HandleKey(key.Key);
                    }
                }
            }
            else if (vastus=="3")
            {
            Console.WriteLine("      Level: " + vastus);
            Console.WriteLine("      Points: " + points);
            Console.SetWindowSize(50, 25);
            Walls walls = new Walls(50, 25);
            walls.Draw();
            Heli song = new Heli();
            _ = song.Tagaplaamis_Mangida("../../../DVRST.mp3");
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(50, 25, '*');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Red;
            food.Draw();
            obstacles obstaclesCreator = new obstacles(50, 25, '*');
            Point obstacles = obstaclesCreator.CreateObstacles();
            obstacles.Draw();


            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (points==1)
                {
                    Console.Clear();
                    while (points==1)
                    {
                        Console.WriteLine("You WIN!! You WIN!! You WIN!! You WIN!! You WIN!! You WIN!! You WIN!!");

                    }
                }
                if (snake.Eat(obstacles))
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    points++;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("      Points: " + points);
                    food = foodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Red;
                    food.Draw();
                    }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    snake.Move();

                }
                Thread.Sleep(130);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            
            }
        }   
    }
}
