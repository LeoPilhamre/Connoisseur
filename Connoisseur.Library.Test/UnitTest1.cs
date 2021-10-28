using Microsoft.VisualStudio.TestTools.UnitTesting;
using Connoisseur.Library;

namespace Connoisseur.Library.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDiscordAsync()
        {
            DiscordAsync.Main(null);
        }

        [TestMethod]
        public void TestRedditFetch()
        {
            RedditFetch.Main(null);
        }
    }
}
