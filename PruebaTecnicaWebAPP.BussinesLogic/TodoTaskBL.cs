using PruebaTecnicaWebAPP.Models.DTO;
using PruebaTecnicaWebAPP.Interfaces;
using PruebaTecnicaWebAPP.Models;
using PruebaTecnicaWebAPP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaWebAPP.BussinesLogic
{
    public class TodoTaskBL : ITodoTask
    {
        public async Task<ResponseDto<TodoTask>> Create(TodoTask model)
        {
            TodoTaskDA TodoTaskDA = new TodoTaskDA();
            return await TodoTaskDA.Create(model);
        }
        public async Task<ResponseDto<List<TodoTask>>> Get()
        {
            TodoTaskDA TodoTaskDA = new TodoTaskDA();
            return await TodoTaskDA.Get();
        }
        public async Task<ResponseDto<TodoTask>> Edit(TodoTask model)
        {
            TodoTaskDA TodoTaskDA = new TodoTaskDA();
            return await TodoTaskDA.Edit(model);

        }
        public async Task<ResponseDto<TodoTask>> Delete(TodoTask model)
        {
            TodoTaskDA TodoTaskDA = new TodoTaskDA();
            return await TodoTaskDA.Delete(model);
        }
        public async Task<ResponseDto<TodoTask>> GetById(TodoTask model)
        {
            ResponseDto<TodoTask> response = new ResponseDto<TodoTask>();

            TodoTaskDA TodoTaskDA = new TodoTaskDA();
            response = await TodoTaskDA.GetById(model);

            return response;
        }
    }
}
