﻿using System.Web;
using System.Web.Mvc;

namespace PrateekVarshney_3337_Assignment4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
