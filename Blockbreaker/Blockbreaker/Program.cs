using System;

namespace Blockbreaker
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (BlockBreakerGame game = new BlockBreakerGame())
            {
                game.Run();
            }
        }
    }
#endif
}

