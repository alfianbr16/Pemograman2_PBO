using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_714220048
{
    public class DVD_714220048 : Product_714220048
    {
        protected string _duration;
        public DVD_714220048(string title, string duration)
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this._duration = duration;

            Console.WriteLine("DVD constructor called");
        }

        public string Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                _duration = value;
            }
        }
    }
}
