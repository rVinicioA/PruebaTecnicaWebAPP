using PruebaTecnicaWebAPP.Models;
using PruebaTecnicaWebAPP.Models.DTO;
namespace PruebaTecnicaWebAPP.Interfaces
{
    public interface ITodoTask
    {

        Task<ResponseDto<TodoTask>> Create(TodoTask model);
        Task<ResponseDto<List<TodoTask>>> Get();
        Task<ResponseDto<TodoTask>> Edit(TodoTask model);
        Task<ResponseDto<TodoTask>> Delete(TodoTask model);
        Task<ResponseDto<TodoTask>> GetById(TodoTask model);
    }
}