namespace Assignment_3
{
    internal class Program
    {
        private static List<Task> tasks = new List<Task>();
        private static int nextId = 1;
        static void Main()
        {
            


        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose your action");
            Console.WriteLine("press 1 to Add Task");
            Console.WriteLine("press 2 to View Task");
            Console.WriteLine("press 3 to Update Task");
            Console.WriteLine("press 4 to Delete Task");
            Console.WriteLine("press 5 to exit Application");

        }
        static void AddTask()
        {
            Console.WriteLine("Enter Task Description:");
            string description = Console.ReadLine();
            var task = new Task();
            {
                task.Id = nextId++;
                task.Description = description;
                task.IsCompleted = false;
            }
            tasks.Add(task);
            Console.WriteLine("Task Added Succesfully");
        }
        static void ViewTask()
        {
            Console.WriteLine("the tasks is");
            foreach (var task in tasks)
            {
                Console.WriteLine("the task id is :{0} and task description is : {1} and task completed is : {2}", task.Id, task.Description, task.IsCompleted);
            }
        }
        static void UpdateTask()
        {
            Console.WriteLine("Enter the id to update");
            int idupdate = Convert.ToInt32(Console.ReadLine());
            var task = tasks.SingleOrDefault(t => t.Id == idupdate);
            if (task != null)
            {
                Console.WriteLine("Enter new description");
                string newdescription = Console.ReadLine();
                task.Description = newdescription;
                Console.WriteLine("is the task completed y/n");
                var iscompletedupdate = Console.ReadLine();
                if (iscompletedupdate.ToLower() == "y")
                {
                    task.IsCompleted = true;
                }
                else

                {
                    task.IsCompleted = false;
                }
                Console.WriteLine("Task updated sucdcesfully");


            }
            else
            {
                Console.WriteLine("Task not found");
            }
            }
    } }

