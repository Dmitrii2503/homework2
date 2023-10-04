Console.WriteLine ("enter the number");

int number = Convert.ToInt32 (Console.ReadLine()) ; 

if (number<100 || number >= 1000) 
{
Console.WriteLine ("Your value Contains more or less then 3 numbers in value. Please, Try again");
return;
} 

else 
{
    Console.Write ($"Entered number is '{number}'");
    int right_number = number / 10 % 10;
    Console.WriteLine ($"the second number of value is '{right_number}' ");
};




