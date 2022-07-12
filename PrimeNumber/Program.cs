namespace LogicalProblem
{
    public class Program
    {
        public static void Main(String[]args)
        {
            Console.WriteLine("Choose a number to go to the respective problem \n");
            Console.WriteLine("1 for Perfect Number");
            Console.WriteLine("2 for Prime Number");
            Console.WriteLine("3 for Reverse Number");
            Console.WriteLine("4 for Fibonacci Series");
            Console.WriteLine("5 for Coupoun Number");
            Console.WriteLine("6 for StopWatch");


            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Perfectnumber perfect = new Perfectnumber();
                    perfect.Perfectnum();
                    break;
                
                case 2:
                    Primenumber prime = new Primenumber();
                    prime.PrimeNumberprgprg();
                    break;
                case 3:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.ReverseNum();
                    break;
                case 4:
                    Fibonacci fib = new Fibonacci();
                    fib.Fib();
                    break;
                case 5:
                    CouponNumber CN = new CouponNumber();
                    CN.Coupon();
                    break;
                case 6:
                    StopWatch SW = new StopWatch();
                    SW.Stop();
                    break;
            }


            

        }
    }
}
