﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Domain.Models
{
    public class StudentModel: UserModel
    {
        public string ContractNumber { get; set; } = string.Empty;
        public Guid? GroupId { get; set; }
    }
}