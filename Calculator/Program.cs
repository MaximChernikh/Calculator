namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите выражение: ");
            string inputData = Console.ReadLine();
            string[] splitedData = inputData.Split(' ');

            Calculator calculator = new Calculator
                (null, 
                int.Parse(splitedData[0]), 
                int.Parse(splitedData[2]));


            switch (splitedData[1])
            {
                case "+":
                    calculator.OperatorStrategy = new Plus();
                    calculator.Operate();
                    break;
                case "-":
                    calculator.OperatorStrategy = new Minus();
                    calculator.Operate();
                    break;
                case "*":
                    calculator.OperatorStrategy = new Multiply();
                    calculator.Operate();
                    break;
                case "/":
                    calculator.OperatorStrategy = new Divide();
                    calculator.Operate();
                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }

            //string[] arrayOfInputData = inputData.Split(['+', '-', '/', '*']);
            //for (int i = 0; i < arrayOfInputData.Length; i++)
            //{
            //    arrayOfInputData[i] = arrayOfInputData[i].Trim();
            //}
        }
    }
}