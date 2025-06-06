//// 1
//int year;

//Console.WriteLine("enter a year:");
//year = Convert.ToInt32(Console.ReadLine());

//if (year > 0)
//{
//    Console.WriteLine("this is the leap year.");
//}
//else
//{
//    Console.WriteLine("this is not the leap year.");
//}





//// 2
//int score;

//Console.WriteLine("enter a score:");
//score = Convert.ToInt32(Console.ReadLine());

//if (score >= 60)
//{
//    Console.WriteLine("you passed");
//}
//else
//{
//    Console.WriteLine("you failed");
//}






//// 3
//int month;

//Console.WriteLine("Enter month number (1-12):");
//month = Convert.ToInt32(Console.ReadLine());

//int days;

//switch (month)
//{
//    case 1:  
//    case 3:  
//    case 5:  
//    case 7:  
//    case 8:  
//    case 10: 
//    case 12: 
//        days = 31;
//        break;

//    case 4:  
//    case 6:  
//    case 9:  
//    case 11: 
//        days = 30;
//        break;

//    case 2:  
//        days = 28;  
//        break;

//    default:
//        days = 0;  
//        break;
//}

//if (days > 0)
//{
//    Console.WriteLine($"Month {month} has {days} days.");
//}
//else
//{
//    Console.WriteLine("Invalid month number entered.");
//}








//// 4;


//Console.WriteLine("enter the temperature in degrees Celsius:");
//temperature = Convert.ToInt32(Console.ReadLine());

//if (temperature < 0)
//{
//    Console.WriteLine("the temperature is cold.");
//}
//else if (temperature >= 0 && temperature <= 30)
//{
//    Console.WriteLine("the temperature is warm.");
//}
//else
//{
//    Console.WriteLine("the temperature is hot.");
//    }







//// 5

//Console.WriteLine("enter a symbol:");
//char symbol = Convert.ToChar(Console.ReadLine());

//if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u' ||
//    symbol == 'A' || symbol == 'E' || symbol == 'I' || symbol == 'O' || symbol == 'U')
//{
//    Console.WriteLine($"{symbol} is a vowel.");
//}
//else
//{
//    Console.WriteLine($"{symbol} is a consonant.");
//}








//// 6. Is the password entered by the user correct?

//Console.WriteLine("enter the password:");
//string inputPassword = Console.ReadLine();

//string correctPassword = "1234";

//if (inputPassword == correctPassword)
//{
//    Console.WriteLine("password is correct.");
//}
//else
//{
//    Console.WriteLine("password is incorrect.");
//}
