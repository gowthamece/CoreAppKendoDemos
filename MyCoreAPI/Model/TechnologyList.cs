using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPI.Model
{
    public class TechnologyList
    {
        public TechnologyList(int value, string text)
        {

            this.value = value;
            this.text = text;
        }
        public int value { get; set; }
        public string text { get; set; }
    }
}
