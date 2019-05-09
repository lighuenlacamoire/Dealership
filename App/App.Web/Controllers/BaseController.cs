using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace App.Web.Controllers
{
    public class BaseController : Controller
    {
        private JsonSerializerSettings jsonFormatter
        {
            get
            {
                var jsonSettings = new JsonSerializerSettings();
                jsonSettings.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                jsonSettings.Formatting = Formatting.None;
                jsonSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                return jsonSettings;
            }
        }
                
        protected internal virtual ActionResult JsonReturn(object data)
        {
            return new ContentResult
            {
                ContentType = "application/json",
                Content = JsonConvert.SerializeObject(data, jsonFormatter)
            };
        }
    }
}