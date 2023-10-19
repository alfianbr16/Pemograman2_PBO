using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_714220048
{
    public class Book_714220048: Product_714220048
    {
        protected string pageCount;

        public Book_714220048(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
