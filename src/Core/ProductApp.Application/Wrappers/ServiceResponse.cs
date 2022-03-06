using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class ServiceResponse<T>:BaseResponse
    {
        public T Value { get; set; }
        public bool ISuccess { get; set; }
        public string Message { get; set; }
        public ServiceResponse(T value)
        {
            Value = value;
        }
        public ServiceResponse(T value,bool Success,string message):base(Success,message)
        {
            Value = value;
            ISuccess = Success;
            Message = message;
        }
        public ServiceResponse(T value,string message) : base(message)
        {
            Value = value;
            ISuccess = Success;
            Message = message;
        }
        public ServiceResponse()
        {

        }
    }
}
