using System;
using System.Linq;
using Modas.Models;

namespace Modas.Controllers
{
    public static class LinqExtension
    {
        public static IOrderedQueryable<EventJson> OrderBy(this IQueryable<EventJson> eventJson, string sortBy, string order)
        {
            return sortBy switch
            {
                "flag" => order == "asc" ? 
                    eventJson.OrderBy(e => e.flag) :
                    eventJson.OrderByDescending(e => e.flag),
                "stamp" => order == "asc" ? 
                    eventJson.OrderBy(e => e.stamp) :
                    eventJson.OrderByDescending(e => e.stamp),
                "loc" => order == "asc" ? 
                    eventJson.OrderBy(e => e.loc) :
                    eventJson.OrderByDescending(e => e.loc),
                _ => order == "asc" ? 
                    eventJson.OrderBy(e => e.stamp) :
                    eventJson.OrderByDescending(e => e.stamp)
            };
        }
    }
}