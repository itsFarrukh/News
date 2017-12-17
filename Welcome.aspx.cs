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
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Search_Click(object sender, EventArgs e)
        {

            WhatsNewBtn.Enabled = false;
            Crawler crawler = new Crawler();
            List<Contents> response = new List<Contents>();
            response = crawler.StartCrawling();
            IEnumerable<TwitterStatus> tweets = crawler.getTweetsOfTrump();
                  
            if (response.Count > 0 && tweets.Count() > 0)
            {
                Session["Articles"] = response;
                Session["Tweets"] = tweets;
                Response.Redirect("SearchResults.aspx");
            }
        }
    }
}