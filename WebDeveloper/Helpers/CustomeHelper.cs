using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomeHelper
    {
        private static string GetHtmlForPrice(double price)
        { 
            return (price == 0.0) ? "<span>Free!!</span>" : $"<span>{price}</span>";
        }

        private static string GetHtmlForDate(DateTime? date)
        {
            return (date == null) ? "<span>None</span>" : $"<span>{date}</span>";
        }

        public static IHtmlString DisplayPriceStatic(double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayDateOrNullStatic(DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? date)
        {
            return new HtmlString(GetHtmlForDate(date));
        }

    }
}
