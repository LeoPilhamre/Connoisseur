using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connoisseur.DiscordAsync;
using Connoisseur.RedditFetch;

namespace Connoisseur.Library.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDiscordAsync()
        {
            new DiscordAsync.App(null);
        }

        [TestMethod]
        public void TestRedditFetch()
        {
            new RedditFetch.App(null);
        }
    }
}
