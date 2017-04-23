using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPI.Model
{
    public class TechnologyList
    {
        public TechnologyList(int Value, string Text)
        {

            this.Value = Value;
            this.Text = Text;
        }
        public int Value { get; set; }
        public string Text { get; set; }
    }
}
