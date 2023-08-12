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






        //  Method for recording data in the session
        public void Set<T>(string key, T value)
        {
            string serializedValue = JsonConvert.SerializeObject(value);
            Session.SetString(key, serializedValue);
        }

        // Method for reading session data
        public T Get<T>(string key)
        {
            string serializedValue = Session.GetString(key);
            if (serializedValue != null)
            {
                return JsonConvert.DeserializeObject<T>(serializedValue);
            }

            return default(T);
        }

        // Method to remove data from the session
        public void Remove(string key)
        {
            Session.Remove(key);
        }

        // Method for clearing the entire session
        public void Clear()
        {
            Session.Clear();
        }
    }
}
