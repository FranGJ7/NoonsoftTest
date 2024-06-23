namespace TaskManager
{
    public record Task
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public bool? Done {get; set;}
    }

    public class TaskRepository
    {
        private static List<Task> _tasks = new List<Task>()
        {
            new Task { Id = 1, Name = "Refeição proteica", Done = false },
            new Task { Id = 2, Name = "Treino com peso", Done = true},
            new Task { Id = 3, Name = "Reunião com equipe de desenvolvimento", Done = false }
        };

        public static List<Task> GetAllTasks()
        {
            return _tasks;
        }

        public static Task? GetTaskById(int id)
        {
            return _tasks.SingleOrDefault(task => task.Id == id);
        }

        public static Task AddTask(Task task)
        {
            _tasks.Add(task);
            return task;
            
        }

        public static Task UpdateTask(Task updatedTask)
        {
            _tasks = _tasks.Select(task =>
            {
                if (task.Id == updatedTask.Id)
                {
                    task.Name = updatedTask.Name;
                    task.Done = updatedTask.Done;
                }
                 return task;

                
            }).ToList();
            return updatedTask;
        }


        public static void RemoveTask(int id)
        {
            _tasks = _tasks.Where(task => task.Id != id).ToList();
        }
    }
}
