using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Models
{
    public class LogInResponse
    {
        public bool Succeeded { get; set; }
        public LogInResponseResult Result { get; set; }
    }

    public class LogInResponseResult
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string AccessToken { get; set; }
    }
}

