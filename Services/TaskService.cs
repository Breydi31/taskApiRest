using TaskModel = TaskApiRest.Models.Task;

namespace TaskApiRest.Services
{
    public class TaskService : TaskInterface
    {
        private static List<TaskModel> tasks = new();
        private static int currentId = 1;

        public List<TaskModel> GetAllTask() => tasks;

        public TaskModel GetByIdTask(int id) => tasks.FirstOrDefault(t => t.Id == id);

        public void AddTask(TaskModel task)
        {
            task.Id = currentId++;
            tasks.Add(task);
        }

        public void UpdateTask(int id, TaskModel task)
        {
            var existing = GetByIdTask(id);
            if (existing != null)
            {
                existing.Titulo = task.Titulo;
                existing.Descripcion = task.Descripcion;
                existing.Estado = task.Estado;
            }
        }

        public void DeleteTask(int id)
        {
            var task = GetByIdTask(id);
            if (task != null)
            {
                tasks.Remove(task);
            }
        }
    }
}