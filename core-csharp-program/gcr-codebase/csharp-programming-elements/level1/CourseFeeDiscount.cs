using System;
class CourseFeeDiscount{
	static void Main(String[] args){

		int fee = 125000;
		int discountPercent = 10;

		int discountAmount = (fee*discountPercent)/100;
		int finalPrice = fee-discountAmount;

		Console.WriteLine("The discount amount is INR "+discountAmount+" and final discounted fee is INR "+finalPrice);
	}
}
