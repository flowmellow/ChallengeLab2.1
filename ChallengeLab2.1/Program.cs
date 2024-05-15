/*Write a C# Sharp program to read temperature in fahrenheit and display a suitable message according to temperature state below :
Temp 0< 10 then Freezing weather
Temp 11-20 then Very Cold weather
Temp 21-35 then Cold weather
Temp 36-50 then Normal in Weather
Temp 51-65 then Its Hot
Temp 66-80 then Its Very Hot
Test Data :
67
Expected Output :
Its very hot.
*/

namespace ChallengeLab2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature (digit format) in fahrenheit to get a weather description: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            
            switch (temp)
            {

                case >= 0 and <= 10:
                    Console.WriteLine($"The temperature is {temp}; It is freezing weather.");
                    break;
                case >= 11 and < 20:
                    Console.WriteLine($"The temperature is {temp}; It is very cold weather.");
                    break;
                case >= 21 and < 35:
                    Console.WriteLine($"The temperature is {temp}; It is cold weather.");
                    break;
                case >= 36 and < 50:
                    Console.WriteLine($"The temperature is {temp}; It is normal weather.");
                    break;
                case >= 51 and < 65:
                    Console.WriteLine($"The temperature is {temp}; It is hot weather.");
                    break;
                case >= 66 and < 80:
                    Console.WriteLine($"The temperature is {temp}; It is very hot weather.");
                    break;
                default:
                    Console.WriteLine($"The temperature {temp} is outside of the acceptable range");
                    break;
            }

        }
    }
}
