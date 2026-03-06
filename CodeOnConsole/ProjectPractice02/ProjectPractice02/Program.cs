namespace ProjectPractice02
{
    internal class Program
    {
        static int y = 20;
        int x = 20;

        static void Main(string[] args)
        {
            int y = 20;
            y = 8;

            Console.WriteLine("y is static variable: " + y);
            //static variable can be accessed directly by class name
            Console.WriteLine("y is static variable: " + Program.y);
            //instance no-static therefore we need to create object of class to access instance variable
            Program obj = new Program();
            Console.WriteLine("x is instance variable: " + obj.x);

            //Calling class a static method
            Console.WriteLine("Calling class a static method: ");
            a obj1 = new a();
            obj1.fun1(); // instance method can be called by object of class
            a.fun(); // static method can be called by class name
        }
    }
}
