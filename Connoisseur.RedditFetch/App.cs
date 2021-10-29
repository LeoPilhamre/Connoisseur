using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Connoisseur.RedditFetch
{
    public class App
    {
        private static HttpClient client = new HttpClient();

        public App(string[] argv)
        {
            Console.WriteLine("This is the reddit app");
        }
    }
}
