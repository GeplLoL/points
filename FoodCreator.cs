﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class FoodCreator
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random= new Random();

        public FoodCreator (int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidht - 2);
            int y = random.Next(6, mapHeight - 6);
            return new Point(x, y, sym);
        }
    }
}
