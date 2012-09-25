using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Utility.Interfaces;

namespace Rozo.Web.Helpers
{
    /// <summary>
    /// Wraps result as data plus pagination information.
    /// </summary>
    public class ResultWrapper<T> 
        where T : class, IDTOBase
    {
        /// <summary>
        /// Data to return
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Pagination information
        /// </summary>
        public Pagination Pagination { get; set; }

        public ResultWrapper(IEnumerable<T> data, Pagination pagination)
        {
            this.Data = data;
            this.Pagination = pagination;
        }

    }
}