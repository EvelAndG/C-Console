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
            string sSide1 = Console.ReadLine();
            Console.WriteLine("Enter Side 2 Length: ");
            string sSide2 = Console.ReadLine();
            int iSide1 = Convert.ToInt32(sSide1);
            int iSide2 = Convert.ToInt32(sSide2);
            int area = iSide1 * iSide2;
            Console.WriteLine("Area is : "+area);
        }


        if (userInt == 5)
        {
        Environment.Exit(0);
        }
        }



        }
    }
}