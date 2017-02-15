using System.Web.Mvc;

namespace MongoCRUD {

    public class FilterConfig {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}