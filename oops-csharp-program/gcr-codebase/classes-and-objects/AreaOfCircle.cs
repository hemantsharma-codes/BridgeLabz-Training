using System;
class AreaOfCircle{
	private double radius;

        // constructor
        public AreaOfCircle(double radius){
		this.radius = radius;
        }

        internal double[] CalculateAreaAndCircumference(){
                double area = Math.PI*radius*radius;
                double circumference = 2*Math.PI*radius;
                return new double[] {area,circumference};
        }

        internal void DisplayAreaAndCircumference(double area,double circumference){

                Console.WriteLine("Area : "+area);
                Console.WriteLine("Circumference : "+circumference);
        }

	static void Main(String[] args){
		Console.WriteLine("Enter the radius : ");
		double radius = double.Parse(Console.ReadLine());

		AreaOfCircle areaOfCircle = new AreaOfCircle(radius);
		double[] result = areaOfCircle.CalculateAreaAndCircumference();
		areaOfCircle.DisplayAreaAndCircumference(result[0],result[1]);
	}
}
