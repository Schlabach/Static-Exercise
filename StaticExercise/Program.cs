namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempConverter.FahrenheitToCelsius(32);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(100);

            Console.WriteLine($"Celsius {celcius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");


        }
    }
}
