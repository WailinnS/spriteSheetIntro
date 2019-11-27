using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetIntro
{
    class Frame
    {
        public Vector2 Origin { get; } //makes it read only, with no set.
        public Rectangle SourceRectangle { get; }

        public Frame(Vector2 vector2, Rectangle rectangle)
        {
            Origin = vector2;
            SourceRectangle = rectangle;
        }


    }
}
