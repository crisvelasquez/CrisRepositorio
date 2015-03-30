using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.Servicio
{
    public partial class ejemplorest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String a = TextBox1.Text;
            String b = TextBox2.Text;

            String url = "http://localhost:5649/SvcOperaciones.svc/Suma/{0}/{1}";


            String newurl = string.Format(url, a, b);
            WebRequest req = WebRequest.Create(newurl);
            req.Method = "GET";
            req.ContentType = "application/json; charset=utf-8";
            try
            {
                HttpWebResponse resp = req.GetResponse() as HttpWebResponse;
                if (resp.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream respStream = resp.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(respStream, Encoding.ASCII);
                        TextBox3.Text = reader.ReadToEnd();

                    }
                }
                else {

                    Response.Write(string.Format("Status Code : {0}, Status Description: {1} ", resp.StatusCode, resp.StatusDescription));
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
    
        
        
        }
    }
}