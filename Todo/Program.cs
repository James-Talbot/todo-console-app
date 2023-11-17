class Todo
{
    public static void Main(string[] args)
    {
        bool inUse = true;
        List<string> Todo = new List<string>() { "Clean House", "Feed Dog", "Code"};

        while (inUse)
        {
            Console.WriteLine("1. View Todos");
            Console.WriteLine("2. Add Todo");
            Console.WriteLine("3. Remove Todo");
            Console.WriteLine("4. Exit App");

            Console.WriteLine("Please Enter a Value");

            string inputString = Console.ReadLine();
            int inputInt;
            int.TryParse(inputString, out inputInt);

            switch (inputInt)
            {
                case 1:
                    Console.WriteLine("View Todos");
                    break;
                case 2:
                    Console.WriteLine("Add Todo");
                    break;
                case 3:
                    Console.WriteLine("Remove Todo");
                    break;
                case 4:
                    Console.WriteLine("Exit App");
                    inUse = false;
                    break;
                default:
                    Console.WriteLine("That is not a valid number");
                    break;
            }
        }
    }
}