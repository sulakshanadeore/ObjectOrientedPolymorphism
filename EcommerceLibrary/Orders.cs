using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceLibrary
{
    public class Orders
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

        public virtual string AddToCart(int prodid)
        { 
            ProductID = prodid;
            return $"Product added to cart with ProductID={ProductID}";
        
        
        }

    }
}
