using System;

class Program {
  public static double CalculateCharges(double hours)
  {
    double charges = 0;
    if (hours <= 3)
    {
      charges = 2.00;
    }
    else if (hours>=19)
    {
      charges = 10.00;
    }
    else
    {
      charges = (2+((hours-3)*.5));
    }
    return charges;
  }

  public static void Main (string[] args) {
    string answer = "Y";
    while(answer == "Y") 
    {
    Console.WriteLine ("Enter hours parked as a decimel:");
    double hours = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Customer owes: $" + CalculateCharges(hours));
    Console.WriteLine("Are there any more customers? Answer Y/N:");
    answer = Console.ReadLine();
    }
    if (answer == "N")
    {
    Console.WriteLine("Program complete.");
    }
    else if (answer == "y")
    {
      Console.WriteLine("PROGRAM IS CASE SENSITIVE, PLEASE RESTART AND CAPITALIZE YOUR Y.");
    }
    else
    {
      Console.WriteLine("Error, does not compute. Initiating self-destruct sequence.");
    }
  }
}