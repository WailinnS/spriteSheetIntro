using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetIntro
{
    public class Sprite
    {
        public Texture2D texture2D;
        public Vector2 postion;
        public float speed;
        public Sprite(Texture2D texture, Vector2 vector2, float speed)
        {
            texture2D = texture;
            postion = vector2;
            this.speed = speed;
        }

    }
}
