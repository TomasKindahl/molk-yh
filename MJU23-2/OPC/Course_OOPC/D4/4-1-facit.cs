namespace OPC1_övn_4_1
{
    internal class Program
    {
        abstract class TodoItem
        {
            protected int id;
            protected string name, description;
            public TodoItem(int id, string name, string description)
            {
                this.id = id;
                this.name = name;
                this.description = description;
            }
            public override abstract string ToString();
        }
        class Task : TodoItem
        {
            int priority;
            public Task(int id, string name, int priority, string description = "")
                : base(id, name, description)
            {
                this.priority = priority;
            }
            public override string ToString()
            {
                return $"Uppgift: {id}, {name}, prio={priority}";
            }
        }
        class Meeting : TodoItem
        {
            int time;
            string place;
            public Meeting(int id, int day, string name, string description = "", string place = "zoom")
                : base(id, name, description)
            {
                this.time = day;
                this.place = place;
            }
            public override string ToString()
            {
                return $"Möte: id={id}, {name}, day={time}";
            }
            public int getDay() => time;
        }
        static void Main(string[] args)
        {
            List<TodoItem> todo = new List<TodoItem>();
            todo.Add(new Task(id: 1, name: "diska", priority: 3));
            todo.Add(new Meeting(id: 2, name: "veckomöte", day: 5));
            todo.Add(new Meeting(id: 2, name: "fika med Kim", day: 4));
            todo.Add(new Task(id: 1, name: "vattna blommorna", priority: 1));

            for (int today = 0; today < 7; today++)
            {
                Console.WriteLine($"--------------------- Dag: {today} ------------------------");
                bool meetingsToday = listMeetingsToday(todo, today);
                if (!meetingsToday)
                {
                    Console.WriteLine($"Uppgifter idag:");
                    listAllTasks(todo);
                }
            }

        }
        private static void listAllTasks(List<TodoItem> todo)
        {
            foreach (TodoItem item in todo)
            {
                if (item is Task t)
                {
                    Console.WriteLine($"{item}");
                }
            }
        }
        private static bool listMeetingsToday(List<TodoItem> todo, int today)
        {
            bool meetingsToday = false;
            foreach (TodoItem item in todo)
            {
                if (item is Meeting m)
                {
                    if (m.getDay() == today)
                    {
                        meetingsToday = true;
                        Console.WriteLine($"today: {item}");
                    }
                }
            }

            return meetingsToday;
        }
    }
}