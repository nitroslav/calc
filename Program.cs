namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в КАЛЬКУЛЯТОР");
            Iaddition addition = new addition();
            addition.add();
        }
        public interface Iaddition
        {
            
            void add()
            {
                
            }
        }
        public class addition : Iaddition
        {
            public void add()
            {
                int number1;
                int number2;
                Console.Write("Введите число 1: ");
                number1 = int.Parse(Console.ReadLine());
                Console.Write("Введите число 2: ");
                number2 = int.Parse(Console.ReadLine());
                Console.Write("Результат: ");
                Console.Write(number1 + number2);
            }
        }
    }
}