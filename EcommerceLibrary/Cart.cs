namespace EcommerceLibrary
{
    public enum UserType 
    {
    Admin=1,
    Customer=2
   }


    

   public class Cart:Orders
    {

        public int CustId { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }

        private decimal _amt;
        public decimal Amt { get { return _amt; } private set { _amt = value; } }
        
        public string Mode {  get; private set; }
        private void CalculateAmt()
        { 

            Amt=Price*Quantity;
            //Amt = amt;//private setter called
            //return amt; 
        
        }

        public override  string AddToCart(int prodid)
        { 
        base.AddToCart(prodid);
         CalculateAmt();
            string greet="Thanks for shopping with us.. Ur order will reach u soon";
            return greet;
        
        }





        public decimal Pay(string upiID)
        {
            Mode = "UPI";

            return Amt;

        }


        public decimal Pay(long cardno,int cvv) 
        {
            Mode = "Card";
            return Amt;
        
        }

        public void Pay()
        {
            Mode = "Cash";
            Console.WriteLine("Thanks");

        }


    }
}
