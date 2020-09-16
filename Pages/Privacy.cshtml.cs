using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Utilities;

namespace razortest.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string LastUpdateTime { get; set; }
        public List<string> Participants { get; set; }
        public List<List<string>> Messages { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public IActionResult OnGet()
        {
            HttpRequestTool tool = new HttpRequestTool();
            string v = tool.Post("http://175.98.160.67/vuewstest/chat/GetTableInfo", new { myUserId = "Player001", otherUserId = "", tableId = "Player001_Player002" });
            JObject jObject = JsonConvert.DeserializeObject<JObject>(v);
            Detail detail = JsonConvert.DeserializeObject<Detail>(jObject["detail"].ToString());
            LastUpdateTime = detail.lastUpdateTime;
            Participants = detail.participants;
            Messages = detail.messages;

            return Page();
        }

        public IActionResult OnPostMyPPost()
        {
            HttpRequestTool tool = new HttpRequestTool();
            string v = tool.Post("http://175.98.160.67/vuewstest/chat/PostToTable", new { myUserId = "Player001", tableId = "Player001_Player002", message = "測試測試5", nickname = "暱稱1" });

            return Page();
        }

        private class Detail
        {
            public List<List<string>> messages;
            public List<string> participants;
            public string lastUpdateTime;
        }

        private class Request
        {
            public Request(string m, string t, string me, string n)
            {
                myUserId = m;
                tableId = t;
                message = me;
                nickname = n;
            }

            public string myUserId;
            public string tableId;
            public string message;
            public string nickname;
        }
    }
}