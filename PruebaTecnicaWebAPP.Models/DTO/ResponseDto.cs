using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaWebAPP.Models.DTO
{
    public class ResponseDto<T>
    {
        public byte? Success { get; set; }
        public T? Data { get; set; }
        public Error? Error { get; set; }


    }
    public class Error
    {
        public string? Message { get; set; }
    }
}
