using System.Web;
using System.Web.Mvc;

namespace _1._33_EF_using_Data_Access_Layers
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
