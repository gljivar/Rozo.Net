using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rozo.Web.Helpers
{
    /// <summary>
    /// Describes paging information.
    /// </summary>
    public class Pagination
    {
        /// <summary>
        /// Number of pages
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        public int Current { get; set; }

        /// <summary>
        /// Uri of next results in pagination
        /// </summary>
        public string Next { get; set; }

        /// <summary>
        /// Uri of previous results in pagination
        /// </summary>
        public string  Previous { get; set; }
    }
}