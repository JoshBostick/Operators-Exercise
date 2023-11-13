namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int dif = a - b;
            int mul = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} with remainder {remainder}");

            Console.WriteLine("Enter the radius of your circle");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of your circle is {AreaOfCircle(radius)}");
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;           
            return area;    
        }
    }
}
