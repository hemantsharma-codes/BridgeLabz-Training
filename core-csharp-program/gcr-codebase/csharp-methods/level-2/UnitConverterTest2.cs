using System;
class UnitConverter{
	public static double ConvertYardsToFeet(double yards){
		double yards2feet = 3;
                return yards*yards2feet;
        }

        public static double ConvertFeetToYards(double feet){
		double feet2yards = 0.333333;
                return feet*feet2yards;
	}

        public static double ConvertMetersToInches(double meters){
		double meters2inches = 39.3701;
                return meters*meters2inches;
        }

        public static double ConvertInchesToMeters(double inches){
		double inches2meters = 0.0254;
                return inches*inches2meters;
	}

	public static double ConvertInchesToCentimeters(double inches){
		double inches2cm = 2.54;
                return inches*inches2cm;
	}
}
class UnitConverterTest2{
	static void Main(string[] args){
		Console.WriteLine("2 yards in feet = " + UnitConverter.ConvertYardsToFeet(2));
                Console.WriteLine("6 feet in yards = " + UnitConverter.ConvertFeetToYards(6));
                Console.WriteLine("1 meter in inches = " + UnitConverter.ConvertMetersToInches(1));
                Console.WriteLine("10 inches in meters = " + UnitConverter.ConvertInchesToMeters(10));
                Console.WriteLine("5 inches in centimeters = " + UnitConverter.ConvertInchesToCentimeters(5));
	}
}

