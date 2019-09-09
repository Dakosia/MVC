using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelAtr.Web.Models
{
    public static class MyHtmlHelper
    {
        public static MvcHtmlString CreatePriceDescription(double price)
        {
            /*
             *  <div class="slider-image">
                             <img src="img/room/l-1.jpg" alt="">
                             <div class="cost">
                                 <h2>$ @Model.Price</h2>
                                 <span>Per Night</span>
                             </div>
                         </div>
             */
            TagBuilder divBace = new TagBuilder("div");
            divBace.AddCssClass("slider-image");

            TagBuilder img = new TagBuilder("img");
            img.MergeAttribute("src", "img/room/l-1.jpg");

            TagBuilder div = new TagBuilder("div");
            div.AddCssClass("cost");

            TagBuilder h2 = new TagBuilder("h2");
            TagBuilder span = new TagBuilder("span");

            span.SetInnerText("Per Night");
            h2.SetInnerText(string.Format("{0} KZT", price));

            div.InnerHtml += h2.ToString();
            div.InnerHtml += span.ToString();

            divBace.InnerHtml += img;
            divBace.InnerHtml += div;

            return new MvcHtmlString(divBace.ToString());

        }
    }
}