using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.Mail;
using System.Text;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        try
        {

            string mailbody = "";
            System.Net.Mail.MailMessage mailMsg = new System.Net.Mail.MailMessage();
            System.Net.Mail.MailAddress fromAdd = new System.Net.Mail.MailAddress(txtemail.Text);
            mailMsg.From = fromAdd;
            //mailMsg.To.Add("info@nctc.co.in")
            //contact@hotelcoronabharuch.com
            //hotelcoronabharuch@gmail.com

            mailMsg.To.Add("info@hotelshreeplaza.com");
            mailMsg.IsBodyHtml = true;
            mailMsg.Priority = MailPriority.High;
            //mailMsg.BodyEncoding = System.Text.Encoding.ASCII
            mailMsg.Subject = "Inquiry Details";
            sb.Append("Inquiry Details  FROM Hotelshreeplaza.com:<br /><br />");
            sb.Append("<table cellspacing='10' style='font-family:Tahoma; color:#000000; font-size: 11pt'>");
            sb.Append("<tr><td> Name : </td><td>" + txtname.Text + "</td></tr>");
            sb.Append("<tr><td> City : </td><td>" + txtcity.Text + "</td></tr>");
            sb.Append("<tr><td> Phone : </td><td>" + txtmobile.Text + "</td></tr>");
            sb.Append("<tr><td> Email : </td><td>" + txtemail.Text + "</td></tr>");
            sb.Append("<tr><td> Comment : </td><td>" + txtcomment.Text + "</td></tr>");
            //sb.Append("<tr><td> City : </td><td>" & txtName.Value.Trim & "</td></tr>")

            sb.Append("<tr><td colspan='2'>&nbsp;</td></tr>");
            sb.Append("</table>");
            mailbody = sb.ToString();
            mailMsg.Body = mailbody.Trim();
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            //smtp.UseDefaultCredentials = True
            //smtp.DeliveryMethod = SmtpDeliveryMethod.PickupDirectoryFromIis
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            // Try
            smtp.Send(mailMsg);
            txtemail.Text = "";
            txtname.Text = "";
            txtmobile.Text = "";
            txtcity.Text = "";
            txtcomment.Text = "";


            lblMessage.Text = " Quick Query Detail Successfully sent,We will Contact you Soon. ";

        }
        catch (Exception ex)
        {
            lblMessage.Text = "Error: " + ex.Message;
        }
    }
}