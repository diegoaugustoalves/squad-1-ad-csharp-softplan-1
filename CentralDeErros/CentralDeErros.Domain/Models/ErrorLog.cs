﻿using CentralDeErros.Domain.Models.Base;
using CentralDeErros.CrossCutting.CustomTypes;

namespace CentralDeErros.Domain.Models
{
    public class ErrorLog : ModelBase
    {
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public bool Archieved { get; set; } = false;
        public Environment Environment { get; set; } = Environment.Unknown;
    }
}
