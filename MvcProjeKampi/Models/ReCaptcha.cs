﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcProjeKampi.Models
{
    public class ReCaptcha
    {
        [JsonProperty("success")]
        public bool Success{get; set;}
        [JsonProperty("error-codes")]
        public List<string> ErrorCodes{ get; set;}
    }
}