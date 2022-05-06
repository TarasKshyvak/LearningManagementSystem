﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } = null!;
        //TODO: Add group admin
        public DateTime StartEducation { get; set; }
        public DateTime EndEducation { get; set; }
        public ICollection<Student> Students { get; set; } = null!;

    }
}
