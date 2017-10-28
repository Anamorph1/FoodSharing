using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{ 
    public class Routes
    {
        public const string API = "api/";
        public const string POSTS = API + "posts/";
        public const string POST_ID = POSTS + "{id}/";
        public const string POST_ADD = POSTS + "add/";

        public const string USER = API + "user/";

        public static Dictionary<string, string> GetRoutes(string root)
        {
            Dictionary<string, string> routes = new Dictionary<string, string>();

            routes["root"] = root + API;
            routes["posts"] = root + POSTS;
            routes["posts_id"] = root + POST_ID;
            routes["posts_add"] = root + POST_ADD;

            routes["user"] = root + USER;

            return routes;
        }
    }
}
