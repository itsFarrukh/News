using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Resources;
using TweetSharp;

namespace News
{
    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Articles"]!=null && Session["Tweets"]!=null) 
            {
                List<Contents> contents = new List<Contents>();
                contents = (List<Contents>)Session["Articles"];
                Results.DataSource = contents;
                Results.DataBind();
                List<TwitterStatus> tweets = new List<TwitterStatus>();
                tweets = (List<TwitterStatus>) Session["Tweets"];
                TweetsRepeater.DataSource = tweets;
                TweetsRepeater.DataBind();

            }
            
        }
        protected void CoolBtn_Click(object sender, EventArgs e) 
        {
            CoolBtn.Enabled = false;
            Crawler crawler = new Crawler();
            IEnumerable<Feeds> feeds = crawler.GetCNNRssFeed();
            if(feeds.Count()>0)
            {
                Session["Rss"] = feeds;
                Response.Redirect("RssFeeds.aspx");
            }
        }
    }
}