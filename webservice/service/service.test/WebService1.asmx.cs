using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Services;

namespace service.test
{
    /// <summary>
    /// WebService1 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string GetData()
        {
            List<User> list = new List<User>();
            User user1 = new User()
            {
                UserID =1,
                UserName = "Admin",
                Age =18
            };
            User user2 = new User()
            {
                UserID = 2,
                UserName = "Tom",
                Age = 20
            };
            list.Add(user1);
            list.Add(user2);
            return JsonConvert.SerializeObject(list);
        }
    }
}
