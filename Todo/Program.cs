using Spectre.Console;
class Todo
{
    public static void Main(string[] args)
    {
        Console.SetWindowSize(50, 20);

        List<string> Todo = new List<string>() { "code", "test", "refactor" };
        bool inUse = true;

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
                    AnsiConsole.MarkupLine("[red] That is not a valid input value! [/]");
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
            AnsiConsole.MarkupLine("[yellow]-----[/] Current Todos [yellow]-----[/]");
            for (int i = 0; i < Todo.Count; i++)
            {
                Console.WriteLine(" - " + Todo[i]);
            }
        }
        else 
        {
            AnsiConsole.MarkupLine("[yellow] You Currently Have No Todos [/]");
        }
        Console.WriteLine("");
    }

    static void AddTodo(List<string> Todo)
    {
        ViewTodos(Todo);
        bool inUse = true;

        while (inUse)
        {
            AnsiConsole.MarkupLine("[yellow]-----[/] Add Todo [yellow]-----[/]");
            string todo = Console.ReadLine().ToLower();

            if (Todo.Contains(todo)) // checks if todo exist in list
            {
                Console.WriteLine("");
                AnsiConsole.MarkupLine("[red] {0} has already been added! [/]", todo);
                Console.WriteLine("");
            }
            else if (string.IsNullOrEmpty(todo))
            {
                Console.WriteLine("");
                AnsiConsole.MarkupLine("[red] Value Cannot be empty! [/]");
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
        bool inUse = true;

        Console.Clear();
        AnsiConsole.MarkupLine("[yellow]-----[/] Remove Todo [yellow]-----[/]");
        
        while (inUse) 
        {
            if (checkTodos(Todo))
            {
                for (int i = 0; i < Todo.Count; i++)
                {
                    Console.WriteLine("{0} - {1}", i, Todo[i]);
                }

                Console.WriteLine("Select a todo to delete: ");

                string removeInput = Console.ReadLine();
                int index;
                bool convertedSuccess = int.TryParse(removeInput, out index);

                if (convertedSuccess)
                {
                    try
                    {
                        Todo.Contains(index.ToString());
                        AnsiConsole.MarkupLine("[green]{0} was deleted from the list![/]", Todo[index]);
                        Todo.RemoveAt(index);
                        Console.WriteLine("");
                        inUse = false;
                    }
                    catch(ArgumentOutOfRangeException ex) 
                    {
                        Console.Clear();
                        AnsiConsole.MarkupLine("[red] That is out of range! [/]");
                    }
                }
                else
                {
                    Console.Clear();
                    AnsiConsole.MarkupLine("[red] That is not a valid input! [/]");
                }
            }
            else
            {
                AnsiConsole.MarkupLine("[yellow]There are currently no todos[/]");
                break;
            }
        }
    }
}