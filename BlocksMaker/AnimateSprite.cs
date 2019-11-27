using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpriteSheetIntro
{
    class AnimateSprite
    {
        List<Frame> IdleFrames { get; }
        List<Frame> RunningFrames { get; }

        TimeSpan updateTime = TimeSpan.FromMilliseconds(100);

        TimeSpan elapsedTime = TimeSpan.Zero;

        public AnimateSprite()
        {

        }



    }
}
