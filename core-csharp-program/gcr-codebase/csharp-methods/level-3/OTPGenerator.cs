using System;
class OTPGenerator{
        // method to generate a 6 digit OTP
        static int GenerateOTP(){
                Random random = new Random();
                int otp = random.Next(100000, 1000000);
                return otp;
        }

        // method to check whether all OTPs are unique
        static bool AreOTPsUnique(int[] otpArray){
                for(int i=0;i<otpArray.Length;i++){
                        for(int j=i+1;j<otpArray.Length;j++){
                                if(otpArray[i] == otpArray[j]){
                                        return false;
                                }
                        }
                }
                return true;
        }

        static void Main(string[] args){

                int[] otpNumbers = new int[10];

                // generate OTPs 10 times
                for(int i=0;i<otpNumbers.Length;i++){
                        otpNumbers[i] = GenerateOTP();
                        Console.WriteLine("Generated OTP "+(i+1)+": "+otpNumbers[i]);
                }

                // check uniqueness
                bool result = AreOTPsUnique(otpNumbers);

                if(result == true){
                        Console.WriteLine("All generated OTPs are unique");
                }else{
                        Console.WriteLine("Duplicate OTP found");
                }
        }
}

