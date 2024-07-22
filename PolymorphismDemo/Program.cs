using EcommerceLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Cart c=new  Cart();
        Console.WriteLine("Enter Custid");
        c.CustId =Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Qty");
        c.Quantity = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Price");
        c.Price = Convert.ToInt32(Console.ReadLine());

        decimal amt=c.CalculateAmt();
        Console.WriteLine($"Your total amt to pay= {amt}");
        Console.WriteLine("Now select your mode of Payment");
        Console.WriteLine("Menu");
        Console.WriteLine("1.Cash \n2.Card \n3.UPI ID");
        int choice=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
           
                c.Pay();
                Console.WriteLine($"You have selected Cash");
               break;
            case 2:
           
                Console.WriteLine("Enter card no");
                long cardno=Convert.ToInt64(Console.ReadLine());
                Console.WriteLine("Enter CVV");
                int cvv=Convert.ToInt32(Console.ReadLine());
               decimal Amt= c.Pay(cardno, cvv);
                Console.WriteLine($"You have paid a {Amt} by {c.Mode}");
                break;
            case 3:
           
                Console.WriteLine("Enter UPI");
                string upi=Console.ReadLine();
                 Amt = c.Pay(upi);
                Console.WriteLine($"You have paid a {Amt} by {c.Mode}");
                break;
            default:
                break;
        }
        Console.ReadLine();

    }
}