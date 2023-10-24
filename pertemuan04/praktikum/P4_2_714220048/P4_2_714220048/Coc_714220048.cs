using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P4_2_714220048
{
    public class Coc_714220048 : Product_714220048
    {
        protected string tahunCount;

        public Coc_714220048(string type, string title, string tahunCount) : base(type, title)
        {
            this.tahunCount = tahunCount;
        }

        public string TahunCount
        {
            get
            {
                return tahunCount;
            }
            set
            {
                tahunCount = value;
            }
        }
    }
}

