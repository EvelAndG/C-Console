namespace CConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.WriteLine("Hello World!");
        int userInt = 1;

        while (userInt != 7)
        {

            Console.WriteLine("Menu here: ");

            Console.WriteLine("Make a selection: ");
            string userInp = Console.ReadLine();
            userInt = Convert.ToInt32(userInp);

        if (userInt ==1)
        {
            Console.WriteLine("Yep, it's One");
        }
        }



        }
    }
}