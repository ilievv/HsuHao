﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabitFury.Interfaces
{
    using Microsoft.Xna.Framework;
    public interface ICollidable
    {
        Vector2[] CollisionPoints { get; set; }
    }
}
