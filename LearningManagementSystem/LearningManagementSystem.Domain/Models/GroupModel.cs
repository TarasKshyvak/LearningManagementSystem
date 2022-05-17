﻿namespace LearningManagementSystem.Domain.Models
{
    public class GroupModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime StartEducation { get; set; }
        public DateTime EndEducation { get; set; }
        public Guid? CourseId { get; set; }
        public ICollection<StudentModel>? Students { get; set; } = null;
    }
}
