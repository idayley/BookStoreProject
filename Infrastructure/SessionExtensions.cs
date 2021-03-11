using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BookStoreProject.Infrastructure
{
    // Tool to convert Cart object to a Json (string) file, and back. 
    // We do this because we can't store a cart object directly into a session
    public static class SessionExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T> (this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default(T) : JsonSerializer.Deserialize<T>(sessionData);
        }
    }
}
