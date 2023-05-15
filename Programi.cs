﻿using System;
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
            Console.WriteLine("1,2,3-LEVEL");
            string vastus = Console.ReadLine();
            if (vastus=="1")
            {
                Console.SetWindowSize(80, 25);
                Walls walls = new Walls(80, 25);
                walls.Draw();
                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../Song.mp3");
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(80, 25, '*');
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
            else if (vastus=="2")
            {
                Console.SetWindowSize(40, 25);
                Walls walls = new Walls(40, 25);
                walls.Draw();
                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../Song.mp3");
                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Draw();

                FoodCreator foodCreator = new FoodCreator(40, 25, '*');
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
        }   
    }
}
