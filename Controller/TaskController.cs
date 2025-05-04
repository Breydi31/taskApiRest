using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskModel = TaskApiRest.Models.Task;
using TaskApiRest.Models;
using TaskApiRest.Data;

namespace TaskApiRest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _context;

        public TaskController(TaskContext context)
        {
            _context = context;
        }

        // Listar tareas
        [HttpGet]
        public async Task<ActionResult<ApiResponseModel<IEnumerable<TaskModel>>>> GetTasks()
        {
            var tasks = await _context.Tasks.ToListAsync();
            return new ApiResponseModel<IEnumerable<TaskModel>>(tasks, "Tareas listadas correctamente", 200);
        }

        // Listar tareas por id
        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponseModel<TaskModel>>> GetTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound(new ApiResponseModel<TaskModel>(null, "Tarea no encontrada", 404));
            }

            return new ApiResponseModel<TaskModel>(task, "Tarea listada correctamente", 200);
        }

        // Crear una tarea
        [HttpPost]
        public async Task<ActionResult<ApiResponseModel<TaskModel>>> CreateTask(TaskModel task)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponseModel<TaskModel>(null, "Datos inválidos", 400));
            }

            _context.Tasks.Add(task);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTask), new { id = task.Id },
                new ApiResponseModel<TaskModel>(task, "Tarea creada exitosamente", 201));
        }

        // Actualizar una tarea
        [HttpPut("{id}")]
        public async Task<ActionResult<ApiResponseModel<TaskModel>>> UpdateTask(int id, TaskModel task)
        {   
            if (!ModelState.IsValid)
            {
                return BadRequest(new ApiResponseModel<TaskModel>(null, "Datos inválidos", 400));
            }

            var existingTask = await _context.Tasks.FindAsync(id);
            if (existingTask == null)
            {
                return NotFound(new ApiResponseModel<TaskModel>(null, "Tarea no encontrada", 404));
            }

            existingTask.Titulo = task.Titulo;
            existingTask.Descripcion = task.Descripcion;
            existingTask.Estado = task.Estado;

            await _context.SaveChangesAsync();

            return Ok(new ApiResponseModel<TaskModel>(existingTask, "Tarea actualizada correctamente", 200));
        }

        // Eliminar tarea
        [HttpDelete("{id}")]
        public async Task<ActionResult<ApiResponseModel<string>>> DeleteTask(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                return NotFound(new ApiResponseModel<string>(null, "Tarea no encontrada", 404));
            }

            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();

            return new ApiResponseModel<string>(null, "Tarea eliminada correctamente", 200);
        }
    }
}
