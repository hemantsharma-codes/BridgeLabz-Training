using System;
class CalendarDisplay{
        // method to check leap year
        static bool IsLeapYear(int year){
                if((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)){
                        return true;
                }else{
                        return false;
                }
        }

        // method to get month name
        static string GetMonthName(int month){
                string[] months = {
                        "January","February","March","April","May","June",
                        "July","August","September","October","November","December"
                };
                return months[month - 1];
        }

        // method to get number of days in a month
        static int GetDaysInMonth(int month,int year){
                int[] days = {31,28,31,30,31,30,31,31,30,31,30,31};

                if(month == 2){
                        if(IsLeapYear(year)){
                                return 29;
                        }else{
                                return 28;
                        }
                }
                return days[month - 1];
        }

        // method to find first day of the month (0 = Sunday)
        static int GetFirstDay(int month,int year){
                int d = 1;
                int m = month;
                int y = year;

                int y0 = y - (14 - m) / 12;
                int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
                int m0 = m + 12 * ((14 - m) / 12) - 2;
                int d0 = (d + x + (31 * m0) / 12) % 7;

                return d0;
        }

        static void Main(string[] args){

                Console.WriteLine("Enter month (1-12):");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter year:");
                int year = int.Parse(Console.ReadLine());

                string monthName = GetMonthName(month);
                int totalDays = GetDaysInMonth(month, year);
                int firstDay = GetFirstDay(month, year);

                Console.WriteLine();
                Console.WriteLine("      " + monthName + " " + year);
                Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

                // spaces before first day
                for(int i = 0; i < firstDay; i++){
                        Console.Write("    ");
                }

                // print all days
                for(int day = 1; day <= totalDays; day++){

                        if(day < 10){
                                Console.Write("  " + day + " ");
                        }else{
                                Console.Write(" " + day + " ");
                        }

                        if((day + firstDay) % 7 == 0){
                                Console.WriteLine();
                        }
                }

                Console.WriteLine();
        }
}

