﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 4, '*');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 4, '*');
            VertikalLine leftLine = new VertikalLine(4, mapHeight - 4, 0, '*');
            VertikalLine rightLine = new VertikalLine(4, mapHeight - 4, mapWidth - 2, '*');
        
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {                
                    return true;
                    Heli song = new Heli();
                    _ = song.Tagaplaamis_Mangida("../../../sirena.mp3");
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
