using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_714220048
{
    public class Product_714220048
    {
private readonly string pagecount;
        private string myType;
        private string myTitle;

        public Product_714220048()
        {

        }

        public Product_714220048(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;
        }

        public string MyType
        {
            get
            {
                return myType;
            }
            set
            {
                myType = value;
            }
        }
        public string MyTitle
        {
            get
            {
                return myTitle;
            }
            set
            {
                myTitle = value;
            }
        }

    }
}
