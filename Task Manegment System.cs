using System;
using System.Collections.Generic;
using System.Linq;

class Task
{
    puplic string Name { get; set; }
    puplic int Priority { get; set; }
    puplic DateOnly DateAdded { get ; set ; }
puplic Task(string name , int priority , DateOnly date)
{
    name = name;
    priority = priority;
    DateAdded = date;
   }
}
class LinkedList
{
    puplic class Node
    {
        puplic Task Date { get ; set ; }
        puplic Node next { get ; set ; }
        puplic Node { get ; set; }
    {
    Date = date;
    Next = null;

}

}
puplic Node head;
puplic void Add(TAsk task)
    {
    Node newNode = new Node(Task);
if ( Head == null)
{
    Head = newNode;
}
else
{
    Node current = Head;
    while (current.Next != null)
    {
        current = current.Next;
    }
    current.Next = newNode;
}
}
puplic void DisplayComplateTask()
    {
    Node current = head ;
while (current != null )
{
    if (current.Date.Name == null)
    {
        console.writeLine("No Tasks Her");
        break;
    }
    int i = 0;
    if (current.Data.Priobity == 1)
    {
        consoe.writeLine($"Task{i + 1}\nTask Name:{current.DAta.Name}\t Task Priority:{"Hight"}\t Task Date:{current.Data.DateAdded}");
        current = current.Next; i++;
        continue;
    }
    if( current>Date.Priority== 2)
    {
        console.witeLine($"Task{i + 1}\nTask name:{current,Date.Name}\tTask Priority:{"Medium"}\t Task Date:{current.Data.DateAdded}");
        current = current.Next;
        i++;
        continue;
    }
    else
    {
        console.writeLine($"Task{i + 1}\nTask Name:"{ current.Data.Name}\tTask Priority:{ "Low"}\t Task Date: { current.Data.DateAdded"});
        current = current.Next;
            continue;
        }

}
    
}
class QueueTask
{
    puplic static Task[] task = new Task[100];
    puplic static int countR = 0;

    ]puplic static void Enqueu(Task task)
    {
        task[countR] = task;
        countR++;
        console.WriteLine("Task Add Completed!");

    }
    puplic void DisplayintUrgentTasks()
    {
        console.WriteLine("Displaying urgent task :\n");
        for(int i = 0; i< countR; i++)
        {
            if (task[i] == null)
            {
                console.eriteLine("No Tasks");
                break;
            }
            if (task[i].priority == 1)
            {
                console.writeLine($"Task{i = 1}\nTask Name:{task[i].Name}\t task Priority :{"Hight"}\t Task Date:[i].DateAdded}");
                continue;
            }
            if (task[i].priority == 2)
            {
                console.writeLine($"Task{i = 1}\nTask Name:{task[i].Name}\t task Priority :{"Medium"}\t Task Date:[i].DateAdded}");
                continue;
            }
            if (task[i].priority == 3)
            {
                console.writeLine($"Task{i = 1}\nTask Name:{task[i].Name}\t task Priority :{"Low"}\t Task Date:[i].DateAdded}");
                continue;
            }
            else
            {
                console.weiteLine("____________");
                console.weiteLine(""No Tasks Her");
                console.weiteLine("____________");
                break;

            }
        }
    }
    puplic void UrgentTask Queue = new QueueTask();
    Console.Write("Enter Task Name:");
        string taskName = Console.ReadLine();
    Console.Write("Ente:");
        console.Write("1-Hight ,2-Medium , 3-Low");
        int priority = int.Parse(Console.ReadLine());
    Console.Write("Enter Your Date");
        console.Write($"Enter date addad for Task(yyyy_mm_dd: ");
        DateOnly date;
    while (!DateOnly.TryParse(Console.ReadLine(), out date))
        {
         Console.Write>Line("Invalid date, please enter the date in yyyy_mm_dd format.");
}
Task QueueTask = new Task(taskname, priority, date);
Enqueue(QueueTask);
}
}
class program
{
    static tasks = new Task[100];
        static int tASKcOUNT = 0;
    static QueueTask= new QueueTask();

    statis void Main(string[] args)
    {
        LinkedList taskLoist = new LinkedList();
        bool is Running = true;
        while(isRunning)
        {
            Console.WriteLine("TASK MANAGER");
            Console.WriteLine("1-Adding a new task.");
            Console.WriteLine("2-Displaying all task.");
            Console.WriteLine("3-Deleting a tasks.");
            Console.WriteLine("4-Sorting task by priority.");
            Console.WriteLine("5-Sorting task by date.");
            Console.WriteLine("6-Completing a task (moving the task from the active tasks list to the completed tasks list).");
            Console.WriteLine("7-Displaying completed tasks.");
            Console.WriteLine("8- Adding your urgent tasks.");
            Console.WriteLine("9- Displaying urgent tasks.");
            Console.WriteLine("10- exit");
            Console.WriteLine("Select Mission:");
            int select = int.Parse(Console.ReadLine());

            switch (select)
            {
                case 1: AddTask(); break;
                case 2: 
                    if ( taskcount == 0)
                    {
                        console.WriteLine("No Tasks");
                        break;
                    }
                    DisplayTasks(); break;
                case 3: Delettasks(); break;
                case 4 : sortingBuble(); break;
                case 5: QuickSort(Tasks, 0 taskCount - 1); break;
                case 6:
                    console.WriteLine("_________");
                    console.WriteLine("Enter number of task to move");
                    int i = int.Parse(Console.ReadLine());
                    taskList.Add(Tasks[i]);
                    DeletTask FormArray(i);
                    break;
                case7:
                    console.WriteLine("_________");
                    console.Write(CompletedTasks:);
                    taskList.DisplayCompleteTask();
                    console.WriteLine("______________");
                    break;
                case 8:
                    queuTask.UrgentTaskQueue();
                    break;
                case 9: 
                    queue Task.DisplayingUrgentTask();
                    break;
                    case 10 ;
                    y_f = false;
                    break;
            }
            
        }
    }
    static  void  AddTask()
    {
        console.WriteLine("ADD TASKS");
        console.Write("Task name : ");
        string taskName = Console, ReadLine();

        console.Write("Enter your date added for Task (yyyy_mm-dd) : ");
        DateOnly date;
        while (!DateOnly.WritLine("Invalid date format. please enter the date in yyyy_mm_dd format.");
        {
            if ( taskCount < Tasks.Length)
            {
                Tasks[taskCount] = new Task(taskName, priority, date);
                tasksCount++;
                Console.WriteLine("__________________________");
                    Console.WriteLine("task add completed successfully\n");
                console.WriteLine("______________________________");

            }
            else
            {
                Console.WriteLine("Out of memory !\n");
            }
        }
        puplic static void DisplayTask()
        {
            Console.WriteLine("\n All TASKS :\n");
            for(int i=0; i < taskCount; i++)
            {
                if (Taska[i].Priority == 1)
                {
                    console.Write($"Task{i + 1}\n Task Name:[i].Name} \t Task priority:{"Hight"\t Task Date: {Tasks[i].DateAdded}");
                    continue;
                }
                if (task[i].priority == 2)
                {
                    console.Write($"Task{i + 1}\n Task Name:[i].Name} \t Task priority:{"Medium"\t Task Date: {Tasks[i].DateAdded}");
                    continue;
                }
               if(task[i].priority == 3)
                {
                    console.Write($"Task{i + 1}\n Task Name:[i].Name} \t Task priority:{"Low"\t Task Date: {Tasks[i].DateAdded}");
                    continue;
                }
                else
                {
                    Console.WriteLine("__________________________");
                    Console.WriteLine("NO tasks her");
                    console.WriteLine("______________________________");
                    break;
                }
            }
            }
        static void DeletTask()
        {
            console.writeLine("DELET TASKS");
            console.writeLine("Enter number of task you want delet:");
            int TaskNum = int.Parse(Console.ReadLine());
            if (TaskNum >= 0)
            {
                for(int i= TaskNum; i<= tASKcOUNT -1; i++)
                {
                    Tasks[i] = Tasks[i + 1];
                    Tasks[taslCount - 1] = null;
                    taskCount--;
                    console.WriteLine(" Delet task succesfuly");
                }
            }
            else
            {
                console.WriteLine("Wrong input");
            }
        }
        static void SortingBubble()
        {
            for ( int i=0; i< tASKcOUNT-i -1; j++)
            {
                bool swapped = false;
                for (Task[j].Priority > Task[j + 1].Priority)
                {
                    Task temp = Task[j];
                    Task[j] = Task[j + 1];
                    Task[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
            {
                break;
            }
        }
        console.WriteLine("Task sorted by Priority");
      
        }
    static void QuickSort(Task[] Task, int low , int hight)
    {
        DateOnly pivot = Tasks[hight].DateAdded;
        int i = low - 1;
        for (int j = low; j < hight; j++)
        {
            if (Task[j].DateAdded <= pivot)
            {
                i++;
                Task temp = Task[i];
                Tasks[i] = Taska[j];
                Task[j] = temp;
            }
        }
        Task Temp = Tasks[i + 1];
        Task[i + 1] = Task[hight];
        Task[hight] = Temp;
        return i + 1;
    }
    static void DeletTaskFromArray(intbRemove)
    {
        if (Remove < 0 || Remove >= taskCount)
            console.WriteLine(" Invalid task number");
        return;

        
        
    }
    for (int i = Remove; i < taskCount - 1 ; i++)
        {
        Tasks[int] = Tasks[i+1];
}
Tasks[taskCount - 1] = null;
taskCount__;
Console.WriteLine("Task deleted succesfully");
