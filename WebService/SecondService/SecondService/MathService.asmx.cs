using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace SecondService
{
    /// <summary>
    /// Summary description for SecondService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {
        //[WebMethod(Description = "Method of running web service")]
        //public string show()
        //{
        //    return "Method from second web service";
        //}
        //[WebMethod(Description = "Method of called web service")]
        //public string display()
        //{
        //    localhost.MathService obj = new localhost.MathService();
        //    return obj.show();
        //}
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod(Description = "Method of called web service")]
        public string display()
        {
            localhost.MathService myMath = new localhost.MathService();
            return myMath.HelloWorld();
        }
    }
}
