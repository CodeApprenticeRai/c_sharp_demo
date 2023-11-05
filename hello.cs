using System;
// using HelloWorld;

namespace HelloWorld {
    class HelloWorld {
        static int ReadInt32FromUserInput(bool prompt=true){
            if (prompt){
                Console.Write("Enter an integer: ");
            }
            int num = Convert.ToInt32( Console.ReadLine() );
            return num;
        }
        static void Main(){
            Console.WriteLine(@"Enter the integer corresponding to 
            the program you would like to run: ");
            int userChoice = HelloWorld.ReadInt32FromUserInput(prompt:false);
            switch (userChoice){
                case 0:
                    HelloWorld.helloWorld();
                    break; 
                case 1:
                    HelloWorld.helloAdd();
                    break;
                default:
                    Console.WriteLine("You must provide a string in the inclusive range 0-1.");
                    break;
            }
        }
        static void helloWorld(){
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        static void helloAdd(){
            Console.Write("Enter an integer: ");
            int num1 = HelloWorld.ReadInt32FromUserInput(prompt:false);

            Console.Write("Enter a second integer: ");
            int num2 = HelloWorld.ReadInt32FromUserInput(prompt:false);
            int resultOutput = String.Format(
                "The sum of the two integers is: {0}",
                num1 + num2
            ); 
            Console.WriteLine(resultOutput);
        }
    }
}