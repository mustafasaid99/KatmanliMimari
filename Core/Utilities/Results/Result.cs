using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool succcess, string message):this(succcess)
        {
            Message = message; 
        }
        public Result(bool succcess)
        {
            Success = succcess;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
