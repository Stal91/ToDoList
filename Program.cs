
List<string> toDoList = new List<string>();

while (true)
{
    if (toDoList.Count > 0)
    {
        Console.WriteLine("To-do List:");

        for (int i = 0; i < toDoList.Count; i++)
        {
            Console.WriteLine("- " + toDoList[i]);
        }
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("You currently have no tasks in your To-do list.");
        Console.WriteLine("");
    }

    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Delete Task");
    Console.WriteLine("3. Exit");
    int res = int.Parse(Console.ReadLine());

    if (res == (int)UserChoice.addTask)
    {
        Console.WriteLine("addTask: ");
        string task = Console.ReadLine();
        toDoList.Add(task);
        Console.Clear();
        Console.WriteLine("Task add successfully");
    }
    else if (res == (int)UserChoice.DeleteTask)
    {
        if (toDoList.Count > 0)
        {
            Console.WriteLine("Enter the number of the task you want to delete:");

            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine("(" + (i + 1) + ") " + toDoList[i]);
            }

            int taskNum = int.Parse(Console.ReadLine());
            taskNum--;

            if (taskNum >= 0 && taskNum < toDoList.Count)
            {
                toDoList.RemoveAt(taskNum);

                Console.Clear();
                Console.WriteLine("Task deleted successfully");
                Console.WriteLine("");
            }
        }
    }

    else if (res == (int)UserChoice.Exit)
    {
        Console.WriteLine("Exiting the program.");
        System.Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Exiting the program.");
    }


}

enum UserChoice
{
    addTask = 1,
    DeleteTask,
    Exit
}


