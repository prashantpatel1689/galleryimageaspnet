using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


public partial class Gallery : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
         string[] filesindirectory = Directory.GetFiles(Server.MapPath("gallery"));

        string GalleryHtml = string.Empty;
        for (int i = 0; i <= filesindirectory.Length - 1; i++)
        {
            string path = filesindirectory[i].ToString();

            path = path.Remove(0, path.IndexOf("gallery")).Replace("\\", "/");

            GalleryHtml += "<li ><a href='" + path + "' rel='prettyPhoto[gallery2]'> " + Environment.NewLine + " <img  style='border: 2 solid #C0C0C0;padding-top:2px;padding-bottom:2px;' src='" + path + "'  width='160' height='110'  alt='' /></a></li> ";
        }

        GalleryUL.InnerHtml = GalleryHtml;

    }
    public Gallery()
	{
		Load += Page_Load;
	}
   
}