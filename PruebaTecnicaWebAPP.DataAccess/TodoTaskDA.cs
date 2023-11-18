using PruebaTecnicaWebAPP.Interfaces;
using PruebaTecnicaWebAPP.Models;
using PruebaTecnicaWebAPP.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PruebaTecnicaWebAPP.DataAccess.Service;
using PruebaTecnicaWebAPP.DataAccess;
using System.Reflection;

namespace PruebaTecnicaWebAPP.DataAccess
{
    public class TodoTaskDA : ITodoTask
    {
        public async Task<ResponseDto<TodoTask>> Create(TodoTask model)
        {
            ResponseDto<TodoTask> response = new ResponseDto<TodoTask>();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(Connection.API());
                var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                var result = await client.PostAsync("TodoTasks", content);
                var json = await result.Content.ReadAsStringAsync();

                if (RequestValidation.Validate(result.StatusCode))
                {
                    var presponse = JsonConvert.DeserializeObject<TodoTask>(json)!;
                    response.Success = 1;
                    response.Data = presponse;
                }
                else
                {
                    response.Success = 0;
                    response.Error = new Error() { Message = json };
                }

            }
            catch (Exception Ex)
            {
                response.Success = 0;
                response.Error = new Error() { Message = Ex.Message };
            }

            return response;
        }
        public async Task<ResponseDto<List<TodoTask>>> Get()
        {
            ResponseDto<List<TodoTask>> response = new ResponseDto<List<TodoTask>>();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(Connection.API());
                var result = await client.GetAsync("TodoTasks");
                var json = await result.Content.ReadAsStringAsync();
                response.Data = JsonConvert.DeserializeObject<List<TodoTask>>(json)!;
                response.Success = 1;
            }
            catch (Exception Ex)
            {
                response.Success = 0;
                response.Error = new Error() { Message = Ex.Message };
            }
            return response;
        }

        public async Task<ResponseDto<TodoTask>> Edit(TodoTask model)
        {
            ResponseDto<TodoTask> response = new ResponseDto<TodoTask>();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(Connection.API());
                //client.DefaultRequestHeaders.Add("x-access-token", model.token);
                var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
                var result = await client.PutAsync("TodoTasks/" + model.Id, content);
                var json = await result.Content.ReadAsStringAsync();
                var presponse = JsonConvert.DeserializeObject<ResponseDto<TodoTask>>(json)!;
                response.Success = 1;


            }
            catch (Exception Ex)
            {
                response.Success = 0;
                response.Error = new Error() { Message = Ex.Message };
            }

            return response;
        }

        public async Task<ResponseDto<TodoTask>> Delete(TodoTask model)
        {
            ResponseDto<TodoTask> response = new ResponseDto<TodoTask>();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(Connection.API());
                //client.DefaultRequestHeaders.Add("x-access-token", model.token);
                var result = await client.DeleteAsync("TodoTasks/" + model.Id);
                var json = await result.Content.ReadAsStringAsync();

                if (RequestValidation.Validate(result.StatusCode))
                {
                    var presponse = JsonConvert.DeserializeObject<TodoTask>(json)!;
                    response.Success = 1;
                    response.Data = presponse;
                }
                else
                {
                    response.Success = 0;
                    response.Error = new Error() { Message = json };
                }
            }
            catch (Exception Ex)
            {
                response.Success = 0;
                response.Error = new Error() { Message = Ex.Message };
            }

            return response;
        }
        public async Task<ResponseDto<TodoTask>> GetById(TodoTask model)
        {
            ResponseDto<TodoTask> response = new ResponseDto<TodoTask>();
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(Connection.API());
                var result = await client.GetAsync("TodoTasks/" + model.Id);
                var json = await result.Content.ReadAsStringAsync();

                if (RequestValidation.Validate(result.StatusCode))
                {
                    var presponse = JsonConvert.DeserializeObject<TodoTask>(json)!;
                    response.Success = 1;
                    response.Data = presponse;
                }
                else
                {
                    response.Success = 0;
                    response.Error = new Error() { Message = json };
                }

            }
            catch (Exception Ex)
            {
                response.Success = 0;
                response.Error = new Error() { Message = Ex.Message };
            }

            return response;
        }

    }
}

