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

namespace News.Resources
{
    public class Crawler
    {
        public List<Content> StartCrawling() 
        {

            string url = "https://search.api.cnn.io/content/?q=Donald%20Trump&size=25";
            WebRequest request = WebRequest.Create(url);
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            List<Content> contents = new List<Content>();
            if(response.StatusCode==HttpStatusCode.OK)
            {
                using (StreamReader reader= new StreamReader(response.GetResponseStream()))
                {

                   string a= reader.ReadToEnd();
                   JavaScriptSerializer deserializeResponse = new JavaScriptSerializer();
                   Response results = (Response)deserializeResponse.Deserialize(a, typeof(Response));


                  
                   foreach (Result result in results.result)
                   {
                       
                       Content content = new Content();
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