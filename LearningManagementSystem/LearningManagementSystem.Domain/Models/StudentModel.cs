﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Models
{
    public class StudentModel : UserModel
    {
        public Guid GroupId { get; set; }
        public GroupModel Group { get; set; } = null!;
    }
}
