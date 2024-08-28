using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;


///////////////////https://www.youtube.com/watch?v=0QUgvfuKvWU

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

//Variables are buckets in the computer memory
        // int number1 = 59;
        // int number2 = 39;

        // Console.WriteLine(number1 + number2 + " Is that the total");

//
//Data      Type    Size	Description
//int	    4       bytes	Stores whole numbers from -2,147,483,648 to 2,147,483,647
//long	    8       bytes	Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
//float	    4       bytes	Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
//double	8       bytes	Stores fractional numbers. Sufficient for storing 15 decimal digits
//bool	    1       bit	    Stores true or false values
//char	    2       bytes	Stores a single character/letter, surrounded by single quotes
//string	2       bytes   per character	Stores a sequence of characters, surrounded by double quotes

        //     int x;
        //     int y;

        //     x= 7;
        //     y= x+3;

        // System.Console.WriteLine( y);

        // System.Console.WriteLine("What is your name?");
        // Console.Write("Type your first name:");
        // string myFirstName;
        // myFirstName = Console.ReadLine();





        // string myLastName;
        // System.Console.WriteLine("Type your last name: ");
        // myLastName = Console.ReadLine();



        // System.Console.WriteLine("What is your age");
        // string strAge ;
        // strAge = Console.ReadLine();
        // int age = int.Parse(strAge); 



        // System.Console.WriteLine( "Hello " + myFirstName + " " + myLastName + " you are " + age + " years old!  ");


//Variable initialization. when you first define what type of data the variable is.  Dont add them at the top. 
// Declare as you need them
// give variables a value as soon as you initialize them. 
















//******************************** IF Statements ********************************************
//******************************** IF Statements ********************************************
//******************************** IF Statements ********************************************
//******************************** IF Statements ********************************************
//******************************** IF Statements ********************************************



// System.Console.WriteLine("Alex's big giveaway");
// System.Console.Write("Chose a door 1, 2, or 3");
// string userValue = Console.ReadLine();


// //Decision statement. based on the evaluation after the if keyword. 
// //The user value variable to perform an evaluation
// // two equal signs == is evaluation for true or false. 

// string returnMessage = "" ;

// //Scope the returnMessage needs to be defined before withing the if scope. if you define the scope inside the if statement then 
// //you cannot call it out side the scope. 

// if (userValue == "1"){
//    // Console.WriteLine("You won a new car!");
//    returnMessage = "You won a new car!";

// } else if (userValue =="2"){
//     // System.Console.WriteLine("Sorry you did not win");
//     returnMessage = "Sorry you did not win";
// } else if (userValue == "3"){
//     // System.Console.WriteLine("Close but not quiet");
//     returnMessage = "Close but not quiet";
// } 
// else {
//     // Console.WriteLine("Not even close");
//     returnMessage = "Not even close";
// }

// System.Console.WriteLine(returnMessage);

// System.Console.WriteLine("Alex's big giveaway 2");
// System.Console.Write("Chose a door 1, 2, or 3");
// string userValue2 = Console.ReadLine();


// string returnMessage2 =  (userValue2 == "1") ? "boat" : "strand of something";

// System.Console.WriteLine("you won a " + returnMessage2);


// // Entering information with {} that you can enter. 
// System.Console.WriteLine("you entered {0}, therefore you won {1}", userValue2, returnMessage2);


// Console.ReadLine();















//******************************** Operators, Expressions,  and Statements********************************************
//******************************** Operators, Expressions,  and Statements********************************************
//******************************** Operators, Expressions,  and Statements********************************************
//******************************** Operators, Expressions,  and Statements********************************************
//******************************** Operators, Expressions,  and Statements********************************************


// // Statements Made of one or more expression
// //expressions are made of one or more operators


// // expression - operator is int - operator a - operator ; 
//     int a;

// //Operant - name of a class - console is a method - operators
//     System.Console.WriteLine();

    
// // operants - subject of your statement code - you give them the name
// //operators - verbs, things that act on operants - you use the built in examples : = - + / *




// //Variable declaration

// int x, y, z;

// //Assignment operator

