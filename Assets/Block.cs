using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Maze
{
    class Block
    {
        public int x;
        public int y;
        public int blockId;

        public Block(int x, int y, int blockId)
        {
            this.x = x;
            this.y = y;
            this.blockId = blockId;
        }
    }
}
