﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Communication.Responses
{
    public class ResponseAllTaskJson
    {
        public List<ResponseShortTaskJson> Pets { get; set; } = [];
    }
}
