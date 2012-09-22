using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rozo.DTO
{
    public class CategoryBaseDTO
    {
        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public int? Parent
        {
            get;
            set;
        }

        public bool CanAddQuestion
        {
            get;
            set;
        }
    }
}
