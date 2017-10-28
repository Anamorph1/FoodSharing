﻿using System;
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
        public const string ORDER_CREATE = ORDER_ID + "create/";
        public const string ORDER_UPDATE = ORDER_ID + "update/";
        public const string ORDER_SUBMIT = ORDER_ID + "submit/{id}";

        public const string USERS = API + "users/";
        public const string USER_ID = USERS + "{id}/";
        public const string USER_CREATE = USERS + "create/";

        public const string IMAGES = API + "images/";
        public const string IMAGE_ID = IMAGES + "{id}/";
        public const string IMAGE_CREATE = IMAGES + "/create";

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
