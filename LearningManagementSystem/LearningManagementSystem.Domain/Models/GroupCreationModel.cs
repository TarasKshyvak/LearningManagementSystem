﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Models
{
    public class GroupCreationModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartEducation { get; set; }
        public DateTime EndEducation { get; set; }
    }
}