// x = 1;
// y = 2;
// z = 3;

// //Mathimatical 

// // addition operator
//  x= 3+4;

//  //subtraction operator

//  x = 3-4;

//  // multiplaction

//  x = 10* 5;

//  // Division operatore

//  x= 10/5;

//  // Order of operations using parenthesis
//  x = (x + y) * (y - z);


// // many operators use to evaluate values. 

// // equality operator

// if ( x == y ){
//     Console.WriteLine("");
// }

// // greater than operator
// if ( x>y){
//     Console.WriteLine("");
// }

// //Less than operator

//  if ( x < z){
//     System.Console.WriteLine("");
//  }

// // greater or equal to operator
// if ( x >= y ){
//     System.Console.WriteLine("");
// }


// // Conditional AND operator

// if((x > y) && (x < z)){
//     System.Console.WriteLine();
// }


// // Conditional OR operator

// if ((x>y) || (x < z)) {
//     System.Console.WriteLine("");
// }


// // in-line conditional operator 
// x= 1;
//  string testingmess = (x == 1) ? "Car" : "Boat";
// System.Console.WriteLine(testingmess);




// //Console is a class
// // WriteLine is a method
// // ("hi"); is  a method invocator
// // classes are containers for methods
// // access a member method 

















//******************************** For Iteration Statements ********************************************
//******************************** For Iteration Statements ********************************************
//******************************** For Iteration Statements ********************************************
//******************************** For Iteration Statements ********************************************
//******************************** For Iteration Statements ********************************************

//Run the line of code over and over again until the middle of the paranthesis is false 
// i++ adds the amount by one
//counter ; condition ; incrementer

// for (int i = 0; i <= 10; i++){
//     System.Console.WriteLine(i);
//     if ( i == 7){
//         System.Console.WriteLine("Found Seven");
//     }
// }






























//******************************** Understanding Arrays ********************************************
//******************************** Understanding Arrays ********************************************
//******************************** Understanding Arrays ********************************************
//******************************** Understanding Arrays ********************************************


//This part is wrong
// int number1 = 67;
// int number2 = 65;
// int number3 = 45;
// int number4 = 3;
// int number5 = 14;

//forced to create an if else structure just to find which variable has the value you are looking for. 

//DO NOT USE /// if (number1 == 24){

//DO NOT USE /// }else if (number2 == 16){

//DO NOT USE /// } else if (number3 == 16){
    
//DO NOT USE /// }


//Variable - not just a bucket. 
// Array a compartments that can have more than just a bucket. 
//Array - general collection of data

// using square brackets []

//array of integers

// //The int[5] is an array that can hold 5 buckets of integers
// int[] numbers = new int[5];

// numbers[0] =4;
// numbers[1] =8;
// numbers[2] =15;
// numbers[3] =16;
// numbers[4] =23;

// //using the index of the array to access the element. [0] will pull the numbers[0] that equals 4 and so on.

// System.Console.WriteLine(numbers[0]);

// //finding out the array length
// System.Console.WriteLine(numbers.Length);

// // for(int i = 0; i < numbers.Length ; i++){
// //         System.Console.WriteLine(numbers[i]);
// // }


// int[] numbers = new int[] { 4,8,15,16,23,42};

//You dont have to always express the total length if you are entering the array 
//string[] names = new string[]{ "Eddie", "Alex", "Michael", "David Lee"};

// for (int i = 0; i< names.Length; i++){
//         System.Console.WriteLine(names[i]);
// }

//This will allow the foreach to go into every element we have in the array. 

// foreach (string name in names){
//         System.Console.WriteLine(name);
// }







//create a string and reverse the string

// WE ARE USING THE ToCharArray method


// string zig = "You can get what you want out of life"+
// " if you help enough other people get what they want.";

// char[] charArray = zig.ToCharArray();

// Array.Reverse(charArray);

// foreach (char zigChar in charArray){
//         Console.WriteLine(zigChar);
// }

//The for loop should be the second option for searching through arrays. 
// for(int i = 0; i  < charArray.Length; i++){
//         System.Console.WriteLine(charArray[i]);
// }


    }




}