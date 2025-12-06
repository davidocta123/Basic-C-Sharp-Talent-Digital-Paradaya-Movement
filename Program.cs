// using System;
// using System.Collections.Generic;

// public class TaskItem
// {
//     public int Id { get; set; }
//     public string Title { get; set; }
//     public bool IsCompleted { get; set; }

//     public void MarkComplete() => IsCompleted = true;
// }

// class Program
// {
//     static void Main()
//     {
//         try
//         {
//             Run();
//         }
//         catch (Exception ex)
//         {
            
//             Console.WriteLine($"Terjadi error: {ex.Message}");
//         }
//     }

//     public void Run()
// {
//     List<TaskItem> tasks = new List<TaskItem>();
//         int id = 1;
//         bool running = true;

//         while (running)
//         {
//             Console.WriteLine("\n1. Add | 2. List | 3. Complete | 4. Exit");
//             Console.Write("Choose: ");
//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     Console.Write("Title: ");
//                     string title = Console.ReadLine();
//                     tasks.Add(new TaskItem { Id = id++, Title = title });
//                     break;

//                 case "2":
//                     foreach (var t in tasks)
//                         Console.WriteLine($"{t.Id}. {t.Title} - {(t.IsCompleted ? "Done" : "Pending")}");
//                     break;

//                 case "3":
//                     Console.Write("Enter ID: ");
//                     int markId = int.Parse(Console.ReadLine());
//                     var task = tasks.Find(t => t.Id == markId);
//                     if (task != null)
//                     {
//                         task.MarkComplete();
//                         Console.WriteLine("Task completed!");
//                     }
//                     else
//                     {
//                         Console.WriteLine("ID tidak ditemukan!");
//                     }
//                     break;

//                 case "4":
//                     running = false;
//                     break;

//                 default:
//                     Console.WriteLine("Pilihan tidak valid!");
//                     break;
//             }
//         }
// }
// }

using System;
using System.Collections.Generic;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public void MarkComplete() => IsCompleted = true;
}

class Program
{
    static void Main()
    {
        List<TaskItem> tasks = new List<TaskItem>();
        int id = 1;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Add | 2. List | 3. Complete | 4. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Title: ");
                    string title = Console.ReadLine();
                    tasks.Add(new TaskItem { Id = id++, Title = title });
                    break;

                case "2":
                    foreach (var t in tasks)
                        Console.WriteLine($"{t.Id}. {t.Title} - {(t.IsCompleted ? "Done" : "Pending")}");
                    break;

                case "3":
                    Console.Write("Enter ID: ");
                    int markId = int.Parse(Console.ReadLine());
                    var task = tasks.Find(t => t.Id == markId);
                    if (task != null)
                    {
                        task.MarkComplete();
                        Console.WriteLine("Task completed!");
                    }
                    else
                    {
                        Console.WriteLine("ID tidak ditemukan!");
                    }
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid!");
                    break;
            }
        }
    }
}
