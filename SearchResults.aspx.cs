using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using News.Resources;

namespace News
{
    public partial class SearchResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Articles"]!=null) 
            {
                List<Contents> contents = new List<Contents>();
                contents = (List<Contents>)Session["Articles"];
                Results.DataSource = contents;
                Results.DataBind();
            }
            
        }
    }
}