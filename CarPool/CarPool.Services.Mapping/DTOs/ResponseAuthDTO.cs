﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarPool.Services.Mapping.DTOs
{
    public class ResponseAuthDTO
    {
        public string Email { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
    }
}
