using System;
class TemperatureAnalyzer{

	// create an 2D array to store temperature data
	private static int days = 7;
	private static int hours = 24;
	private static float[,] temperatureData = new float[days,hours];
	private static string[] dayNames = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

	static void Main(String[] args){
		
		InitiateApp();
	}
	
	private static void InitiateApp(){

		FillTemperatureData();

		// method for displaying the menu
		DisplayMenu();
		DisplayTemperatureOfEveryDay();

		Console.WriteLine("Please press the button : ");
		int n = int.Parse(Console.ReadLine());

		switch(n){
			case 1 :
				FindHottestAndColdestDay();
				break;
			case 2 :
				for(int i=0;i<days;i++){
					Console.WriteLine("Average temperature on "+dayNames[i]+" is "+FindAvgTemperature(i)+" degree celcius");
				}
				break;
			default :
				Console.WriteLine("Please enter the valid button.");
				break;
		}

	}

	private static void FindHottestAndColdestDay(){


		Console.WriteLine("\nThe coddest and the hotest value of every day : \n");
		for(int i=0;i<temperatureData.GetLength(0);i++){
			float coldestDay = float.MaxValue;
			float hottestDay = float.MinValue;
			for(int j=0;j<temperatureData.GetLength(1);j++){
				if(coldestDay > temperatureData[i,j]){
					coldestDay = temperatureData[i,j];
				}
				if(hottestDay < temperatureData[i,j]){
					hottestDay = temperatureData[i,j];
				}
			}
			Console.WriteLine("The coldest temperature is "+coldestDay+" degree celcius on "+dayNames[i]);
			Console.WriteLine("The hottest temperature is "+hottestDay+" degree celcius on "+dayNames[i]);

		}
	}

	private static float FindAvgTemperature(int day){
		float sum = 0;
		for(int hours = 0;hours<temperatureData.GetLength(1);hours++){
			sum += temperatureData[day,hours];
		}
		float avgTemp = sum/temperatureData.GetLength(1);
		return avgTemp;
	}

	private static void FillTemperatureData(){
		
		float minValue = 0.0f;
		float maxValue = 150.0f;


		Random temperature = new Random();

		for(int i=0;i<temperatureData.GetLength(0);i++){
			for(int j=0;j<temperatureData.GetLength(1);j++){
				temperatureData[i,j] = (float)(minValue+(temperature.NextDouble()*(maxValue-minValue)));
			}
		}
	}
	static void DisplayMenu(){
		
		Console.WriteLine("Press 1 for : Find  the hottest and coldest day.");
		Console.WriteLine("Press 2 for : Return average temperature per day.");

	}
	private static void DisplayTemperatureOfEveryDay(){

		for(int i=0;i<temperatureData.GetLength(0);i++){
			Console.WriteLine("Temperature of "+dayNames[i]);
			for(int j=0;j<temperatureData.GetLength(1);j++){
				Console.WriteLine(temperatureData[i,j]);
			}
		}
	}

}
