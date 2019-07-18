using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindDataLibrary
{
    public class CountryItem
    {
        public int? CountryIdentifier { get;  set; }
        public string CountyName { get;  set; }
        public override string ToString()
        {
            return CountyName;
        }
    }
}
