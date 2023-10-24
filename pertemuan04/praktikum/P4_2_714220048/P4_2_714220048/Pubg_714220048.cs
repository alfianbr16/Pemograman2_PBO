using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220048
{
    public class PUBG_714220048 : Product_714220048
    {
        protected string _tahun;

        public PUBG_714220048(string title, string tahun)
        {
            this.MyTitle = title;
            this.MyType = "Pubg";
            this._tahun = tahun;

            Console.WriteLine("Pubg constructor called");
        }
        public string TahunCount
        {
            get
            {
                return _tahun;
            }
            set
            {
                _tahun = value;
            }
        }
    }
}
