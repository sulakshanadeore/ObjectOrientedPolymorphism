namespace EcommerceLibrary
{
    public class Cart
    {

        public int CustId { get; set; }

        public int Price { get; set; }
        public int Quantity { get; set; }

        private decimal _amt;
        public decimal Amt { get { return _amt; } private set { _amt = value; } }
        
        public string Mode {  get; private set; }
        public decimal CalculateAmt()
        { 

            decimal amt=Price*Quantity;
            Amt = amt;//private setter called
            return amt; 
        
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
