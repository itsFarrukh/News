using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using News.Resources;
using TweetSharp;

namespace News
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Search_Click(object sender, EventArgs e) 
        {
            //if (SearchText.Text == String.Empty)
            //{
            //    Errorlabel.Text = "Oop! You forgot to enter a search term.";
            //    Errorlabel.Visible = true;
                
            //}
            //else 
            //{
                Crawler crawler = new Crawler();
                List<Contents> response = new List<Contents>();
                response=crawler.StartCrawling();
                IEnumerable<TwitterStatus> tweets = crawler.getTweetsOfTrump();
                TwitterStatus tweet = new TwitterStatus();
               // string a = tweets.FirstOrDefault().Author;
                string b = tweets.FirstOrDefault().Text;
                string c = tweets.FirstOrDefault().Source;
                if(response.Count>0)
                {
                    Session["Articles"] = response;
                    Session["Tweets"] = tweets;
                    Response.Redirect("SearchResults.aspx");
                }
            //}
        }
    }
}
