namespace uke_1_OOP;

class Program
{
    // Methods that implements the interface iCalculator
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        calculator.x = 25;
        calculator.y = 5;
        Console.WriteLine(calculator.Power(calculator.y, calculator.x));
        Console.WriteLine(calculator.Add(5, 50)); // 55
        Console.WriteLine(calculator.Divide(5, 0)); // should fail
        Console.WriteLine(calculator.GetType());
        
    }
}
