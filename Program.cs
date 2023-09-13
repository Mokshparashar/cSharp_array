using System;

namespace myArrayNamespace { 
    class myArrayClass
    {
        
        static void Main(string[] args)
        {
            int[] numbers = new int[4];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            int  myNumber = 56;
            int  secondNumber = 67;

            Console.WriteLine("My 4rth element is :{0}", numbers[3]);

            //Console.WriteLine($"my number is {myNumber}");
            Console.WriteLine("Change your 4th number");
            string userInput =  Console.ReadLine();

            int stringNumber = int.Parse(userInput);

            numbers[3] = stringNumber;
            Console.WriteLine("Now my new 4rth number is :{0}",numbers[3]);

           ConsoleKeyInfo newInfo =  Console.ReadKey();
           

            if(newInfo.Key == ConsoleKey.NumPad5)
            {
                numbers[3] = 5;
                Console.WriteLine("Now my new 4rth number is :{0}", numbers[3]);
            }

            else
            {
                Console.WriteLine(" please enter valid number");
            }




        }
    }
}