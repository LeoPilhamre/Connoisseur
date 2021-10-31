using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Connoisseur.RedditFetch
{
    public class App
    {
        private static readonly HttpClient client = new HttpClient();

        private static string uri = "https://www.reddit.com/api/v1/authorize?client_id={0}&response_type={1}&state={2}&redirect_uri={3}&duration={4}&scope={5}";


        public App(string[] argv)
        {
            Request().Wait();
        }


        private static async Task<string> Request()
        {/* TOKEN 	    gCEDrLJo4y1-y5uxZ5gw4PZj6I8hRg
                        YyXVnL8BMiV-ykVtn8NCrw
            USERNAME    TopYak4476
            SCOPRE      identity, edit, flair, history, modconfig, modflair, modlog, modposts, modwiki, mysubreddits, privatemessages, read, report, save, submit, subscribe, vote, wikiedit, wikiread
            https://www.reddit.com/api/v1/authorize?client_id=CLIENT_ID&response_type=TYPE&
            state=RANDOM_STRING&redirect_uri=URI&duration=DURATION&scope=SCOPE_STRING*/
             

            //THIS IS A TEST

            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.Error.WriteLine("\nException Caught! Message: {0}", e.Message);
            }

            return null;
        }
    }
}
