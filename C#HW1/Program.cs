using System;
class HelloWorld
{
    static void Main()
    {
        //============= task2 =============//

        // int num;
        // while(true){
        //     Console.Write("Enter number: ");
        //     num = Int32.Parse(Console.ReadLine());
        //     if( num>0 && num<101) break;
        //     if( num<=0 || num>=101){
        //         Console.WriteLine("Entered a value not in the range of 1 up to 100");
        //     } 
        // }
        // if(num %3 == 0 && num %5 != 0){
        //     Console.WriteLine("Fizz");
        // }
        // else if(num %3 != 0 && num %5 == 0){
        //     Console.WriteLine("Buzz");
        // }
        // else if (num %3 == 0 && num %5 == 0){
        //     Console.WriteLine("Fizz Buzz");
        // }

        //============= task2 =============//

        // int num1, num2;
        // Console.Write("Enter number: ");
        // num1 = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter percentage that you want to find: ");
        // num2 = Int32.Parse(Console.ReadLine());
        // int result = num2*num1/100;
        // Console.WriteLine($"Result is {result}");

        //============= task3 =============//

        // int num3, num4, num5, num6;

        // Console.Write("Enter 1st number: ");
        // num3 = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter 2nd number: ");
        // num4 = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter 3th number: ");
        // num5 = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter 4th number: ");
        // num6 = Int32.Parse(Console.ReadLine());
        // int result = num3*1000+num4*100+num5*10+num6;
        // Console.WriteLine($"Result is {result}");

        //============= task4 =============//

        // int number;
        // while(true){
        //     Console.Write("Enter 6 digit number: ");
        //     number = Int32.Parse(Console.ReadLine());
        //     if( number>99999 && number<1000000) break;
        //     if( number<=99999 || number>=1000000){
        //         Console.WriteLine("Entered 6 digit number!");
        //     }
        // }
        // int digit1, digit2;
        // while(true){
        // Console.Write("Enter 1st number that need to change: ");
        //     digit1 = Int32.Parse(Console.ReadLine());
        //     if(digit1<1 || digit1>6){
        //         Console.Write("Enter number from 1 to 6");
        //     }
        //     if(digit1>=1 && digit1<=6){
        //         break;
        //     }
        // }
        // while(true){
        //     Console.Write("Enter 2st number that need to change: ");
        //     digit2 = Int32.Parse(Console.ReadLine());
        //     if(digit2<1 || digit2>6){
        //         Console.Write("Enter number from 1 to 6");
        //     }
        //     if(digit2>=1 && digit2<=6){
        //         break;
        //     }
        // }
        // char[] numArray = number.ToString().ToCharArray();
        // char temp = numArray[digit1 - 1];
        // numArray[digit1 - 1] = numArray[digit2 - 1];
        // numArray[digit2 - 1] = temp;
        // int swappedNumber = int.Parse(new string(numArray));
        // Console.WriteLine($"Result is: {swappedNumber}");

        //============= task5 =============//    

        // int day, month, year;
        // Console.Write("Enter day : ");
        // day = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter month : ");
        // month = Int32.Parse(Console.ReadLine());
        // Console.Write("Enter year : ");
        // year = Int32.Parse(Console.ReadLine());

        // Console.Write("Result is : ");
        // switch (month) {
        // case 1:
        // case 2:
        // case 12:
        //     Console.Write("Winter ");
        //     break;
        // case 3:
        // case 4:
        // case 5:
        //     Console.Write("Spring ");
        //     break;
        //     case 6:
        // case 7:
        // case 8:
        //     Console.Write("Summer ");
        // break;
        // case 9:
        // case 10:
        // case 11:
        //     Console.Write("Autumn ");
        //     break;
        // default:
        //     break;
        // }

        // DateTime date = new DateTime(year, month, day);
        // string weekday =  date.DayOfWeek.ToString();
        // Console.Write(weekday);

        //============= task6 =============//
        // int temperature1, select1, select2;
        // Console.Write("Enter temperatur: ");
        // temperature1 = Int32.Parse(Console.ReadLine());
        // while(true){
        //     Console.Write("Select type of mesure\n1. Celsius\n2. Fahrenheit\nSelect-> ");
        //     select1 = Int32.Parse(Console.ReadLine());
        //     if(select1 == 1 || select1 == 2) break;
        // }
        // while(true){
        //     Console.Write("Select type of mesure to turn in \n1. Celsius\n2. Fahrenheit\nSelect-> ");
        //     select2 = Int32.Parse(Console.ReadLine());
        //     if(select2 == 1 || select2 == 2) break;
        // }
        // if(select1 == 1 && select2 == 1){
        //     Console.WriteLine($"Temperature is {temperature1} celsius");
        // }
        // if(select1 == 1 && select2 == 2){
        //     double temperature2 = (temperature1 * 9/5) + 32;
        //     Console.WriteLine($"Temperature is {temperature2} fahrenheit");
        // }
        // if(select1 == 2 && select2 == 1){
        //     double temperature2 = ((temperature1 - 32) * 5/9);
        //     Console.WriteLine($"Temperature is {temperature2} celsius");
        // }
        // if (select1 == 2 && select2 == 2){
        //     Console.WriteLine($"Temperature is {temperature1} fahrenheit");
        // }

        //============= task6 =============//

        int startRange, endRange;
        Console.Write("Enter start of range: ");
        startRange = Int32.Parse(Console.ReadLine());
        Console.Write("Enter end of range: ");
        endRange = Int32.Parse(Console.ReadLine());
        if (startRange > endRange)
        {
            int temp = startRange;
            startRange = endRange;
            endRange = temp;
        }
        for (int i = startRange; i < endRange; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }


    }
}





