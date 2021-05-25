using System;

namespace _2
{
    delegate dynamic UserInput(string text);
    delegate dynamic Action(dynamic a, dynamic b);
    class Program
    {
        static void Main(string[] args)
        {
            UserInput smthng = Input;
            Action Sum = (a, b) => a + b;
            Action Divide = (a, b) => a / b;
            Action Diff = (a, b) => a - b;
            Action Mult = (a, b) => a * b;
            while(true)
            {
                Console.Clear();
                dynamic value_1 = smthng("Введите 1 значение:");
                dynamic value_2 = smthng("Введите 2 значение");
                dynamic value_3 = smthng("Выберите действие:\n1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление");
                dynamic Answer;
                switch(value_3)
                {
                    case 1:
                        Answer = Sum(value_1, value_2);
                        break;
                    case 2:
                        Answer = Diff(value_1, value_2);
                        break;
                    case 3:
                        Answer = Mult(value_1, value_2);
                        break;
                    case 4:
                        try
                        {
                            Answer = Divide(value_1, value_2);
                        } 
                        catch (Exception)
                        {
                            Answer = "error";
                        }
                        break;
                    default:
                        Answer = "error";
                        break;
                }
                Console.WriteLine($"Результат: {Answer}");
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey(true);
            }
        }
        private static dynamic Input(string text)
        {
            Console.WriteLine(text);
            dynamic input = Console.ReadLine();
            try
            {
                input = Int32.Parse(input);
            } 
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода");
            }
            return input;
            
        }
    }
}
