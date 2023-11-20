class Todo
{
    public static void Main(string[] args)
    {
        bool inUse = true;
        List<string> Todo = new List<string>() { "Clean House", "Feed Dog", "Code" };

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
                    ViewTodos(Todo);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("// Add Todo //");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("// Remove Todo //");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    inUse = false;
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("That is not a valid input value!");
                    Console.WriteLine("");
                    break;
            }
        }
    }

    static void ViewTodos(List<string> Todo)
    {
        Console.Clear();
        Console.WriteLine("// Current Todos //");
        for (int i = 0; i < Todo.Count; i++)
        {
            Console.WriteLine(" - " +Todo[i]);
        }
        Console.WriteLine();
    }
}