using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;


///////////////////https://www.youtube.com/watch?v=0QUgvfuKvWU

internal class Program
{
    private static void Main(string[] args)
    {
        int testingNum = 56;
        Console.WriteLine(testingNum);

        Console.ReadLine();
        //Console.WriteLine("Hello, World!");

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


















        //******************************** Definning and Calling Methods ********************************************
        //******************************** Definning and Calling Methods ********************************************
        //******************************** Definning and Calling Methods ********************************************
        //******************************** Definning and Calling Methods ********************************************
        //******************************** Definning and Calling Methods ********************************************


        //Organize our code better. 
        //Allow use to take feature/functionality give it a name and call it through our projects. 
        //Method block of code that has a name and you can call it by the name. 
        //Important building block.



        //keep methods within the same class. 

        //    Console.WriteLine("The Name Game");
        //    Console.Write("What's your first name?");
        //    string firstName = Console.ReadLine();

        //    Console.Write("What's your last name?");
        //    string lastName = Console.ReadLine();

        //    Console.Write("In what City were you born?");
        //    string city = Console.ReadLine();

        //    ////char[] firstNameArray = firstName.ToCharArray();
        //    ////Array.Reverse(firstNameArray);

        //    ////char[] lastNameArray = lastName.ToCharArray();
        //    ////Array.Reverse(lastNameArray);

        //    ////char[] cityArray = city.ToCharArray();
        //    ////Array.Reverse(cityArray);

        //    //string result = "";


        //    ////foreach (char item in firstNameArray)
        //    ////{
        //    ////    result += item;
        //    ////}

        //    ////result += " ";

        //    ////foreach (char item in lastNameArray)
        //    ////{
        //    ////    result += item;
        //    ////}

        //    ////result += " ";

        //    ////foreach (char item in cityArray)
        //    ////{
        //    ////    result += item;
        //    ////}
        //    ////Console.WriteLine("Results " + result);
        //    ////Console.ReadLine();

        //    Console.WriteLine("Did itwork?");
        //    TurnToArrayandFlip(firstName);
        //    TurnToArrayandFlip(lastName);
        //    TurnToArrayandFlip(city);


        //    string reversedFirstName = ReverseString(firstName);
        //    string reversedLastName = ReverseString(lastName);
        //    string reversedCity = ReverseString(city);

        //    Console.Write(String.Format("{0} {1} {2}",
        //        reversedFirstName,
        //        reversedLastName,
        //        reversedCity));


        //    Console.ReadLine(); 


        //}
        /////////////Setting up a private static void - means that there will be return after running the method.

        //private static void TurnToArrayandFlip(string dataInput)
        ////the void says that you dont report to give back a result
        //{
        //    char[] turnIntoArray = dataInput.ToCharArray();
        //    Array.Reverse(turnIntoArray);

        //    string switching = "";
        //    foreach (char item in turnIntoArray)
        //    {
        //        switching += item;
        //    }
        //    Console.Write(switching += " ");
        //}

        //private static string ReverseString(string message)
        //    //Accepting the values and returning something
        //{
        //    char[] messageArray = message.ToCharArray();
        //    Array.Reverse(messageArray);
        //    return String.Concat(messageArray);

        //}


        //private static void HelloWorlds()
        //{
        //    Console.WriteLine("hello world");
        //    Console.ReadLine();


























        //******************************** While Iteration Statement ********************************************
        //******************************** While Iteration Statement ********************************************
        //******************************** While Iteration Statement ********************************************
        //******************************** While Iteration Statement ********************************************
        //******************************** While Iteration Statement ********************************************


        // How many times the code needs to go through. until some condition is met - Use the While

        // DO-WHILE will at least be ran at least one.


        //    bool displayMenu = true;
        //    while (displayMenu)//Checks the condition 
        //    {
        //        displayMenu = MainMenu();
        //    }

        //    MainMenu();


        //}

        //private static bool MainMenu()
        //{
        //    Console.WriteLine("Choose an option:");
        //    Console.WriteLine("1) Print Numbers");
        //    Console.WriteLine("2) Guessing Game");
        //    Console.WriteLine("3) Exit");

        //    string result = Console.ReadLine();

        //    if (result == "1")
        //    {
        //        PrintNumbers();
        //        return true;
        //    }
        //    else if (result == "2")
        //    {
        //        GuessingGame();
        //        return true;
        //    }
        //    else if (result == "3")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;

        //    }

        //}

        //private static void PrintNumbers()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Print numbers");
        //    Console.WriteLine("Type a number: ");
        //    int result = int.Parse(Console.ReadLine());
        //    int counter = 1;
        //    while (counter <= result)
        //    {
        //        if (counter == (result))
        //        {
        //            Console.Write(counter);
        //        } else
        //        {
        //            Console.Write(counter);
        //            Console.Write("-");
        //        }
        //        counter++;

        //    }
        //    Console.ReadLine();
        //}

        //private static void GuessingGame()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Guessing game!");
        //    Random myRandom = new Random();
        //    int randomNumber = myRandom.Next(1, 11);
        //    int guesses = 0;
        //    bool incorrect = true;

        //    do
        //    {
        //        Console.WriteLine("Guess a number between 1 and 10: ");
        //        string result = Console.ReadLine();
        //        guesses++;
        //        if (result == randomNumber.ToString())
        //            incorrect = false;
        //        else
        //            Console.WriteLine("Wrong!");
        //    } while (incorrect);
        //    Console.WriteLine("Correct! It took you {0} guesses", guesses);
        //    Console.ReadLine();
        //}




















        //******************************** Working with string  ********************************************
        //******************************** Working with string  ********************************************
        //******************************** Working with string  ********************************************
        //******************************** Working with string  ********************************************
        //******************************** Working with string  ********************************************




        //Changing strings to  create values

        //string myString = "My \"so-called\" life " ;
        //string myString2 = "What if I need a\nnew line?";
        //string myString3 = "Go to your C:\\ drive";
        //string myString4 = @"Go to your c:\= drive";

        //string myString5 = String.Format("{0} = {1}", "First","Second");
        //string myString6 = String.Format("{0:C}", 123.45);
        //string myString7 = String.Format("{0:N}", 12345667);
        //string myString8 = String.Format("{0:P}", .123);


        //string myString9 = String.Format("Phone Number: {0:(###) ###-####}", 1234567890);
        //Console.WriteLine(myString9);
        //Console.ReadLine();



        ////change the string its self

        //string myString10 = " That summer we took threes across the board ";
        ////myString10 = myString.Replace(" ", "--");
        ////myString10 = myString10.Substring(6);
        //myString10 = myString.Remove(6);
        //Console.WriteLine(myString10);
        //Console.ReadLine();


        //StringBuilder myString11 = new StringBuilder();

        //for (int i = 0; i <100; i++)
        //{
        //    myString11.Append("--");
        //    myString11.Append(i);

        //}
        //Console.WriteLine(myString11);
        //Console.ReadLine();


















        //******************************** Working with strings ********************************************
        //******************************** Working with strings ********************************************
        //******************************** Working with strings ********************************************
        //******************************** Working with strings ********************************************
        //******************************** Working with strings ********************************************



        //DateTime myValue = DateTime.Now;
        //Console.WriteLine(myValue.ToString());//Will take the country and location and present dates in times as they are presented in our date and our culture.
        //Console.WriteLine(myValue.ToShortDateString());
        //Console.WriteLine(myValue.ToShortTimeString());
        //Console.WriteLine(myValue.ToLongDateString());
        //Console.WriteLine(myValue.ToLongTimeString());
        //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
        //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
        //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

        //DateTime myBirthday = new DateTime(1993, 12, 7);
        //Console.WriteLine("This is my birthday "+ myBirthday);


        //TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
        //Console.WriteLine(myAge);
        //Console.ReadLine ();























        //******************************** UNDERSTANDING CLASSES ********************************************
        //******************************** UNDERSTANDING CLASSES ********************************************
        //******************************** UNDERSTANDING CLASSES ********************************************
        //******************************** UNDERSTANDING CLASSES ********************************************
        //******************************** UNDERSTANDING CLASSES ********************************************




        //Object orientated programming
        // Calling methods that are inside classes.
        // 



        //Creating application for selling cars
        //need to create number of variables to hold information 
        //use the information base on make, models.



        //This is not the right approach becuase you will have multiple cars that will have thier own things. 

        //string car1Make;
        //string car1Model;
        //int car1Year;
        //string car1Color;


        //Define 4 properties. 


        //Declaring the class


        // Car is calling the class car
        // myCar is setting the name that will be used in the main class when calling it. 
        // new is creating a new instance of that class. Put this up in the memory
        // Car() this creating the new instance of the car. So basiaclly taking all the information
        // so the main class can use it (or any class that would like to call it)
        Car myCar = new Car();
        myCar.Make = "oldsmobile";
        myCar.Model = "Cutlas Supreme";
        myCar.Year = 1986;
        myCar.Color = "Silver";
        //you set the new instance of the Car class then assigned the variables in your 
        //Car class and assigned them in the Main class.

        Console.WriteLine("{0} {1} {2} {3}", 
            myCar.Year, 
            myCar.Make, 
            myCar.Model, 
            myCar.Color);
        Console.ReadLine();


        //decimal value = DetermineMarketValue(myCar);
        //Console.WriteLine("{0:C}", value);

        Console.WriteLine("{0:C",myCar.DetermineMarketValue());
        Console.ReadLine();



       
    }

    private static decimal DetermineMarketValue (Car car)//We are setting up a method that will have the Class car as the parameters being entered. 
    //the car is the variable name
    {
        decimal carValue = 100.00m;

        //Someday I might look up the car 
        //online using a webservice to get accurate value.
        return carValue;
    }

}

//define a new class
//Create a bucket that will hold information that will hold any given car in the lot. 
//All the values should be in the bucket "class" 
//This is defining the class itself - this is the definition. 

//Object will create based on having the class in this case the Car class.  
class Car
{
    public string Make { get; set; } //declaring a property
    public string Model { get; set; }//declaring a property
    public int Year { get; set; }//declaring a property
    public string Color { get; set; }//declaring a property

    public decimal DetermineMarketValue()
    {
        decimal carValue;
        if (Year > 1990)
        {
            carValue = 10000;
        }
        else
        {
            carValue = 2000;

        }

        return carValue;
    }
}


