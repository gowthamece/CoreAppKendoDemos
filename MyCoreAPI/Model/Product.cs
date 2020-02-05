using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreAPI.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public double Tax { get; set; }
        public string SkuCode { get; set; }
        public string Price1 { get; set; }
        public string Price2 { get; set; }
        public string Price3 { get; set; }
        public string Price4 { get; set; }
        public string Price5 { get; set; }
        public string Price6 { get; set; }
        public string Price7 { get; set; }
        public string Price8 { get; set; }
        public string Price9 { get; set; }
        public string Price10 { get; set; }



        public Product(int ProductID,string ProductName, double Price, double Tax,string SkuCode,string Price1,string Price2,string Price3,string Price4,string Price5,string Price6, string Price7,string Price8,string Price9,string Price10 )
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Tax = Tax;
            this.SkuCode = SkuCode;
            this.Price1 = Price1;
            this.Price2 = Price2;
            this.Price3 = Price3;
            this.Price4 = Price4;
            this.Price5 = Price5;
            this.Price6 = Price6;
            this.Price7 = Price7;
            this.Price8 = Price8;
            this.Price9 = Price9;
            this.Price10 = Price10;
        }
    }
}
