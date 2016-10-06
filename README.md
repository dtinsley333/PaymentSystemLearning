#Basic Code Demo for Inheritance, Overriding, and Overloading
####Run this code in Visual Studio Code (works on mac, pc, linux)
This is a basic example that focuses on a few object oriented topics. 

####Base Class is Called Payment
We know we are going to have to deal with various types of payments, in this example we will need to receive payments in cash,
paypal, and credit card. The base class below only has a property for amount and a virtual method "MakePayment" which will likely need to 
modified in sub classes.
```
 public class Payment
    {
        public decimal Amount{get;set;}

        public virtual  string MakePayment()
        {
          return $"You paid ${this.Amount} in Cash ";
        }

        public string SendConfirmation(string email)
        {
           return "You purchased several nice items"; 
        }

        public string SendConfirmation(string email, bool digitalDownload)
        {
           return "Check your email for the downloadable book"; 
        }
    }

```
####The PayPalPayment class inherits the Base class "Payment"
```
  public class PayPalPayment:Payment
    {
        public string Password {get;set;}
        public string Email {get;set;}
        public override string MakePayment()
        {
           string message=string.Empty;
           if(this.Amount>0 && this.Password!=null)
           {
              return message=$"Your payment of {this.Amount} has been processed by PayPal"; 
           }

            return message ;
        }

```
####Using your derived classes. 

```
 public static void Main(string[] args)
        {          
            var paymentType=args[0];
            
            if(paymentType=="p")
            {
                var paypalpayment=new PayPalPayment
                {
                    Email=args[1],
                    Password=args[2],
                    Amount=Convert.ToDecimal(args[3])
                };
                Console.WriteLine(paypalpayment.MakePayment());
            }

            if(paymentType=="c")
            {
                var creditcardpayment=new CreditCardPayment
                {
                    CreditCardNumber=args[1],
                    Amount=Convert.ToDecimal(args[2])
                };
                Console.WriteLine(creditcardpayment.MakePayment());
            }
        }
```

