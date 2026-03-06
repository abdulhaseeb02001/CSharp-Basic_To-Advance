namespace ProjectPractice01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Program class to call the instance method because above function is not static
            Operations p = new Operations();
            p.Accept();
            p.Add();
            p.Subtract();
            p.Multiply();
            p.Divide();
            SimpleInterest s = new SimpleInterest();
            s.calSI();
        }
    }
}
