using System;
class UnitConverter{
	public static double ConvertFahrenheitToCelsius(double fahrenheit){
		double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
                return fahrenheit2celsius;
	}

	public static double ConvertCelsiusToFahrenheit(double celsius){
		double celsius2fahrenheit = (celsius * 9 / 5) + 32;
                return celsius2fahrenheit;
	}

	public static double ConvertPoundsToKilograms(double pounds){
		double pounds2kilograms = 0.453592;
		return pounds * pounds2kilograms;
        }

        public static double ConvertKilogramsToPounds(double kilograms){
		double kilograms2pounds = 2.20462;
                return kilograms * kilograms2pounds;
	}

        public static double ConvertGallonsToLiters(double gallons){
		double gallons2liters = 3.78541;
                return gallons * gallons2liters;
	}

        public static double ConvertLitersToGallons(double liters){
		double liters2gallons = 0.264172;
		return liters * liters2gallons;
        }
}
class UnitConverterTest{
	static void Main(string[] args){
		Console.WriteLine("98.6°F in Celsius = "+UnitConverter.ConvertFahrenheitToCelsius(98.6));
		Console.WriteLine("37°C in Fahrenheit = "+UnitConverter.ConvertCelsiusToFahrenheit(37));
		Console.WriteLine("150 pounds in kilograms = "+UnitConverter.ConvertPoundsToKilograms(150));
                Console.WriteLine("68 kilograms in pounds = "+UnitConverter.ConvertKilogramsToPounds(68));
                Console.WriteLine("2 gallons in liters = "+UnitConverter.ConvertGallonsToLiters(2));
                Console.WriteLine("5 liters in gallons = "+UnitConverter.ConvertLitersToGallons(5));
    }
}

