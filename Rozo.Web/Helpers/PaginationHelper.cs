using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Routing;

namespace Rozo.Web.Helpers
{
    public class PaginationHelper
    {
        public static Pagination CreatePagination(UrlHelper urlHelper, int currentOffset, int limit, int totalResults)
        {
            var pagination = new Rozo.Web.Helpers.Pagination();
            pagination.Current = currentOffset;
            pagination.Pages = totalResults % limit == 0 ? totalResults / limit : totalResults / limit + 1;
            pagination.Next = currentOffset + limit > totalResults ? null : urlHelper.Link("DefaultApi", new { offset = currentOffset + limit, limit = limit, totalResults = totalResults });
            pagination.Previous = currentOffset == 0 ? null : urlHelper.Link("DefaultApi", new { offset = currentOffset - limit < 0 ? 0 : currentOffset - limit, limit = limit, totalResults = totalResults });

            return pagination;
        }
    }
}