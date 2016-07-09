﻿namespace RabitFury.Classes
{
    using System;
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using GameObject;
    using Enums;

    public class AllPlatforms
    {
        public AllPlatforms(Texture2D[] texture)
        {
            this.Rocks = MapGenerator.GeneratePlatform(texture);
        }

        public bool HasBurned { get; set; }

        public List<Platform> Rocks { get; set; }

        public void Scroll(Vector2 theOffSet)
        {
            for (int i = 0; i < Rocks.Count; i++)
            {
                Rocks[i].Scroll(theOffSet);
            }
        }

        public bool IfCollide(Vector2 point)
        {
            foreach (Platform r in Rocks)
            {
                if (r.IfCollide(point))
                {
                    if(r.MaterialID == PlatformType.Lava)
                    return true;
                }
            }
            return false;
        }
    }
}