using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Resources;

namespace News
{
    public partial class RssFeeds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Rss"]!=null)
            {
                List<Feeds> feeds = new List<Feeds>();
                feeds = (List<Feeds>)Session["Rss"];
                RssRepeater.DataSource = feeds;
                RssRepeater.DataBind();
            }

        }
    }
}