﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses
{
    public class ResponseTaskJson
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public TaskPriorityEnum Priority { get; set; }

        public TaskStatusEnum Status { get; set; }

    }
}
