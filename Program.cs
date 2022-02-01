namespace CConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Hello World!");
        int userInt = 0;

        while (userInt != 7)
        {

            Console.WriteLine("Enter a number to make a selection: \n 1.) Greet by name \n 2.) Calculate area of rectangle \n 3.) Calculate MPG \n 4.) String search \n 5.)Close application");

            
            string userInp = Console.ReadLine();
            userInt = Convert.ToInt32(userInp);

        if (userInt ==1)
        {
            Console.WriteLine("What is your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, "+userName);
            Console.WriteLine(" ");
        }

        if (userInt ==2)
        {
            Console.WriteLine("Enter Side 1 Length: ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Side 2 Length: ");
            int side2 = Convert.ToInt32(Console.ReadLine());
            int area = side1 * side2;
            Console.WriteLine("Total area is : "+area);
        }

        if (userInt ==3)
        {
            Console.WriteLine("How many miles did you drive? ");
            int milesDr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many gallons used? ");
            int gallonsUsed = Convert.ToInt32(Console.ReadLine());
            float milesPerG = milesDr / gallonsUsed;
            Console.WriteLine("You are getting "+milesPerG+" MPG");
            Console.WriteLine(" "); //empty space to separate from menu
        }


        if (userInt == 5)
        {
        Environment.Exit(0);
        }
        }



        }
    }
}