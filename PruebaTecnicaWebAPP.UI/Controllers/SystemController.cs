using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaWebAPP.Models;
using PruebaTecnicaWebAPP.Models.DTO;
using PruebaTecnicaWebAPP.Interfaces;
using PruebaTecnicaWebAPP.BussinesLogic;

namespace PruebaTecnicaWebAPP.Controllers
{
    public class SystemController : Controller
    {
        private readonly ITodoTask _todoTask;
        private readonly ILogger<SystemController> _logger;

        public SystemController(ITodoTask todoTask, ILogger<SystemController> logger)
        {
            _todoTask = todoTask;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            ResponseDto<List<TodoTask>> Response = await _todoTask.Get();
            return View(Response.Data);
        }
        // GET: SystemController/TodoTask
        [HttpGet]
        public async Task<IActionResult> TodoTask()
        {
            ResponseDto<List<TodoTask>> Response = await _todoTask.Get();
            return View(Response.Data);

        }

        // POST: SystemController/Create
        [HttpPost]
        public async Task<JsonResult> Create(TodoTask data)
        {
            var ResponseDTO = new ResponseDto<TodoTask>();
            var TodoTaskBL = new TodoTaskBL();
            ResponseDTO = await TodoTaskBL.Create(data);

            return Json(new { data = ResponseDTO });
        }

        // GET: SystemController/GetById
        public async Task<JsonResult> GetById(TodoTask data)
        {
            var ResponseDTO = new ResponseDto<TodoTask>();
            var TodoTaskBL = new TodoTaskBL();
            ResponseDTO = await TodoTaskBL.GetById(data);


            return Json(new { data = ResponseDTO });
        }

        // POST: SystemController/Edit
        [HttpPost]
        public async Task<JsonResult> Edit(TodoTask data)
        {
            var ResponseDTO = new ResponseDto<TodoTask>();
            var TodoTaskBL = new TodoTaskBL();
            ResponseDTO = await TodoTaskBL.Edit(data);

            return Json(new { data = ResponseDTO });
        }


        // POST: SystemController/Delete
        [HttpPost]
        public async Task<JsonResult> Delete(TodoTask data)
        {
            var ResponseDTO = new ResponseDto<TodoTask>();
            var TodoTaskBL = new TodoTaskBL();
            ResponseDTO = await TodoTaskBL.Delete(data);

            return Json(new { data = ResponseDTO });
        }
    }
}
