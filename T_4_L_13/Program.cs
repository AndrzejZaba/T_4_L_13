namespace T_4_L_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new FizzBuzz();
            Console.WriteLine("Zagrajmy w FizzBuzz!\n");

            while (true)
            {
                Console.WriteLine("Podaj liczbę:");
                if(int.TryParse(Console.ReadLine(), out int value))
                {
                    Console.WriteLine($"Wynik:\t{game.Play(value)}\n");
                }
                else
                {
                    Console.WriteLine("Podano złą wartość\n");
                }
            }
        }
    }
}