using System;
class CourseFeeDiscountUserInput{
        static void Main(String[] args){

		Console.WriteLine("Enter the college fee :");
                int fee = int.Parse(Console.ReadLine());
		
		Console.WriteLine("Enter the discount percent :");
                int discountPercent = int.Parse(Console.ReadLine());

                int discountAmount = (fee*discountPercent)/100;
                int finalPrice = fee-discountAmount;

                Console.WriteLine("The discount amount is INR "+discountAmount+" and final discounted fee is INR "+finalPrice);
        }
}

