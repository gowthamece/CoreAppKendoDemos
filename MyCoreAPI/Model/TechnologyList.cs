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
        public TechnologyList(int value, string text,Category category)
        {

            this.value = value;
            this.text = text;
            this.Category = category;
        }
        public int value { get; set; }
        public string text { get; set; }

        public Category Category { get; set; }
    }

    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
