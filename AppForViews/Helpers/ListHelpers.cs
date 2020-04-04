using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppForViews.Models;

namespace AppForViews.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items , object htmlAttributes = null)
        {
            // создаем список
            TagBuilder ul = new TagBuilder("ul");
            foreach (string item in items)
            {
                // создаем элемент списка
                TagBuilder li = new TagBuilder("li");
                // задаем текст элемента списка
                li.SetInnerText(item);
                // добавляем в список
                ul.InnerHtml += li.ToString();
            }

            // добавим атрибуты нашему тегу если надо класс или id 
            ul.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));

            return new MvcHtmlString(ul.ToString());

          
        }

        
        
    }
}