using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;

namespace scraping
{
    public partial class scraping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
              var getHtmlWeb = new HtmlWeb(); 
            var document = getHtmlWeb.Load(TextBox1.Text);            
            var aTags = document.DocumentNode.SelectNodes("//a");            
            int counter = 1;             
            if (aTags != null)           
            {               
                foreach (var aTag in aTags)               
                {                    
                    Label1.Text += counter + ". " + aTag.InnerHtml + " - " + aTag.Attributes["href"].Value + "\t" + "<br/>";                   
                    counter++;
                }
            }
        }
    }
}