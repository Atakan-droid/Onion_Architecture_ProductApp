using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Wrappers
{
    public class BaseResponse
    {
        public Guid Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

        public BaseResponse(bool success, string message)
        {
          
            Success = success;
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
        public BaseResponse(string message)
        {

            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
        public BaseResponse()
        {

        }
    }
}
