using CLIGL;
using System;
using System.Collections.Generic;
using System.Text;

namespace HistoryEngine.UI
{
    class InitUI
    {
        public const int WINDOW_WIDTH = 90;
        public const int WINDOW_HEIGHT = 50;
        public void Initialise()
        {
            RenderingWindow window = new RenderingWindow("Terrain Generator", WINDOW_WIDTH, WINDOW_HEIGHT);
            RenderingBuffer buffer = new RenderingBuffer(WINDOW_WIDTH, WINDOW_HEIGHT);
        }
    }
}
