﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace News
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Search_Click(object sender, EventArgs e) 
        {
            if (SearchText.Text == String.Empty)
            {
                Errorlabel.Text = "Oop! You forgot to enter a search term.";
                Errorlabel.Visible = true;
            }
            else 
            {

            }
        }
    }
}
