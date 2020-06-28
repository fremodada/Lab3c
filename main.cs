using System;

class MainClass {
  public static void Main (string[] args) {
    /*

Determine if a number is prime
a) a prime number is not divisible by any other number between 1 and itself (exclude 1 and the number)
eg. For the number 5, between 1 and 5, the numbers are 2, 3,4. All of them leave a remainder when they divide 5. So they are not divisors. Since we did not find a divisor for 5, 5 is prime.
b) A non-prime number will be divisible by any other number between 1 and itself (exclude 1 and the number)
eg. For the number 18, between 1 and 18, the numbers are 2, 3,4,6,9 DONOT leave a remainder when they divide 18. So they are divisors. Since we found a divisor for 18, 18 is not prime.
c) A number is divisible by another number if there is no remainder (use % operator to get remainder).
*/

// Define inputs


// User input number
 int enteredNumber;
// Counter 
 int i;
// Maximum whole number divisor - no remainder
 int max=0;
 // Flag to break out of loop when remainder is found
int flag=0;

// Get number to test
  Console.Write("Enter the Number to check Prime: ");    
  enteredNumber = int.Parse(Console.ReadLine());  
// Set max = entere dNumber divided by 2 
  max=enteredNumber / 2;    
  
  // Continue to divide by 2
  for(i = 2; i <= max; i++)    
  {    
    // If entered Number remainder = 0, it is not Prime
    if(enteredNumber % i == 0)    
    {    
      Console.Write("Number is not Prime.");    
      // Set the flag to 1 and break from the loop
      flag = 1;    
      break;    
    }    
  }    
  // If the flag has not been set, then the Number is Prime
  if (flag == 0)    
    Console.Write("Number is Prime.");       
  }
}