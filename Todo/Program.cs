class Todo
{
    public static void Main(string[] args)
    {
        bool inUse = true;
        List<string> Todo = new List<string>() { "Code", "Test", "Debug" };

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
                    AddTodo(Todo);
                    break;
                case 3:
                    RemoveTodo(Todo);
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

    static bool checkTodos(List<string> Todo)
    {
        if (Todo.Count == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static void ViewTodos(List<string> Todo)
    {
        Console.Clear();

        if (checkTodos(Todo))
        {
            Console.WriteLine("// Current Todos //");
            for (int i = 0; i < Todo.Count; i++)
            {
                Console.WriteLine(" - " + Todo[i]);
            }
        }
        else 
        {
            Console.WriteLine("You Currently Have No Todos");
        }
        Console.WriteLine("");
    }

    static void AddTodo(List<string> Todo)
    {
        ViewTodos(Todo);
        bool inUse = true;

        while (inUse)
        {
            Console.WriteLine("// Add Todo //");
            string todo = Console.ReadLine().ToLower();

            if (Todo.Contains(todo))
            {
                Console.WriteLine("");
                Console.WriteLine("{0} has already been added!", todo);
                Console.WriteLine("");
            }
            else if (string.IsNullOrEmpty(todo))
            {
                Console.WriteLine("");
                Console.WriteLine("Value Cannot be empty!");
            }
            else
            {
                Todo.Add(todo);
                inUse = false;
                Console.Clear();
            }
        }
    }

    static void RemoveTodo(List<string> Todo)
    {
        Console.Clear();
        Console.WriteLine("// Remove Todo //");
        
        for(int i = 0; i < Todo.Count; i++) 
        {
            Console.WriteLine("{0} - {1}",i, Todo[i]);
        }

        Console.WriteLine("Select a todo to delete: ");

        string removeInput = Console.ReadLine();
        int index = int.Parse(removeInput);

        // TODO - eeception handling
        Todo.Contains(index.ToString());
        Console.WriteLine("{0} was deleted from the list!", Todo[index]);
        Todo.RemoveAt(index);
        Console.WriteLine("");
    }
}
