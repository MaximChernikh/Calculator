using System.Runtime.InteropServices;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");
            string inputData = Console.ReadLine();
            char[] operations = ['+', '-', '/', '*'];

            int[] extractedNums = (inputData.Split(operations)).Select(int.Parse).ToArray();
            char[] extractedOperations = inputData.Where(c => operations.Contains(c)).ToArray();

            var calculator = new Calculator<double>(null);

            double result = extractedNums[0];

            for (int i = 0; i < extractedOperations.Length; i++)
            {
                switch (extractedOperations[i])
                {
                    case '+':
                        calculator.SetOperator = new Plus();
                        result = calculator.Operate((int)result, extractedNums[i+1]);
                        break;
                    case '-':
                        calculator.SetOperator = new Minus();
                        result = calculator.Operate((int)result, extractedNums[i + 1]);
                        break;
                    case '*':
                        calculator.SetOperator = new Multiply();
                        result = calculator.Operate((int)result, extractedNums[i + 1]);
                        break;
                    case '/':
                        calculator.SetOperator = new Divide();
                        result = calculator.Operate(extractedNums[i], extractedNums[i + 1]);
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}