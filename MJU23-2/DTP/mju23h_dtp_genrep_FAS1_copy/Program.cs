namespace mju23h_dtp_genrep_FAS1
{
    internal class Program
    {
        static List<Todo> todolist;
        class Todo
        {
            static public int waiting = 0, active = 1, done = 2, deleted = 3;
            DateTime start;
            string description;
            int status;
            public Todo(string description)
            {
                start = DateTime.Now;
                this.description = description;
                status = waiting;
            }
            public string Status()
            {
                if (status == 0) return "waiting";
                else if (status == 1) return "active";
                else if (status == 2) return "done";
                else if (status == 3) return "deleted";
                else return "(invalid status)";
            }
            public void Print()
            {
                Console.WriteLine($"{start,-24} {Status(),-9} {description,-40}");
            }
        }
        static void Main(string[] args)
        {
            todolist = new List<Todo>();
            todolist.Add(new Todo("vattna blommorna"));
            todolist.Add(new Todo("tvätta bilen"));
            todolist.Add(new Todo("koka soppa"));

            string command;
            do
            {
                Console.Write("command: ");
                command = Console.ReadLine();
                //  6. ... continue here ...
                if (command == "quit")
                {
                    break;
                }
                else if (command == "list")
                {
                    foreach (Todo task in todolist)
                    {
                        if (task.Status() == "waiting" || task.Status() == "active")
                            task.Print();
                    }
                }
                else if (command == "list all")
                {
                    foreach (Todo task in todolist)
                    {
                        task.Print();
                    }
                }
                else if (command == "new")
                {
                    Console.Write("add a description: ");
                    string descr = Console.ReadLine();
                    Todo newTask = new Todo(descr);
                    todolist.Add(newTask);
                }
                else
                {
                    Console.WriteLine($"Unknown command: '{command}'");
                }
            } while (command != "quit");
            Console.WriteLine("Bye!");
        }
    }
}