using System;
using Connoisseur.Library;

namespace Connoisseur
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] argv)
        {
            DiscordAsync.Main(argv);

            RedditFetch.Main(argv);
        }
    }
}
