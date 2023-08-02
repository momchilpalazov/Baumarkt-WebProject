using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BaumarktSystem.Common.EntityValidationConstanst;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;

namespace BaumarktSystem.Web.Utility
{
    public class UserSession
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserSession(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;


       



        // Метод за запис на данни в сесията
        public void Set<T>(string key, T value)
        {
            string serializedValue = JsonConvert.SerializeObject(value);
            Session.SetString(key, serializedValue);
        }

        // Метод за четене на данни от сесията
        public T Get<T>(string key)
        {
            string serializedValue = Session.GetString(key);
            if (serializedValue != null)
            {
                return JsonConvert.DeserializeObject<T>(serializedValue);
            }

            return default(T);
        }

        // Метод за премахване на данни от сесията
        public void Remove(string key)
        {
            Session.Remove(key);
        }

        // Метод за изчистване на цялата сесия
        public void Clear()
        {
            Session.Clear();
        }
    }
}
