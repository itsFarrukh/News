using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Web.Script.Serialization;
using TweetSharp;
using System.Xml.Linq;
using System.Web.Configuration;

namespace News.Resources
{
    public class Crawler
    {
        public List<Feeds> GetCNNRssFeed()
        {
            using (WebClient client = new WebClient())
            {
                string RssFeeds = client.DownloadString(Constants.CNN_RSS_URL);
                XDocument xml = XDocument.Parse(RssFeeds);
                List<Feeds> feeds = xml.Descendants("item").Where(x => x.Element("description") != null)
                    .Select(x => new Feeds()
                    {
                        Description = x.Element("description").Value,
                        Title = x.Element("title").Value,
                        Link = x.Element("link").Value
                    }).ToList();    
                return feeds;
            }

        }
        public IEnumerable<TwitterStatus> getTweetsOfTrump()
        {
            var service = new TwitterService(WebConfigurationManager.AppSettings["ConsumerKey"], WebConfigurationManager.AppSettings["ConsumerSecret"]);
            service.AuthenticateWith(WebConfigurationManager.AppSettings["AccessToken"], WebConfigurationManager.AppSettings["AccessTokenSecret"]);
            //var service = new TwitterService("ivnI50UWRcZVMUBguRsPVGnSb", "d78IbB3SGvYFpNAdUxJOwOpLqtn9sIOypCXSzzGeHu0nNtYELJ");
            //service.AuthenticateWith("1410667633-wqJ4YdawiaAJzCXoEBO6pTu8lwOq4tjJZTE0ABD", "11A5ABaLPYFkrLM2tlg0puXoYqHWCY8g4TZ1P7ZKJIZAE");
            IEnumerable<TwitterStatus> tweets = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions { ScreenName = Constants.SCREEN_NAME, Count = 25 });
            return tweets;
        }

        public List<Contents> StartCrawling()
        {           
            WebRequest request = WebRequest.Create(Constants.CNN_SEARCH_URL);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            List<Contents> contents = new List<Contents>();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string a = reader.ReadToEnd();
                    JavaScriptSerializer deserializeResponse = new JavaScriptSerializer();
                    Response results = (Response)deserializeResponse.Deserialize(a, typeof(Response));
                    foreach (Result result in results.result)
                    {
                        Contents content = new Contents();
                        content.Url = result.url;
                        content.Title = result.headline;
                        content.ImageUrl = result.thumbnail;
                        contents.Add(content);
                    }

                }
            }
            return contents;
        }
    }
}