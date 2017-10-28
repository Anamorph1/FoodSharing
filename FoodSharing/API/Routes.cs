using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace API
{ 
    public class Routes
    {
        public const string API = "api/";

        public const string OFFERS = API + "offers/";
        public const string OFFER_ID = OFFERS + "{id}/";
        public const string OFFER_CREATE = OFFERS + "create/";

        public const string PRODUCTS = API + "products/";
        public const string PRODUCT_ID = PRODUCTS + "{id}/";
        public const string PRODUCT_CREATE = PRODUCTS + "create/";

        public const string ORDERS = API + "orders/";
        public const string ORDER_ID = ORDERS + "{id}/";
        public const string ORDER_SUBMIT = ORDERS + "submit/";

        public const string SEARCH = API + "search/";

        public static Dictionary<string, string> GetRoutes(string root)
        {
            Dictionary<string, string> routes = new Dictionary<string, string>();

            var type = typeof(Routes);
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Static);
            foreach (var field in fields)
            {
                if (field.IsLiteral && !field.IsInitOnly)
                {
                    routes[field.Name] = root + field.GetRawConstantValue().ToString();
                }
            }
            return routes;
        }
    }
}
