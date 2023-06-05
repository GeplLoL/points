using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Game
    {
        private int points;
        private string playerName;
        private string level;
        private string color;
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public Game(string level, string color)
        {
            points = 0;
            this.level = level;
            this.color = color;

        }

        public void Start()
        {
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Points: " + points);
            Console.WriteLine(playerName);

            if (level == "1")
            {
                Console.SetWindowSize(80, 25);
                Console.WriteLine(" ");

                Walls walls = new Walls(80, 25);
                walls.Draw();

                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../Song.mp3");

                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Color = GetSelectedColor(); // Установка выбранного цвета
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
                        Console.WriteLine("Points: " + points);
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();
                    }
                    else
                    {
                        Console.ForegroundColor = snake.Color;
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
            else if (level == "2")
            {
                Console.SetWindowSize(50, 25);

                Walls walls = new Walls(50, 25);
                walls.Draw();

                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../miraz.mp3");

                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Color = GetSelectedColor(); // Установка выбранного цвета
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
                        Console.WriteLine("Points: " + points);
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();
                    }
                    else
                    {
                        Console.ForegroundColor = snake.Color;
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
            else if (level == "3")
            {
                Console.SetWindowSize(50, 25);

                Walls walls = new Walls(50, 25);
                walls.Draw();

                Heli song = new Heli();
                _ = song.Tagaplaamis_Mangida("../../../DVRST.mp3");

                Point p = new Point(4, 5, '*');
                Snake snake = new Snake(p, 4, Direction.RIGHT);
                snake.Color = GetSelectedColor(); // Установка выбранного цвета
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

                    if (points == 1)
                    {
                        Console.Clear();
                        while (points == 1)
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
                        Console.WriteLine("Points: " + points);
                        food = foodCreator.CreateFood();
                        Console.ForegroundColor = ConsoleColor.Red;
                        food.Draw();
                    }
                    else
                    {
                        Console.ForegroundColor = snake.Color;
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
            string record = playerName + "-" + points;
            using (StreamWriter writer = new StreamWriter("../../../record.txt", true))
            {
                // Добавляем полное имя в файл
                writer.WriteLine(record);
            }
        }

        private ConsoleColor GetSelectedColor()
        {
            ConsoleColor selectedColor;
            switch (color)
            {
                case "red":
                    selectedColor = ConsoleColor.Red;
                    break;
                case "white":
                    selectedColor = ConsoleColor.White;
                    break;
                case "green":
                    selectedColor = ConsoleColor.Green;
                    break;
                case "yellow":
                    selectedColor = ConsoleColor.Yellow;
                    break;
                default:
                    selectedColor = ConsoleColor.Red;
                    break;
            }

            return selectedColor;
        }
    }
}
