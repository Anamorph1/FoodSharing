using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{ 
    public class Routes
    {
        public const string API = "api/";
        public const string POSTS = "posts/";
        public const string POST_ID = POSTS + "{id}/";

        public static Dictionary<string, string> GetRoutes(string root)
        {
            Dictionary<string, string> routes = new Dictionary<string, string>();

            routes["root"] = root + API;
            routes["posts"] = root + POSTS;
            routes["posts_id"] = root + POST_ID;

            return routes;
        }
    }
}
