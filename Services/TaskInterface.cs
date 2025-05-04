using TaskModel = TaskApiRest.Models.Task;

namespace TaskApiRest.Services
{
    public interface TaskInterface
    {
        List<TaskModel> GetAllTask();
        TaskModel GetByIdTask(int id);
        void AddTask(TaskModel task);
        void UpdateTask(int id, TaskModel task);
        void DeleteTask(int id);
    }
}